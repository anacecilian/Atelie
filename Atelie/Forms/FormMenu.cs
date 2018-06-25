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
    public partial class FormMenu : Form
    {
        FormCliente formCliente;
        FormClienteConsulta formClienteConsulta;
        FormEncomenda formEncomenda;
        FormEncomendaConsulta formEncomendaConsulta;
        FormProvaConsulta formProvaConsulta;

        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            formCliente = new FormCliente();
            formCliente.Show();
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            formClienteConsulta = new FormClienteConsulta();
            formClienteConsulta.Show();
        }

        private void btnCadastrarEncomenda_Click(object sender, EventArgs e)
        {
            formEncomenda = new FormEncomenda();
            formEncomenda.Show();
        }

        private void btnConsultarEncomenda_Click(object sender, EventArgs e)
        {
            formEncomendaConsulta = new FormEncomendaConsulta();
            formEncomendaConsulta.Show();
        }

        private void btnConsultarProva_Click(object sender, EventArgs e)
        {
            formProvaConsulta = new FormProvaConsulta();
            formProvaConsulta.Show();
        }
    }
}
