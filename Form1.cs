using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Proyecto1
{
    public partial class Form1 : Form
    {
        //static int max_size = 10;

        //Arreglos que contienen los objetos
        Administrador[] administradores = new Administrador[20];
        Cliente[] clientes = new Cliente[20];
        Sucursal[] sucursales = new Sucursal[5];
        Articulo[] articulos = new Articulo[20];
        Categoria[] categorias = new Categoria[10];
        dynamic arreglo = new dynamic[1];
        bool array_full = true;
        bool exit = false;
        int empty_position = -1;


        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //AllocConsole();

        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void button1_Click(object sender, EventArgs e) {

            arreglo = sucursales;
            ArrayCheck();

            Form2 f2 = new Form2();
            f2.Sucursales = sucursales;
            f2.Admninistradores = administradores;
            f2.SucursalCount = empty_position;
            f2.array_full = array_full;
            f2.Show(); // Shows Form2
                       
        }

        private void button2_Click(object sender, EventArgs e) {
            arreglo = administradores;
            ArrayCheck();

            Form4 f4 = new Form4();
            f4.Sucursales = sucursales;
            f4.Administradores = administradores;
            f4.AdministradoresCount = empty_position;
            f4.array_full = array_full;
            f4.Show(); // Shows Form2
        }

        private void button3_Click(object sender, EventArgs e) {
            arreglo = clientes;
            ArrayCheck();

            Form5 f5 = new Form5();
            f5.Clientes = clientes;
            f5.ClienteCount = empty_position;
            f5.array_full = array_full;
            f5.Show(); // Shows Form2
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void button7_Click(object sender, EventArgs e) {

            Form8 f8 = new Form8();
            f8.exit = exit;
            f8.Show();

        }

        private void button4_Click(object sender, EventArgs e) {
            arreglo = categorias;
            ArrayCheck();

            Form6 f6 = new Form6();
            f6.Categorias = categorias;
            f6.CategoriasCount = empty_position;
            f6.array_full = array_full;
            f6.Show(); // Shows Form2
        }
        private void button8_Click(object sender, EventArgs e) {
            arreglo = articulos;
            ArrayCheck();

            Form7 f7 = new Form7();
            //f7.Sucursales = sucursales;
            f7.Categorias = categorias;
            f7.Articulos = articulos ;
            f7.ArticulosCount = empty_position;
            f7.array_full = array_full;
            f7.Show(); // Shows Form2
        }

        private void button5_Click(object sender, EventArgs e) {

            Form9 f9 = new Form9();
            f9.Sucursales = sucursales;
            f9.Categorias = categorias;
            f9.Articulos = articulos;
            f9.Clientes = clientes;
            f9.Administradores = administradores;
            f9.Show(); // Shows Form2


        }


        private void ArrayCheck() {
            array_full = true;
            empty_position = -1;
            foreach (dynamic item in arreglo) {
                empty_position++;
                try {
                    if (item.IsOk()) {
                        array_full = true;
                    }
                    else {
                        array_full = false;
                        break;
                    }
                }
                catch {
                    array_full = false;
                    break;
                }
            }
        }

        
    }
}
