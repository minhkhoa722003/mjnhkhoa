using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            errorProvider1=new ErrorProvider();
            errorProvider2=new ErrorProvider();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
           
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox4.Text);
            int b = Convert.ToInt32(textBox6.Text);
            int kq = a + b;
            textBox7.Text = kq.ToString();
        }

        
        
        private void button10_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox4.Text);
            int b = Convert.ToInt32(textBox6.Text);
            int kq = a - b;
            textBox7.Text = kq.ToString();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox4.Text);
            int b = Convert.ToInt32(textBox6.Text);
            int kq = a * b;
            textBox7.Text = kq.ToString();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            float a = Convert.ToInt32(textBox4.Text);
            float b = Convert.ToInt32(textBox6.Text);
            if(b==0)
            {
                errorProvider2.SetError(textBox7, "Vui lòng nhập số lớn hơn 0 !");
            }
            float kq = a / b;
            textBox7.Text = kq.ToString();
        }


        

        
    }
}
