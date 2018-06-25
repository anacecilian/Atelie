using Atelie.Entidades;
using Atelie.Servico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelie.Forms
{
    public partial class FormEncomenda : Form
    {
        public const int indexColunaExcluir = 0;
        public const int indexColunaEditar = 3;
        public const int indexColunaCancelar = 0;

        public List<EncomendaMaterial> Materiais { get; set; } = new List<EncomendaMaterial>();
        public List<EncomendaProva> Provas { get; set; } = new List<EncomendaProva>();
        public int indexItemMaterialEditando { get; set; } = -1;
        public int indexItemProvaEditando { get; set; } = -1;
        public Encomenda encomenda { get; set; }
        public Cliente cliente { get; set; }

        EncomendaServico encomendaServico;
        ClienteServico clienteServico;

        public FormEncomenda(int EncomendaId = 0, int ClienteId = 0)
        {
            InitializeComponent();
            encomendaServico = new EncomendaServico();
            clienteServico = new ClienteServico();
            cmbCliente.DataSource = clienteServico.PesquisaClientes(string.Empty, string.Empty, string.Empty);
            
            if (EncomendaId > 0)
            {
                encomenda = encomendaServico.RetornaEncomenda(ClienteId, EncomendaId);
                cliente = clienteServico.RetornaCliente(ClienteId);
                CarregarDadosEncomenda();
            }
        }

        private void CarregarDadosEncomenda()
        {
            cmbCliente.Text = cliente.Nome;
            cmbCliente.Enabled = false;

            dtpDataEntregaPrev.Text = encomenda.DataEntregaPrevista.ToShortDateString();
            txtPreco.Text = encomenda.Preco.ToString();
            txtDescricao.Text = encomenda.Descricao;
            dtpDataEntregaEfet.Text = encomenda.DataEntregaEfetiva != DateTime.MinValue ? encomenda.DataEntregaEfetiva.ToShortDateString() : string.Empty;
            dtpDataPagamento.Text = encomenda.DataPagamento != DateTime.MinValue ? encomenda.DataPagamento.ToShortDateString() : string.Empty;

            Materiais = encomenda.Materiais.Count > 0 ? encomenda.Materiais : new List<EncomendaMaterial>();
            AtualizarGridMateriais();

            Provas = encomenda.Provas.Count > 0 ? encomenda.Provas : new List<EncomendaProva>();
            AtualizarGridProvas();
        }

        private void btnSalvarMaterial_Click(object sender, EventArgs e)
        {
            decimal quantidade = 0.0M;
            Decimal.TryParse(txtQuantidade.Text, out quantidade);

            if (String.IsNullOrEmpty(txtDetalhes.Text))
                MessageBox.Show("Digite a descrição.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (String.IsNullOrEmpty(txtUnidadeMedida.Text))
                MessageBox.Show("Digite a unidade de medida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (quantidade <= 0)
                MessageBox.Show("Quandidade inválida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (indexItemMaterialEditando < 0)
            {
                Materiais.Add(new EncomendaMaterial
                {
                    Detalhes = txtDetalhes.Text
                    ,
                    Quantidade = quantidade
                    ,
                    UnidadeMedida = txtUnidadeMedida.Text
                });
            }
            else
            {
                Materiais.ElementAt(indexItemMaterialEditando).Detalhes = txtDetalhes.Text;
                Materiais.ElementAt(indexItemMaterialEditando).Quantidade = quantidade;
                Materiais.ElementAt(indexItemMaterialEditando).UnidadeMedida = txtUnidadeMedida.Text;
                indexItemMaterialEditando = -1;
            }

            AtualizarGridMateriais();
            LimparFormMaterial();
        }

        private void LimparFormMaterial()
        {
            txtQuantidade.Text = txtUnidadeMedida.Text = txtDetalhes.Text = string.Empty;
        }

        private void dgvMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == indexColunaExcluir && Materiais.Any())
            {
                Materiais.RemoveAt(e.RowIndex);
                AtualizarGridMateriais();
            }
            else if (e.ColumnIndex == indexColunaEditar && Materiais.Any())
            {
                EncomendaMaterial material = Materiais.ElementAt(e.RowIndex);

                txtDetalhes.Text = material.Detalhes;
                txtQuantidade.Text = material.Quantidade.ToString();
                txtUnidadeMedida.Text = material.UnidadeMedida;

                indexItemMaterialEditando = e.RowIndex;
            }
        }

        private void AtualizarGridMateriais()
        {
            dgvMaterial.DataSource = (from m in Materiais select new { Quantidade = m.Quantidade, UnidadeMedida = m.UnidadeMedida, Descricao = m.Detalhes, Id = m.Id }).ToList();

            if (Materiais.Any())
            {
                dgvMaterial.Columns["Descricao"].DisplayIndex = 0;
                dgvMaterial.Columns["Quantidade"].DisplayIndex = 1;
                dgvMaterial.Columns["UnidadeMedida"].DisplayIndex = 2;
                dgvMaterial.Columns["Excluir"].DisplayIndex = 3;
            }
        }

        private void btnSalvarEncomenda_Click(object sender, EventArgs e)
        {
            int ClienteId = 0;
            decimal preco = 0.0M;
            DateTime dataEntrega = DateTime.MinValue;
            DateTime dataPagamento = DateTime.MinValue;
            DateTime dataEntregaEfet = DateTime.MinValue;
            string val = string.Empty;
            if (cmbCliente.SelectedValue != null)
                val = cmbCliente.SelectedValue.ToString();

            Int32.TryParse(val, out ClienteId);
            Decimal.TryParse(txtPreco.Text, out preco);
            DateTime.TryParse(dtpDataEntregaPrev.Text, out dataEntrega);

            if (ClienteId <= 0)
                MessageBox.Show("Selecione um cliente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (preco <= 0)
                MessageBox.Show("Preço inválido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (dataEntrega == DateTime.MinValue)
                MessageBox.Show("Data de entrega prevista inválida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!String.IsNullOrEmpty(dtpDataPagamento.Text)){
                DateTime.TryParse(dtpDataPagamento.Text, out dataPagamento);
                if (dataPagamento == DateTime.MinValue)
                    MessageBox.Show("Data de entrega prevista inválida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!String.IsNullOrEmpty(dtpDataEntregaEfet.Text))
            {
                DateTime.TryParse(dtpDataEntregaEfet.Text, out dataEntregaEfet);
                if (dataEntrega == DateTime.MinValue)
                    MessageBox.Show("Data de entrega prevista inválida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                encomenda.ClienteId = ClienteId;
                encomenda.DataEntregaPrevista = dataEntrega;
                encomenda.Materiais = Materiais;
                encomenda.Preco = preco;
                encomenda.Provas = Provas;
                encomenda.DataEntregaEfetiva = dataEntregaEfet;
                encomenda.DataPagamento = dataPagamento;

                if (encomendaServico.Salvar(encomenda))
                {
                    MessageBox.Show("Encomenda salva com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível salvar a encomenda.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAgendarProva_Click(object sender, EventArgs e)
        {
            DateTime data = DateTime.MinValue;
            DateTime.TryParse(dtpDataProva.Text, out data);
            DateTime hora = DateTime.MinValue;
            DateTime.TryParse(dtpHoraProva.Text, out hora);

            if (data == DateTime.MinValue)
                MessageBox.Show("Data inválida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (hora == DateTime.MinValue)
                MessageBox.Show("Hora inválida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DateTime dataHora = DateTime.ParseExact(data.ToShortDateString() + " " + hora.ToShortTimeString(), "dd/MM/yyyy HH:mm", null);

                Provas.Add(new EncomendaProva { Data = dataHora });
            }

            AtualizarGridProvas();
        }

        private void AtualizarGridProvas()
        {
            dgvProva.DataSource = (from p in Provas select new { Data = p.Data, Id = p.Id }).ToList();

            if (Provas.Any())
            {
                dgvProva.Columns["Data"].DisplayIndex = 0;
                dgvProva.Columns["ExcluirProva"].DisplayIndex = 1;
            }
        }

        private void dgvProva_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == indexColunaCancelar)
            {
                Provas.RemoveAt(e.RowIndex);
            }
            else
            {
                txtAnotacaoProva.Text = Provas.ElementAt(e.RowIndex).Anotacao;
                indexItemProvaEditando = e.RowIndex;
            }
            AtualizarGridProvas();
        }

        private void btnSalvarAnotacao_Click(object sender, EventArgs e)
        {
            Provas.ElementAt(indexItemProvaEditando).Anotacao = txtAnotacaoProva.Text;
            indexItemProvaEditando = -1;
            txtAnotacaoProva.Text = string.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
