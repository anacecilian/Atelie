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
        public ClienteServico clienteServico = new ClienteServico(); 

        public FormCliente()
        {
            InitializeComponent();
        }
        
        private void FormCliente_Load(object sender, System.EventArgs e)
        {
            
        }

        private void btnPesquisarEnd_Click(object sender, EventArgs e)
        {
            string cep = txtCEPNum.Text + txtCEPDig.Text;
            //método de pesquisar o endereço pelo cep
            Endereco end = new Endereco();
            if (end.Id > 0)
            {
                txtLogradouro.Text = end.Logradouro;
                txtBairro.Text = end.Bairro;
                txtCEPDig.Enabled = 
                txtCEPNum.Enabled = 
                txtLogradouro.Enabled = 
                txtBairro.Enabled = false;
            }
        }
        
        private void btnAdiconarMedida_Click(object sender, EventArgs e)
        {
            TipoMedidaCliente tipo = (TipoMedidaCliente)Convert.ToByte(cmbTipoMedida.SelectedValue);
            if (!Medidas.Any(x => x.Tipo == tipo))
                Medidas.Add(
                    new ClienteMedida
                    {
                        Tipo = tipo
                        ,
                        Valor = Convert.ToDecimal(txtMedida.Text)
                    });
            else
                MessageBox.Show("Já existe este tipo de medida para o cliente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente
            {
                DataCadastro = DateTime.Now
                ,
                Medidas = Medidas
                ,
                Nome = txtNome.Text
                ,
                Telefone = txtDDD.Text + txtNumeroTel.Text
                ,
                Endereco = new ClienteEndereco
                {
                    Complemento = txtComplemento.Text
                    ,
                    Numero = txtNumeroEnd.Text
                }
            };
            if (clienteServico.SalvarCliente(cliente))
            {
                MessageBox.Show("Cliente cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCamposFormulario();
            }
            else
                MessageBox.Show("Não foi possível salvar o cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LimparCamposFormulario()
        {
            txtNome.Text =
            txtNumeroTel.Text =
            txtDDD.Text =
            txtCEPNum.Text =
            txtCEPDig.Text =
            txtLogradouro.Text =
            txtNumeroEnd.Text =
            txtComplemento.Text =
            txtBairro.Text =
            txtMedida.Text = string.Empty;

            txtLogradouro.Enabled =
            txtBairro.Enabled =
            txtCEPDig.Enabled =
            txtCEPNum.Enabled = true;
        }
    }
}
