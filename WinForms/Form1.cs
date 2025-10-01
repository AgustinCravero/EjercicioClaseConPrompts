using ClasesEjerPrompts.Data;
using ClasesEjerPrompts.Models;
using ClasesEjerPrompts.Repositories;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Marca no puede estar vacio");
                return;
            }
            if (textBox3.Text.Trim() == "")
            {
                MessageBox.Show("Modelo no puede estar vacio");
                return;
            }
            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Marca no puede estar vacio");
                return;
            }
            if (!int.TryParse (textBox2.Text, out int anio))
            {
                MessageBox.Show("Año debe ser un número válido");
                return;
            }
            Vehiculo vehiculo = new Vehiculo
            {
                Marca = textBox1.Text,
                Modelo = textBox3.Text,
                Anio = int.Parse(textBox2.Text)
            };
            ClasesEjerPrompts.Repositories.VehiculoRepository.Agregar(vehiculo);
            MessageBox.Show("Vehiculo Registrado"); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var lista = VehiculoRepository.ObtenerTodos();
            dataGridView1.DataSource = lista;
        }
    }
}
