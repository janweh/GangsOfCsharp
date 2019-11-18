using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApp15.Data;
using WindowsFormsApp15.model;

namespace WindowsFormsApp15
{
    public partial class RegisterForm : Form
    {
        University noSelectedUniversity;
        public RegisterForm()
        {
            DataSearch ds = new DataSearch();
            InitializeComponent();
            List<University> unis = ds.GetAll<University>();
            noSelectedUniversity = new University("-select uni-");
            //noSelectedLecturer = new Lecturer(0, "", noSelectedUniversity, noSelectedMajor);
            unis.Insert(0, noSelectedUniversity);
            universityComboBox.DataSource = unis;
            universityComboBox.DisplayMember = "UniversityName";

            BindingSource bs = new BindingSource();
            bs.DataSource = new List<string>
            {
                " ",
                "Agriculture, forestry and fishery",
                "Architecture and town planning",
                "Arts and Humanities",
                "Business administration and management",
                "Communication",
                "Education and Teacher Training",
                "Engineering",
                "Environmental Sciences",
                "Fine and applied arts",
                "Law",
                "Mathematics and computer sciences",
                "Medical and health sciences",
                "Natural sciences",
                "Other",
                "Service, Tourism and Leisure",
                "Social and behavioural sciences",
                "Transport and communication"
            };
            areaOfStudiesComboBox.DataSource = bs;
        }

        private void TextBoxFirstName_Enter(object sender, EventArgs e)
        {
            String fname = textBoxFirstName.Text;
            if (fname.ToLower().Trim().Equals("first name"))
            {
                textBoxFirstName.Text = "";
                textBoxFirstName.ForeColor = Color.Black;
            } 
        }

        private void TextBoxFirstName_Leave(object sender, EventArgs e)
        {
            String fname = textBoxFirstName.Text;
            if (fname.ToLower().Trim().Equals("first name") || fname.Trim().Equals(""))
            {
                textBoxFirstName.Text = "first name";
                textBoxFirstName.ForeColor = Color.Gray;
            }
        }

        private void TextBoxLastName_Enter(object sender, EventArgs e)
        {
            String lname = textBoxLastName.Text;
            if (lname.ToLower().Trim().Equals("last name"))
            {
                textBoxLastName.Text = "";
                textBoxLastName.ForeColor = Color.Black;
            }
        }

        private void TextBoxLastName_Leave(object sender, EventArgs e)
        {
            String lname = textBoxLastName.Text;
            if (lname.ToLower().Trim().Equals("last name") || lname.Trim().Equals(""))
            {
                textBoxLastName.Text = "last name";
                textBoxLastName.ForeColor = Color.Gray;
            }
        }

        private void TextBoxEmail_Enter(object sender, EventArgs e)
        {
            String email = textBoxEmail.Text;
            if (email.ToLower().Trim().Equals("email adress"))
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }

        }

        private void TextBoxEmail_Leave(object sender, EventArgs e)
        {
            string pattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                            + "@"
                            + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";
            String email = textBoxEmail.Text;
            if (email.ToLower().Trim().Equals("email adress") || email.Trim().Equals(""))
            {
                textBoxEmail.Text = "email adress";
                textBoxEmail.ForeColor = Color.Gray;
            }
            if (Regex.IsMatch(textBoxEmail.Text, pattern))
            {
                errorProvider1.Clear();
                buttonCreateAccount.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(this.textBoxEmail, "Please provide valid email adress");
                buttonCreateAccount.Enabled = false;
            }
        }

        private void TextBoxUsername_Enter(object sender, EventArgs e)
        {
            String uname = textBoxUsername.Text;
            if (uname.ToLower().Trim().Equals("username"))
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Black;
            }
        }

        private void TextBoxUsername_Leave(object sender, EventArgs e)
        {
            String uname = textBoxUsername.Text;
            if (uname.ToLower().Trim().Equals("username") || uname.Trim().Equals(""))
            {
                textBoxUsername.Text = "username";
                textBoxUsername.ForeColor = Color.Gray;
            }
        }

        



        private void TextBoxPassword_Enter(object sender, EventArgs e)
        {
            String password = textBoxPassword.Text;
            if (password.ToLower().Trim().Equals("password"))
            {
                textBoxPassword.Text = "";
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            String password = textBoxPassword.Text;
            if (password.ToLower().Trim().Equals("password") || password.Trim().Equals(""))
            {
                textBoxPassword.Text = "password";
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void TextBoxRepeatPassword_Enter(object sender, EventArgs e)
        {
            String repeatpassword = textBoxRepeatPassword.Text;
            if (repeatpassword.ToLower().Trim().Equals("confirm password"))
            {
                textBoxRepeatPassword.Text = "";
                textBoxRepeatPassword.UseSystemPasswordChar = true;
                textBoxRepeatPassword.ForeColor = Color.Black;
            }
        }

        private void TextBoxRepeatPassword_Leave(object sender, EventArgs e)
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

        private void LabelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LabelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Red;
        }

        private void LabelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }

        private string getUniFromComboBox()
        {
            University selected = (University)universityComboBox.SelectedItem;
            return selected.ID.ToString();
        }

        private void ButtonCreateAccount_Click(object sender, EventArgs e)
        {
            //add new user

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`( `firstname`, `lastname`, `email`, `university`, `areaOfStudies`, `username`, `password`) VALUES (@fn, @ln, @email, @uni, @area, @usn, @pass) ", db.GetConnection());

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = textBoxFirstName.Text;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = textBoxLastName.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxEmail.Text;
            command.Parameters.Add("@uni", MySqlDbType.VarChar).Value = getUniFromComboBox();
            command.Parameters.Add("@area", MySqlDbType.VarChar).Value = (string) areaOfStudiesComboBox.SelectedItem;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBoxUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;

            //open connection to db

            db.OpenConnection();

            //check if text boxes contain defaul values
            if (!CheckTextBoxesValues()) {
                //check if password == confirm pasword
                if (textBoxPassword.Text.Equals(textBoxRepeatPassword.Text))
                {
                    //check if the username already exists
                    if (CheckUsername())
                    {
                        MessageBox.Show("This Username Already Exists, Select A Different One", "Duplicate username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //execute the query

                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Your Account Has Been Created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
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

            db.CloseConnection();
        }

        public Boolean CheckUsername()
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
        public Boolean CheckTextBoxesValues()
        {
            String fname = textBoxFirstName.Text;
            String lname = textBoxLastName.Text;
            String email = textBoxEmail.Text;
            String usn = textBoxUsername.Text;
            String pass = textBoxPassword.Text;
            University uni = (University)universityComboBox.SelectedValue;
            string areaOfStudies = areaOfStudiesComboBox.SelectedText;


            if (fname.Equals("first name") || lname.Equals("last name") || email.Equals("email adress") ||
                uni == noSelectedUniversity || areaOfStudies.Equals(" ") ||
                 usn.Equals("username") || pass.Equals("password"))
            {
                return true;
            }
            else
            {
                return false;
            } 
        }

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
