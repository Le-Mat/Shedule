using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shedule
{
    public partial class Registration : Form
    {
        int numIter;
        int counter;
        string[] groups   = new string[1000];
        string[] days     = new string[7] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
        string[] cabinets = new string[1000];
        string[] teachers = new string[1000];
        string[] lessons  = new string[1000];
        bool groupActive = true;
        bool daysActive = false;
        bool cabinetsActive = false;
        bool teachersActive = false;
        bool lessonActive = false  ;
        public Registration()
        {
            InitializeComponent();
        }

        private void titleButton_Click(object sender, EventArgs e)
        {
            numIter = Convert.ToInt32(titleBox.Text);
            counter = numIter;
            counterLabel.Text = "Осталось " + numIter; 
            if (groupActive) 
            {
                titleBox.Visible = false;
                titleButton.Visible = false;
                titleLabel.Visible = false;
                continueButton.Visible = false;
            }
            else if(daysActive )
            {
                titleBox.Visible = false;
                titleButton.Visible = false;
                titleLabel.Visible = false;
                continueButton.Visible = false;

            }
            else if(cabinetsActive)
            {

            }
            else if (teachersActive)
            {
            }
            else if (lessonActive)
            {

            }
            else
            { 
            
            }
            
            
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if(groupActive)
            {
                groups[numIter - counter] = textBox1.Text;
            }
            else if (daysActive) 
            {

            }
            else if (cabinetsActive)
            {

            }
            else if (teachersActive)
            {

            }
            else if (lessonActive)
            {

            }

            counter--;
            counterLabel.Text = "Осталось " + counter;
            if(counter == 0)
            {
                Save.Visible = false;
                continueButton.Visible = true;
            }
        }
    }
}
