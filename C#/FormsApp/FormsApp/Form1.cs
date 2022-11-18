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

namespace FormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void CalculateBTN_Click(object sender, EventArgs e)
        {
            int test1 = int.Parse(this.MsWord.Text);
            int test2 = int.Parse(this.MsExcel.Text);
            int test3 = int.Parse(this.MsAccess.Text);
            int test4 = int.Parse(this.MsPowerPoint.Text);
            double average = Convert.ToDouble((test1 + test2 + test3 + test4)) / 3.0;
            this.AverageResult.Text = average.ToString("n1");
            int total = int.Parse(this.MsWord.Text) + int.Parse(this.MsExcel.Text) + int.Parse(this.MsAccess.Text) + int.Parse(this.MsPowerPoint.Text);
            this.TotalResult.Text = total.ToString();
            if (average >= 75.0 & average <= 85.0)
            {
                this.GradeResult.Text = "A";
            }
            else
            {
                if (average >= 65.0 & average <= 75.0)
                {
                    this.GradeResult.Text = "C";
                }
                else
                {
                    if (average >= 55.0 & average <= 65.0)
                    {
                        this.GradeResult.Text = "S";
                    }
                    else
                    {
                        if (average <= 55.0)
                        {
                            this.GradeResult.Text = "Fail";
                        }
                    }
                }
            }
            if (average >= 50.0 & average <= 85.0)
            {
                this.CompetentResult.Text = "Yes";
            }
            if (average <= 50.0)
            {
                this.CompetentResult.Text = "No";
            }
        }
        private void ClearBTN_Click(object sender, EventArgs e)
        {
            this.Name.Text = null;
            this.MsWord.Text = null;
            this.MsExcel.Text = null;
            this.MsAccess.Text = null;
            this.MsPowerPoint.Text = null;
            this.TotalResult.Text = null;
            this.AverageResult.Text = null;
            this.CompetentResult.Text = null;
            this.GradeResult.Text = null;
        }
        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/pubuduprasad");
        }
    }
}
