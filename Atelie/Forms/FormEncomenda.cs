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
        public List<EncomendaMaterial> Materiais { get; set; } = new List<EncomendaMaterial>();

        public FormEncomenda()
        {
            InitializeComponent();

            List<Cliente> clientes = new List<Cliente>();
            clientes.Add(new Cliente { Id = 1, Nome = "Maria" });
            clientes.Add(new Cliente { Id = 2, Nome = "Julia" });
            clientes.Add(new Cliente { Id = 3, Nome = "Carol" });
            clientes.Add(new Cliente { Id = 4, Nome = "Vera" });
            cmbCliente.DataSource = clientes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal quantidade = 0.0M;
            Decimal.TryParse(txtQuantidade.Text, out quantidade);

            if (String.IsNullOrEmpty(txtDescricao.Text))
                MessageBox.Show("Digite a descrição.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (String.IsNullOrEmpty(txtUnidadeMedida.Text))
                MessageBox.Show("Digite a unidade de medida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (quantidade <= 0)
                MessageBox.Show("Quandidade inválida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Materiais.Add(new EncomendaMaterial
                {
                    Descricao = txtDescricao.Text
                    ,
                    Quantidade = quantidade
                    ,
                    UnidadeMedida = txtUnidadeMedida.Text
                });

                dgvMaterial.DataSource = (from m in Materiais
                                          select
                      new
                      {
                          Descricao = m.Descricao
                          ,
                          Quantidade = m.Quantidade
                          ,
                          UnidadeMedida = m.UnidadeMedida
                      }).ToList();
            }

        }
    }
}
