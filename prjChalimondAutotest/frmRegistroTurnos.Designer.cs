namespace prjChalimondAutotest
{
    partial class frmRegistroTurnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroTurnos));
            panelRegistro = new Panel();
            numNumTurno = new NumericUpDown();
            lblTitular = new Label();
            lblAñoFab = new Label();
            lblDominio = new Label();
            lblNumTurn = new Label();
            btnSalir = new Button();
            btnRegistrar = new Button();
            txtTitular = new TextBox();
            numAñoFabricacion = new NumericUpDown();
            txtDominio = new TextBox();
            lblTCantTurnos = new Label();
            lblTMasAntiguo = new Label();
            lblTDominio = new Label();
            lblCantTurnos = new Label();
            lblAñoMasAntiguo = new Label();
            lblDominio6Char = new Label();
            btnConsultar = new Button();
            panelEstadisticas = new Panel();
            lblRegistroTurnos = new Label();
            lblEstadisticas = new Label();
            panelRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numNumTurno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAñoFabricacion).BeginInit();
            panelEstadisticas.SuspendLayout();
            SuspendLayout();
            // 
            // panelRegistro
            // 
            panelRegistro.Controls.Add(numNumTurno);
            panelRegistro.Controls.Add(lblTitular);
            panelRegistro.Controls.Add(lblAñoFab);
            panelRegistro.Controls.Add(lblDominio);
            panelRegistro.Controls.Add(lblNumTurn);
            panelRegistro.Controls.Add(btnSalir);
            panelRegistro.Controls.Add(btnRegistrar);
            panelRegistro.Controls.Add(txtTitular);
            panelRegistro.Controls.Add(numAñoFabricacion);
            panelRegistro.Controls.Add(txtDominio);
            panelRegistro.Location = new Point(42, 30);
            panelRegistro.Name = "panelRegistro";
            panelRegistro.Size = new Size(397, 208);
            panelRegistro.TabIndex = 0;
            // 
            // numNumTurno
            // 
            numNumTurno.Location = new Point(107, 43);
            numNumTurno.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numNumTurno.Name = "numNumTurno";
            numNumTurno.Size = new Size(144, 23);
            numNumTurno.TabIndex = 10;
            // 
            // lblTitular
            // 
            lblTitular.AutoSize = true;
            lblTitular.Location = new Point(10, 150);
            lblTitular.Name = "lblTitular";
            lblTitular.Size = new Size(41, 15);
            lblTitular.TabIndex = 9;
            lblTitular.Text = "Titular";
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
            lblNumTurn.Size = new Size(56, 15);
            lblNumTurn.TabIndex = 6;
            lblNumTurn.Text = "N° Turno";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(295, 126);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 44);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(295, 43);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 49);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtTitular
            // 
            txtTitular.Location = new Point(107, 147);
            txtTitular.MaxLength = 30;
            txtTitular.Name = "txtTitular";
            txtTitular.Size = new Size(144, 23);
            txtTitular.TabIndex = 3;
            // 
            // numAñoFabricacion
            // 
            numAñoFabricacion.Location = new Point(107, 109);
            numAñoFabricacion.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            numAñoFabricacion.Name = "numAñoFabricacion";
            numAñoFabricacion.Size = new Size(144, 23);
            numAñoFabricacion.TabIndex = 2;
            // 
            // txtDominio
            // 
            txtDominio.Location = new Point(107, 74);
            txtDominio.MaxLength = 7;
            txtDominio.Name = "txtDominio";
            txtDominio.Size = new Size(144, 23);
            txtDominio.TabIndex = 1;
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
            // btnConsultar
            // 
            btnConsultar.Location = new Point(299, 37);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(71, 34);
            btnConsultar.TabIndex = 7;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // panelEstadisticas
            // 
            panelEstadisticas.Controls.Add(lblDominio6Char);
            panelEstadisticas.Controls.Add(btnConsultar);
            panelEstadisticas.Controls.Add(lblAñoMasAntiguo);
            panelEstadisticas.Controls.Add(lblCantTurnos);
            panelEstadisticas.Controls.Add(lblTDominio);
            panelEstadisticas.Controls.Add(lblTMasAntiguo);
            panelEstadisticas.Controls.Add(lblTCantTurnos);
            panelEstadisticas.Location = new Point(42, 270);
            panelEstadisticas.Name = "panelEstadisticas";
            panelEstadisticas.Size = new Size(397, 101);
            panelEstadisticas.TabIndex = 8;
            // 
            // lblRegistroTurnos
            // 
            lblRegistroTurnos.AutoSize = true;
            lblRegistroTurnos.Location = new Point(52, 21);
            lblRegistroTurnos.Name = "lblRegistroTurnos";
            lblRegistroTurnos.Size = new Size(87, 15);
            lblRegistroTurnos.TabIndex = 9;
            lblRegistroTurnos.Text = "Registro turnos";
            // 
            // lblEstadisticas
            // 
            lblEstadisticas.AutoSize = true;
            lblEstadisticas.Location = new Point(52, 261);
            lblEstadisticas.Name = "lblEstadisticas";
            lblEstadisticas.Size = new Size(67, 15);
            lblEstadisticas.TabIndex = 10;
            lblEstadisticas.Text = "Estadisticas";
            // 
            // frmRegistroTurnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 397);
            Controls.Add(lblEstadisticas);
            Controls.Add(lblRegistroTurnos);
            Controls.Add(panelEstadisticas);
            Controls.Add(panelRegistro);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRegistroTurnos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de turnos";
            panelRegistro.ResumeLayout(false);
            panelRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numNumTurno).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAñoFabricacion).EndInit();
            panelEstadisticas.ResumeLayout(false);
            panelEstadisticas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelRegistro;
        private Button btnSalir;
        private Button btnRegistrar;
        private TextBox txtTitular;
        private NumericUpDown numAñoFabricacion;
        private TextBox txtDominio;
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
        private Button btnConsultar;
        private Panel panelEstadisticas;
        private NumericUpDown numNumTurno;
        private Label lblRegistroTurnos;
        private Label lblEstadisticas;
    }
}
