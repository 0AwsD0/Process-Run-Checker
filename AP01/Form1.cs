using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP01
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Process window display
        void processlist()
        {

            Process[] processlist = Process.GetProcesses();

            foreach (Process theprocess in processlist)
            {
                //label7.Text = "Process:"+theprocess.ProcessName+theprocess.Id;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            processlist();
        }

        bool time = true;
        string processName = "";

        //Time display and freeze
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time == true)
            {
                LastTimeSeen.Text = DateTime.Now.ToString("HH:mm:ss");
            }
        }

        //Process checker
        private void timer2_Tick(object sender, EventArgs e)
        {

            Process[] TargetProcessName = Process.GetProcessesByName(processName);

            if (TargetProcessName.Length > 0)
            {
                label4.Text = "Working";
                label4.ForeColor = Color.FromArgb(45, 181, 95);
                time = true;
                control = true;
            }
            else
            {
                label4.Text = "Not working";
                label4.ForeColor = Color.FromArgb(255, 0, 0);
                time = false;
                if (EnableAllerts.Checked == true && control == true)
                {
                    control_f();
                }
            }

            if (processName.Length < 0)
            {
                label3.Text = "NONE";
            }
            else
            {
                label3.Text = processName;
            }
            processlist();
        }

        //checkbox for ms windows sound alert
        bool checkbox = false;
        bool control = false;

        private void control_f()
        {
            control = false;
            System.Media.SystemSounds.Beep.Play();
        }

        private void EnableAllerts_CheckedChanged(object sender, EventArgs e)
        {
            if (EnableAllerts.Checked)
            {
                checkbox = true;
            }
            else if (EnableAllerts.Checked == false)
            {
                checkbox = false;
            }
        }


        //Draging window -start
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        //Draging window -stop
        private void LastTimeSeen_MouseHover(object sender, EventArgs e)
        {
            LastTimeSeen.BackColor = Color.FromArgb(9,18,28);
        }

        private void LastTimeSeen_MouseLeave(object sender, EventArgs e)
        {
            LastTimeSeen.BackColor = Color.FromArgb(45,50,59);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


        //processName assign

        private void ProcessNameSave_Click(object sender, EventArgs e)
        {
            processName = textBox1.Text;
        }

    }
}
