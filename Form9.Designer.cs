namespace Proyecto1
{
    partial class Form9
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(216, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new System.Drawing.Size(880, 458);
            dataGridView1.TabIndex = 0;
            dataGridView1.Text = "dataGridView1";
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Segoe UI", 10F);
            button1.Location = new System.Drawing.Point(12, 48);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(170, 40);
            button1.TabIndex = 1;
            button1.Text = "Mostrar Sucursales";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new System.Drawing.Font("Segoe UI", 10F);
            button2.Location = new System.Drawing.Point(12, 110);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(170, 40);
            button2.TabIndex = 2;
            button2.Text = "Mostrar Administradores";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new System.Drawing.Font("Segoe UI", 10F);
            button3.Location = new System.Drawing.Point(12, 172);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(170, 40);
            button3.TabIndex = 3;
            button3.Text = "Mostrar Clientes";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new System.Drawing.Font("Segoe UI", 10F);
            button4.Location = new System.Drawing.Point(12, 244);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(170, 40);
            button4.TabIndex = 4;
            button4.Text = "Mostrar Categorias";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new System.Drawing.Font("Segoe UI", 10F);
            button5.Location = new System.Drawing.Point(12, 314);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(170, 40);
            button5.TabIndex = 5;
            button5.Text = "Mostrar Articulos";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = System.Drawing.Color.Red;
            button6.Font = new System.Drawing.Font("Segoe UI", 14F);
            button6.Location = new System.Drawing.Point(12, 415);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(170, 40);
            button6.TabIndex = 6;
            button6.Text = "SALIR";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Form9
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1137, 482);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form9";
            Text = "Data";
            Load += Form9_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}