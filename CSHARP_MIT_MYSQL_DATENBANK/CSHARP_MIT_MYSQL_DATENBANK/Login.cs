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

namespace CSHARP_MIT_MYSQL_DATENBANK
{
    public partial class Login : Form
    {

        Connect con = new Connect();
        MySqlCommand cmd;
        MySqlDataReader reader;

        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnmelden_Click(object sender, EventArgs e)
        {
            con.connection();
            cmd = new MySqlCommand("select * from login where username = '"+ cbUsername.Text + "' and password = '"+ txtPassword.Text + "'", con.con);
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Erfolgreich angemeldet!", "world", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 f1 = new Form1();
                this.Hide();
                f1.Show();
            }
            else
            {
                MessageBox.Show("Username oder Password falsch!", "world", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            con.con.Close();
        }
    }
}
