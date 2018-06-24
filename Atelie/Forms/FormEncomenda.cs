using Atelie.Entidades;
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
        public const int indexColunaCancelar = 2;

        public List<EncomendaMaterial> Materiais { get; set; } = new List<EncomendaMaterial>();
        public List<EncomendaProva> Provas { get; set; } = new List<EncomendaProva>();
        public int indexItemMaterialEditando { get; set; } = -1;
        public int indexItemProvaEditando { get; set; } = -1;
        public Encomenda encomenda { get; set; }

        public FormEncomenda()
        {
            InitializeComponent();

            List<Cliente> clientes = new List<Cliente>();
            cmbCliente.DataSource = clientes;
        }

        private void btnSalvarMaterial_Click(object sender, EventArgs e)
        {
            decimal quantidade = 0.0M;
            Decimal.TryParse(txtQuantidade.Text, out quantidade);

            if (String.IsNullOrEmpty(txtDescricao.Text))
                MessageBox.Show("Digite a descrição.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (String.IsNullOrEmpty(txtUnidadeMedida.Text))
                MessageBox.Show("Digite a unidade de medida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (quantidade <= 0)
                MessageBox.Show("Quandidade inválida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (indexItemMaterialEditando < 0)
            {
                Materiais.Add(new EncomendaMaterial
                {
                    Descricao = txtDescricao.Text
                    ,
                    Quantidade = quantidade
                    ,
                    UnidadeMedida = txtUnidadeMedida.Text
                });
            }
            else
            {
                Materiais.ElementAt(indexItemMaterialEditando).Descricao = txtDescricao.Text;
                Materiais.ElementAt(indexItemMaterialEditando).Quantidade = quantidade;
                Materiais.ElementAt(indexItemMaterialEditando).UnidadeMedida = txtUnidadeMedida.Text;
                indexItemMaterialEditando = -1;
            }

            AtualizarGridMateriais();
            LimparFormMaterial();
        }

        private void LimparFormMaterial()
        {
            txtQuantidade.Text = txtUnidadeMedida.Text = txtDescricao.Text = string.Empty;
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

                txtDescricao.Text = material.Descricao;
                txtQuantidade.Text = material.Quantidade.ToString();
                txtUnidadeMedida.Text = material.UnidadeMedida;

                indexItemMaterialEditando = e.RowIndex;
            }
        }

        private void AtualizarGridMateriais()
        {
            dgvMaterial.DataSource = (from m in Materiais select new { Quantidade = m.Quantidade, UnidadeMedida = m.UnidadeMedida, Descricao = m.Descricao }).ToList();

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

            Int32.TryParse(cmbCliente.SelectedValue.ToString(), out ClienteId);
            Decimal.TryParse(txtPreco.Text, out preco);
            DateTime.TryParse(dtpDataEntregaPrev.Text, out dataEntrega);

            if (ClienteId <= 0)
                MessageBox.Show("Selecione um cliente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (preco <= 0)
                MessageBox.Show("Preço inválido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (dataEntrega == DateTime.MinValue)
                MessageBox.Show("Data de entrega prevista inválida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                encomenda.ClienteId = ClienteId;
                encomenda.DataEntregaPrevista = dataEntrega;
                encomenda.Materiais = Materiais;
                encomenda.Preco = preco;
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
            dgvProva.DataSource = (from m in Provas select new { Data = m.Data }).ToList();

            if (Provas.Any())
            {
                dgvProva.Columns["Data"].DisplayIndex = 0;
                dgvProva.Columns["Cancelar"].DisplayIndex = 1;
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
    }
}
