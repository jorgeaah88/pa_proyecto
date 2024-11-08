using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto1
{
    public partial class Form7 : Form
    {

        //public Sucursal[] Sucursales;
        public Categoria[] Categorias;
        public Articulo[] Articulos;
        public int ArticulosCount;
        public bool array_full = false;
        int id;
        string marca;
        string descripcion;
        int categoria;
        int estado;
        bool activo;
        string result;
        Form3 f3 = new Form3();
        public Form7() {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e) {

            //if (Sucursales[0] == null) {
            //    f3.result = "No hay Fincas Registradas";
            //    f3.ShowDialog(); // Shows Form3
            //    this.Close();
            //    return;
            //}

            if (Categorias[0] == null) {
                f3.result = "No hay Categorias Registradas";
                f3.ShowDialog(); // Shows Form3
                this.Close();
                return;
            }

            if (array_full) {
                f3.result = "Memoria Llena";
                f3.ShowDialog(); // Shows Form3
                this.Close();
                return;
            }
            label10.Text = (ArticulosCount + 1).ToString();

            //foreach (Sucursal item in Sucursales) {
            //    if (item != null) {
            //        comboBox1.Items.Add(item.ToStringSmall());
            //    }

            //}

            foreach (Categoria item in Categorias) {
                if (item != null) {
                    comboBox1.Items.Add(item.ToString());
                }

            }

        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {

            categoria = -1;
            try {
                Articulo tmp = Articulos[ArticulosCount];
            }
            catch (Exception) {
                f3.result = "Memoria Llena";
                f3.ShowDialog(); // Shows Form3
                this.Close();
                return;
            }

            id = Proyecto1.Funciones.EsNumValido(maskedTextBox1.Text.Replace(" ", ""));
            marca = textBox1.Text.Replace(" ", "");
            categoria = comboBox1.SelectedIndex;
            descripcion = textBox4.Text;

            estado = comboBox3.SelectedIndex;
            if (estado == 0)
            {
                activo = true;
            }
            else
            {
                activo = false;
            }

            if (categoria != -1) {

                Articulos[ArticulosCount] = new Articulo(id, descripcion, Categorias[categoria], marca, activo);

                if (!Articulos[ArticulosCount].IsOk()) {
                    result = "Error";
                    Articulos[ArticulosCount] = null;
                }
                else {
                    result = "Registrado";
                    ArticulosCount++;
                }
                f3.result = result;
                f3.ShowDialog(); // Shows Form3
                label10.Text = (ArticulosCount + 1).ToString();

            }
            else {
                f3.result = "Finca o Raza No Seleccionada";
                f3.ShowDialog(); // Shows Form3

            }

            ClearTextBoxes();

        }

        private void ClearTextBoxes() {
            Action<Control.ControlCollection> func = null;

            func = (controls) => {
                foreach (Control control in controls)
                    if (control is System.Windows.Forms.TextBox )
                        (control as System.Windows.Forms.TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
    }
}
