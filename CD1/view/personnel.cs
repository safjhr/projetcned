using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CD1.view
{
    public partial class personnel : Form
    {
        MySqlConnection sqlconn = new MySqlConnection(@"server=localhost;user id=root;database=projetcned");

        public personnel()
        {
            InitializeComponent();
            srvaff.Items.AddRange(new object[] { "1", "2", "3" });
        }

        private void UploadData()
        {
            try
            {
                sqlconn.Open();
                string sqlquery = "SELECT nom, prenom, tel, mail, idservice FROM personnel";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlquery, sqlconn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
            }
            finally
            {
                if (sqlconn.State == ConnectionState.Open)
                    sqlconn.Close();
            }
        }

        private void btnann_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in panel1.Controls)
                {
                    if (c is TextBox)
                        ((TextBox)c).Clear();
                }
                srvaff.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void personnel_Load(object sender, EventArgs e)
        {
            UploadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlconn.Open();
                string sqlquerry = "INSERT INTO personnel (nom, prenom, tel, mail, idservice) VALUES (@nom, @prenom, @tel, @mail, @idservice)";
                using (MySqlCommand sqlcmd = new MySqlCommand(sqlquerry, sqlconn))
                {
                    sqlcmd.Parameters.AddWithValue("@nom", txtnom.Text);
                    sqlcmd.Parameters.AddWithValue("@prenom", txtprenom.Text);
                    sqlcmd.Parameters.AddWithValue("@tel", txttel.Text);
                    sqlcmd.Parameters.AddWithValue("@mail", txtmail.Text);
                    sqlcmd.Parameters.AddWithValue("@idservice", srvaff.SelectedIndex + 1);

                    int rowsAffected = sqlcmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Données insérées avec succès.");
                        UploadData();
                    }
                    else
                    {
                        MessageBox.Show("Aucune donnée insérée.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'insertion des données : " + ex.Message);
            }
            finally
            {
                if (sqlconn.State == ConnectionState.Open)
                    sqlconn.Close();
            }
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            try
            {
                sqlconn.Open();
                MySqlCommand sqlcmd = new MySqlCommand();
                sqlcmd.Connection = sqlconn;

                sqlcmd.CommandText = "UPDATE personnel SET nom = @nom, prenom = @prenom, " +
                                     "tel = @tel, mail = @mail, idservice = @idservice " +
                                     "WHERE idpersonnel = @idpersonnel";

                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.Parameters.AddWithValue("@nom", txtnom.Text);
                sqlcmd.Parameters.AddWithValue("@prenom", txtprenom.Text);
                sqlcmd.Parameters.AddWithValue("@tel", txttel.Text);
                sqlcmd.Parameters.AddWithValue("@mail", txtmail.Text);
                sqlcmd.Parameters.AddWithValue("@idservice", srvaff.SelectedIndex + 1); // Ajoutez 1 car l'index commence à 0

                int rowsAffected = sqlcmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Données modifiées avec succès.");
                    UploadData();
                }
                else
                {
                    MessageBox.Show("Aucune donnée modifiée.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification des données : " + ex.Message);
            }
            finally
            {
                if (sqlconn.State == ConnectionState.Open)
                    sqlconn.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtnom.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtprenom.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txttel.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtmail.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                srvaff.SelectedIndex = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value) - 1; // Soustrayez 1 car l'index commence à 0
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}




