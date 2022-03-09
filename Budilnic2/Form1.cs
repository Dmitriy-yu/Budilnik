using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budilnic2
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
         string t= string.Empty;
        SoundPlayer sp = new SoundPlayer(@"C:\Users\Долгорукий\Desktop\sample-3s.wav");
        SoundPlayer sp2 = new SoundPlayer(@"C:\Users\Долгорукий\Desktop\korotkaya-melodiya-veseloe-otkryitie-animirovannyiy-fonovyiy-zvuk-igryi-40627.wav");
        Random rnd = new Random();
        bool b = false;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
            label3.Text = DateTime.Now.Day.ToString("00")+"."+DateTime.Now.Month.ToString("00")+"."+DateTime.Now.Year.ToString("00")+" г.";
            timer3.Interval = 1000;
            timer3.Start();
          
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            string timer01 = "";
            int h = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;
            int s = DateTime.Now.Second;
            if (h < 10)
            {
                timer01 += "0" + h;

            }
            else
            {
                timer01 += h;
            }

            timer01 += ":";  
            if (m < 10)
            {
                timer01 += "0" + m;

            }
            else
            {
                timer01 += m;
            }

            timer01 += ":";
            if(t==string.Empty)
            {
                t = "t";
            }
            else 
            {
                t = string.Empty;
            }
            label1.Text = t;
            if (s < 10)
            {
                timer01 += "0" + s;

            }
            else
            {
                timer01 += s;
            }
            label1.Text = timer01;
            //if (t == string.Empty)моргающий циферблат с часами
            //    t = label1.Text;
            //else
            //    t = string.Empty;

            //label1.Text =t;
            
     
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (b == false)
            {
                label2.Text = maskedTextBox1.Text;
                timer2.Start();
                maskedTextBox1.Visible = false;
                button1.Text = "Убрать будильник";
                b = true;
                this.button1.BackColor = Color.Red;
                maskedTextBox1.Text = "00:00";
            }

            else if (b==true)
            {
                label2.Text = "00:00";
                timer2.Stop();
                maskedTextBox1.Visible = true;
                button1.Text = "Завести будильник";
                b  = false;
                this.button1.BackColor = Color.Yellow;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (label1.Text==label2.Text+":00")
            {
                button2.Enabled = true;
                sp2.PlayLooping();
              
                this.button2.BackColor = Color.Green;
            }
               
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            sp.Stop();
            button2.Enabled = false;
            maskedTextBox1.Visible = true;
            button1.Text = "Завести будильник";
            b = false;
        }
       
        private async void timer3_Tick_1(object sender, EventArgs e)
        {
          Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

           listBox1.BackColor = randomColor;
        }

    }
}
         
          
                
                
                
          

               
            
          
           
          
            
            
            
           
            




            

           
            
            


                

          


        
            
            
            

            






            





