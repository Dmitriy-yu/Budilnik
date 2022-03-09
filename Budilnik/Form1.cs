using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Budilnik
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        bool b = false;
        SoundPlayer sp = new SoundPlayer(@"C:\Users\Долгорукий\Desktop\sample-3s.wav");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
            button2.Enabled= false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (b==false)
            {
                label2.Text = maskedTextBox1.Text;
                timer2.Start();
                maskedTextBox1.Visible = false;
                button1.Text = "Убрать будильник";
                b = true;
            }
            else if (b==true)
            {
                label2.Text = "00:00";
                maskedTextBox1.Visible = true;
                button1.Text = "Завести буильник";
                b = false;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (label1.Text==label2.Text+":00")
            {
                sp.PlayLooping();
                button2.Enabled = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            sp.Stop();
            button2.Enabled = false;
            maskedTextBox1.Text = "00:00";
            button1.Text = "Завести будильник";
            b = false;
        }
    }
}


           


            










                




          
           



           
            







