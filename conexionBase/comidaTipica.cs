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
    public partial class comidaTipica : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=restaurante; uid=root; ");
        public comidaTipica()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand("select * from comida_tipica ", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string Query = "INSERT INTO comida_tipica (id, platillo, puntuacion, categoria) VALUES ( '" + txtId.Text + "','" + txtplatillo.Text + "','" + txtpuntuacion.Text + "','" + txtcategoria.Text + "'); ";
            MySqlCommand comando = new MySqlCommand(Query, conexion);

            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("se ha insertado el platillo  " + txtplatillo.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string Query = "UPDATE comida_tipica SET id= '" + txtId.Text +
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

        private void button5_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string Query = "DELETE FROM comida_tipica WHERE id='" + txtId.Text + "'; ";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("se ha eliminado correctamente el registro");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
