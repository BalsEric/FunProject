using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using WMPLib;

namespace Question
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
            trollTimer.Enabled = false;
            label1.Visible = false;
            progressBar1.Visible = false;
            timer1.Enabled = false;
            
            label2.Text = "Waiting...";
            timer2.Enabled = false;
            label10.Visible = false;

        }
        int x1;
        int y1;
        Random x2 = new Random();
        Random y2 = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            player.URL = "Liviu Guta - Pe pat si pe covor - HIT 2016 (18).mp3";
            player.controls.play();
            player.settings.volume = 50;
            label1.Visible = true;
            progressBar1.Visible = true;
            timer1.Enabled = true;
            label2.Text = "Adding Spiderx64 C\\Windows32\\SpiderHax.x64...";
            


        }
        private void LabelSwitch(int r1)
        {
            label2.Enabled = true;
            Random r = new Random();
            if(progressBar1.Value<70)
                r1 = r.Next(1, 25);
            
            switch (r1)
            {
                case 1:
                    label2.Text = "C\\Windows32\\SpiderHax.x64\\Main...";
                    break;
                case 2:
                    label2.Text = "C\\Windows32\\SpiderHax.x64\\Main\\Data\\Pops...";
                    break;
                case 3:
                    label2.Text = "C\\Windows32\\SpiderHax.x64\\Main\\Data\\Local...";
                    break;
                case 4:
                    label2.Text = "C\\Windows32\\SpiderHax.x64\\Main\\hackSetup...";
                    break;
                case 5:
                    label2.Text = "C\\Windows32\\SpiderHax.x64\\Main\\BIOS...";
                    break;
                case 6:
                    label2.Text = "C\\Windows32\\SpiderHax.x64\\Register...";
                    break;
                case 7:
                    label2.Text = "C\\Windows32\\SpiderHax.x64\\Anti-virusBlock...";
                    break;
                case 8:
                    label2.Text = "C\\Windows32\\SpiderHax.x64\\Local2\\kayl2.exe";
                    break;
                case 9:
                    label2.Text = "C\\Windows32\\SpiderHax.x64\\Local2\\spider.xof";
                    break;
                case 10:
                    label2.Text = "C\\Windows32\\SpiderHax.x64\\Main\\pox.l2d";
                    break;
                case 11:
                    label2.Text = "C\\Windows32\\SpiderHax.x64\\Main\\SpiderSetup...";
                    break;
                case 12:
                    label2.Text = "C\\Windows32\\SpiderHax.x64\\Local\\Uninstall.exe";
                    break;
                case 13:
                    label2.Text = "C\\Windows32\\SpiderHax.x64\\Main\\READ-ME.txt";
                    break;
                case 14:
                    label2.Text = "C\\Windows32\\SpiderHax.x64\\Main\\DATA\\Pops\\Storage...";
                    break;
                case 15:
                    label2.Text = "C\\Windows32\\SpiderHax.x64\\Main\\Executive.rts";
                    break;
                case 16:
                    label2.Text = "C\\Windows32\\SpiderHax.x64\\Main\\Opx.dxd...";
                    break;
                case 17:
                    label2.Text = "C\\Windows32\\SpiderHax.x64\\Local2\\Raw.pxp";
                    break;
                case 18:
                    label2.Text = "C\\Windows32\\SpiderHax.x64\\Main...";
                    break;
                case 19:
                    label2.Text = "C\\Windows32\\SpiderHax.x64\\Main\\PersonalInfo\\Personal.txt";
                    break;
                case 20:
                    label2.Text = "C\\Windows32\\SpiderHax.x64\\Main\\Maervelous...";
                    break;
                case 21:
                    label2.Text = "C\\Windows32\\SpiderHax.x64\\Kilo.exe";
                    break;
                case 22:
                    label2.Text = "C\\Windows32\\SpiderHax.x64\\Retrieving Data...";
                    break;
                case 23:
                    label2.Text = "C\\Windows32\\SpiderHax.x64\\Maininting Data...";
                    break;
                case 24:
                    label2.Text = "C\\Windows32\\SpiderHax.x64\\Main...";
                    break;
         


            }
            if(progressBar1.Value>70)
            {
                r1++;
                switch (r1)
                {
                    case 25:
                        label2.Text = "C\\Documents\\Stealing...";
                        break;
                    case 26:
                        label2.Text = "C\\Documents\\Stealing InfoData...";
                        break;
                    case 27:
                        label2.Text = "Copying User Data..";
                        break;
                    case 28:
                        label2.Text = "Copying User Data..";
                        break;
                    case 29:
                        label2.Text = "Copying User Data..";
                        break;
                    case 30:
                        label2.Text = "Copying User Data..";
                        break;
                    case 31:
                        label2.Text = "Breaking Anti-virus";
                        break;
                    case 32:
                        label2.Text = "Breaking Anti-virus";
                        break;
                    case 33:
                        label2.Text = "Breaking Online Conection";
                        break;
                }
            }
            if(IsCompleted)
            {
                nr++;
                if(nr==20)
                {
                    IsCompleted = false;
                    timer1.Enabled = true;
                    timer2.Enabled = false;
                    
                }
            }
        }
        int t = 60;
        int r1=0;
        int nr = 0;
        private bool IsCompleted = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            // PROGRESS BAR
            t--;
           
            
            if (progressBar1.Value < 100 && !IsCompleted)
                progressBar1.Value += 1;
            else
                timer1.Enabled = false;
            if (progressBar1.Value == 8)
            {
                label2.Text = "Blocking Anti-virus...";
                progressBar1.Value = 17;
                timer1.Interval = 750;
                timer2.Enabled = true;
               
            }
            if(progressBar1.Value== 66)
            {
                timer2.Enabled = false;
                label2.Text = "Generating spiders...";
                r1 = 24;
                progressBar1.Value = 70;
                timer1.Interval = 800;
            }
            if (progressBar1.Value == 72)
            {
                timer2.Enabled = true;
                progressBar1.Value = 85;
                timer1.Interval = 650;

            }
            if (progressBar1.Value == 35)
            {

                progressBar1.Value = 45;
                timer1.Interval = 600;
            }
            if (progressBar1.Value == 95)
            {
                progressBar1.Value = 99;
                IsCompleted = true;
                timer1.Enabled = false;
                
            }
            if(progressBar1.Value==100)
            {
                label2.Text = "PC sucsessfully Spidered";
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
            
            if (t == 0)
                timer1.Enabled = false;
        }
        int q = 10000;

        private void timer2_Tick(object sender, EventArgs e)
        {
            q--;
            LabelSwitch(r1++);
            if (q == 0)
                timer2.Enabled = false;
        }

        
        private void Mail()
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential("balseric7@gmail.com",
               "qaqmlyrixfdzvyvy");

            smtp.Send("balseric7@gmail.com", textBox2.Text,
               "SpiderHax Team", "Dear "+textBox2.Text +"," + "We THANK you for trying our first app.Love");
            textBox2.Visible = false;
            button2.Visible = false;
            label4.Visible = false;
            label7.Visible = false;
            label10.Visible = true;


        }
        private bool CheckMail(string c)
        {
            for (int l = 0; l < c.Length; l++)
                if (c[l].ToString() == "@" )
                    if((c[l+1].ToString()=="g" && c[l + 2].ToString() == "m" && c[l + 3].ToString() == "a" && c[l + 4].ToString() == "i" && c[l + 5].ToString() == "l" && c[l + 6].ToString() == "." && c[l + 7].ToString() == "c" && c[l + 8].ToString() == "o" && c[l + 9].ToString() == "m") || (c[l + 1].ToString() == "y" && c[l + 2].ToString() == "a" && c[l + 3].ToString() == "h" && c[l + 4].ToString() == "o" && c[l + 5].ToString() == "o" && c[l + 6].ToString() == "." && c[l + 7].ToString() == "c" && c[l + 8].ToString() == "o" && c[l + 9].ToString() == "m"))
                         return true;
            return false;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && CheckMail(textBox2.Text))
                Mail();
            else
                MessageBox.Show("You must include a valid e-mail");
        }

        

        

       

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            label9.Text = (int.Parse(label9.Text) - 1).ToString();
            if (int.Parse(label9.Text) < 0)
                label9.Text = 0.ToString();
            player.settings.volume = int.Parse(label9.Text);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            label9.Text = (int.Parse(label9.Text) + 1).ToString();
            if (int.Parse(label9.Text) > 100)
                label9.Text = 100.ToString();
            player.settings.volume = int.Parse(label9.Text);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackBar1.Value;
        }
        int l = 1000;
        int troll;
        Random r = new Random();
        private void trollTimer_Tick(object sender, EventArgs e)
        {
            l--;
            troll = r.Next(1, 8);
            switch(troll)
            {
                case 1:
                    x1 = x2.Next(10, 1900);
                    y1 = y2.Next(10, 1100);
                    break;
                case 2:
                    x1 = x2.Next(10, 1900);
                    y1 = y2.Next(10, 200);
                    break;
                case 3:
                    x1 = x2.Next(10, 200);
                    y1 = y2.Next(10, 1100);
                    break;
                case 4:
                    x1 = x2.Next(500, 1200);
                    y1 = y2.Next(10, 1100);
                    break;
                case 5:
                    x1 = x2.Next(10, 1900);
                    y1 = y2.Next(400, 800);
                    break;
                case 6:
                    x1 = x2.Next(300, 1300);
                    y1 = y2.Next(200, 600);
                    break;
                case 7:
                    x1 = x2.Next(800,1000);
                    y1 = y2.Next(100, 500);
                    break;

            }
            Form1 f1 = new Form1();
            this.SetDesktopLocation(x1, y1);
            
            timer1.Enabled = false;
            progressBar1.Value = 99;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            trollTimer.Enabled = true;
            
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            trollTimer.Enabled = true;
        }

        

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Orange;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.DarkGray;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightPink;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
        }
    }
}
