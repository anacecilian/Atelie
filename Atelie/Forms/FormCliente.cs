using Atelie.Entidades;
using Atelie.Enumeradores;
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

namespace Atelie
{
    public partial class FormCliente : Form
    {
        public List<ClienteMedida> Medidas { get; set; } = new List<ClienteMedida>();
        public ClienteServico clienteServico;
        public Cliente cliente { get; set; }

        EnderecoServico enderecoServico;

        public FormCliente(int clienteId = 0)
        {
            InitializeComponent();
            clienteServico = new ClienteServico();
            enderecoServico = new EnderecoServico();

            if (clienteId > 0)
            {
                cliente = clienteServico.RetornaCliente(clienteId);
                CarregarDadosCliente();
            }
            else cliente = new Cliente();
        }

        private void CarregarDadosCliente()
        {
            txtNome.Text = cliente.Nome;
            txtNumeroTel.Text = cliente.Telefone;
            txtCPF.Text = cliente.CPF;

            txtCEPNum.Text = cliente.ClienteEndereco.Endereco.CEP;
            txtLogradouro.Text = cliente.ClienteEndereco.Endereco.Logradouro;
            txtComplemento.Text = cliente.ClienteEndereco.Complemento;
            txtNumeroEnd.Text = cliente.ClienteEndereco.Numero;
            txtBairro.Text = cliente.ClienteEndereco.Endereco.Bairro;

            Medidas = cliente.Medidas;
            AtualizarGridMedidas();
        }

        private void FormCliente_Load(object sender, System.EventArgs e)
        {
            cmbTipoMedida.SelectedIndex = 0;
        }

        private void btnPesquisarEnd_Click(object sender, EventArgs e)
        {
            string cep = txtCEPNum.Text;
            Endereco end = enderecoServico.PesquisaPorCEP(cep);
            if (end.Id > 0)
            {
                txtLogradouro.Text = end.Logradouro;
                txtBairro.Text = end.Bairro;
                txtCEPNum.Enabled =
                txtLogradouro.Enabled =
                txtBairro.Enabled = false;
            }
            else
            {
                txtLogradouro.Text =
                txtBairro.Text = string.Empty;
                txtCEPNum.Enabled = false;
                txtLogradouro.Enabled =
                txtBairro.Enabled = true;
            }
        }

        private void btnAdiconarMedida_Click(object sender, EventArgs e)
        {
            decimal medida = 0.0M;
            Decimal.TryParse(txtMedida.Text, out medida);

            if (cmbTipoMedida.SelectedIndex <= 0)
                MessageBox.Show("Selecione um tipo de medida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (medida <= 0)
                MessageBox.Show("Digite uma medida válida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                TipoMedidaCliente tipo = (TipoMedidaCliente)cmbTipoMedida.SelectedIndex;
                
                if (!Medidas.Any(x => x.Tipo == tipo))
                {
                    Medidas.Add(new ClienteMedida
                    {
                        Tipo = tipo
                                                ,
                        Valor = Convert.ToDecimal(txtMedida.Text)
                    });
                }
                else
                {
                    Medidas.Where(x => x.Tipo == tipo).FirstOrDefault().Valor = Convert.ToDecimal(txtMedida.Text);
                }

                AtualizarGridMedidas();
                txtMedida.Text = string.Empty;
                cmbTipoMedida.SelectedIndex = 0;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cliente.Id <= 0)
            {
                cliente.DataCadastro = DateTime.Now;
            }
            cliente.Medidas = Medidas;
            cliente.Nome = txtNome.Text;
            cliente.Telefone = txtNumeroTel.Text;
            cliente.ClienteEndereco.Endereco.Logradouro = txtLogradouro.Text;
            cliente.ClienteEndereco.Endereco.Bairro = txtBairro.Text;
            cliente.ClienteEndereco.Endereco.CEP = txtCEPNum.Text;
            cliente.ClienteEndereco.Complemento = txtComplemento.Text;
            cliente.ClienteEndereco.Numero = txtNumeroEnd.Text;
            cliente.CPF = txtCEPNum.Text;
            
            public override string ToString()
            {
                string cadastrocliente = "nome=" + cliente.Nome + "',CPF='" + cliente.CPF + "',cel_num='" + cliente.Telefone +"'";
                return cadastrocliente;
            }
            

            if (clienteServico.Salvar(cliente))
            {
                MessageBox.Show("Cliente cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Não foi possível salvar o cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LimparCamposFormulario()
        {
            txtNome.Text =
            txtNumeroTel.Text =
            txtCEPNum.Text =
            txtLogradouro.Text =
            txtNumeroEnd.Text =
            txtComplemento.Text =
            txtBairro.Text =
            txtMedida.Text = string.Empty;

            txtLogradouro.Enabled =
            txtBairro.Enabled =
            txtCEPNum.Enabled = true;
        }

        private string RetornaTextoTipoMedida(TipoMedidaCliente tipo)
        {
            switch (tipo)
            {
                case TipoMedidaCliente.AlturaBusto:
                    return "Altura do busto";
                case TipoMedidaCliente.Busto:
                    return "Busto";
                case TipoMedidaCliente.Cintura:
                    return "Cintura";
                case TipoMedidaCliente.ComprimentoCalca:
                    return "Comprimento da calça";
                case TipoMedidaCliente.ComprimentoMangaCurta:
                    return "Comprimento da manga curta";
                case TipoMedidaCliente.ComprimentoMangaLonga:
                    return "Comprimento da manga longa";
                case TipoMedidaCliente.ComprimentoSaia:
                    return "Comprimento da saia";
                case TipoMedidaCliente.OmbroAOmbro:
                    return "Ombro a ombro";
                case TipoMedidaCliente.Quadril:
                    return "Quadril";
                default:
                    return string.Empty;
            }
        }

        private void AtualizarGridMedidas()
        {
            dgvMedidas.DataSource = (from m in Medidas select new { Valor = m.Valor, Tipo = RetornaTextoTipoMedida(m.Tipo) }).ToList();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbxDadosPessoais_Enter(object sender, EventArgs e)
        {

        }
    }
}
