namespace Control_de_inventario
{
    partial class frmPrincipal
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
            label1 = new Label();
            btnVendedor = new Button();
            button1 = new Button();
            btnProbedor = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Bookman Old Style", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(299, 82);
            label1.Name = "label1";
            label1.Size = new Size(467, 47);
            label1.TabIndex = 2;
            label1.Text = "Control de inventario";
            label1.Click += label1_Click;
            // 
            // btnVendedor
            // 
            btnVendedor.Anchor = AnchorStyles.None;
            btnVendedor.BackColor = Color.LightCyan;
            btnVendedor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnVendedor.Location = new Point(149, 512);
            btnVendedor.Name = "btnVendedor";
            btnVendedor.Size = new Size(325, 75);
            btnVendedor.TabIndex = 3;
            btnVendedor.Text = "Información del Vendedor";
            btnVendedor.UseVisualStyleBackColor = false;
            btnVendedor.Click += btnVendedor_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(758, 676);
            button1.Name = "button1";
            button1.Size = new Size(232, 68);
            button1.TabIndex = 4;
            button1.Text = "Cerrar Aplicacion";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnProbedor
            // 
            btnProbedor.Anchor = AnchorStyles.None;
            btnProbedor.BackColor = Color.LightCyan;
            btnProbedor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProbedor.Location = new Point(147, 296);
            btnProbedor.Name = "btnProbedor";
            btnProbedor.Size = new Size(327, 79);
            btnProbedor.TabIndex = 5;
            btnProbedor.Text = "Información del Proveedor";
            btnProbedor.UseVisualStyleBackColor = false;
            btnProbedor.Click += btnProbedor_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.LightCyan;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(546, 300);
            button2.Name = "button2";
            button2.Size = new Size(317, 75);
            button2.TabIndex = 6;
            button2.Text = "Información del Producto";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.LightCyan;
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(546, 516);
            button3.Name = "button3";
            button3.Size = new Size(317, 71);
            button3.TabIndex = 7;
            button3.Text = "ventas";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.LightCyan;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(331, 183);
            label2.Name = "label2";
            label2.Size = new Size(392, 31);
            label2.TabIndex = 8;
            label2.Text = "Bienvenidos  a la tienda Doña vicky";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Imagen_de_WhatsApp_2025_03_26_a_las_20_04_48_67087795;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.Imagen_de_WhatsApp_2025_03_26_a_las_20_04_48_67087795;
            ClientSize = new Size(1022, 777);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnProbedor);
            Controls.Add(button1);
            Controls.Add(btnVendedor);
            Controls.Add(label1);
            Name = "frmPrincipal";
            Text = "Formulario principal";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnVendedor;
        private Button button1;
        private Button btnProbedor;
        private Button button2;
        private Button button3;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
