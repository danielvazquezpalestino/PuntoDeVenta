namespace Control_de_inventario
{
    partial class FormularioVendedor
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
            lblID = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            txtID = new TextBox();
            txtNombre = new TextBox();
            txtNumeroTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtSeguroSocial = new TextBox();
            btGuardar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnMostrar = new Button();
            btnSalir = new Button();
            txtDomicilio = new Label();
            textBox1 = new TextBox();
            dataGridViewVendedores = new DataGridView();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVendedores).BeginInit();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = Color.LightCyan;
            lblID.Location = new Point(192, 71);
            lblID.Name = "lblID";
            lblID.Size = new Size(24, 20);
            lblID.TabIndex = 0;
            lblID.Text = "ID";
            lblID.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 104);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 135);
            label3.Name = "label3";
            label3.Size = new Size(144, 20);
            label3.TabIndex = 2;
            label3.Text = "Número de telefono";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 173);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 3;
            label4.Text = "Correo electronico";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 207);
            label5.Name = "label5";
            label5.Size = new Size(175, 20);
            label5.TabIndex = 4;
            label5.Text = "Número de seguro social";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 13);
            label1.Name = "label1";
            label1.Size = new Size(274, 28);
            label1.TabIndex = 5;
            label1.Text = "Ingresa los siguientes datos";
            label1.Click += label1_Click_1;
            // 
            // txtID
            // 
            txtID.Location = new Point(251, 68);
            txtID.Name = "txtID";
            txtID.Size = new Size(175, 27);
            txtID.TabIndex = 6;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(251, 101);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(175, 27);
            txtNombre.TabIndex = 7;
            // 
            // txtNumeroTelefono
            // 
            txtNumeroTelefono.Location = new Point(253, 132);
            txtNumeroTelefono.Name = "txtNumeroTelefono";
            txtNumeroTelefono.Size = new Size(173, 27);
            txtNumeroTelefono.TabIndex = 8;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(251, 169);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(173, 27);
            txtCorreo.TabIndex = 9;
            // 
            // txtSeguroSocial
            // 
            txtSeguroSocial.Location = new Point(255, 204);
            txtSeguroSocial.Name = "txtSeguroSocial";
            txtSeguroSocial.Size = new Size(173, 27);
            txtSeguroSocial.TabIndex = 10;
            // 
            // btGuardar
            // 
            btGuardar.BackColor = SystemColors.GradientActiveCaption;
            btGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btGuardar.Location = new Point(118, 329);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(107, 44);
            btGuardar.TabIndex = 11;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = false;
            btGuardar.Click += btGuardar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.LightGray;
            btnActualizar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnActualizar.Location = new Point(241, 329);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(120, 44);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(501, 329);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 44);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.LightGray;
            btnMostrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnMostrar.Location = new Point(382, 329);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(104, 44);
            btnMostrar.TabIndex = 14;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.DarkCyan;
            btnSalir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.Snow;
            btnSalir.Location = new Point(1179, 357);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(103, 43);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += button1_Click;
            // 
            // txtDomicilio
            // 
            txtDomicilio.AutoSize = true;
            txtDomicilio.Location = new Point(146, 244);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(74, 20);
            txtDomicilio.TabIndex = 16;
            txtDomicilio.Text = "Domicilio";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(254, 240);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 27);
            textBox1.TabIndex = 17;
            // 
            // dataGridViewVendedores
            // 
            dataGridViewVendedores.AllowUserToOrderColumns = true;
            dataGridViewVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVendedores.Location = new Point(466, 45);
            dataGridViewVendedores.Margin = new Padding(3, 4, 3, 4);
            dataGridViewVendedores.Name = "dataGridViewVendedores";
            dataGridViewVendedores.RowHeadersWidth = 51;
            dataGridViewVendedores.Size = new Size(838, 261);
            dataGridViewVendedores.TabIndex = 18;
            dataGridViewVendedores.CellContentClick += dataGridViewVendedores_CellContentClick_1;
            dataGridViewVendedores.SelectionChanged += dataGridViewVendedores_SelectionChanged_1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.IndianRed;
            btnLimpiar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLimpiar.ForeColor = SystemColors.ButtonFace;
            btnLimpiar.Location = new Point(638, 329);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 44);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // FormularioVendedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Imagen_de_WhatsApp_2025_03_26_a_las_20_04_48_67087795;
            ClientSize = new Size(1311, 459);
            Controls.Add(btnLimpiar);
            Controls.Add(dataGridViewVendedores);
            Controls.Add(textBox1);
            Controls.Add(txtDomicilio);
            Controls.Add(btnSalir);
            Controls.Add(btnMostrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btGuardar);
            Controls.Add(txtSeguroSocial);
            Controls.Add(txtCorreo);
            Controls.Add(txtNumeroTelefono);
            Controls.Add(txtNombre);
            Controls.Add(txtID);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblID);
            Name = "FormularioVendedor";
            Text = "Formulario del Vendedor";
            Load += FormularioVendedor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewVendedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label1;
        private TextBox txtID;
        private TextBox txtNombre;
        private TextBox txtNumeroTelefono;
        private TextBox txtCorreo;
        private TextBox txtSeguroSocial;
        private Button btGuardar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnMostrar;
        private Button btnSalir;
        private Label txtDomicilio;
        private TextBox textBox1;
        private DataGridView dataGridViewVendedores;
        private Button btnLimpiar;
    }
}