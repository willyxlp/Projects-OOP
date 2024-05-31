using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace profit_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label_SUM_Click(object sender, EventArgs e)
        {

        }

        private void label_ID_Click(object sender, EventArgs e)
        {

        }

 
        private void button1_Click_1(object sender, EventArgs e)
        {
            Product p1 = new Product(txtname.Text,Convert.ToInt32(txtquantity.Text), Convert.ToDouble(txtprice.Text), Convert.ToDouble(txtprofit.Text));
                string id = p1.GetId();
                label_ID.Text = id;
                label_SUM.Text = p1.GetSum();
                lbl_profit.Text = p1.GetProfit();


            panel_ID.Visible = true;
            Panel_sum.Visible = true;
            panel_profit.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            labelpft.Visible = true;
            label_ID.Visible = true;
            label_SUM.Visible = true;
            lbl_profit.Visible=true;


            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}