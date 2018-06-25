namespace Atelie.Forms
{
    partial class FormEncomenda
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataEntregaPrev = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUnidadeMedida = new System.Windows.Forms.TextBox();
            this.dgvMaterial = new System.Windows.Forms.DataGridView();
            this.btnSalvarMaterial = new System.Windows.Forms.Button();
            this.txtDetalhes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalvarEncomenda = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSalvarAnotacao = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAnotacaoProva = new System.Windows.Forms.TextBox();
            this.dgvProva = new System.Windows.Forms.DataGridView();
            this.btnAgendarProva = new System.Windows.Forms.Button();
            this.dtpHoraProva = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpDataProva = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDataEntregaEfet = new System.Windows.Forms.DateTimePicker();
            this.dtpDataPagamento = new System.Windows.Forms.DateTimePicker();
            this.IdProva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExcluirProva = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadeMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProva)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDataPagamento);
            this.groupBox1.Controls.Add(this.dtpDataEntregaEfet);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPreco);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpDataEntregaPrev);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da encomenda";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(372, 37);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(344, 108);
            this.txtDescricao.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Descricao";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data do pagamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data de entrega efetiva";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(13, 82);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(119, 20);
            this.txtPreco.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preço";
            // 
            // dtpDataEntregaPrev
            // 
            this.dtpDataEntregaPrev.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntregaPrev.Location = new System.Drawing.Point(160, 82);
            this.dtpDataEntregaPrev.Name = "dtpDataEntregaPrev";
            this.dtpDataEntregaPrev.Size = new System.Drawing.Size(121, 20);
            this.dtpDataEntregaPrev.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de entrega prevista";
            // 
            // cmbCliente
            // 
            this.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCliente.DisplayMember = "Nome";
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(13, 37);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(327, 21);
            this.cmbCliente.TabIndex = 1;
            this.cmbCliente.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUnidadeMedida);
            this.groupBox2.Controls.Add(this.dgvMaterial);
            this.groupBox2.Controls.Add(this.btnSalvarMaterial);
            this.groupBox2.Controls.Add(this.txtDetalhes);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtQuantidade);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(13, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(734, 278);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Material";
            // 
            // txtUnidadeMedida
            // 
            this.txtUnidadeMedida.Location = new System.Drawing.Point(13, 76);
            this.txtUnidadeMedida.Name = "txtUnidadeMedida";
            this.txtUnidadeMedida.Size = new System.Drawing.Size(183, 20);
            this.txtUnidadeMedida.TabIndex = 8;
            // 
            // dgvMaterial
            // 
            this.dgvMaterial.AllowUserToAddRows = false;
            this.dgvMaterial.AllowUserToDeleteRows = false;
            this.dgvMaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMaterial,
            this.Descricao,
            this.Quantidade,
            this.UnidadeMedida,
            this.Excluir});
            this.dgvMaterial.Location = new System.Drawing.Point(13, 113);
            this.dgvMaterial.Name = "dgvMaterial";
            this.dgvMaterial.ReadOnly = true;
            this.dgvMaterial.Size = new System.Drawing.Size(710, 150);
            this.dgvMaterial.TabIndex = 7;
            this.dgvMaterial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterial_CellClick);
            // 
            // btnSalvarMaterial
            // 
            this.btnSalvarMaterial.Location = new System.Drawing.Point(604, 74);
            this.btnSalvarMaterial.Name = "btnSalvarMaterial";
            this.btnSalvarMaterial.Size = new System.Drawing.Size(119, 23);
            this.btnSalvarMaterial.TabIndex = 6;
            this.btnSalvarMaterial.Text = "Salvar material";
            this.btnSalvarMaterial.UseVisualStyleBackColor = true;
            this.btnSalvarMaterial.Click += new System.EventHandler(this.btnSalvarMaterial_Click);
            // 
            // txtDetalhes
            // 
            this.txtDetalhes.Location = new System.Drawing.Point(227, 37);
            this.txtDetalhes.Multiline = true;
            this.txtDetalhes.Name = "txtDetalhes";
            this.txtDetalhes.Size = new System.Drawing.Size(371, 60);
            this.txtDetalhes.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(224, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Detalhes";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(13, 36);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Quantidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Unidade de medida";
            // 
            // btnSalvarEncomenda
            // 
            this.btnSalvarEncomenda.Location = new System.Drawing.Point(1047, 486);
            this.btnSalvarEncomenda.Name = "btnSalvarEncomenda";
            this.btnSalvarEncomenda.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarEncomenda.TabIndex = 2;
            this.btnSalvarEncomenda.Text = "Salvar";
            this.btnSalvarEncomenda.UseVisualStyleBackColor = true;
            this.btnSalvarEncomenda.Click += new System.EventHandler(this.btnSalvarEncomenda_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(966, 486);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSalvarAnotacao);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtAnotacaoProva);
            this.groupBox3.Controls.Add(this.dgvProva);
            this.groupBox3.Controls.Add(this.btnAgendarProva);
            this.groupBox3.Controls.Add(this.dtpHoraProva);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.dtpDataProva);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(754, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 455);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prova";
            // 
            // btnSalvarAnotacao
            // 
            this.btnSalvarAnotacao.Location = new System.Drawing.Point(293, 417);
            this.btnSalvarAnotacao.Name = "btnSalvarAnotacao";
            this.btnSalvarAnotacao.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarAnotacao.TabIndex = 8;
            this.btnSalvarAnotacao.Text = "Salvar anotação";
            this.btnSalvarAnotacao.UseVisualStyleBackColor = true;
            this.btnSalvarAnotacao.Click += new System.EventHandler(this.btnSalvarAnotacao_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Anotação";
            // 
            // txtAnotacaoProva
            // 
            this.txtAnotacaoProva.Location = new System.Drawing.Point(10, 251);
            this.txtAnotacaoProva.Multiline = true;
            this.txtAnotacaoProva.Name = "txtAnotacaoProva";
            this.txtAnotacaoProva.Size = new System.Drawing.Size(358, 160);
            this.txtAnotacaoProva.TabIndex = 6;
            // 
            // dgvProva
            // 
            this.dgvProva.AllowUserToAddRows = false;
            this.dgvProva.AllowUserToDeleteRows = false;
            this.dgvProva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProva,
            this.Data,
            this.ExcluirProva});
            this.dgvProva.Location = new System.Drawing.Point(10, 65);
            this.dgvProva.Name = "dgvProva";
            this.dgvProva.ReadOnly = true;
            this.dgvProva.Size = new System.Drawing.Size(358, 150);
            this.dgvProva.TabIndex = 5;
            this.dgvProva.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProva_CellClick);
            // 
            // btnAgendarProva
            // 
            this.btnAgendarProva.Location = new System.Drawing.Point(226, 37);
            this.btnAgendarProva.Name = "btnAgendarProva";
            this.btnAgendarProva.Size = new System.Drawing.Size(75, 23);
            this.btnAgendarProva.TabIndex = 4;
            this.btnAgendarProva.Text = "Agendar";
            this.btnAgendarProva.UseVisualStyleBackColor = true;
            this.btnAgendarProva.Click += new System.EventHandler(this.btnAgendarProva_Click);
            // 
            // dtpHoraProva
            // 
            this.dtpHoraProva.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraProva.Location = new System.Drawing.Point(124, 37);
            this.dtpHoraProva.Name = "dtpHoraProva";
            this.dtpHoraProva.Size = new System.Drawing.Size(95, 20);
            this.dtpHoraProva.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(121, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Hora";
            // 
            // dtpDataProva
            // 
            this.dtpDataProva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataProva.Location = new System.Drawing.Point(10, 37);
            this.dtpDataProva.Name = "dtpDataProva";
            this.dtpDataProva.Size = new System.Drawing.Size(105, 20);
            this.dtpDataProva.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Data";
            // 
            // dtpDataEntregaEfet
            // 
            this.dtpDataEntregaEfet.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntregaEfet.Location = new System.Drawing.Point(13, 125);
            this.dtpDataEntregaEfet.Name = "dtpDataEntregaEfet";
            this.dtpDataEntregaEfet.Size = new System.Drawing.Size(119, 20);
            this.dtpDataEntregaEfet.TabIndex = 12;
            // 
            // dtpDataPagamento
            // 
            this.dtpDataPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataPagamento.Location = new System.Drawing.Point(160, 124);
            this.dtpDataPagamento.Name = "dtpDataPagamento";
            this.dtpDataPagamento.Size = new System.Drawing.Size(121, 20);
            this.dtpDataPagamento.TabIndex = 13;
            // 
            // IdProva
            // 
            this.IdProva.DataPropertyName = "Id";
            this.IdProva.HeaderText = "Id";
            this.IdProva.Name = "IdProva";
            this.IdProva.ReadOnly = true;
            this.IdProva.Visible = false;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ExcluirProva
            // 
            this.ExcluirProva.HeaderText = "Excluir";
            this.ExcluirProva.Name = "ExcluirProva";
            this.ExcluirProva.ReadOnly = true;
            this.ExcluirProva.Text = "Excluir";
            this.ExcluirProva.ToolTipText = "Excluir";
            this.ExcluirProva.UseColumnTextForButtonValue = true;
            // 
            // IdMaterial
            // 
            this.IdMaterial.DataPropertyName = "Id";
            this.IdMaterial.HeaderText = "Id";
            this.IdMaterial.Name = "IdMaterial";
            this.IdMaterial.ReadOnly = true;
            this.IdMaterial.Visible = false;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Descricao.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UnidadeMedida
            // 
            this.UnidadeMedida.DataPropertyName = "UnidadeMedida";
            this.UnidadeMedida.HeaderText = "Unidade de medida";
            this.UnidadeMedida.Name = "UnidadeMedida";
            this.UnidadeMedida.ReadOnly = true;
            this.UnidadeMedida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Excluir
            // 
            this.Excluir.DataPropertyName = "Excluir";
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Excluir.Text = "Excluir";
            this.Excluir.ToolTipText = "Excluir";
            this.Excluir.UseColumnTextForLinkValue = true;
            this.Excluir.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // FormEncomenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 521);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvarEncomenda);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEncomenda";
            this.Text = "Cadastro de encomenda";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDataEntregaPrev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalvarMaterial;
        private System.Windows.Forms.TextBox txtDetalhes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvMaterial;
        private System.Windows.Forms.Button btnSalvarEncomenda;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtUnidadeMedida;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpHoraProva;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpDataProva;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvProva;
        private System.Windows.Forms.Button btnAgendarProva;
        private System.Windows.Forms.Button btnSalvarAnotacao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAnotacaoProva;
        private System.Windows.Forms.DateTimePicker dtpDataPagamento;
        private System.Windows.Forms.DateTimePicker dtpDataEntregaEfet;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewButtonColumn ExcluirProva;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMaterial;
        private System.Windows.Forms.DataGridViewLinkColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadeMedida;
        private System.Windows.Forms.DataGridViewLinkColumn Excluir;
    }
}