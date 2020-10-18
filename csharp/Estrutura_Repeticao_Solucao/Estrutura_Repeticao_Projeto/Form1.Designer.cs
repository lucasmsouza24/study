namespace Estrutura_Repeticao_Projeto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelValor = new System.Windows.Forms.Label();
            this.listBoxNumeros = new System.Windows.Forms.ListBox();
            this.buttonMostrar1 = new System.Windows.Forms.Button();
            this.buttonMostrar2 = new System.Windows.Forms.Button();
            this.numericUpDownValor = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDownFor = new System.Windows.Forms.NumericUpDown();
            this.buttonMostrarFor = new System.Windows.Forms.Button();
            this.listBoxFor = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBoxWhile = new System.Windows.Forms.ListBox();
            this.buttonWhile = new System.Windows.Forms.Button();
            this.numericUpDownWhile = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValor)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFor)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWhile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.numericUpDownValor);
            this.panel1.Controls.Add(this.buttonMostrar2);
            this.panel1.Controls.Add(this.buttonMostrar1);
            this.panel1.Controls.Add(this.listBoxNumeros);
            this.panel1.Controls.Add(this.labelValor);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 469);
            this.panel1.TabIndex = 0;
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(14, 30);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(171, 19);
            this.labelValor.TabIndex = 0;
            this.labelValor.Text = "Escolha um valor: ";
            // 
            // listBoxNumeros
            // 
            this.listBoxNumeros.FormattingEnabled = true;
            this.listBoxNumeros.ItemHeight = 19;
            this.listBoxNumeros.Location = new System.Drawing.Point(18, 124);
            this.listBoxNumeros.Name = "listBoxNumeros";
            this.listBoxNumeros.Size = new System.Drawing.Size(255, 308);
            this.listBoxNumeros.TabIndex = 1;
            // 
            // buttonMostrar1
            // 
            this.buttonMostrar1.Location = new System.Drawing.Point(27, 77);
            this.buttonMostrar1.Name = "buttonMostrar1";
            this.buttonMostrar1.Size = new System.Drawing.Size(105, 30);
            this.buttonMostrar1.TabIndex = 2;
            this.buttonMostrar1.Text = "Mostrar 1";
            this.buttonMostrar1.UseVisualStyleBackColor = true;
            this.buttonMostrar1.Click += new System.EventHandler(this.buttonMostrar1_Click);
            // 
            // buttonMostrar2
            // 
            this.buttonMostrar2.Location = new System.Drawing.Point(152, 77);
            this.buttonMostrar2.Name = "buttonMostrar2";
            this.buttonMostrar2.Size = new System.Drawing.Size(105, 30);
            this.buttonMostrar2.TabIndex = 3;
            this.buttonMostrar2.Text = "Mostrar 2";
            this.buttonMostrar2.UseVisualStyleBackColor = true;
            this.buttonMostrar2.Click += new System.EventHandler(this.buttonMostrar2_Click);
            // 
            // numericUpDownValor
            // 
            this.numericUpDownValor.Location = new System.Drawing.Point(179, 28);
            this.numericUpDownValor.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownValor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownValor.Name = "numericUpDownValor";
            this.numericUpDownValor.Size = new System.Drawing.Size(87, 26);
            this.numericUpDownValor.TabIndex = 4;
            this.numericUpDownValor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.listBoxFor);
            this.panel2.Controls.Add(this.buttonMostrarFor);
            this.panel2.Controls.Add(this.numericUpDownFor);
            this.panel2.Location = new System.Drawing.Point(317, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 236);
            this.panel2.TabIndex = 1;
            // 
            // numericUpDownFor
            // 
            this.numericUpDownFor.Location = new System.Drawing.Point(27, 21);
            this.numericUpDownFor.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownFor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFor.Name = "numericUpDownFor";
            this.numericUpDownFor.Size = new System.Drawing.Size(87, 26);
            this.numericUpDownFor.TabIndex = 5;
            this.numericUpDownFor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonMostrarFor
            // 
            this.buttonMostrarFor.Location = new System.Drawing.Point(161, 17);
            this.buttonMostrarFor.Name = "buttonMostrarFor";
            this.buttonMostrarFor.Size = new System.Drawing.Size(105, 30);
            this.buttonMostrarFor.TabIndex = 5;
            this.buttonMostrarFor.Text = "Mostrar";
            this.buttonMostrarFor.UseVisualStyleBackColor = true;
            this.buttonMostrarFor.Click += new System.EventHandler(this.buttonMostrarFor_Click);
            // 
            // listBoxFor
            // 
            this.listBoxFor.FormattingEnabled = true;
            this.listBoxFor.ItemHeight = 19;
            this.listBoxFor.Location = new System.Drawing.Point(11, 64);
            this.listBoxFor.Name = "listBoxFor";
            this.listBoxFor.Size = new System.Drawing.Size(255, 156);
            this.listBoxFor.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.listBoxWhile);
            this.panel3.Controls.Add(this.buttonWhile);
            this.panel3.Controls.Add(this.numericUpDownWhile);
            this.panel3.Location = new System.Drawing.Point(316, 257);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(283, 225);
            this.panel3.TabIndex = 6;
            // 
            // listBoxWhile
            // 
            this.listBoxWhile.FormattingEnabled = true;
            this.listBoxWhile.ItemHeight = 19;
            this.listBoxWhile.Location = new System.Drawing.Point(11, 64);
            this.listBoxWhile.Name = "listBoxWhile";
            this.listBoxWhile.Size = new System.Drawing.Size(255, 156);
            this.listBoxWhile.TabIndex = 5;
            // 
            // buttonWhile
            // 
            this.buttonWhile.Location = new System.Drawing.Point(161, 17);
            this.buttonWhile.Name = "buttonWhile";
            this.buttonWhile.Size = new System.Drawing.Size(105, 30);
            this.buttonWhile.TabIndex = 5;
            this.buttonWhile.Text = "Mostrar ";
            this.buttonWhile.UseVisualStyleBackColor = true;
            this.buttonWhile.Click += new System.EventHandler(this.buttonWhile_Click);
            // 
            // numericUpDownWhile
            // 
            this.numericUpDownWhile.Location = new System.Drawing.Point(27, 21);
            this.numericUpDownWhile.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownWhile.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWhile.Name = "numericUpDownWhile";
            this.numericUpDownWhile.Size = new System.Drawing.Size(87, 26);
            this.numericUpDownWhile.TabIndex = 5;
            this.numericUpDownWhile.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lucas Mesquita de Souza";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(612, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPrincipal";
            this.Text = "Estrutura de Repetição";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValor)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFor)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWhile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDownValor;
        private System.Windows.Forms.Button buttonMostrar2;
        private System.Windows.Forms.Button buttonMostrar1;
        private System.Windows.Forms.ListBox listBoxNumeros;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBoxFor;
        private System.Windows.Forms.Button buttonMostrarFor;
        private System.Windows.Forms.NumericUpDown numericUpDownFor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBoxWhile;
        private System.Windows.Forms.Button buttonWhile;
        private System.Windows.Forms.NumericUpDown numericUpDownWhile;
        private System.Windows.Forms.Label label1;
    }
}

