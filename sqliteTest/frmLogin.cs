using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Net.Sockets;
using System.Net;

namespace sqliteTest
{
    public partial class frmLogin : Form
    {
        public string clientIP;
        public string clientPort;
        public Socket ClientSocket = null;

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
        private Boolean SocketConnectionCheck(string ip, string port)//check the ip and port connection
        {
            ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress yourAddress = IPAddress.Parse(ip);
            int yourPort = int.Parse(port);

            try
            {
                IAsyncResult connResult = ClientSocket.BeginConnect(yourAddress, yourPort, null, null);
                connResult.AsyncWaitHandle.WaitOne(1000, true);  //wait 1 second

                if (connResult.IsCompleted)
                {
                    return true;
                }
                else
                {
                    ClientSocket.Close();
                    return false;
                }

            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
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

            clientIP = txtIP.Text.Trim();
            clientPort = txtPort.Text.Trim();
            if (!SocketConnectionCheck(clientIP, clientPort))
            {
                MessageBox.Show("Server no response!");
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
