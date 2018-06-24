namespace Atelie.Forms
{
    partial class FormClienteConsulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultarEncomendas = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ConsultarProvas = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Editar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(267, 20);
            this.txtNome.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(415, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CEP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(299, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.CPF,
            this.Telefone,
            this.ConsultarEncomendas,
            this.ConsultarProvas,
            this.Editar,
            this.Excluir});
            this.dgvCliente.Location = new System.Drawing.Point(16, 57);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.Size = new System.Drawing.Size(636, 381);
            this.dgvCliente.TabIndex = 6;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(547, 26);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "CPF";
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // ConsultarEncomendas
            // 
            this.ConsultarEncomendas.HeaderText = "Consultar encomendas";
            this.ConsultarEncomendas.Name = "ConsultarEncomendas";
            this.ConsultarEncomendas.ReadOnly = true;
            this.ConsultarEncomendas.Text = "Consultar encomendas";
            this.ConsultarEncomendas.UseColumnTextForLinkValue = true;
            this.ConsultarEncomendas.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // ConsultarProvas
            // 
            this.ConsultarProvas.HeaderText = "Consultar provas";
            this.ConsultarProvas.Name = "ConsultarProvas";
            this.ConsultarProvas.ReadOnly = true;
            this.ConsultarProvas.Text = "Consultar provas";
            this.ConsultarProvas.UseColumnTextForLinkValue = true;
            this.ConsultarProvas.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForLinkValue = true;
            this.Editar.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseColumnTextForLinkValue = true;
            this.Excluir.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // FormClienteConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "FormClienteConsulta";
            this.Text = "FormClienteConsulta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewLinkColumn ConsultarEncomendas;
        private System.Windows.Forms.DataGridViewLinkColumn ConsultarProvas;
        private System.Windows.Forms.DataGridViewLinkColumn Editar;
        private System.Windows.Forms.DataGridViewLinkColumn Excluir;
    }
}