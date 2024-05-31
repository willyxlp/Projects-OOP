using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;


namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
              button4.Visible = true;
               button3.Visible = false;
                listBox1.BorderStyle = BorderStyle.None;
                listBox1.ForeColor = Color.LightGray;
              listBox1.BackColor = Color.LightGray;
             powerlbl.ForeColor = Color.Purple;
            power_lbl.ForeColor = Color.White;



            int count = 0;
            if (textBox1.TextLength >= 15)
            {  
                count += 75;
            }
            else if (textBox1.TextLength >= 10 && textBox1.TextLength <= 14)
            { 
               count += 60;
            }
            else if (textBox1.TextLength >= 7 && textBox1.TextLength <= 9)
            {
                count += 40;
            }
            else if (textBox1.TextLength > 4)
            {
                count += 20;
                listBox1.Items.Add("password is too short");
            }
            else
            {
                count -= 100;
                listBox1.Items.Add("password is too short");
            }
            
            if (Regex.IsMatch(textBox1.Text, @"[a-zA-Z]")) 
            {  
                count += 15;
            }
            if (Regex.IsMatch(textBox1.Text, @"\d"))
            {
                count += 10;
            }

            if (Regex.IsMatch(textBox1.Text, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]"))
            {

                count += 15;
            }





            if (count >= 90)
            {
                power_lbl.ForeColor = Color.Green;
                power_lbl.Text = ("Very Strong");
                 
            }
            else if (count >= 75 && count <= 89) 
            {
                power_lbl.ForeColor = Color.DarkGreen;
                power_lbl.Text = ("Strong");
                 
            }
            else if (count >= 50 && count <= 74)
            {
                power_lbl.Text = ("Medium");
                power_lbl.ForeColor = Color.Orange;
            }
                 

            else if (count >= 25 && count <= 49)
            {
                power_lbl.ForeColor = Color.Red;
                power_lbl.Text = ("Weak");
                 
            }

            else
            {
                power_lbl.ForeColor = Color.DarkRed;
                power_lbl.Text = ("Very Weak");

            }
             

             


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit
                ();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
             panel2.BackColor = Color.White;
            textBox1.BorderStyle= BorderStyle.None;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            


        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.UseSystemPasswordChar = false;
             
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            textBox1.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.BackColor = Color.LightGray;
             panel2.BackColor = Color.LightGray;
             textBox1.BorderStyle = BorderStyle.FixedSingle;
            this.ActiveControl = null;
        }

        private void power_lbl_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.BackColor = Color.White;
             listBox1.ForeColor = Color.Purple;
              listBox1.BorderStyle = BorderStyle.FixedSingle;
             button3.Visible = true;
            button4.Visible = false;

            if (Regex.IsMatch(textBox1.Text, @"[a-zA-Z]") && Regex.IsMatch(textBox1.Text, @"\d") && Regex.IsMatch(textBox1.Text, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]") && textBox1.TextLength >= 7)
            {
                listBox1.Items.Add("Your Password dont have anny issues");
            }          
            else if (Regex.IsMatch(textBox1.Text, @"[a-zA-Z]") && Regex.IsMatch(textBox1.Text, @"\d"))
            {
                listBox1.Items.Add("Your password dont have any special character");
            }
            else if (Regex.IsMatch(textBox1.Text, @"[a-zA-Z]") && Regex.IsMatch(textBox1.Text, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]"))
            {
                listBox1.Items.Add("Your password dont have any number");
            }
            else if (Regex.IsMatch(textBox1.Text, @"\d") && Regex.IsMatch(textBox1.Text, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]"))
            {
                listBox1.Items.Add("your password dont have any letters");
            }
            else if (Regex.IsMatch(textBox1.Text, @"[a-zA-Z]"))
            {
                listBox1.Items.Add("Your password dont have any number");
                listBox1.Items.Add("Your password dont have any special character");
            }
            else if (Regex.IsMatch(textBox1.Text, @"\d"))
            {
                listBox1.Items.Add("your password dont have any letters");
                listBox1.Items.Add("Your password dont have any special character");
            }
            else if (Regex.IsMatch(textBox1.Text, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]"))
            {
                listBox1.Items.Add("your password dont have any letters");
                listBox1.Items.Add("Your password dont have any number");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
             button4.Visible = true;
               button3.Visible=false;
               listBox1.BorderStyle = BorderStyle.None;
              listBox1.ForeColor= Color.LightGray;
            listBox1.BackColor= Color.LightGray;        
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }
    }
}
