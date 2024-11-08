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
    public partial class Form5 : Form
    {
        public Cliente[] Clientes;
        public int ClienteCount;
        public bool array_full = false;
        int id;
        int estado;
        bool activo;
        string nombre;
        string apellido1;
        string apellido2;
        DateTime fechaNac;
        string result;
        Form3 f3 = new Form3();
        public Form5() {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e) {

            if (array_full) {
                f3.result = "Memoria Llena";
                f3.ShowDialog(); // Shows Form3
                this.Close();
                return;
            }
            label7.Text = (ClienteCount + 1).ToString();

        }
        

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {

            try {
                Cliente tmp = Clientes[ClienteCount];
            }
            catch (Exception) {
                f3.result = "Memoria Llena";
                f3.ShowDialog(); // Shows Form3
                this.Close();
                return;
            }

            id = Proyecto1.Funciones.EsNumValido(maskedTextBox1.Text.Replace(" ", ""));
            nombre = textBox1.Text.Replace(" ", "");
            apellido1 = textBox2.Text.Replace(" ", "");
            apellido2 = textBox3.Text.Replace(" ", "");
            fechaNac = dateTimePicker1.Value;
            estado = comboBox1.SelectedIndex;
            if (estado == 0)
            {
                activo = true;
            }
            else
            {
                activo = false;
            }



            Clientes[ClienteCount] = new Cliente(id, nombre, apellido1, apellido2, activo, fechaNac);

            if (!Clientes[ClienteCount].IsOk()) {
                result = "Error";
                Clientes[ClienteCount] = null;
            }
            else {
                result = "Registrado";
                ClienteCount++;
            }
            f3.result = result;
            f3.ShowDialog(); // Shows Form3
            label7.Text = (ClienteCount + 1).ToString();
            ClearTextBoxes();

        }

        private void ClearTextBoxes() {
            Action<Control.ControlCollection> func = null;

            func = (controls) => {
                foreach (Control control in controls)
                    if (control is System.Windows.Forms.TextBox)
                        (control as System.Windows.Forms.TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }


    }
}
