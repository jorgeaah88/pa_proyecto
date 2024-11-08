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
    public partial class Form2 : Form
    {

        public Sucursal[] Sucursales;
        public int SucursalCount;
        public Administrador[] Admninistradores;
        public bool array_full = false;
        int identificacion;
        string nombre;
        int idAdministrador;
        string direccion;
        string tel;
        string result;
        int estado;
        bool activo;
        Form3 f3 = new Form3();
        public Form2() {
            InitializeComponent();
            comboBox1.SelectedItem = "Si";
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                Sucursal tmp = Sucursales[SucursalCount];
            }
            catch (Exception) {
                f3.result = "Memoria Llena";
                f3.ShowDialog(); // Shows Form3
                this.Close();
                return;
            }

            identificacion = Proyecto1.Funciones.EsNumValido(textBox1.Text.Replace(" ", ""));
            nombre = textBox2.Text; ;
            idAdministrador = comboBox2.SelectedIndex;
            direccion = textBox4.Text;
            tel = textBox5.Text.Replace(" ", "");
            estado = comboBox2.SelectedIndex;
            if (estado == 0)
            {
                activo = true;
            } else
            {
                activo = false;
            }

            if (idAdministrador != -1)
            {

                Sucursales[SucursalCount] = new Sucursal(identificacion, nombre, Admninistradores[idAdministrador], direccion, tel, activo);

                if (!Sucursales[SucursalCount].IsOk())
                {
                    result = "Error";
                    Sucursales[SucursalCount] = null;
                }
                else
                {
                    result = "Registrado";
                    SucursalCount++;
                }
                f3.result = result;
                f3.ShowDialog(); // Shows Form3
                label7.Text = (SucursalCount + 1).ToString();

            }
            else
            {
                f3.result = "Administrador No Seleccionada";
                f3.ShowDialog(); // Shows Form3

            }

            //Sucursales[SucursalCount] = new Sucursal(identificacion, nombre, Admninistradores[idAdministrador], direccion, tel, activo);

            //if (!Sucursales[SucursalCount].IsOk()) {
            //    result = "Error";
            //    Sucursales[SucursalCount] = null;
            //}
            //else {
            //    result = "Registrado";
            //    SucursalCount++;
            //}
            f3.result = result;
            f3.ShowDialog(); // Shows Form3
            label7.Text = (SucursalCount + 1).ToString();
            ClearTextBoxes();
        }

        private void Form2_Load(object sender, EventArgs e) {
            if (Admninistradores[0] is null)
            {
                f3.result = "No hay Administradores Registrados";
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

            foreach (Administrador item in Admninistradores)
            {
                if (item != null)
                {
                    comboBox2.Items.Add(item.GetName());
                }

            }
            label7.Text = (SucursalCount + 1).ToString();
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
