namespace Control_de_inventario
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Size = new Size(200, 50);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            FormularioVendedor formulario = new FormularioVendedor();
            formulario.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProbedor_Click(object sender, EventArgs e)
        {
            fomularioProvedor formulario = new fomularioProvedor();
            this.Hide();


            formulario.ShowDialog();
            this.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormularioProducto formulario = new FormularioProducto();
            this.Hide();
            formulario.ShowDialog();
            this.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            formularioCarrito formulario = new formularioCarrito();
            this.Hide();

            formulario.ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
