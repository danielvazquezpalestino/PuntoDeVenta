namespace Control_de_inventario
{
    partial class formularioCarrito
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
            label6 = new Label();
            btnBuscar = new Button();
            txtTotal = new TextBox();
            btnSalir = new Button();
            dataGridView1 = new DataGridView();
            txtBusquedaProducto = new TextBox();
            button1 = new Button();
            label3 = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(553, 18);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 0;
            label1.Text = "Inventario";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label2.Location = new Point(25, 117);
            label2.Name = "label2";
            label2.Size = new Size(187, 28);
            label2.TabIndex = 4;
            label2.Text = "Buscar Productos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            label6.Location = new Point(399, 241);
            label6.Name = "label6";
            label6.Size = new Size(109, 28);
            label6.TabIndex = 8;
            label6.Text = "Cantidad";
            label6.Click += label6_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkGray;
            btnBuscar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnBuscar.Location = new Point(36, 232);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(283, 45);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Mostrar Productos";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += button2_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(514, 241);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(191, 35);
            txtTotal.TabIndex = 10;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalir.BackColor = Color.Red;
            btnSalir.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnSalir.Location = new Point(1145, 607);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(113, 41);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(61, 311);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1009, 337);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // txtBusquedaProducto
            // 
            txtBusquedaProducto.Location = new Point(334, 105);
            txtBusquedaProducto.Multiline = true;
            txtBusquedaProducto.Name = "txtBusquedaProducto";
            txtBusquedaProducto.Size = new Size(769, 49);
            txtBusquedaProducto.TabIndex = 15;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Chartreuse;
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            button1.Location = new Point(1115, 311);
            button1.Name = "button1";
            button1.Size = new Size(113, 41);
            button1.TabIndex = 17;
            button1.Text = "Vender";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            label3.Location = new Point(769, 245);
            label3.Name = "label3";
            label3.Size = new Size(185, 28);
            label3.TabIndex = 18;
            label3.Text = "Metodo de Pago";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(971, 251);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(257, 28);
            comboBox1.TabIndex = 19;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.DarkGray;
            button2.FlatStyle = FlatStyle.System;
            button2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            button2.Location = new Point(1106, 381);
            button2.Name = "button2";
            button2.Size = new Size(152, 75);
            button2.TabIndex = 20;
            button2.Text = "Mostrar Ventas";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // formularioCarrito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Imagen_de_WhatsApp_2025_03_26_a_las_20_04_48_67087795;
            ClientSize = new Size(1327, 675);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(txtBusquedaProducto);
            Controls.Add(dataGridView1);
            Controls.Add(btnSalir);
            Controls.Add(txtTotal);
            Controls.Add(btnBuscar);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formularioCarrito";
            Text = "formularioCarrito";
            Load += formularioCarrito_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label6;
        private Button btnBuscar;
        private TextBox txtTotal;
        private Button btnSalir;
        private DataGridView dataGridView1;
        private TextBox txtBusquedaProducto;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label3;
        private ComboBox comboBox1;
        private Button button2;
    }
}