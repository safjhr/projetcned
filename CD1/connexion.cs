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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection(@"server=localhost;user id=root;database=projetcned");

        private void button1_Click(object sender, EventArgs e)
        {
            string login, login_pwd;
            login = txt_login.Text;
            login_pwd = txt_pwd.Text;

            try
            {
                string querry = "SELECT * FROM responsable WHERE login = '"+txt_login.Text+"' AND pwd = '"+txt_pwd.Text+"' ";
                MySqlDataAdapter sda = new MySqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    login = txt_login.Text;
                    login_pwd = txt_pwd.Text;

                    //la page qui apparait aprés la connexion
                    personnel personnel = new personnel();
                    personnel.Show();
                    this.Hide();
                }

                else 
                {
                    MessageBox.Show("mot de passe ou login incorrect");
                }

            }
            catch
            {
                MessageBox.Show("mot de passe ou login incorrect");
                txt_login.Clear();
                txt_pwd.Clear();
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
