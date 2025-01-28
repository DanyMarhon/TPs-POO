namespace Forms
{
    partial class Principal
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
            frmAgregarJugador = new Button();
            btnDetalleEquipo = new Button();
            btnAgregarEquipo = new Button();
            panel2 = new Panel();
            dgvDatos = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            colCantidadMaximaJugadores = new DataGridViewTextBoxColumn();
            colCantidadJugadores = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(frmAgregarJugador);
            panel1.Controls.Add(btnDetalleEquipo);
            panel1.Controls.Add(btnAgregarEquipo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 76);
            panel1.TabIndex = 0;
            // 
            // frmAgregarJugador
            // 
            frmAgregarJugador.Location = new Point(115, 12);
            frmAgregarJugador.Name = "frmAgregarJugador";
            frmAgregarJugador.Size = new Size(103, 58);
            frmAgregarJugador.TabIndex = 1;
            frmAgregarJugador.Text = "AgregarJugador";
            frmAgregarJugador.UseVisualStyleBackColor = true;
            frmAgregarJugador.Click += frmAgregarJugador_Click;
            // 
            // btnDetalleEquipo
            // 
            btnDetalleEquipo.Location = new Point(224, 12);
            btnDetalleEquipo.Name = "btnDetalleEquipo";
            btnDetalleEquipo.Size = new Size(97, 58);
            btnDetalleEquipo.TabIndex = 0;
            btnDetalleEquipo.Text = "DetalleEquipo";
            btnDetalleEquipo.UseVisualStyleBackColor = true;
            btnDetalleEquipo.Click += btnDetalleEquipo_Click;
            // 
            // btnAgregarEquipo
            // 
            btnAgregarEquipo.Location = new Point(12, 12);
            btnAgregarEquipo.Name = "btnAgregarEquipo";
            btnAgregarEquipo.Size = new Size(97, 58);
            btnAgregarEquipo.TabIndex = 0;
            btnAgregarEquipo.Text = "AgregarEquipo";
            btnAgregarEquipo.UseVisualStyleBackColor = true;
            btnAgregarEquipo.Click += btnAgregarEquipo_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvDatos);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 374);
            panel2.TabIndex = 1;
            // 
            // dgvDatos
            // 
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colNombre, colCantidadMaximaJugadores, colCantidadJugadores });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(800, 374);
            dgvDatos.TabIndex = 0;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colCantidadMaximaJugadores
            // 
            colCantidadMaximaJugadores.HeaderText = "CantidadMaximaJugadores";
            colCantidadMaximaJugadores.Name = "colCantidadMaximaJugadores";
            colCantidadMaximaJugadores.ReadOnly = true;
            // 
            // colCantidadJugadores
            // 
            colCantidadJugadores.HeaderText = "CantidadJugadores";
            colCantidadJugadores.Name = "colCantidadJugadores";
            colCantidadJugadores.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button frmAgregarJugador;
        private Button btnDetalleEquipo;
        private Button btnAgregarEquipo;
        private Panel panel2;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colCantidadMaximaJugadores;
        private DataGridViewTextBoxColumn colCantidadJugadores;
    }
}
