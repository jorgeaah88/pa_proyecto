namespace Proyecto1
{
    partial class Form7
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
            maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            textBox1 = new System.Windows.Forms.TextBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            comboBox3 = new System.Windows.Forms.ComboBox();
            textBox4 = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new System.Drawing.Point(223, 29);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.PasswordChar = '*';
            maskedTextBox1.Size = new System.Drawing.Size(212, 23);
            maskedTextBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(223, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(212, 23);
            textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(223, 115);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(212, 23);
            comboBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            label1.Location = new System.Drawing.Point(28, 27);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 21);
            label1.TabIndex = 8;
            label1.Text = "Identificacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            label2.Location = new System.Drawing.Point(28, 70);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 21);
            label2.TabIndex = 9;
            label2.Text = "Marca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            label3.Location = new System.Drawing.Point(28, 113);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(77, 21);
            label3.TabIndex = 10;
            label3.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            label5.Location = new System.Drawing.Point(28, 182);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(91, 21);
            label5.TabIndex = 12;
            label5.Text = "Descripcion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            label6.Location = new System.Drawing.Point(28, 305);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(53, 21);
            label6.TabIndex = 13;
            label6.Text = "Activo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 11F);
            label9.Location = new System.Drawing.Point(499, 95);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(77, 20);
            label9.TabIndex = 16;
            label9.Text = "Registro #";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 11F);
            label10.Location = new System.Drawing.Point(582, 95);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(30, 20);
            label10.TabIndex = 17;
            label10.Text = "NA";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.LawnGreen;
            button1.Font = new System.Drawing.Font("Segoe UI", 14F);
            button1.Location = new System.Drawing.Point(170, 422);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(120, 40);
            button1.TabIndex = 18;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Red;
            button2.Font = new System.Drawing.Font("Segoe UI", 14F);
            button2.Location = new System.Drawing.Point(420, 422);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(120, 40);
            button2.TabIndex = 19;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Si", "No" });
            comboBox3.Location = new System.Drawing.Point(223, 305);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new System.Drawing.Size(212, 23);
            comboBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(223, 182);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(212, 69);
            textBox4.TabIndex = 21;
            // 
            // Form7
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(676, 495);
            Controls.Add(textBox4);
            Controls.Add(comboBox3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(maskedTextBox1);
            Name = "Form7";
            Text = "Articulos";
            Load += Form7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}