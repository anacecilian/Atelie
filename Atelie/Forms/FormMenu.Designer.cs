﻿namespace Atelie.Forms
{
    partial class FormMenu
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
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConsultarEncomenda = new System.Windows.Forms.Button();
            this.btnCadastrarEncomenda = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnConsultarProva = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsultarCliente);
            this.groupBox1.Controls.Add(this.btnCadastrarCliente);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(91, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.Location = new System.Drawing.Point(7, 50);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarCliente.TabIndex = 1;
            this.btnConsultarCliente.Text = "Consultar";
            this.btnConsultarCliente.UseVisualStyleBackColor = true;
            this.btnConsultarCliente.Click += new System.EventHandler(this.btnConsultarCliente_Click);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Location = new System.Drawing.Point(7, 20);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarCliente.TabIndex = 0;
            this.btnCadastrarCliente.Text = "Cadastrar";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConsultarEncomenda);
            this.groupBox2.Controls.Add(this.btnCadastrarEncomenda);
            this.groupBox2.Location = new System.Drawing.Point(111, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(87, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encomenda";
            // 
            // btnConsultarEncomenda
            // 
            this.btnConsultarEncomenda.Location = new System.Drawing.Point(7, 50);
            this.btnConsultarEncomenda.Name = "btnConsultarEncomenda";
            this.btnConsultarEncomenda.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarEncomenda.TabIndex = 1;
            this.btnConsultarEncomenda.Text = "Consultar";
            this.btnConsultarEncomenda.UseVisualStyleBackColor = true;
            this.btnConsultarEncomenda.Click += new System.EventHandler(this.btnConsultarEncomenda_Click);
            // 
            // btnCadastrarEncomenda
            // 
            this.btnCadastrarEncomenda.Location = new System.Drawing.Point(7, 20);
            this.btnCadastrarEncomenda.Name = "btnCadastrarEncomenda";
            this.btnCadastrarEncomenda.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarEncomenda.TabIndex = 0;
            this.btnCadastrarEncomenda.Text = "Cadastrar";
            this.btnCadastrarEncomenda.UseVisualStyleBackColor = true;
            this.btnCadastrarEncomenda.Click += new System.EventHandler(this.btnCadastrarEncomenda_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnConsultarProva);
            this.groupBox3.Location = new System.Drawing.Point(205, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(90, 80);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prova";
            // 
            // btnConsultarProva
            // 
            this.btnConsultarProva.Location = new System.Drawing.Point(7, 20);
            this.btnConsultarProva.Name = "btnConsultarProva";
            this.btnConsultarProva.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarProva.TabIndex = 0;
            this.btnConsultarProva.Text = "Consultar";
            this.btnConsultarProva.UseVisualStyleBackColor = true;
            this.btnConsultarProva.Click += new System.EventHandler(this.btnConsultarProva_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 101);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsultarCliente;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConsultarEncomenda;
        private System.Windows.Forms.Button btnCadastrarEncomenda;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnConsultarProva;
    }
}