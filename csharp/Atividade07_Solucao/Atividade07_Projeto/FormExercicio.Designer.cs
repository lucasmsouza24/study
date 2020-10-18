namespace Atividade07_Projeto
{
    partial class FormExercicio
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
            this.buttonPesquisarCliente = new System.Windows.Forms.Button();
            this.buttonSairCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCodigoCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonSexoM = new System.Windows.Forms.RadioButton();
            this.radioButtonSexoF = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPesquisarCliente
            // 
            this.buttonPesquisarCliente.BackColor = System.Drawing.Color.Firebrick;
            this.buttonPesquisarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPesquisarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPesquisarCliente.Image = global::Atividade07_Projeto.Properties.Resources.search;
            this.buttonPesquisarCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPesquisarCliente.Location = new System.Drawing.Point(218, 275);
            this.buttonPesquisarCliente.Name = "buttonPesquisarCliente";
            this.buttonPesquisarCliente.Size = new System.Drawing.Size(100, 74);
            this.buttonPesquisarCliente.TabIndex = 17;
            this.buttonPesquisarCliente.Text = "Pesquisar";
            this.buttonPesquisarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPesquisarCliente.UseVisualStyleBackColor = false;
            this.buttonPesquisarCliente.Click += new System.EventHandler(this.buttonPesquisarCliente_Click);
            // 
            // buttonSairCliente
            // 
            this.buttonSairCliente.BackColor = System.Drawing.Color.Firebrick;
            this.buttonSairCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSairCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSairCliente.Image = global::Atividade07_Projeto.Properties.Resources.exit;
            this.buttonSairCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSairCliente.Location = new System.Drawing.Point(218, 12);
            this.buttonSairCliente.Name = "buttonSairCliente";
            this.buttonSairCliente.Size = new System.Drawing.Size(100, 73);
            this.buttonSairCliente.TabIndex = 16;
            this.buttonSairCliente.Text = "Sair";
            this.buttonSairCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSairCliente.UseVisualStyleBackColor = false;
            this.buttonSairCliente.Click += new System.EventHandler(this.buttonSairCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sexo:";
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.Location = new System.Drawing.Point(21, 125);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.ReadOnly = true;
            this.textBoxNomeCliente.Size = new System.Drawing.Size(297, 26);
            this.textBoxNomeCliente.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nome:";
            // 
            // textBoxCodigoCliente
            // 
            this.textBoxCodigoCliente.Location = new System.Drawing.Point(21, 49);
            this.textBoxCodigoCliente.Name = "textBoxCodigoCliente";
            this.textBoxCodigoCliente.Size = new System.Drawing.Size(32, 26);
            this.textBoxCodigoCliente.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Código do cliente:";
            // 
            // radioButtonSexoM
            // 
            this.radioButtonSexoM.AutoSize = true;
            this.radioButtonSexoM.Location = new System.Drawing.Point(21, 202);
            this.radioButtonSexoM.Name = "radioButtonSexoM";
            this.radioButtonSexoM.Size = new System.Drawing.Size(108, 23);
            this.radioButtonSexoM.TabIndex = 18;
            this.radioButtonSexoM.TabStop = true;
            this.radioButtonSexoM.Text = "Masculino";
            this.radioButtonSexoM.UseVisualStyleBackColor = true;
            // 
            // radioButtonSexoF
            // 
            this.radioButtonSexoF.AutoSize = true;
            this.radioButtonSexoF.Location = new System.Drawing.Point(21, 231);
            this.radioButtonSexoF.Name = "radioButtonSexoF";
            this.radioButtonSexoF.Size = new System.Drawing.Size(99, 23);
            this.radioButtonSexoF.TabIndex = 19;
            this.radioButtonSexoF.TabStop = true;
            this.radioButtonSexoF.Text = "Feminino";
            this.radioButtonSexoF.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Lucas Mesquita";
            // 
            // FormExercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButtonSexoF);
            this.Controls.Add(this.radioButtonSexoM);
            this.Controls.Add(this.buttonPesquisarCliente);
            this.Controls.Add(this.buttonSairCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNomeCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCodigoCliente);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormExercicio";
            this.Text = "Exercício";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPesquisarCliente;
        private System.Windows.Forms.Button buttonSairCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCodigoCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonSexoM;
        private System.Windows.Forms.RadioButton radioButtonSexoF;
        private System.Windows.Forms.Label label4;
    }
}