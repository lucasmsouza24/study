namespace Personagens_Projeto
{
    partial class FormPersonagens
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
            this.pictureBoxPersonagem = new System.Windows.Forms.PictureBox();
            this.listBoxPersonagem = new System.Windows.Forms.ListBox();
            this.comboBoxPersonagem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersonagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPersonagem
            // 
            this.pictureBoxPersonagem.Location = new System.Drawing.Point(317, 33);
            this.pictureBoxPersonagem.Name = "pictureBoxPersonagem";
            this.pictureBoxPersonagem.Size = new System.Drawing.Size(309, 323);
            this.pictureBoxPersonagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPersonagem.TabIndex = 0;
            this.pictureBoxPersonagem.TabStop = false;
            // 
            // listBoxPersonagem
            // 
            this.listBoxPersonagem.FormattingEnabled = true;
            this.listBoxPersonagem.ItemHeight = 19;
            this.listBoxPersonagem.Items.AddRange(new object[] {
            "Goku",
            "Vegeta",
            "Inuyasha",
            "Sesshoumaru",
            "Tokoyami",
            "Yusuke",
            "Tanjiro",
            "Zero-Two",
            "Erwin",
            "Goblin Slayer"});
            this.listBoxPersonagem.Location = new System.Drawing.Point(62, 33);
            this.listBoxPersonagem.Name = "listBoxPersonagem";
            this.listBoxPersonagem.Size = new System.Drawing.Size(173, 232);
            this.listBoxPersonagem.TabIndex = 1;
            this.listBoxPersonagem.SelectedIndexChanged += new System.EventHandler(this.listBoxPersonagem_SelectedIndexChanged);
            // 
            // comboBoxPersonagem
            // 
            this.comboBoxPersonagem.FormattingEnabled = true;
            this.comboBoxPersonagem.Items.AddRange(new object[] {
            "Goku",
            "Vegeta",
            "Inuyasha",
            "Sesshoumaru",
            "Tokoyami",
            "Yusuke",
            "Tanjiro",
            "Zero-Two",
            "Erwin",
            "Goblin Slayer"});
            this.comboBoxPersonagem.Location = new System.Drawing.Point(62, 317);
            this.comboBoxPersonagem.Name = "comboBoxPersonagem";
            this.comboBoxPersonagem.Size = new System.Drawing.Size(173, 27);
            this.comboBoxPersonagem.TabIndex = 2;
            this.comboBoxPersonagem.SelectedIndexChanged += new System.EventHandler(this.comboBoxPersonagem_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lucas Mesquita de Souza";
            // 
            // FormPersonagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPersonagem);
            this.Controls.Add(this.listBoxPersonagem);
            this.Controls.Add(this.pictureBoxPersonagem);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPersonagens";
            this.Text = "O Programa Personagens";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersonagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPersonagem;
        private System.Windows.Forms.ListBox listBoxPersonagem;
        private System.Windows.Forms.ComboBox comboBoxPersonagem;
        private System.Windows.Forms.Label label1;
    }
}

