using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class Form9 : Form
    {
        public Sucursal[] Sucursales;
        public Administrador[] Administradores;
        public Categoria[] Categorias;
        public Articulo[] Articulos;
        public Cliente[] Clientes;

        public Form9() {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void Form9_Load(object sender, EventArgs e) {
        }

        private void button6_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Index", "Index");
            dataGridView1.Columns.Add("Value", "Nombre");
            dataGridView1.Columns.Add("Value", "Administrador");
            dataGridView1.Columns.Add("Value", "Direccion");
            dataGridView1.Columns.Add("Value", "Telefono");
            dataGridView1.Columns.Add("Value", "Estado");
            int i = 0;
            foreach (Sucursal item in Sucursales) {

                if (item != null) {
                    i++;
                    dataGridView1.Rows.Add(new object[] { i, item.ToArray()[0], item.ToArray()[1], item.ToArray()[2], item.ToArray()[3], item.ToArray()[4], item.ToArray()[5] });


                }

            }

           

        }

        private void button2_Click(object sender, EventArgs e) {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Index", "Index");
            dataGridView1.Columns.Add("Value", "ID");
            dataGridView1.Columns.Add("Value", "Nombre");
            dataGridView1.Columns.Add("Value", "Apellido1");
            dataGridView1.Columns.Add("Value", "Apellido2");
            dataGridView1.Columns.Add("Value", "FNac");
            dataGridView1.Columns.Add("Value", "FIng");

            int i = 0;
            foreach (Administrador item in Administradores) {

                if (item != null) {
                    i++;
                    dataGridView1.Rows.Add(new object[] { i, item.ToArray()[0], item.ToArray()[1], item.ToArray()[2], item.ToArray()[3], item.ToArray()[4], item.ToArray()[5], item.ToArray()[6] });

                }

            }
        }

        private void button3_Click(object sender, EventArgs e) {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Index", "Index");
            dataGridView1.Columns.Add("Value", "ID");
            dataGridView1.Columns.Add("Value", "Nombre");
            dataGridView1.Columns.Add("Value", "Apellido1");
            dataGridView1.Columns.Add("Value", "Apellido2");
            dataGridView1.Columns.Add("Value", "FNac");
            int i = 0;
            foreach (Cliente item in Clientes) {

                if (item != null) {
                    i++;
                    dataGridView1.Rows.Add(new object[] { i, item.ToArray()[0], item.ToArray()[1], item.ToArray()[2], item.ToArray()[3], item.ToArray()[4]});

                }

            }
        }

        private void button4_Click(object sender, EventArgs e) {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Index", "Index");
            dataGridView1.Columns.Add("Value", "Id");
            dataGridView1.Columns.Add("Value", "Nombre");
            dataGridView1.Columns.Add("Value", "Desc");
            int i = 0;
            foreach (Categoria item in Categorias) {

                if (item != null) {
                    i++;
                    dataGridView1.Rows.Add(new object[] { i, item.ToArray()[0], item.ToArray()[1], item.ToArray()[2] });

                }

            }
        }

        private void button5_Click(object sender, EventArgs e) {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            dataGridView1.Columns.Add("Index", "Index");
            dataGridView1.Columns.Add("Value", "Id");
            dataGridView1.Columns.Add("Value", "Marca");
            dataGridView1.Columns.Add("Value", "Desc");
            dataGridView1.Columns.Add("Value", "Nacimiento");
            int i = 0;
            foreach (Articulo item in Articulos) {

                if (item != null) {
                    i++;
                    dataGridView1.Rows.Add(new object[] { i, item.ToArray()[0], item.ToArray()[1], item.ToArray()[2], item.ToArray()[3] });


                }

            }
        }
    }
}
