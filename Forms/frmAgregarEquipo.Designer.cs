namespace Forms
{
    partial class frmAgregarEquipo
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
            label2 = new Label();
            label1 = new Label();
            txtNombreEquipo = new TextBox();
            nudCantidadMaximaJugadores = new NumericUpDown();
            btnAceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCantidadMaximaJugadores).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 83);
            label2.Name = "label2";
            label2.Size = new Size(172, 15);
            label2.TabIndex = 3;
            label2.Text = "Cantidad maxima de jugadores";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 27);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre del equipo";
            // 
            // txtNombreEquipo
            // 
            txtNombreEquipo.Location = new Point(152, 25);
            txtNombreEquipo.Name = "txtNombreEquipo";
            txtNombreEquipo.Size = new Size(178, 23);
            txtNombreEquipo.TabIndex = 5;
            // 
            // nudCantidadMaximaJugadores
            // 
            nudCantidadMaximaJugadores.Location = new Point(210, 81);
            nudCantidadMaximaJugadores.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidadMaximaJugadores.Name = "nudCantidadMaximaJugadores";
            nudCantidadMaximaJugadores.Size = new Size(120, 23);
            nudCantidadMaximaJugadores.TabIndex = 6;
            nudCantidadMaximaJugadores.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(152, 137);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 48);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmAgregarEquipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 197);
            Controls.Add(btnAceptar);
            Controls.Add(nudCantidadMaximaJugadores);
            Controls.Add(txtNombreEquipo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAgregarEquipo";
            Text = "frmAgregarEquipo";
            ((System.ComponentModel.ISupportInitialize)nudCantidadMaximaJugadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtNombreEquipo;
        private NumericUpDown nudCantidadMaximaJugadores;
        private Button btnAceptar;
    }
}