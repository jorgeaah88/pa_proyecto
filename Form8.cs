using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class Form8 : Form
    {
        public bool exit;
        public Form8() {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
