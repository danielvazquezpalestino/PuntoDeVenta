using BasesDeDatos;
using Entidades;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Control_de_inventario
{
    public partial class FormularioVendedor : Form
    {
        public FormularioVendedor()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(Conexion.CadenaConexion);

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor
            {
                NSS = txtSeguroSocial.Text,
                CorreoElectronico = txtCorreo.Text,
                Domicilio = textBox1.Text,
                Nombre = txtNombre.Text,
                NumeroTelefono = txtNumeroTelefono.Text
            };

            GuardarVendedor(vendedor);
        }

        private void GuardarVendedor(Vendedor vendedor)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexion))
                {
                    connection.Open();

                    string query = @"INSERT INTO Vendedor (NSS, Correo_Electronico, Domicilio, Nombre, Num_Telefono) 
                                     VALUES (@NSS, @Correo_Electronico, @Domicilio, @Nombre, @Num_Telefono)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NSS", vendedor.NSS);
                        command.Parameters.AddWithValue("@Correo_Electronico", vendedor.CorreoElectronico);
                        command.Parameters.AddWithValue("@Domicilio", vendedor.Domicilio);
                        command.Parameters.AddWithValue("@Nombre", vendedor.Nombre);
                        command.Parameters.AddWithValue("@Num_Telefono", vendedor.NumeroTelefono);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Vendedor guardado correctamente.");
                MostrarVendedores(); // Actualizar el DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el vendedor: " + ex.Message);
            }
        }

        private void btnMostar_Click(object sender, EventArgs e)
        {
            MostrarVendedores();
        }

        private void MostrarVendedores()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexion))
                {
                    connection.Open();

                    string query = "SELECT * FROM Vendedor";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridViewVendedores.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los vendedores: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FormularioVendedor_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Por favor, ingrese el ID del vendedor a eliminar.");
                return;
            }

            var id = Convert.ToInt32(txtID.Text);
            EliminarVendedor(id);
        }

        private void EliminarVendedor(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexion))
                {
                    connection.Open();

                    string query = "DELETE FROM Vendedor WHERE ID = @ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Vendedor eliminado correctamente.");

                            // Reorganizar los IDs
                            ReorganizarIDs(connection);

                            // Actualizar el DataGridView
                            MostrarVendedores();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el vendedor con el ID especificado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el vendedor: " + ex.Message);
            }
        }

        private void ReorganizarIDs(SqlConnection connection)
        {
            try
            {
                // Desactivar la restricción de identidad
                using (SqlCommand disableIdentityCommand = new SqlCommand("SET IDENTITY_INSERT Vendedor ON", connection))
                {
                    disableIdentityCommand.ExecuteNonQuery();
                }

                // Obtener todos los vendedores ordenados por ID
                string selectQuery = "SELECT ID FROM Vendedor ORDER BY ID";
                DataTable dataTable = new DataTable();
                using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
                    adapter.Fill(dataTable);
                }

                // Actualizar los IDs secuencialmente
                int newID = 1;
                foreach (DataRow row in dataTable.Rows)
                {
                    int oldID = Convert.ToInt32(row["ID"]);
                    if (oldID != newID)
                    {
                        string updateQuery = "UPDATE Vendedor SET ID = @NewID WHERE ID = @OldID";
                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@NewID", newID);
                            updateCommand.Parameters.AddWithValue("@OldID", oldID);
                            updateCommand.ExecuteNonQuery();
                        }
                    }
                    newID++;
                }

                // Reactivar la restricción de identidad
                using (SqlCommand enableIdentityCommand = new SqlCommand("SET IDENTITY_INSERT Vendedor OFF", connection))
                {
                    enableIdentityCommand.ExecuteNonQuery();
                }

                MessageBox.Show("IDs reorganizados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al reorganizar los IDs: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtSeguroSocial.Clear();
            txtCorreo.Clear();
            txtNombre.Clear();
            txtNumeroTelefono.Clear();
            textBox1.Clear();
        }

        private void dataGridViewVendedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewVendedores_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewVendedores.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewVendedores.SelectedRows[0];

                txtID.Text = selectedRow.Cells["ID"].Value.ToString();
                txtSeguroSocial.Text = selectedRow.Cells["NSS"].Value.ToString();
                txtCorreo.Text = selectedRow.Cells["CorreoElectronico"].Value.ToString();
                textBox1.Text = selectedRow.Cells["Domicilio"].Value.ToString();
                txtNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
                txtNumeroTelefono.Text = selectedRow.Cells["NumeroTelefono"].Value.ToString();
            }
        }

        private void vendedorBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewVendedores_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDomicilio.Text) || string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtSeguroSocial.Text) || string.IsNullOrEmpty(txtNumeroTelefono.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            Vendedor vendedor = new Vendedor
            {
                ID = Convert.ToInt32(txtID.Text),
                NSS = txtSeguroSocial.Text,
                CorreoElectronico = txtCorreo.Text,
                Domicilio = textBox1.Text,
                Nombre = txtNombre.Text,
                NumeroTelefono = txtNumeroTelefono.Text
            };

            ActualizarVendedor(vendedor);
        }
        private void ActualizarVendedor(Vendedor vendedor)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexion))
                {
                    connection.Open();

                    string query = @"UPDATE Vendedor
                                      SET NSS = @NSS, 
                                          Correo_Electronico = @Correo_Electronico, 
                                          Domicilio = @Domicilio, 
                                          Nombre = @Nombre, 
                                          Num_Telefono = @Num_Telefono 
                                      WHERE ID = @ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", vendedor.ID);
                        command.Parameters.AddWithValue("@NSS", vendedor.NSS);
                        command.Parameters.AddWithValue("@Correo_Electronico", vendedor.CorreoElectronico);
                        command.Parameters.AddWithValue("@Domicilio", vendedor.Domicilio);
                        command.Parameters.AddWithValue("@Nombre", vendedor.Nombre);
                        command.Parameters.AddWithValue("@Num_Telefono", vendedor.NumeroTelefono);

                        command.ExecuteNonQuery();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Vendedor actualizado correctamente.");
                            MostrarVendedores(); // Actualizar el DataGridView
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el vendedor con el ID especificado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el vendedor: " + ex.Message);
            }
        }

        private void dataGridViewVendedores_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridViewVendedores.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewVendedores.SelectedRows[0];

                txtID.Text = selectedRow.Cells["ID"].Value.ToString();
                txtSeguroSocial.Text = selectedRow.Cells["NSS"].Value.ToString();
                txtCorreo.Text = selectedRow.Cells["Correo_Electronico"].Value.ToString();
                textBox1.Text = selectedRow.Cells["Domicilio"].Value.ToString();
                txtNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
                txtNumeroTelefono.Text = selectedRow.Cells["Num_Telefono"].Value.ToString();
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNombre.Clear();
            txtCorreo.Clear();
            textBox1.Clear();
            txtSeguroSocial.Clear();
            txtNumeroTelefono.Clear();

        }
    }
}