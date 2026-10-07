using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace haye
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String food1, food2;
            double price,price2, fullinfo;
            food1 = txtfood.Text;
            food2=txtfoood2.Text;
            price2=double.Parse(txtprice2.Text);
            price=double.Parse(txtprice.Text);
            fullinfo = price + price2;
            //lbloutput.Text = fullinfo;
            

             

            

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String food1, food2;
            double price, price2, fullinfo;
            food1 = txtfood.Text;
            food2 = txtfoood2.Text;
            price2 = double.Parse(txtprice2.Text);
            price = double.Parse(txtprice.Text);
            fullinfo = price + price2;
            lbloutput.Text = fullinfo;

        }
    }
}
