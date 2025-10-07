using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using BasesDeDatos;
using Entidades;
using Microsoft.Data.SqlClient;


namespace Control_de_inventario
{
    public partial class fomularioProvedor : Form
    {
        public fomularioProvedor()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(Conexion.CadenaConexion);

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            EliminarProveedor(id);
        }
        private void EliminarProveedor(int id)
        {
            try
            {
                    using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexion))
                {
                    connection.Open();

                    // Eliminar el proveedor
                    string deleteQuery = "DELETE FROM Proveedor WHERE ID = @ID";
                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@ID", id);
                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Proveedor eliminado correctamente.");

                            // Reorganizar los IDs
                            ReorganizarIDs(connection);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el proveedor con el ID especificado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el proveedor: " + ex.Message);
            }
        }
        private void ReorganizarIDs(SqlConnection connection)
        {
            try
            {
                // Obtener todos los proveedores ordenados por ID
                string selectQuery = "SELECT ID FROM Proveedor ORDER BY ID";
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
                        string updateQuery = "UPDATE Proveedor SET ID = @NewID WHERE ID = @OldID";
                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@NewID", newID);
                            updateCommand.Parameters.AddWithValue("@OldID", oldID);
                            updateCommand.ExecuteNonQuery();
                        }
                    }
                    newID++;
                }

                MessageBox.Show("IDs reorganizados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al reorganizar los IDs: " + ex.Message);
            }
        }

        private void fomularioProvedor_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtDomicilio.Text != "" && txtCorreo.Text != "")
            {
                Proveedor proveedor = new Proveedor
                {
                    Nombre = txtNombre.Text,
                    Domicilio = txtDomicilio.Text,
                    CorreoElectronico = txtCorreo.Text
                };

                GuardarProveedor(proveedor);
            }
            else
                MessageBox.Show("Rellena los campos solicitados");
        }
        private void GuardarProveedor(Proveedor proveedor)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexion))
                {
                    connection.Open();

                    string query = @"INSERT INTO Proveedor (Nombre, Domicilio, Correo_Electronico) 
                                     VALUES (@Nombre, @Domicilio, @Correo_Electronico)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", proveedor.Nombre);
                        command.Parameters.AddWithValue("@Domicilio", proveedor.Domicilio);
                        command.Parameters.AddWithValue("@Correo_Electronico", proveedor.CorreoElectronico);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Proveedor guardado correctamente.");

                MostrarProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el proveedor: " + ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarProveedores();
        }
        private void MostrarProveedores()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexion))
                {
                    connection.Open();

                    string query = "SELECT * FROM Proveedor";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridViewProveedores.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los proveedores: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDomicilio.Text) || string.IsNullOrEmpty(txtCorreo.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            Proveedor proveedor = new Proveedor
            {
                ID = Convert.ToInt32(txtID.Text),
                Nombre = txtNombre.Text,
                Domicilio = txtDomicilio.Text,
                CorreoElectronico = txtCorreo.Text
            };

            ActualizarProveedor(proveedor);
        }
        private void ActualizarProveedor(Proveedor proveedor)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexion))
                {
                    connection.Open();

                    string query = @"UPDATE Proveedor 
                                      SET Nombre = @Nombre, 
                                          Domicilio = @Domicilio, 
                                          Correo_Electronico = @Correo_Electronico
                                      WHERE ID = @ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", proveedor.ID);
                        command.Parameters.AddWithValue("@Nombre", proveedor.Nombre);
                        command.Parameters.AddWithValue("@Domicilio", proveedor.Domicilio);
                        command.Parameters.AddWithValue("@Correo_Electronico", proveedor.CorreoElectronico);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Proveedor actualizado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el proveedor con el ID especificado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el proveedor: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNombre.Clear();
            txtDomicilio.Clear();
            txtCorreo.Clear();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProveedores.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewProveedores.SelectedRows[0];

                txtID.Text = selectedRow.Cells["ID"].Value.ToString();
                txtNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
                txtDomicilio.Text = selectedRow.Cells["Domicilio"].Value.ToString();
                txtCorreo.Text = selectedRow.Cells["Correo_Electronico"].Value.ToString();
            }
        }
    }
}
