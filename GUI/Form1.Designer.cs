namespace GUI
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
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            panel1 = new Panel();
            panel2 = new Panel();
            btnInventario = new Button();
            panel3 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumBlue;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1036, 67);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(btnInventario);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 562);
            panel2.TabIndex = 1;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = Color.MidnightBlue;
            btnInventario.BackgroundImageLayout = ImageLayout.None;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.Font = new Font("Univers for KPMG", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInventario.ForeColor = SystemColors.Control;
            btnInventario.Location = new Point(0, 38);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(242, 66);
            btnInventario.TabIndex = 0;
            btnInventario.Text = "INVENTARIO";
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += btnInventario_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(242, 67);
            panel3.Name = "panel3";
            panel3.Size = new Size(794, 562);
            panel3.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 629);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnInventario;
        private Panel panel3;
    }
}