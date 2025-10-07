namespace Control_de_inventario
{
    partial class FormularioProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            txtCategoria = new TextBox();
            txtProvedor = new TextBox();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            picImagen = new PictureBox();
            dataGridView1 = new DataGridView();
            btnMostrar = new Button();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 120);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 154);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 1;
            label2.Text = "Descripción";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 82);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(478, 154);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Imagen";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 221);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 4;
            label5.Text = "ProveedorID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(29, 188);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 5;
            label6.Text = "CategoriaID";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(150, 79);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(310, 27);
            txtPrecio.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(150, 127);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(310, 27);
            txtNombre.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(150, 160);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(310, 27);
            txtDescripcion.TabIndex = 9;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(150, 188);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(310, 27);
            txtCategoria.TabIndex = 10;
            // 
            // txtProvedor
            // 
            txtProvedor.Location = new Point(150, 221);
            txtProvedor.Name = "txtProvedor";
            txtProvedor.Size = new Size(310, 27);
            txtProvedor.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.GradientActiveCaption;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(257, 9);
            label7.Name = "label7";
            label7.Size = new Size(290, 31);
            label7.TabIndex = 12;
            label7.Text = "Información del producto";
            label7.Click += label7_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button1.Location = new Point(158, 352);
            button1.Name = "button1";
            button1.Size = new Size(105, 41);
            button1.TabIndex = 13;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ControlLight;
            button2.Location = new Point(290, 352);
            button2.Name = "button2";
            button2.Size = new Size(105, 42);
            button2.TabIndex = 14;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button3.Location = new Point(418, 352);
            button3.Name = "button3";
            button3.Size = new Size(111, 42);
            button3.TabIndex = 15;
            button3.Text = "Actualizar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightCyan;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button4.Location = new Point(557, 352);
            button4.Name = "button4";
            button4.Size = new Size(99, 41);
            button4.TabIndex = 16;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkCyan;
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(24, 384);
            button5.Name = "button5";
            button5.Size = new Size(85, 41);
            button5.TabIndex = 17;
            button5.Text = "Salir";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // picImagen
            // 
            picImagen.Location = new Point(546, 79);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(198, 169);
            picImagen.TabIndex = 18;
            picImagen.TabStop = false;
            picImagen.Click += picImagen_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(834, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(516, 341);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.FromArgb(224, 224, 224);
            btnMostrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnMostrar.Location = new Point(669, 352);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(103, 42);
            btnMostrar.TabIndex = 20;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // FormularioProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Imagen_de_WhatsApp_2025_03_26_a_las_20_04_48_67087795;
            ClientSize = new Size(1400, 450);
            Controls.Add(btnMostrar);
            Controls.Add(dataGridView1);
            Controls.Add(picImagen);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(txtProvedor);
            Controls.Add(txtCategoria);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(txtPrecio);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormularioProducto";
            Text = "FormularioProducto";
            Load += FormularioProducto_Load;
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtCategoria;
        private TextBox txtProvedor;
        private Label label7;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private PictureBox picImagen;
        private DataGridView dataGridView1;
        private Button btnMostrar;
    }
}