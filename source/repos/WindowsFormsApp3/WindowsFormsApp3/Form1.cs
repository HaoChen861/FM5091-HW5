using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Disable Rho until checked//
            Rho.Enabled = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void rho_TextChanged(object sender, EventArgs e)
        {
            
        }



        private void Reset_Click(object sender, EventArgs e)
        {
            result.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ATU_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BM_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PR_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Compute_Click(object sender, EventArgs e)
        {
            string text;
            if (!Add_Twelve.Checked && !Box_Muller.Checked && !Polar_Rejection.Checked)
            {
                MessageBox.Show("Please select a method.");
            }
            else
            {
                try
                {
                if (float.Parse(Rho.Text)>1 || float.Parse(Rho.Text) < -1)
                            {
                                MessageBox.Show("You have entered an invalid correlation.");
                            }
                else
                 {
                    if (Joint_checkBox.Checked)
                    {
                        string text1 = joint_dist_fun();
                        result.Text = text1 + '\n' + result.Text;
                    }
                    else
                    {
                        if (Add_Twelve.Checked)
                        {
                            text = Add_Twelve_fun().ToString();
                            result.Text = text + '\n' + result.Text;
                        }

                        if (Box_Muller.Checked)
                        {
                            var values = Box_Muller_fun();
                            text = values.Item1.ToString();
                            result.Text = text + "\n" + result.Text;
                        }

                        if (Polar_Rejection.Checked)
                        {
                            var values = Polar_Rejection_fun();
                            text = values.Item1.ToString();
                            result.Text = text + "\n" + result.Text;
                        }

                    }

                }

                }
                catch
                {
                    MessageBox.Show("You have entered an invalid correlation.");
                }

            }
            
          
               
            

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public double Add_Twelve_fun()
        {
            double randn=0;
            for (int i=0; i <= 12; i++ )
            {
                Random rnd = new Random();
                randn = randn + rnd.NextDouble();
            }
            randn = randn - 6;
            return randn;
        }
        /// <summary>
        /// Box Muller function, use two uni-random to create two normal random
        /// normal_1 = sqrt(-2*log(rand1))*cos(2*pi*rand2)
        /// normal_2 = sqrt(-2*log(rand1))*sin(2*pi*rand2)
        /// </summary>
        /// <returns>2 double random number</returns>
        public (double,double) Box_Muller_fun ()
        {
            
            Random rnd = new Random();
            double rand1 = rnd.NextDouble();
            double rand2 = rnd.NextDouble();
            double rand3 = Math.Sqrt(-2 * Math.Log(rand1)) * Math.Cos(2 * Math.PI * rand2);
            double rand4 = Math.Sqrt(-2 * Math.Log(rand1)) * Math.Sin(2 * Math.PI * rand2);
            return (rand3 , rand4);

        }
        /// <summary>
        /// Polar rejection function, use two uni-random to create two normal random
        /// w= rand1^2+rand2^2
        /// if w>1, redo
        /// c=sqrt(-2*ln(w)/w)
        /// normal_1=c*rand1
        /// normal_2=c*rand2
        /// </summary>
        /// <returns>2 double random number</returns>
        public (double,double) Polar_Rejection_fun()
        {
            Random rnd = new Random();
            double rand1 = rnd.NextDouble();
            double rand2 = rnd.NextDouble();
            double w = Math.Pow(rand1, 2) + Math.Pow(rand2, 2);

            while (w > 1 || w==0)
            {
                rand1 = rnd.NextDouble();
                rand2 = rnd.NextDouble();
                w = Math.Pow(rand1, 2) + Math.Pow(rand2, 2);
            }

            double c = Math.Sqrt(-2 * Math.Log(w) / w);
            double rand3 = c * rand1;
            double rand4 = c * rand2;
            return (rand3, rand4);
        }

        public string joint_dist_fun()
        {
            double rand1 = 0;
            double rand2 = 0;
            double rho_v = float.Parse(Rho.Text);
            
            if (Add_Twelve.Checked)
            {
                rand1 = Add_Twelve_fun();
                rand2 = Add_Twelve_fun();
            }
            if (Box_Muller.Checked)
            {
                var values = Box_Muller_fun();
                rand1 = values.Item1;
                rand2 = values.Item2;
            }
            if (Polar_Rejection.Checked)
            {
                var values = Polar_Rejection_fun();
                rand1 = values.Item1;
                rand2 = values.Item2;
            }
            rand2 = rho_v * rand1 + Math.Sqrt(1 - Math.Pow(rho_v, 2)) * rand2;
            string text = "First: " + Convert.ToString(rand1) + " Second: " + Convert.ToString(rand2);
            return text;
        }

        private void Joint_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            //Check to unlock, uncheck to lock//
            if (Joint_checkBox.Checked)
            {
                Rho.Enabled = true;
            }
            else
            {
                Rho.Enabled = false;
                //clear values//
                Rho.Text = "0";
            }
        }
    }
}
