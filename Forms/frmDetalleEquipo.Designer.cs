namespace Forms
{
    partial class frmDetalleEquipo
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
            lblNombreEquipo = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            dgvDatos = new DataGridView();
            colNombreJugador = new DataGridViewTextBoxColumn();
            colDni = new DataGridViewTextBoxColumn();
            colPartidosJugados = new DataGridViewTextBoxColumn();
            colPromedioGoles = new DataGridViewTextBoxColumn();
            colTotalGoles = new DataGridViewTextBoxColumn();
            lblCantidad = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // lblNombreEquipo
            // 
            lblNombreEquipo.AutoSize = true;
            lblNombreEquipo.Location = new Point(27, 27);
            lblNombreEquipo.Name = "lblNombreEquipo";
            lblNombreEquipo.Size = new Size(51, 15);
            lblNombreEquipo.TabIndex = 0;
            lblNombreEquipo.Text = "Nombre";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblCantidad);
            panel1.Controls.Add(lblNombreEquipo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(712, 71);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvDatos);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(712, 361);
            panel2.TabIndex = 2;
            // 
            // dgvDatos
            // 
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colNombreJugador, colDni, colPartidosJugados, colPromedioGoles, colTotalGoles });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(712, 361);
            dgvDatos.TabIndex = 1;
            // 
            // colNombreJugador
            // 
            colNombreJugador.HeaderText = "Nombre Jugador";
            colNombreJugador.Name = "colNombreJugador";
            colNombreJugador.ReadOnly = true;
            // 
            // colDni
            // 
            colDni.HeaderText = "DNI";
            colDni.Name = "colDni";
            colDni.ReadOnly = true;
            // 
            // colPartidosJugados
            // 
            colPartidosJugados.HeaderText = "Partidos Jugados";
            colPartidosJugados.Name = "colPartidosJugados";
            colPartidosJugados.ReadOnly = true;
            // 
            // colPromedioGoles
            // 
            colPromedioGoles.HeaderText = "Promedio Goles";
            colPromedioGoles.Name = "colPromedioGoles";
            colPromedioGoles.ReadOnly = true;
            // 
            // colTotalGoles
            // 
            colTotalGoles.HeaderText = "Total de goles";
            colTotalGoles.Name = "colTotalGoles";
            colTotalGoles.ReadOnly = true;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(543, 27);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 1;
            lblCantidad.Text = "Cantidad";
            // 
            // frmDetalleEquipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 432);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmDetalleEquipo";
            Text = "frmDetalleEquipo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombreEquipo;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colNombreJugador;
        private DataGridViewTextBoxColumn colDni;
        private DataGridViewTextBoxColumn colPartidosJugados;
        private DataGridViewTextBoxColumn colPromedioGoles;
        private DataGridViewTextBoxColumn colTotalGoles;
        private Label lblCantidad;
    }
}