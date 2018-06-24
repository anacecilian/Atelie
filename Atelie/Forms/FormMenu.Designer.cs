namespace Atelie.Forms
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
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCadastrarEncomenda = new System.Windows.Forms.Button();
            this.btnConsultarEncomenda = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Location = new System.Drawing.Point(7, 20);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarCliente.TabIndex = 0;
            this.btnCadastrarCliente.Text = "Cadastrar";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.Location = new System.Drawing.Point(7, 50);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarCliente.TabIndex = 1;
            this.btnConsultarCliente.Text = "Consultar";
            this.btnConsultarCliente.UseVisualStyleBackColor = true;
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
            // btnCadastrarEncomenda
            // 
            this.btnCadastrarEncomenda.Location = new System.Drawing.Point(7, 20);
            this.btnCadastrarEncomenda.Name = "btnCadastrarEncomenda";
            this.btnCadastrarEncomenda.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarEncomenda.TabIndex = 0;
            this.btnCadastrarEncomenda.Text = "Cadastrar";
            this.btnCadastrarEncomenda.UseVisualStyleBackColor = true;
            // 
            // btnConsultarEncomenda
            // 
            this.btnConsultarEncomenda.Location = new System.Drawing.Point(7, 50);
            this.btnConsultarEncomenda.Name = "btnConsultarEncomenda";
            this.btnConsultarEncomenda.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarEncomenda.TabIndex = 1;
            this.btnConsultarEncomenda.Text = "Consultar";
            this.btnConsultarEncomenda.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsultarCliente;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConsultarEncomenda;
        private System.Windows.Forms.Button btnCadastrarEncomenda;
    }
}