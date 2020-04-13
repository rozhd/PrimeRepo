using PrimeServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            PrimeService primeService = new PrimeService();

            try
            {
                int num = int.Parse(tbNum.Text);

                if (num < 2 || num > int.MaxValue)
                {
                    throw new Exception();
                }
                
                var result = primeService.IsPrime(num);

                if (result)
                {
                    lblAns.ForeColor = Color.Green;
                    lblAns.Text = "Yes";
                }

                else
                {
                    lblAns.ForeColor = Color.Red;
                    lblAns.Text = "No";
                }
                
            }
           
            catch (Exception)
            {

                MessageBox.Show("Write correct data!");
            }
            
            
                
        }

        private void lblAns_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
