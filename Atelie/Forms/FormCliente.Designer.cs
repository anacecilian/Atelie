namespace Atelie
{
    partial class FormCliente
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
            this.gbxDadosPessoais = new System.Windows.Forms.GroupBox();
            this.txtNumeroTel = new System.Windows.Forms.TextBox();
            this.txtDDD = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNumeroTel = new System.Windows.Forms.Label();
            this.lblDDD = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.gbxEndereco = new System.Windows.Forms.GroupBox();
            this.btnPesquisarEnd = new System.Windows.Forms.Button();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblTraco = new System.Windows.Forms.Label();
            this.txtCEPDig = new System.Windows.Forms.TextBox();
            this.txtCEPNum = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNumeroEnd = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.gbxMedidas = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAdiconarMedida = new System.Windows.Forms.Button();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoMedida = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbxDadosPessoais.SuspendLayout();
            this.gbxEndereco.SuspendLayout();
            this.gbxMedidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxDadosPessoais
            // 
            this.gbxDadosPessoais.Controls.Add(this.txtNumeroTel);
            this.gbxDadosPessoais.Controls.Add(this.txtDDD);
            this.gbxDadosPessoais.Controls.Add(this.txtNome);
            this.gbxDadosPessoais.Controls.Add(this.lblNumeroTel);
            this.gbxDadosPessoais.Controls.Add(this.lblDDD);
            this.gbxDadosPessoais.Controls.Add(this.lblTelefone);
            this.gbxDadosPessoais.Controls.Add(this.lblNome);
            this.gbxDadosPessoais.Location = new System.Drawing.Point(12, 12);
            this.gbxDadosPessoais.Name = "gbxDadosPessoais";
            this.gbxDadosPessoais.Size = new System.Drawing.Size(524, 119);
            this.gbxDadosPessoais.TabIndex = 0;
            this.gbxDadosPessoais.TabStop = false;
            this.gbxDadosPessoais.Text = "Dados pessoais";
            // 
            // txtNumeroTel
            // 
            this.txtNumeroTel.Location = new System.Drawing.Point(48, 89);
            this.txtNumeroTel.Name = "txtNumeroTel";
            this.txtNumeroTel.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroTel.TabIndex = 6;
            // 
            // txtDDD
            // 
            this.txtDDD.Location = new System.Drawing.Point(10, 89);
            this.txtDDD.Name = "txtDDD";
            this.txtDDD.Size = new System.Drawing.Size(32, 20);
            this.txtDDD.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(10, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(484, 20);
            this.txtNome.TabIndex = 4;
            // 
            // lblNumeroTel
            // 
            this.lblNumeroTel.AutoSize = true;
            this.lblNumeroTel.Location = new System.Drawing.Point(44, 73);
            this.lblNumeroTel.Name = "lblNumeroTel";
            this.lblNumeroTel.Size = new System.Drawing.Size(44, 13);
            this.lblNumeroTel.TabIndex = 3;
            this.lblNumeroTel.Text = "Número";
            // 
            // lblDDD
            // 
            this.lblDDD.AutoSize = true;
            this.lblDDD.Location = new System.Drawing.Point(7, 73);
            this.lblDDD.Name = "lblDDD";
            this.lblDDD.Size = new System.Drawing.Size(31, 13);
            this.lblDDD.TabIndex = 2;
            this.lblDDD.Text = "DDD";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(7, 59);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 1;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(7, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // gbxEndereco
            // 
            this.gbxEndereco.Controls.Add(this.btnPesquisarEnd);
            this.gbxEndereco.Controls.Add(this.txtBairro);
            this.gbxEndereco.Controls.Add(this.lblBairro);
            this.gbxEndereco.Controls.Add(this.lblTraco);
            this.gbxEndereco.Controls.Add(this.txtCEPDig);
            this.gbxEndereco.Controls.Add(this.txtCEPNum);
            this.gbxEndereco.Controls.Add(this.lblCEP);
            this.gbxEndereco.Controls.Add(this.textBox2);
            this.gbxEndereco.Controls.Add(this.lblComplemento);
            this.gbxEndereco.Controls.Add(this.textBox1);
            this.gbxEndereco.Controls.Add(this.lblNumeroEnd);
            this.gbxEndereco.Controls.Add(this.txtLogradouro);
            this.gbxEndereco.Controls.Add(this.lblLogradouro);
            this.gbxEndereco.Location = new System.Drawing.Point(13, 138);
            this.gbxEndereco.Name = "gbxEndereco";
            this.gbxEndereco.Size = new System.Drawing.Size(523, 197);
            this.gbxEndereco.TabIndex = 1;
            this.gbxEndereco.TabStop = false;
            this.gbxEndereco.Text = "Endereço";
            // 
            // btnPesquisarEnd
            // 
            this.btnPesquisarEnd.Location = new System.Drawing.Point(167, 37);
            this.btnPesquisarEnd.Name = "btnPesquisarEnd";
            this.btnPesquisarEnd.Size = new System.Drawing.Size(141, 23);
            this.btnPesquisarEnd.TabIndex = 12;
            this.btnPesquisarEnd.Text = "Pesquisar endereço";
            this.btnPesquisarEnd.UseVisualStyleBackColor = true;
            this.btnPesquisarEnd.Click += new System.EventHandler(this.btnPesquisarEnd_Click);
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(9, 165);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(267, 20);
            this.txtBairro.TabIndex = 11;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(9, 148);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 10;
            this.lblBairro.Text = "Bairro";
            // 
            // lblTraco
            // 
            this.lblTraco.AutoSize = true;
            this.lblTraco.Location = new System.Drawing.Point(94, 40);
            this.lblTraco.Name = "lblTraco";
            this.lblTraco.Size = new System.Drawing.Size(10, 13);
            this.lblTraco.TabIndex = 9;
            this.lblTraco.Text = "-";
            // 
            // txtCEPDig
            // 
            this.txtCEPDig.Location = new System.Drawing.Point(109, 37);
            this.txtCEPDig.Name = "txtCEPDig";
            this.txtCEPDig.Size = new System.Drawing.Size(37, 20);
            this.txtCEPDig.TabIndex = 8;
            // 
            // txtCEPNum
            // 
            this.txtCEPNum.Location = new System.Drawing.Point(9, 37);
            this.txtCEPNum.Name = "txtCEPNum";
            this.txtCEPNum.Size = new System.Drawing.Size(78, 20);
            this.txtCEPNum.TabIndex = 7;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(9, 20);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(28, 13);
            this.lblCEP.TabIndex = 6;
            this.lblCEP.Text = "CEP";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 20);
            this.textBox2.TabIndex = 5;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(94, 104);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(71, 13);
            this.lblComplemento.TabIndex = 4;
            this.lblComplemento.Text = "Complemento";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lblNumeroEnd
            // 
            this.lblNumeroEnd.AutoSize = true;
            this.lblNumeroEnd.Location = new System.Drawing.Point(9, 104);
            this.lblNumeroEnd.Name = "lblNumeroEnd";
            this.lblNumeroEnd.Size = new System.Drawing.Size(44, 13);
            this.lblNumeroEnd.TabIndex = 2;
            this.lblNumeroEnd.Text = "Número";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(9, 77);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(484, 20);
            this.txtLogradouro.TabIndex = 1;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(6, 60);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(61, 13);
            this.lblLogradouro.TabIndex = 0;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // gbxMedidas
            // 
            this.gbxMedidas.Controls.Add(this.dataGridView1);
            this.gbxMedidas.Controls.Add(this.btnAdiconarMedida);
            this.gbxMedidas.Controls.Add(this.txtMedida);
            this.gbxMedidas.Controls.Add(this.label2);
            this.gbxMedidas.Controls.Add(this.cmbTipoMedida);
            this.gbxMedidas.Controls.Add(this.label1);
            this.gbxMedidas.Location = new System.Drawing.Point(13, 342);
            this.gbxMedidas.Name = "gbxMedidas";
            this.gbxMedidas.Size = new System.Drawing.Size(523, 221);
            this.gbxMedidas.TabIndex = 2;
            this.gbxMedidas.TabStop = false;
            this.gbxMedidas.Text = "Medidas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMedida,
            this.colTipo,
            this.colExcluir});
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(495, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // colMedida
            // 
            this.colMedida.HeaderText = "Medida";
            this.colMedida.Name = "colMedida";
            this.colMedida.ReadOnly = true;
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            // 
            // colExcluir
            // 
            this.colExcluir.HeaderText = "Excluir";
            this.colExcluir.Name = "colExcluir";
            this.colExcluir.ReadOnly = true;
            this.colExcluir.Text = "Excluir";
            // 
            // btnAdiconarMedida
            // 
            this.btnAdiconarMedida.Location = new System.Drawing.Point(407, 16);
            this.btnAdiconarMedida.Name = "btnAdiconarMedida";
            this.btnAdiconarMedida.Size = new System.Drawing.Size(75, 23);
            this.btnAdiconarMedida.TabIndex = 9;
            this.btnAdiconarMedida.Text = "Adicionar";
            this.btnAdiconarMedida.UseVisualStyleBackColor = true;
            this.btnAdiconarMedida.Click += new System.EventHandler(this.btnAdiconarMedida_Click);
            // 
            // txtMedida
            // 
            this.txtMedida.Location = new System.Drawing.Point(277, 16);
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.Size = new System.Drawing.Size(100, 20);
            this.txtMedida.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Medida";
            // 
            // cmbTipoMedida
            // 
            this.cmbTipoMedida.FormattingEnabled = true;
            this.cmbTipoMedida.Location = new System.Drawing.Point(40, 16);
            this.cmbTipoMedida.Name = "cmbTipoMedida";
            this.cmbTipoMedida.Size = new System.Drawing.Size(166, 21);
            this.cmbTipoMedida.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipo";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(461, 569);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(380, 569);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Medida
            // 
            this.Medida.HeaderText = "Medida";
            this.Medida.Name = "Medida";
            this.Medida.ReadOnly = true;
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Name = "Excluir";
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 602);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbxMedidas);
            this.Controls.Add(this.gbxEndereco);
            this.Controls.Add(this.gbxDadosPessoais);
            this.Name = "FormCliente";
            this.Text = "Cadastro de cliente";
            this.gbxDadosPessoais.ResumeLayout(false);
            this.gbxDadosPessoais.PerformLayout();
            this.gbxEndereco.ResumeLayout(false);
            this.gbxEndereco.PerformLayout();
            this.gbxMedidas.ResumeLayout(false);
            this.gbxMedidas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDadosPessoais;
        private System.Windows.Forms.TextBox txtNumeroTel;
        private System.Windows.Forms.TextBox txtDDD;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNumeroTel;
        private System.Windows.Forms.Label lblDDD;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gbxEndereco;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblTraco;
        private System.Windows.Forms.TextBox txtCEPDig;
        private System.Windows.Forms.TextBox txtCEPNum;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNumeroEnd;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.GroupBox gbxMedidas;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPesquisarEnd;
        private System.Windows.Forms.Button btnAdiconarMedida;
        private System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoMedida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medida;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewButtonColumn colExcluir;
    }
}

