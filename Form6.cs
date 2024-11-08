using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class Form6 : Form
    {
        public Categoria[] Categorias;
        public int CategoriasCount;
        public bool array_full = false;
        int identificacion;
        string nombre;
        string desc;
        string result;
        Form3 f3 = new Form3();
        public Form6() {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e) {
            if (array_full) {
                f3.result = "Memoria Llena";
                f3.ShowDialog(); // Shows Form3
                this.Close();
                return;
            }
            label4.Text = (CategoriasCount + 1).ToString();
        }

        private void button1_Click(object sender, EventArgs e) {

            try {
                Categoria tmp = Categorias[CategoriasCount];
            }
            catch (Exception) {
                f3.result = "Memoria Llena";
                f3.ShowDialog(); // Shows Form3
                this.Close();
                return;
            }

            identificacion = Proyecto1.Funciones.EsNumValido(textBox1.Text.Replace(" ", ""));
            nombre = textBox1.Text.Replace(" ", "");
            desc = textBox2.Text;

            Categorias[CategoriasCount] = new Categoria(identificacion, nombre, desc);

            if (!Categorias[CategoriasCount].IsOk()) {
                result = "Error";
                Categorias[CategoriasCount] = null;
            }
            else {
                result = "Registrado";
                CategoriasCount++;
            }
            f3.result = result;
            f3.ShowDialog(); // Shows Form3
            label4.Text = (CategoriasCount + 1).ToString();
            ClearTextBoxes();

        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ClearTextBoxes() {
            Action<Control.ControlCollection> func = null;

            func = (controls) => {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
    }
}
