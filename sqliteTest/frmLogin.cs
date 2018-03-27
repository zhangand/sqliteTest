using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace sqliteTest
{
    public partial class frmLogin : Form
    {


        public frmLogin()
        {
            InitializeComponent();
        }

         //define user method
        private Boolean LoginInfoCheck(string username, string password)//check the username and password
        {
            try
            {
                config.DatabaseFile = "database.sqlite";

                using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
                {
                    conn.Open();
                    string Query = "select * from employee where username='" + this.txtUser.Text + "' and password='" + this.txtPwd.Text + "'";
                    SQLiteCommand createCommand = new SQLiteCommand(Query, conn);

                    createCommand.ExecuteNonQuery();
                    SQLiteDataReader dr = createCommand.ExecuteReader();

                    int count = 0;
                    while (dr.Read())
                    {
                        count++;
                    }
                    if (count == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }


        //define control method
        private void btnCancel_Click(object sender, EventArgs e)//close the login form
        {
            Application.Exit();
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)//close the login form
        {
            Application.Exit();
        }
        private void btnOK_Click(object sender, EventArgs e)//login button
        {

            if (txtUser.Text == "")
            {
                MessageBox.Show("Username can not be blank!");
                return;
            }
            if (txtPwd.Text == "")
            {
                MessageBox.Show("Password can not be blank!");
                return;
            }

            if (LoginInfoCheck(txtUser.Text.Trim(), txtPwd.Text.Trim()))
            {
                frmMain frm = new frmMain(txtUser.Text);
                frm.Show();
                this.Hide();
            }
            else MessageBox.Show("Username and Password is not correct");
        }

    }
}
