using System;
using System.Windows.Forms;

namespace Transacciones
{
    public partial class Crud : Form
    {
        public Crud()
        {
            InitializeComponent();
        }

        ConexionPgsql conectandoseBD = new ConexionPgsql();
        private void button1_Click(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = conectandoseBD.Consultar();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            try
            {
                conectandoseBD.CrearCliente(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text));
            }
            catch
            {
                MessageBox.Show("Ingrese sus datos correctamente");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conectandoseBD.EditarCliente(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text));
            }
            catch
            {
                MessageBox.Show("Ingrese sus datos correctamente");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                conectandoseBD.EliminarCliente(textBox5.Text);
            }
            catch
            {
                MessageBox.Show("Ingrese sus datos correctamente");
            }
        }
    }
}
