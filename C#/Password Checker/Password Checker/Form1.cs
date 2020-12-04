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
        private void Password_One_Click(object sender, EventArgs e)
        {
            Password_One.SelectAll();
        }

        private void Password_Two_Click(object sender, EventArgs e)
        {
            Password_two.SelectAll();
        }

        private void Password_One_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Password_One.TextLength <= 0 || Password_One.Text == null)
                {
                    Zxcvbn.Core.EvaluatePassword(AOORE);
                    Password_One.Text = AOORE;
                    Password_One.SelectAll();
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
                Warning_one.Text = "Warning: " + Passwd_One.Feedback.Warning;
                Suggestion_one.Text = "Suggestions: " + Passwd_One.Feedback.Suggestions[0];
                Crack_Time_one.Text = "Crack Time: " + Passwd_One.CrackTimeDisplay.OnlineNoThrottling10PerSecond;
                Compare_Passwd();
            }
            finally
            {
                if (Password_One.TextLength <= 0 || Password_One.Text == null)
                {
                    Zxcvbn.Core.EvaluatePassword(AOORE);
                    Password_One.Text = AOORE;
                    Password_One.SelectAll();
                }
            }
        }

        private void Password_two_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Password_two.TextLength <= 0 || Password_two.Text == null)
                {
                    Zxcvbn.Core.EvaluatePassword(AOORE);
                    Password_two.Text = AOORE;
                    Password_two.SelectAll();
                }

                var Passwd_two = Zxcvbn.Core.EvaluatePassword(Password_two.Text);

                switch (Passwd_two.Score)
                {
                    case 0:
                        Result_two.Text = "Very Weak";
                        Result_two.ForeColor = Color.Red;
                        Result_two.BackColor = Color.White;
                        break;
                    case 1:
                        Result_two.Text = "Weak";
                        Result_two.ForeColor = Color.Orange;
                        Result_two.BackColor = Color.White;
                        break;
                    case 2:
                        Result_two.Text = "Good";
                        Result_two.ForeColor = Color.Yellow;
                        Result_two.BackColor = Color.DarkKhaki;
                        break;
                    case 3:
                        Result_two.Text = "Strong";
                        Result_two.ForeColor = Color.Blue;
                        Result_two.BackColor = Color.White;
                        break;
                    case 4:
                        Result_two.Text = "Very Strong";
                        Result_two.ForeColor = Color.Green;
                        Result_two.BackColor = Color.White;
                        break;
                }

                Guesses_two.Text = "Guesses: " + Passwd_two.Guesses.ToString();
                Warning_two.Text = "Warning: " + Passwd_two.Feedback.Warning;
                Suggestion_two.Text = "Suggestions: " + Passwd_two.Feedback.Suggestions[0];
                Crack_Time_two.Text = "Crack Time: " + Passwd_two.CrackTimeDisplay.OnlineNoThrottling10PerSecond;
                Compare_Passwd();
            }
            finally
            {
                if (Password_two.TextLength <= 0 || Password_two.Text == null)
                {
                    Zxcvbn.Core.EvaluatePassword(AOORE);
                    Password_two.Text = AOORE;
                    Password_two.SelectAll();
                }
            }
        }

        public void Compare_Passwd()
        {
            var Passwd_one = Zxcvbn.Core.EvaluatePassword(Password_One.Text);
            var Passwd_two = Zxcvbn.Core.EvaluatePassword(Password_two.Text);
            if (Passwd_one.Score == Passwd_two.Score && Passwd_one.CrackTime.OnlineNoThrottling10PerSecond == Passwd_two.CrackTime.OnlineNoThrottling10PerSecond)
            {
                Comp_one.Text = "Same";
                Comp_one.ForeColor = Color.Yellow;
                Comp_one.BackColor = Color.DarkKhaki;
                Comp_two.Text = "Same";
                Comp_two.ForeColor = Color.Yellow;
                Comp_two.BackColor = Color.DarkKhaki;
            }
            else if (Passwd_one.Score >= Passwd_two.Score && Passwd_one.CrackTime.OnlineNoThrottling10PerSecond >= Passwd_two.CrackTime.OnlineNoThrottling10PerSecond)
            {
                Comp_one.Text = "Stronger";
                Comp_one.ForeColor = Color.Green;
                Comp_one.BackColor = Color.White;
                Comp_two.Text = "Weaker";
                Comp_two.ForeColor = Color.Red;
                Comp_two.BackColor = Color.White;
            }
            else if (Passwd_one.Score <= Passwd_two.Score && Passwd_one.CrackTime.OnlineNoThrottling10PerSecond <= Passwd_two.CrackTime.OnlineNoThrottling10PerSecond)
            {
                Comp_one.Text = "Weaker";
                Comp_one.ForeColor = Color.Red;
                Comp_one.BackColor = Color.White;
                Comp_two.Text = "Stronger";
                Comp_two.ForeColor = Color.Green;
                Comp_two.BackColor = Color.White;
            }
        }
    }
}
