using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hanoka
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Start();
            

            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
           

            
            
        }
       



        private void timer2_Tick(object sender, EventArgs e)
        {
           
            pictureBox2.Visible = true;
            
            timer3.Start();

        }
      

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            
            timer4.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            
            timer5.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            
            timer6.Start();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            
            timer7.Start();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            pictureBox8.Visible = true;
            
            timer8.Start();
           
            
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

           
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();
            timer6.Stop();
            timer7.Stop();
            timer8.Stop();
            
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;

            if (pictureBox9.Visible == false)
            {
                timer2.Start();
                timer1.Stop();
            }

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

            }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox10.Visible == false)
            {
                pictureBox10.Visible = true;
                pictureBox5.Visible = false;
            }
            else
            {
                timer2.Start();
            }
         
        }
        }
       
        

  

   

    }
