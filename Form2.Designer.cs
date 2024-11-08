namespace Proyecto1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            textBox5 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            comboBox2 = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(148, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(245, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(148, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(245, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(148, 156);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(248, 69);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(148, 237);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(248, 23);
            textBox5.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.LimeGreen;
            button1.Font = new System.Drawing.Font("Segoe UI", 14F);
            button1.Location = new System.Drawing.Point(95, 336);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(120, 60);
            button1.TabIndex = 5;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Red;
            button2.Font = new System.Drawing.Font("Segoe UI", 14F);
            button2.Location = new System.Drawing.Point(369, 336);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(120, 60);
            button2.TabIndex = 6;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            label1.Location = new System.Drawing.Point(47, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(23, 21);
            label1.TabIndex = 7;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            label2.Location = new System.Drawing.Point(47, 62);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(68, 21);
            label2.TabIndex = 8;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            label3.Location = new System.Drawing.Point(32, 105);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(110, 21);
            label3.TabIndex = 9;
            label3.Text = "Administrador";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            label4.Location = new System.Drawing.Point(47, 156);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(75, 21);
            label4.TabIndex = 10;
            label4.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            label5.Location = new System.Drawing.Point(47, 235);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(68, 21);
            label5.TabIndex = 11;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 11F);
            label6.Location = new System.Drawing.Point(451, 29);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(77, 20);
            label6.TabIndex = 12;
            label6.Text = "Registro #";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 11F);
            label7.Location = new System.Drawing.Point(534, 29);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(30, 20);
            label7.TabIndex = 13;
            label7.Text = "NA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            label8.Location = new System.Drawing.Point(47, 294);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(53, 21);
            label8.TabIndex = 14;
            label8.Text = "Activo";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Si", "No" });
            comboBox1.Location = new System.Drawing.Point(148, 292);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(132, 23);
            comboBox1.TabIndex = 15;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(148, 105);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(245, 23);
            comboBox2.TabIndex = 16;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(606, 416);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Sucursales";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}