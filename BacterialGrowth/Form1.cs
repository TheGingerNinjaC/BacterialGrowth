using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BacterialGrowth
{
    public partial class growthCalcForm : Form
    {
        public growthCalcForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Variables
            double startBacteria;
            double newBacteria;
            int daysDouble;
            int count = 0;
            double t = 1;

            // Get the starting bacteria
            if (double.TryParse(bacteriaTextBox.Text, out startBacteria))
            {
                // Get the days it takes to double
                if (int.TryParse(daysTextBox.Text, out daysDouble))
                {
                    // Output for 10 days
                    while (t <= 10)
                    {

                        // Calculate daily growth
                        newBacteria = startBacteria * Math.Pow(2, (t / daysDouble));
                        
                        // Add one to the days counter and counter
                        t++;
                        count++;

                        // Display this day's growth
                        outputListBox.Items.Add(count.ToString() + "\t\t\t" + newBacteria.ToString("N0"));
                    }
                }
                else
                {
                    // Invalid number of days
                    MessageBox.Show("Invalid value for days.");
                }
            }
            else
            {
                // Invalid value for starting bacteria
                MessageBox.Show("Invalid value for starting bacteria.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the text boxes and list box
            bacteriaTextBox.Text = "";
            daysTextBox.Text = "";
            outputListBox.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
