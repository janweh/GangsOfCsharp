using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void textBoxFirstName_Enter(object sender, EventArgs e)
        {
            String fname = textBoxFirstName.Text;
            if (fname.ToLower().Trim().Equals("first name"))
            {
                textBoxFirstName.Text = "";
                textBoxFirstName.ForeColor = Color.Black;
            } 
        }

        private void textBoxFirstName_Leave(object sender, EventArgs e)
        {
            String fname = textBoxFirstName.Text;
            if (fname.ToLower().Trim().Equals("first name") || fname.Trim().Equals(""))
            {
                textBoxFirstName.Text = "first name";
                textBoxFirstName.ForeColor = Color.Gray;
            }
        }

        private void textBoxLastName_Enter(object sender, EventArgs e)
        {
            String lname = textBoxLastName.Text;
            if (lname.ToLower().Trim().Equals("last name"))
            {
                textBoxLastName.Text = "";
                textBoxLastName.ForeColor = Color.Black;
            }
        }

        private void textBoxLastName_Leave(object sender, EventArgs e)
        {
            String lname = textBoxLastName.Text;
            if (lname.ToLower().Trim().Equals("last name") || lname.Trim().Equals(""))
            {
                textBoxLastName.Text = "last name";
                textBoxLastName.ForeColor = Color.Gray;
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            String email = textBoxEmail.Text;
            if (email.ToLower().Trim().Equals("email adress"))
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }

        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            String email = textBoxEmail.Text;
            if (email.ToLower().Trim().Equals("email adress") || email.Trim().Equals(""))
            {
                textBoxEmail.Text = "email adress";
                textBoxEmail.ForeColor = Color.Gray;
            }
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            String uname = textBoxUsername.Text;
            if (uname.ToLower().Trim().Equals("username"))
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Black;
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            String uname = textBoxUsername.Text;
            if (uname.ToLower().Trim().Equals("username") || uname.Trim().Equals(""))
            {
                textBoxUsername.Text = "username";
                textBoxUsername.ForeColor = Color.Gray;
            }
        }

        private void textBoxUniversity_Enter(object sender, EventArgs e)
        {
            String uni = textBoxUniversity.Text;
            if (uni.ToLower().Trim().Equals("university"))
            {
                textBoxUniversity.Text = "";
                textBoxUniversity.ForeColor = Color.Black;
            }
        }

        private void textBoxUniversity_Leave(object sender, EventArgs e)
        {
            String uni = textBoxUniversity.Text;
            if (uni.ToLower().Trim().Equals("university") || uni.Trim().Equals(""))
            {
                textBoxUniversity.Text = "university";
                textBoxUniversity.ForeColor = Color.Gray;
            }
        }

        private void textBoxMajor_Enter(object sender, EventArgs e)
        {
            String major = textBoxMajor.Text;
            if (major.ToLower().Trim().Equals("major"))
            {
                textBoxMajor.Text = "";
                textBoxMajor.ForeColor = Color.Black;
            }
        }

        private void textBoxMajor_Leave(object sender, EventArgs e)
        {
            String major = textBoxMajor.Text;
            if (major.ToLower().Trim().Equals("major") || major.Trim().Equals(""))
            {
                textBoxMajor.Text = "major";
                textBoxMajor.ForeColor = Color.Gray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            String password = textBoxPassword.Text;
            if (password.ToLower().Trim().Equals("password"))
            {
                textBoxPassword.Text = "";
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            String password = textBoxPassword.Text;
            if (password.ToLower().Trim().Equals("password") || password.Trim().Equals(""))
            {
                textBoxPassword.Text = "password";
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void textBoxRepeatPassword_Enter(object sender, EventArgs e)
        {
            String repeatpassword = textBoxRepeatPassword.Text;
            if (repeatpassword.ToLower().Trim().Equals("confirm password"))
            {
                textBoxRepeatPassword.Text = "";
                textBoxRepeatPassword.UseSystemPasswordChar = true;
                textBoxRepeatPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxRepeatPassword_Leave(object sender, EventArgs e)
        {
            String repeatpassword = textBoxRepeatPassword.Text;
            if (repeatpassword.ToLower().Trim().Equals("confirm password") ||
                repeatpassword.Trim().Equals("") ||
                repeatpassword.Trim().Equals("password")) 
            {
                textBoxRepeatPassword.Text = "confirm password";
                textBoxRepeatPassword.UseSystemPasswordChar = false;
                textBoxRepeatPassword.ForeColor = Color.Gray;
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Red;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            //add new user

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`( `firstname`, `lastname`, `email`, `university`, `major`, `username`, `password`) VALUES (@fn, @ln, @email, @uni, @major, @usn, @pass) ", db.GetConnection());

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = textBoxFirstName.Text;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = textBoxLastName.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxEmail.Text;
            command.Parameters.Add("@uni", MySqlDbType.VarChar).Value = textBoxUniversity.Text;
            command.Parameters.Add("@major", MySqlDbType.VarChar).Value = textBoxMajor.Text;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBoxUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;

            //open connection to db

            db.openConnection();

            //check if text boxes contain defaul values
            if (!checkTextBoxesValues()) {
                //check if password == confirm pasword
                if (textBoxPassword.Text.Equals(textBoxRepeatPassword.Text))
                {
                    //check if the username already exists
                    if (checkUsername())
                    {
                        MessageBox.Show("This Username Already Exists, Select A Different One", "Duplicate username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //execute the query

                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Your Account Has Been Created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("ERROR");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Passwords Do Not Match", "Password Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) ;
                }
            }
               
            else
            {
                MessageBox.Show("Enter Your Information First", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            //close connection

            db.closeConnection();
        }

        public Boolean checkUsername()
        {
            DB db = new DB();

            String username = textBoxUsername.Text;
            String password = textBoxPassword.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username`= @usn", db.GetConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            //check if this username already exists in database
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // check if text boxes contain default values
        public Boolean checkTextBoxesValues()
        {
            String fname = textBoxFirstName.Text;
            String lname = textBoxLastName.Text;
            String email = textBoxEmail.Text;
            String university = textBoxUniversity.Text;
            String mjr = textBoxMajor.Text;
            String usn = textBoxUsername.Text;
            String pass = textBoxPassword.Text;


            if (fname.Equals("first name") || lname.Equals("last name") || email.Equals("email adress") || university.Equals("university")
                || mjr.Equals("major") || usn.Equals("username") || pass.Equals("password"))
            {
                return true;
            }
            else
            {
                return false;
            } 
        }

        Point lastPoint;

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            {
                lastPoint = new Point(e.X, e.Y);
            }
        }
    }
}
