namespace Forms
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            frmAgregarEquipo frm = new frmAgregarEquipo();
            DialogResult dr = frm.ShowDialog(this);
        }

        private void frmAgregarJugador_Click(object sender, EventArgs e)
        {
            frmAgregarJugador frm = new frmAgregarJugador();
            DialogResult dr = frm.ShowDialog(this);
        }

        private void btnDetalleEquipo_Click(object sender, EventArgs e)
        {
            frmDetalleEquipo frm = new frmDetalleEquipo();
            DialogResult dr = frm.ShowDialog(this);
        }
    }
}
