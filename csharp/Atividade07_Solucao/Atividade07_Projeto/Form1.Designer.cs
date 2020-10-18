namespace Atividade07_Projeto
{
    partial class frmAcesso
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
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxNomeDoEstado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(25, 49);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(32, 26);
            this.textBoxCodigo.TabIndex = 3;
            // 
            // textBoxNomeDoEstado
            // 
            this.textBoxNomeDoEstado.Location = new System.Drawing.Point(25, 125);
            this.textBoxNomeDoEstado.Name = "textBoxNomeDoEstado";
            this.textBoxNomeDoEstado.ReadOnly = true;
            this.textBoxNomeDoEstado.Size = new System.Drawing.Size(181, 26);
            this.textBoxNomeDoEstado.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome do estado:";
            // 
            // textBoxUF
            // 
            this.textBoxUF.Location = new System.Drawing.Point(25, 202);
            this.textBoxUF.Name = "textBoxUF";
            this.textBoxUF.ReadOnly = true;
            this.textBoxUF.Size = new System.Drawing.Size(32, 26);
            this.textBoxUF.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "UF:";
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSair.Image = global::Atividade07_Projeto.Properties.Resources.exit;
            this.buttonSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSair.Location = new System.Drawing.Point(222, 12);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(100, 73);
            this.buttonSair.TabIndex = 8;
            this.buttonSair.Text = "Sair";
            this.buttonSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPesquisar.Image = global::Atividade07_Projeto.Properties.Resources.search;
            this.buttonPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPesquisar.Location = new System.Drawing.Point(222, 275);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(100, 74);
            this.buttonPesquisar.TabIndex = 9;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPesquisar.UseVisualStyleBackColor = false;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Lucas Mesquita";
            // 
            // frmAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.textBoxUF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNomeDoEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAcesso";
            this.Text = "Acesso MySQL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxNomeDoEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Label label4;
    }
}

