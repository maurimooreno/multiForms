using GUI.View;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AbrirFormContenedor(Form formContainer)
        {
            if (this.panel3.Controls.Count > 0)
            {
                this.panel3.Controls.RemoveAt(0);
            }

            formContainer.TopLevel = false;
            formContainer.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(formContainer);
            this.panel3.Tag = formContainer;
            formContainer.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirFormContenedor(new Inventario());
        }
    }
}