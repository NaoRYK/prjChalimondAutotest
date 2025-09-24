namespace prjChalimondAutotest
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
            panel1 = new Panel();
            textBox2 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            lblTCantTurnos = new Label();
            lblTMasAntiguo = new Label();
            lblTDominio = new Label();
            lblCantTurnos = new Label();
            lblAñoMasAntiguo = new Label();
            lblDominio6Char = new Label();
            button3 = new Button();
            panel2 = new Panel();
            lblAñoFab = new Label();
            lblDominio = new Label();
            lblNumTurn = new Label();
            lblTitular = new Label();
            numericUpDown2 = new NumericUpDown();
            lblRegistroTurnos = new Label();
            lblEstadisticas = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(numericUpDown2);
            panel1.Controls.Add(lblTitular);
            panel1.Controls.Add(lblAñoFab);
            panel1.Controls.Add(lblDominio);
            panel1.Controls.Add(lblNumTurn);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(42, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 208);
            panel1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(107, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(144, 23);
            textBox2.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(107, 109);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(144, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(107, 147);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(144, 23);
            textBox3.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(295, 43);
            button1.Name = "button1";
            button1.Size = new Size(75, 49);
            button1.TabIndex = 4;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(295, 126);
            button2.Name = "button2";
            button2.Size = new Size(75, 44);
            button2.TabIndex = 5;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            // 
            // lblTCantTurnos
            // 
            lblTCantTurnos.AutoSize = true;
            lblTCantTurnos.Location = new Point(10, 20);
            lblTCantTurnos.Name = "lblTCantTurnos";
            lblTCantTurnos.Size = new Size(111, 15);
            lblTCantTurnos.TabIndex = 1;
            lblTCantTurnos.Text = "Cantidad de turnos:";
            // 
            // lblTMasAntiguo
            // 
            lblTMasAntiguo.AutoSize = true;
            lblTMasAntiguo.Location = new Point(10, 47);
            lblTMasAntiguo.Name = "lblTMasAntiguo";
            lblTMasAntiguo.Size = new Size(117, 15);
            lblTMasAntiguo.TabIndex = 2;
            lblTMasAntiguo.Text = "Año del mas antiguo";
            // 
            // lblTDominio
            // 
            lblTDominio.AutoSize = true;
            lblTDominio.Location = new Point(10, 68);
            lblTDominio.Name = "lblTDominio";
            lblTDominio.Size = new Size(213, 15);
            lblTDominio.TabIndex = 3;
            lblTDominio.Text = "Cantidad con dominio de 6 caraceteres";
            // 
            // lblCantTurnos
            // 
            lblCantTurnos.AutoSize = true;
            lblCantTurnos.Location = new Point(127, 20);
            lblCantTurnos.Name = "lblCantTurnos";
            lblCantTurnos.Size = new Size(0, 15);
            lblCantTurnos.TabIndex = 4;
            // 
            // lblAñoMasAntiguo
            // 
            lblAñoMasAntiguo.AutoSize = true;
            lblAñoMasAntiguo.Location = new Point(127, 47);
            lblAñoMasAntiguo.Name = "lblAñoMasAntiguo";
            lblAñoMasAntiguo.Size = new Size(0, 15);
            lblAñoMasAntiguo.TabIndex = 5;
            // 
            // lblDominio6Char
            // 
            lblDominio6Char.AutoSize = true;
            lblDominio6Char.Location = new Point(229, 68);
            lblDominio6Char.Name = "lblDominio6Char";
            lblDominio6Char.Size = new Size(0, 15);
            lblDominio6Char.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new Point(299, 37);
            button3.Name = "button3";
            button3.Size = new Size(71, 34);
            button3.TabIndex = 7;
            button3.Text = "Consultar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblDominio6Char);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(lblAñoMasAntiguo);
            panel2.Controls.Add(lblCantTurnos);
            panel2.Controls.Add(lblTDominio);
            panel2.Controls.Add(lblTMasAntiguo);
            panel2.Controls.Add(lblTCantTurnos);
            panel2.Location = new Point(42, 270);
            panel2.Name = "panel2";
            panel2.Size = new Size(397, 101);
            panel2.TabIndex = 8;
            // 
            // lblAñoFab
            // 
            lblAñoFab.AutoSize = true;
            lblAñoFab.Location = new Point(10, 111);
            lblAñoFab.Name = "lblAñoFab";
            lblAñoFab.Size = new Size(91, 15);
            lblAñoFab.TabIndex = 8;
            lblAñoFab.Text = "Año fabricación";
            // 
            // lblDominio
            // 
            lblDominio.AutoSize = true;
            lblDominio.Location = new Point(10, 77);
            lblDominio.Name = "lblDominio";
            lblDominio.Size = new Size(53, 15);
            lblDominio.TabIndex = 7;
            lblDominio.Text = "Dominio";
            // 
            // lblNumTurn
            // 
            lblNumTurn.AutoSize = true;
            lblNumTurn.Location = new Point(10, 43);
            lblNumTurn.Name = "lblNumTurn";
            lblNumTurn.Size = new Size(55, 15);
            lblNumTurn.TabIndex = 6;
            lblNumTurn.Text = "N° Turno";
            // 
            // lblTitular
            // 
            lblTitular.AutoSize = true;
            lblTitular.Location = new Point(10, 150);
            lblTitular.Name = "lblTitular";
            lblTitular.Size = new Size(40, 15);
            lblTitular.TabIndex = 9;
            lblTitular.Text = "Titular";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(107, 43);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(144, 23);
            numericUpDown2.TabIndex = 10;
            // 
            // lblRegistroTurnos
            // 
            lblRegistroTurnos.AutoSize = true;
            lblRegistroTurnos.Location = new Point(52, 21);
            lblRegistroTurnos.Name = "lblRegistroTurnos";
            lblRegistroTurnos.Size = new Size(87, 15);
            lblRegistroTurnos.TabIndex = 9;
            lblRegistroTurnos.Text = "Registro turnos";
            lblRegistroTurnos.Click += label11_Click;
            // 
            // lblEstadisticas
            // 
            lblEstadisticas.AutoSize = true;
            lblEstadisticas.Location = new Point(52, 261);
            lblEstadisticas.Name = "lblEstadisticas";
            lblEstadisticas.Size = new Size(67, 15);
            lblEstadisticas.TabIndex = 10;
            lblEstadisticas.Text = "Estadisticas";
            lblEstadisticas.Click += label12_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 397);
            Controls.Add(lblEstadisticas);
            Controls.Add(lblRegistroTurnos);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Registro de turnos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private NumericUpDown numericUpDown1;
        private TextBox textBox2;
        private Label lblTitular;
        private Label lblAñoFab;
        private Label lblDominio;
        private Label lblNumTurn;
        private Label lblTCantTurnos;
        private Label lblTMasAntiguo;
        private Label lblTDominio;
        private Label lblCantTurnos;
        private Label lblAñoMasAntiguo;
        private Label lblDominio6Char;
        private Button button3;
        private Panel panel2;
        private NumericUpDown numericUpDown2;
        private Label lblRegistroTurnos;
        private Label lblEstadisticas;
    }
}
