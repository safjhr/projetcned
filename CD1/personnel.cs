using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CD1
{
    public partial class personnel : Form
    {
        MySqlConnection sqlconn = new MySqlConnection(@"server=localhost;user id=root;database=projetcned");
        MySqlCommand sqlcmd = new MySqlCommand();
        DataTable sqldt = new DataTable();
        string sqlquerry;
        MySqlDataAdapter dta = new MySqlDataAdapter();
        MySqlDataReader sqlrd;

        DataSet ds = new DataSet();       

        public personnel()
        {
            InitializeComponent();           
        }

        private void uploaddata()
        {
            sqlconn.Open();
            sqlcmd.Connection = sqlconn;
            sqlcmd.CommandText = "SELECT nom, prenom, tel, mail, idservice FROM personnel";

            sqlrd = sqlcmd.ExecuteReader();
            sqldt.Load(sqlrd);
            sqlrd.Close();
            sqlconn.Close();
            dataGridView1.DataSource = sqldt;
        }

        private void btnann_Click(object sender, EventArgs e)
        {
            try
            {
                foreach(Control c in panel1.Controls)
                {
                    if (c is TextBox)
                        ((TextBox)c).Clear();                  
                }
                srvaff.Text = "";
                
                     
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void personnel_Load(object sender, EventArgs e)
        {
            uploaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlconn.Open();
                sqlquerry = "insert into personnel (nom, prenom, tel, mail, idservice)" + "values('" + txtnom.Text + "','" + txtprenom.Text + "','" + txttel.Text + "','" + txtmail.Text + "','" + srvaff.Text +"','" + "')";

                sqlcmd = new MySqlCommand(sqlquerry, sqlconn);
                sqlrd = sqlcmd.ExecuteReader();

                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlconn.Close();
            }
            uploaddata();
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            

            try
            {
                MySqlCommand sqlcmd = new MySqlCommand();
                sqlcmd.Connection = sqlconn;

                sqlcmd.CommandText = "update personnel set nom = @nom, prenom = @prenom, " + "tel = @tel, mail = @mail, idservice";

                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.Parameters.AddWithValue("@nom", txtnom.Text);
                sqlcmd.Parameters.AddWithValue("@prenom", txtprenom.Text);
                sqlcmd.Parameters.AddWithValue("@tel", txttel.Text);
                sqlcmd.Parameters.AddWithValue("@mail", txtmail.Text);
                sqlcmd.Parameters.AddWithValue("@idservice", srvaff.Text);

                sqlcmd.ExecuteNonQuery();
                sqlconn.Clone();
                uploaddata();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                srvaff.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}



    

