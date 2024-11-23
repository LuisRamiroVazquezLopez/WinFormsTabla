namespace WinFormsTabla
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelprincipal = new Panel();
            labelnombre = new Label();
            richTextBoxresultados = new RichTextBox();
            buttonver = new Button();
            textBoxnum = new TextBox();
            labelnumero = new Label();
            labeltitulo = new Label();
            panelprincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelprincipal
            // 
            panelprincipal.BackColor = Color.SteelBlue;
            panelprincipal.Controls.Add(labelnombre);
            panelprincipal.Controls.Add(richTextBoxresultados);
            panelprincipal.Controls.Add(buttonver);
            panelprincipal.Controls.Add(textBoxnum);
            panelprincipal.Controls.Add(labelnumero);
            panelprincipal.Controls.Add(labeltitulo);
            panelprincipal.Location = new Point(12, 11);
            panelprincipal.Name = "panelprincipal";
            panelprincipal.Size = new Size(1118, 661);
            panelprincipal.TabIndex = 0;
            // 
            // labelnombre
            // 
            labelnombre.AutoSize = true;
            labelnombre.Location = new Point(13, 612);
            labelnombre.Name = "labelnombre";
            labelnombre.Size = new Size(302, 32);
            labelnombre.TabIndex = 5;
            labelnombre.Text = "Luis Ramiro Vázquez López";
            labelnombre.TextAlign = ContentAlignment.BottomLeft;
            // 
            // richTextBoxresultados
            // 
            richTextBoxresultados.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxresultados.Location = new Point(607, 167);
            richTextBoxresultados.Name = "richTextBoxresultados";
            richTextBoxresultados.Size = new Size(268, 420);
            richTextBoxresultados.TabIndex = 4;
            richTextBoxresultados.Text = "";
            // 
            // buttonver
            // 
            buttonver.FlatStyle = FlatStyle.Flat;
            buttonver.Font = new Font("Times New Roman", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonver.Location = new Point(165, 298);
            buttonver.Name = "buttonver";
            buttonver.Size = new Size(150, 46);
            buttonver.TabIndex = 3;
            buttonver.Text = "Ver tabla";
            buttonver.UseVisualStyleBackColor = true;
            buttonver.Click += buttonver_Click;
            // 
            // textBoxnum
            // 
            textBoxnum.BackColor = SystemColors.HighlightText;
            textBoxnum.Location = new Point(96, 226);
            textBoxnum.Name = "textBoxnum";
            textBoxnum.Size = new Size(300, 39);
            textBoxnum.TabIndex = 2;
            textBoxnum.TextAlign = HorizontalAlignment.Center;
            textBoxnum.TextChanged += textBox1_TextChanged;
            // 
            // labelnumero
            // 
            labelnumero.AutoSize = true;
            labelnumero.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelnumero.Location = new Point(96, 167);
            labelnumero.Name = "labelnumero";
            labelnumero.Size = new Size(300, 40);
            labelnumero.TabIndex = 1;
            labelnumero.Text = "¿Cual tabla quieres?";
            labelnumero.UseMnemonic = false;
            labelnumero.Click += labelnumero_Click;
            // 
            // labeltitulo
            // 
            labeltitulo.AutoSize = true;
            labeltitulo.Font = new Font("Stencil", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltitulo.Location = new Point(294, 81);
            labeltitulo.Name = "labeltitulo";
            labeltitulo.Size = new Size(457, 44);
            labeltitulo.TabIndex = 0;
            labeltitulo.Text = "Tabla de Multiplicar";
            labeltitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 684);
            Controls.Add(panelprincipal);
            Name = "Form1";
            Text = "Form1";
            panelprincipal.ResumeLayout(false);
            panelprincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelprincipal;
        private Label labeltitulo;
        private Label labelnumero;
        private TextBox textBoxnum;
        private RichTextBox richTextBoxresultados;
        private Button buttonver;
        private Label labelnombre;
    }
}
