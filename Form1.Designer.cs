namespace Proyecto1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            regFinca = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // regFinca
            // 
            regFinca.Location = new System.Drawing.Point(101, 70);
            regFinca.Name = "regFinca";
            regFinca.Size = new System.Drawing.Size(200, 36);
            regFinca.TabIndex = 0;
            regFinca.Text = "Registrar Sucursal";
            regFinca.UseVisualStyleBackColor = true;
            regFinca.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(101, 123);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(200, 36);
            button2.TabIndex = 0;
            button2.Text = "Registrar Administrador";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(101, 180);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(200, 36);
            button3.TabIndex = 0;
            button3.Text = "Registrar Cliente";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(101, 241);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(200, 36);
            button4.TabIndex = 0;
            button4.Text = "Registrar Categoria de Articulos";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new System.Drawing.Font("Segoe UI", 12F);
            button5.Location = new System.Drawing.Point(434, 180);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(200, 50);
            button5.TabIndex = 0;
            button5.Text = "Mostrar Registros";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.BackColor = System.Drawing.Color.Red;
            button7.Font = new System.Drawing.Font("Segoe UI", 16F);
            button7.Location = new System.Drawing.Point(398, 338);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(300, 60);
            button7.TabIndex = 0;
            button7.Text = "Salir del Sistema";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new System.Drawing.Point(101, 303);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(200, 36);
            button8.TabIndex = 0;
            button8.Text = "Registrar Articulo";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            label1.Location = new System.Drawing.Point(133, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(487, 32);
            label1.TabIndex = 2;
            label1.Text = "Sistema de Administracion Tienda Deportiva";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(101, 362);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(200, 36);
            button1.TabIndex = 3;
            button1.Text = "Registrar Articulo por Sucursal";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(759, 449);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(regFinca);
            Name = "Form1";
            Text = "Proyecto 1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button regFinca;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

