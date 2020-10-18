namespace Data_Projeto
{
    partial class FormPrincipal
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
            this.buttonExibiaDia = new System.Windows.Forms.Button();
            this.labelExibicao = new System.Windows.Forms.Label();
            this.buttonExibirDataJunta = new System.Windows.Forms.Button();
            this.buttonExibeBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExibiaDia
            // 
            this.buttonExibiaDia.Location = new System.Drawing.Point(12, 114);
            this.buttonExibiaDia.Name = "buttonExibiaDia";
            this.buttonExibiaDia.Size = new System.Drawing.Size(87, 23);
            this.buttonExibiaDia.TabIndex = 0;
            this.buttonExibiaDia.Text = "Data separada";
            this.buttonExibiaDia.UseVisualStyleBackColor = true;
            this.buttonExibiaDia.Click += new System.EventHandler(this.buttonExibiaDia_Click);
            // 
            // labelExibicao
            // 
            this.labelExibicao.Location = new System.Drawing.Point(12, 13);
            this.labelExibicao.Name = "labelExibicao";
            this.labelExibicao.Size = new System.Drawing.Size(250, 86);
            this.labelExibicao.TabIndex = 1;
            this.labelExibicao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExibirDataJunta
            // 
            this.buttonExibirDataJunta.Location = new System.Drawing.Point(105, 114);
            this.buttonExibirDataJunta.Name = "buttonExibirDataJunta";
            this.buttonExibirDataJunta.Size = new System.Drawing.Size(77, 23);
            this.buttonExibirDataJunta.TabIndex = 2;
            this.buttonExibirDataJunta.Text = "Data junta";
            this.buttonExibirDataJunta.UseVisualStyleBackColor = true;
            this.buttonExibirDataJunta.Click += new System.EventHandler(this.buttonExibirDataJunta_Click);
            // 
            // buttonExibeBox
            // 
            this.buttonExibeBox.Location = new System.Drawing.Point(188, 114);
            this.buttonExibeBox.Name = "buttonExibeBox";
            this.buttonExibeBox.Size = new System.Drawing.Size(75, 23);
            this.buttonExibeBox.TabIndex = 3;
            this.buttonExibeBox.Text = "Box";
            this.buttonExibeBox.UseVisualStyleBackColor = true;
            this.buttonExibeBox.Click += new System.EventHandler(this.buttonExibeBox_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 149);
            this.Controls.Add(this.buttonExibeBox);
            this.Controls.Add(this.buttonExibirDataJunta);
            this.Controls.Add(this.labelExibicao);
            this.Controls.Add(this.buttonExibiaDia);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExibiaDia;
        private System.Windows.Forms.Label labelExibicao;
        private System.Windows.Forms.Button buttonExibirDataJunta;
        private System.Windows.Forms.Button buttonExibeBox;
    }
}

