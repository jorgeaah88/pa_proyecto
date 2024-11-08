using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class Form3 : Form
    {
        public string result;
        public Form3() {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e) {
            label1.Text = result;

        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

    }
}
