using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class Form4 : Form
    {
        public Sucursal[] Sucursales;
        public Administrador[] Administradores;
        public int AdministradoresCount;
        public bool array_full = false;
        int id;
        DateTime fechaNac;
        DateTime fechaIng;
        string nombre;
        string apellido1;
        string apellido2;
        string result;
        Form3 f3 = new Form3();
        public Form4() {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e) {

            //if (Sucursales[0] == null) {
            //    f3.result = "No hay Fincas Registradas";
            //    f3.ShowDialog(); // Shows Form3
            //    this.Close();
            //    return;
            //}

            if (array_full) {
                f3.result = "Memoria Llena";
                f3.ShowDialog(); // Shows Form3
                this.Close();
                return;
            }
            label9.Text = (AdministradoresCount + 1).ToString();

            //foreach (Sucursal item in Sucursales) {
            //    if (item != null) {
            //        comboBox1.Items.Add(item.ToStringSmall());
            //    }
               
            //}

        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {

            try {
                Sucursal tmp = Sucursales[AdministradoresCount];
            }
            catch (Exception) {
                f3.result = "Memoria Llena";
                f3.ShowDialog(); // Shows Form3
                this.Close();
                return;
            }

            id = Proyecto1.Funciones.EsNumValido(textBox1.Text.Replace(" ", ""));
            nombre = textBox4.Text.Replace(" ", "");
            apellido1 = textBox2.Text.Replace(" ", "");
            apellido2 = textBox6.Text.Replace(" ", "");
            fechaNac = dateTimePicker1.Value;
            fechaIng = dateTimePicker2.Value;

            Administradores[AdministradoresCount] = new Administrador(id, nombre, apellido1, apellido2, fechaNac, fechaIng);

            if (!Administradores[AdministradoresCount].IsOk())
            {
                result = "Error";
                Administradores[AdministradoresCount] = null;
            }
            else
            {
                result = "Registrado";
                AdministradoresCount++;
            }
            f3.result = result;
            f3.ShowDialog(); // Shows Form3
            label9.Text = (AdministradoresCount + 1).ToString();
            ClearTextBoxes();

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
