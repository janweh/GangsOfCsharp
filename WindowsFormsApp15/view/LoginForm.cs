using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp15.model;


namespace WindowsFormsApp15
{
    public delegate void LogedOnDelegate(object sender, EventArgs args);

    public partial class LoginForm : Form
    {

        
        public LoginForm()
        {
            InitializeComponent();


            this.textBoxPassword.AutoSize = false;
            this.textBoxPassword.Size = new Size(this.textBoxPassword.Size.Width, 40);
        }
       
        
        private void LabelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Red;
        }

        private void LabelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }

        private void LabelClose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }


        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            String username = textBoxUsername.Text;
            String password = textBoxPassword.Text;
            
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username`= @usn and `password` = @pass", db.GetConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            //check if the user exists or not.
            if(table.Rows.Count > 0)
            {
                MessageBox.Show("You are logged on!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginStatus.isLogged = true;
                if(LogenOn != null)
                {
                    LogenOn(this, new EventArgs());
                }
                this.Close();
                
            }
            else
            {
                if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username To Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password To Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Wrong Username Or Password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public event LogedOnDelegate LogenOn;

        Point lastPoint;
        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
            {
                lastPoint = new Point(e.X, e.Y);
            }
        }
    }
}
