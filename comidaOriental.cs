using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conexionBase
{
    public partial class comidaOriental : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=restaurante; uid=root; ");
        public comidaOriental()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand("select * from comida_oriental ", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string Query = "INSERT INTO comida_oriental (id, platillo, puntuacion, categoria) VALUES ( '" + txtId.Text + "','" + txtplatillo.Text + "','" + txtpuntuacion.Text + "','" + txtcategoria.Text + "'); ";
            MySqlCommand comando = new MySqlCommand(Query, conexion);

            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("se ha insertado el platillo  " + txtplatillo.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string Query = "UPDATE comida_oriental SET id= '" + txtId.Text +
                "',platillo='" + txtplatillo.Text +
                "',puntuacion='" + txtpuntuacion.Text +
                "',categoria= '" + txtcategoria.Text +
                "' WHERE  id='" + txtId.Text +
                "'; ";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("se ha actualizado correctamente ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string Query = "DELETE FROM comida_oriental WHERE id='" + txtId.Text + "'; ";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("se ha eliminado correctamente el registro");
        }

        private void comidaOriental_Load(object sender, EventArgs e)
        {

        }
    }
}
