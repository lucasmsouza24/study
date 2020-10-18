namespace Atividade08_Projeto
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome do estado:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(26, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "UF:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(26, 173);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 20);
            this.textBox3.TabIndex = 4;
            // 
            // buttonSair
            // 
            this.buttonSair.Image = global::Atividade08_Projeto.Properties.Resources.exit;
            this.buttonSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSair.Location = new System.Drawing.Point(241, 33);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 63);
            this.buttonSair.TabIndex = 6;
            this.buttonSair.Text = "Sair";
            this.buttonSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Image = global::Atividade08_Projeto.Properties.Resources.atualizar;
            this.buttonAtualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAtualizar.Location = new System.Drawing.Point(17, 314);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(75, 63);
            this.buttonAtualizar.TabIndex = 7;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            // 
            // buttonNovo
            // 
            this.buttonNovo.Image = global::Atividade08_Projeto.Properties.Resources.adicionar;
            this.buttonNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonNovo.Location = new System.Drawing.Point(98, 314);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(75, 63);
            this.buttonNovo.TabIndex = 8;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNovo.UseVisualStyleBackColor = true;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Image = global::Atividade08_Projeto.Properties.Resources.search;
            this.buttonPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPesquisar.Location = new System.Drawing.Point(260, 314);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(75, 63);
            this.buttonPesquisar.TabIndex = 10;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Image = global::Atividade08_Projeto.Properties.Resources.erase;
            this.buttonApagar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonApagar.Location = new System.Drawing.Point(179, 314);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 63);
            this.buttonApagar.TabIndex = 9;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonApagar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 398);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Button buttonApagar;
    }
}

