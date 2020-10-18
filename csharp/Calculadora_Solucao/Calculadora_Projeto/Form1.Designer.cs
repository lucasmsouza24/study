namespace Calculadora_Projeto
{
    partial class FormMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNegativo = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDecimal = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonMais = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonMenos = new System.Windows.Forms.Button();
            this.buttonVezes = new System.Windows.Forms.Button();
            this.buttonResultado = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(178, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonNegativo);
            this.panel1.Controls.Add(this.button0);
            this.panel1.Controls.Add(this.buttonDecimal);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 217);
            this.panel1.TabIndex = 1;
            // 
            // buttonNegativo
            // 
            this.buttonNegativo.Location = new System.Drawing.Point(121, 165);
            this.buttonNegativo.Name = "buttonNegativo";
            this.buttonNegativo.Size = new System.Drawing.Size(54, 48);
            this.buttonNegativo.TabIndex = 11;
            this.buttonNegativo.Text = "-/+";
            this.buttonNegativo.UseVisualStyleBackColor = true;
            this.buttonNegativo.Click += new System.EventHandler(this.buttonNegativo_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(63, 165);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(54, 48);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonDecimal
            // 
            this.buttonDecimal.Location = new System.Drawing.Point(3, 165);
            this.buttonDecimal.Name = "buttonDecimal";
            this.buttonDecimal.Size = new System.Drawing.Size(54, 48);
            this.buttonDecimal.TabIndex = 9;
            this.buttonDecimal.Text = ",";
            this.buttonDecimal.UseVisualStyleBackColor = true;
            this.buttonDecimal.Click += new System.EventHandler(this.buttonDecimal_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(121, 111);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(54, 48);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(63, 111);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(54, 48);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 111);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(54, 48);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(121, 57);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(54, 48);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(63, 57);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 48);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 48);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(121, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 48);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonMais);
            this.panel2.Controls.Add(this.buttonDiv);
            this.panel2.Controls.Add(this.buttonMenos);
            this.panel2.Controls.Add(this.buttonVezes);
            this.panel2.Location = new System.Drawing.Point(196, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(67, 154);
            this.panel2.TabIndex = 2;
            // 
            // buttonMais
            // 
            this.buttonMais.Location = new System.Drawing.Point(0, 0);
            this.buttonMais.Name = "buttonMais";
            this.buttonMais.Size = new System.Drawing.Size(67, 34);
            this.buttonMais.TabIndex = 0;
            this.buttonMais.Text = "+";
            this.buttonMais.UseVisualStyleBackColor = true;
            this.buttonMais.Click += new System.EventHandler(this.buttonMais_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(0, 120);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(67, 34);
            this.buttonDiv.TabIndex = 5;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // buttonMenos
            // 
            this.buttonMenos.Location = new System.Drawing.Point(0, 40);
            this.buttonMenos.Name = "buttonMenos";
            this.buttonMenos.Size = new System.Drawing.Size(67, 34);
            this.buttonMenos.TabIndex = 4;
            this.buttonMenos.Text = "-";
            this.buttonMenos.UseVisualStyleBackColor = true;
            this.buttonMenos.Click += new System.EventHandler(this.buttonMenos_Click);
            // 
            // buttonVezes
            // 
            this.buttonVezes.Location = new System.Drawing.Point(0, 80);
            this.buttonVezes.Name = "buttonVezes";
            this.buttonVezes.Size = new System.Drawing.Size(67, 34);
            this.buttonVezes.TabIndex = 3;
            this.buttonVezes.Text = "*";
            this.buttonVezes.UseVisualStyleBackColor = true;
            this.buttonVezes.Click += new System.EventHandler(this.buttonVezes_Click);
            // 
            // buttonResultado
            // 
            this.buttonResultado.BackColor = System.Drawing.Color.Turquoise;
            this.buttonResultado.Location = new System.Drawing.Point(196, 209);
            this.buttonResultado.Name = "buttonResultado";
            this.buttonResultado.Size = new System.Drawing.Size(67, 51);
            this.buttonResultado.TabIndex = 3;
            this.buttonResultado.Text = "=";
            this.buttonResultado.UseVisualStyleBackColor = false;
            this.buttonResultado.Click += new System.EventHandler(this.buttonResultado_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonClear.Location = new System.Drawing.Point(197, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(66, 39);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 274);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonResultado);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Calculadora";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonNegativo;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDecimal;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonMais;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonMenos;
        private System.Windows.Forms.Button buttonVezes;
        private System.Windows.Forms.Button buttonResultado;
        private System.Windows.Forms.Button buttonClear;
    }
}

