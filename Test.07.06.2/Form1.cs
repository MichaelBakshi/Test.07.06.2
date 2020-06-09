using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test._07._06._2
{
    public partial class Form1 : Form
    {

        const int interval = 100;
        int upperBorder = 100;
        int percent = 1;
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            //Task.Run(() =>
            //{
                while (percent <= upperBorder)
                {
                    progressBar.Value++;
                    ProgressLbl.Text = percent.ToString()+"%";
                    Thread.Sleep(interval);
                    percent++;
                    
                }

            //});

            

        }

        private void TerminateBtn_Click(object sender, EventArgs e)
        {
            progressBar.MarqueeAnimationSpeed = 0;
        }
    }
}
