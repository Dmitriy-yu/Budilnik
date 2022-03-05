﻿using System;
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
        Timer timer01=new Timer();
        SoundPlayer sp = new SoundPlayer("C:\\korotkaya-melodiya-veseloe-otkryitie-animirovannyiy-fonovyiy-zvuk-igryi-40627.wav");
        bool b = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            timer01.Interval = 1000;
            timer01.Tick += new EventHandler(timer1_Tick);
            timer01.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label1.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
            string  time = "";
            int h = DateTime.Now.Hour;
            if (h<0)
            {
                time += "0" + h;
            }
            else
            {
                time += h;
            }
            time += ":";

            int m = DateTime.Now.Minute;
            if (m<10)
            {
                time += "0" + m;
            }
            else
            {
                time += m;
            }
            time += ":";

            int s = DateTime.Now.Second;
            if (s < 10)
            {
               time += "0" + s;
            }
            else
            {
              time +=s;
            }
            label1.Text=time;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (b==false)
            {
                label2.Text = maskedTextBox1.Text;
                timer2.Start();
                maskedTextBox1.Visible = false;
                button1.Text = "Убрать будильник";
                b =true;

            }
            else if (b==true)
            {
                label2.Text = "00:00";
                timer2.Stop();
                maskedTextBox1.Visible = true;
                button1.Text = "Завеси будильник";
                
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (label1.Text==label2.Text+":00")
            {
                button2.Enabled = true;
                sp.Play();


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
    }
}
