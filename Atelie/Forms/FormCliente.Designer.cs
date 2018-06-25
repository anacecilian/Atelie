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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.gbxEndereco = new System.Windows.Forms.GroupBox();
            this.btnPesquisarEnd = new System.Windows.Forms.Button();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtCEPNum = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtNumeroEnd = new System.Windows.Forms.TextBox();
            this.lblNumeroEnd = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.gbxMedidas = new System.Windows.Forms.GroupBox();
            this.dgvMedidas = new System.Windows.Forms.DataGridView();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.gbxDadosPessoais.SuspendLayout();
            this.gbxEndereco.SuspendLayout();
            this.gbxMedidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedidas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxDadosPessoais
            // 
            this.gbxDadosPessoais.Controls.Add(this.txtCPF);
            this.gbxDadosPessoais.Controls.Add(this.label3);
            this.gbxDadosPessoais.Controls.Add(this.txtNumeroTel);
            this.gbxDadosPessoais.Controls.Add(this.txtNome);
            this.gbxDadosPessoais.Controls.Add(this.lblTelefone);
            this.gbxDadosPessoais.Controls.Add(this.lblNome);
            this.gbxDadosPessoais.Location = new System.Drawing.Point(12, 12);
            this.gbxDadosPessoais.Name = "gbxDadosPessoais";
            this.gbxDadosPessoais.Size = new System.Drawing.Size(524, 105);
            this.gbxDadosPessoais.TabIndex = 0;
            this.gbxDadosPessoais.TabStop = false;
            this.gbxDadosPessoais.Text = "Dados pessoais";
            // 
            // txtNumeroTel
            // 
            this.txtNumeroTel.Location = new System.Drawing.Point(131, 75);
            this.txtNumeroTel.Name = "txtNumeroTel";
            this.txtNumeroTel.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroTel.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(10, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(484, 20);
            this.txtNome.TabIndex = 4;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(128, 59);
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
            this.gbxEndereco.Controls.Add(this.txtCEPNum);
            this.gbxEndereco.Controls.Add(this.lblCEP);
            this.gbxEndereco.Controls.Add(this.txtComplemento);
            this.gbxEndereco.Controls.Add(this.lblComplemento);
            this.gbxEndereco.Controls.Add(this.txtNumeroEnd);
            this.gbxEndereco.Controls.Add(this.lblNumeroEnd);
            this.gbxEndereco.Controls.Add(this.txtLogradouro);
            this.gbxEndereco.Controls.Add(this.lblLogradouro);
            this.gbxEndereco.Location = new System.Drawing.Point(13, 123);
            this.gbxEndereco.Name = "gbxEndereco";
            this.gbxEndereco.Size = new System.Drawing.Size(523, 189);
            this.gbxEndereco.TabIndex = 1;
            this.gbxEndereco.TabStop = false;
            this.gbxEndereco.Text = "Endereço";
            // 
            // btnPesquisarEnd
            // 
            this.btnPesquisarEnd.Location = new System.Drawing.Point(94, 37);
            this.btnPesquisarEnd.Name = "btnPesquisarEnd";
            this.btnPesquisarEnd.Size = new System.Drawing.Size(141, 23);
            this.btnPesquisarEnd.TabIndex = 12;
            this.btnPesquisarEnd.Text = "Pesquisar endereço";
            this.btnPesquisarEnd.UseVisualStyleBackColor = true;
            this.btnPesquisarEnd.Click += new System.EventHandler(this.btnPesquisarEnd_Click);
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(9, 117);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(267, 20);
            this.txtBairro.TabIndex = 11;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(9, 100);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 10;
            this.lblBairro.Text = "Bairro";
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
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(94, 157);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(179, 20);
            this.txtComplemento.TabIndex = 5;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(91, 140);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(71, 13);
            this.lblComplemento.TabIndex = 4;
            this.lblComplemento.Text = "Complemento";
            // 
            // txtNumeroEnd
            // 
            this.txtNumeroEnd.Location = new System.Drawing.Point(6, 157);
            this.txtNumeroEnd.Name = "txtNumeroEnd";
            this.txtNumeroEnd.Size = new System.Drawing.Size(78, 20);
            this.txtNumeroEnd.TabIndex = 3;
            // 
            // lblNumeroEnd
            // 
            this.lblNumeroEnd.AutoSize = true;
            this.lblNumeroEnd.Location = new System.Drawing.Point(6, 140);
            this.lblNumeroEnd.Name = "lblNumeroEnd";
            this.lblNumeroEnd.Size = new System.Drawing.Size(44, 13);
            this.lblNumeroEnd.TabIndex = 2;
            this.lblNumeroEnd.Text = "Número";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Enabled = false;
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
            this.gbxMedidas.Controls.Add(this.dgvMedidas);
            this.gbxMedidas.Controls.Add(this.btnAdiconarMedida);
            this.gbxMedidas.Controls.Add(this.txtMedida);
            this.gbxMedidas.Controls.Add(this.label2);
            this.gbxMedidas.Controls.Add(this.cmbTipoMedida);
            this.gbxMedidas.Controls.Add(this.label1);
            this.gbxMedidas.Location = new System.Drawing.Point(13, 318);
            this.gbxMedidas.Name = "gbxMedidas";
            this.gbxMedidas.Size = new System.Drawing.Size(523, 221);
            this.gbxMedidas.TabIndex = 2;
            this.gbxMedidas.TabStop = false;
            this.gbxMedidas.Text = "Medidas";
            // 
            // dgvMedidas
            // 
            this.dgvMedidas.AllowUserToAddRows = false;
            this.dgvMedidas.AllowUserToDeleteRows = false;
            this.dgvMedidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTipo,
            this.colMedida});
            this.dgvMedidas.Location = new System.Drawing.Point(12, 57);
            this.dgvMedidas.Name = "dgvMedidas";
            this.dgvMedidas.ReadOnly = true;
            this.dgvMedidas.Size = new System.Drawing.Size(495, 150);
            this.dgvMedidas.TabIndex = 10;
            // 
            // colTipo
            // 
            this.colTipo.DataPropertyName = "Tipo";
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            // 
            // colMedida
            // 
            this.colMedida.DataPropertyName = "Valor";
            this.colMedida.HeaderText = "Medida";
            this.colMedida.Name = "colMedida";
            this.colMedida.ReadOnly = true;
            // 
            // btnAdiconarMedida
            // 
            this.btnAdiconarMedida.Location = new System.Drawing.Point(407, 16);
            this.btnAdiconarMedida.Name = "btnAdiconarMedida";
            this.btnAdiconarMedida.Size = new System.Drawing.Size(100, 23);
            this.btnAdiconarMedida.TabIndex = 9;
            this.btnAdiconarMedida.Text = "Salvar medida";
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
            this.cmbTipoMedida.Items.AddRange(new object[] {
            "- Selecione -",
            "Comprimento da calça",
            "Comprimento da saia",
            "Comprimento da manga longa",
            "Comprimento da manga curta",
            "Ombro a ombro",
            "Busto",
            "Altura do busto",
            "Cintura",
            "Quadril"});
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
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(380, 569);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CPF";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(10, 75);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(112, 20);
            this.txtCPF.TabIndex = 8;
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
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.gbxDadosPessoais.ResumeLayout(false);
            this.gbxDadosPessoais.PerformLayout();
            this.gbxEndereco.ResumeLayout(false);
            this.gbxEndereco.PerformLayout();
            this.gbxMedidas.ResumeLayout(false);
            this.gbxMedidas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDadosPessoais;
        private System.Windows.Forms.TextBox txtNumeroTel;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gbxEndereco;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtCEPNum;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtNumeroEnd;
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
        private System.Windows.Forms.DataGridView dgvMedidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedida;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label3;
    }
}

