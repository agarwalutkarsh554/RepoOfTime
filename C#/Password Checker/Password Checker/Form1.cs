using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Checker
{
    public partial class Form1 : Form
    {
        readonly string AOORE = "Enter Password Here";

        public Form1()
        {
            InitializeComponent();
        }

        private void Password_One_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Password_One.TextLength <= 0 || Password_One.Text == null)
                {
                    Zxcvbn.Core.EvaluatePassword(AOORE);
                    Password_One.Text = AOORE;
                }
                
                var Passwd_One = Zxcvbn.Core.EvaluatePassword(Password_One.Text);
                
                switch (Passwd_One.Score)
                {
                    case 0:
                        Result_one.Text = "Very Weak";
                        Result_one.ForeColor = Color.Red;
                        Result_one.BackColor = Color.White;
                        break;
                    case 1:
                        Result_one.Text = "Weak";
                        Result_one.ForeColor = Color.Orange;
                        Result_one.BackColor = Color.White;
                        break;
                    case 2:
                        Result_one.Text = "Good";
                        Result_one.ForeColor = Color.Yellow;
                        Result_one.BackColor = Color.DarkKhaki;
                        break;
                    case 3:
                        Result_one.Text = "Strong";
                        Result_one.ForeColor = Color.Blue;
                        Result_one.BackColor = Color.White;
                        break;
                    case 4:
                        Result_one.Text = "Very Strong";
                        Result_one.ForeColor = Color.Green;
                        Result_one.BackColor = Color.White;
                        break;
                }

                Guesses_one.Text = "Guesses: " + Passwd_One.Guesses.ToString();
            }
            finally
            {
                if (Password_One.TextLength <= 0 || Password_One.Text == null)
                {
                    Zxcvbn.Core.EvaluatePassword(AOORE);
                    Password_One.Text = AOORE;
                }
            }
        }
    }
}
