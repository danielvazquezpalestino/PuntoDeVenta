namespace Control_de_inventario
{
    partial class fomularioProvedor
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
            txtNombre = new TextBox();
            txtDomicilio = new TextBox();
            txtCorreo = new TextBox();
            button1 = new Button();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnMostrar = new Button();
            txtID = new TextBox();
            dataGridViewProveedores = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(179, 121);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(111, 207);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 1;
            label2.Text = "Correo electronico";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(169, 165);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "Domicilio";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientActiveCaption;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(402, 35);
            label4.Name = "label4";
            label4.Size = new Size(281, 28);
            label4.TabIndex = 3;
            label4.Text = "Información del proveedor";
            label4.Click += label4_Click;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtNombre.Location = new Point(264, 119);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(265, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtDomicilio.Location = new Point(264, 163);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(265, 27);
            txtDomicilio.TabIndex = 5;
            // 
            // txtCorreo
            // 
            txtCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtCorreo.Location = new Point(264, 207);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(265, 27);
            txtCorreo.TabIndex = 6;
            txtCorreo.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(565, 394);
            button1.Name = "button1";
            button1.Size = new Size(81, 51);
            button1.TabIndex = 7;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregar.BackColor = Color.LightGray;
            btnAgregar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnAgregar.Location = new Point(-5, 394);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(104, 45);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnActualizar.BackColor = Color.LightGray;
            btnActualizar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnActualizar.Location = new Point(106, 394);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(110, 45);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(342, 391);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 51);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLimpiar.BackColor = Color.IndianRed;
            btnLimpiar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLimpiar.ForeColor = SystemColors.ButtonFace;
            btnLimpiar.Location = new Point(460, 394);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(81, 51);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnMostrar.BackColor = Color.LightGray;
            btnMostrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnMostrar.Location = new Point(226, 394);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(110, 45);
            btnMostrar.TabIndex = 13;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // txtID
            // 
            txtID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtID.Location = new Point(264, 83);
            txtID.Name = "txtID";
            txtID.Size = new Size(265, 27);
            txtID.TabIndex = 14;
            // 
            // dataGridViewProveedores
            // 
            dataGridViewProveedores.AllowUserToOrderColumns = true;
            dataGridViewProveedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProveedores.Location = new Point(554, 83);
            dataGridViewProveedores.Margin = new Padding(3, 4, 3, 4);
            dataGridViewProveedores.Name = "dataGridViewProveedores";
            dataGridViewProveedores.RowHeadersWidth = 51;
            dataGridViewProveedores.Size = new Size(531, 200);
            dataGridViewProveedores.TabIndex = 15;
            dataGridViewProveedores.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(210, 87);
            label5.Name = "label5";
            label5.Size = new Size(24, 20);
            label5.TabIndex = 16;
            label5.Text = "ID";
            // 
            // fomularioProvedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Imagen_de_WhatsApp_2025_03_26_a_las_20_04_48_67087795;
            ClientSize = new Size(1097, 451);
            Controls.Add(label5);
            Controls.Add(dataGridViewProveedores);
            Controls.Add(txtID);
            Controls.Add(btnMostrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(button1);
            Controls.Add(txtCorreo);
            Controls.Add(txtDomicilio);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fomularioProvedor";
            Text = "fomularioProvedor";
            Load += fomularioProvedor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtDomicilio;
        private TextBox txtCorreo;
        private Button button1;
        private Button button2;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnMostrar;
        private TextBox txtID;
        private DataGridView dataGridViewProveedores;
        private Label label5;
    }
}