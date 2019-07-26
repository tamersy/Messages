using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messages
{
    public partial class Messages : Form
    {
        public Messages()
        {
            InitializeComponent();
            comboBox1.Items.Add("Error");
            comboBox1.Items.Add("Information");
            comboBox1.Items.Add("Warning");
            comboBox1.Items.Add("Question");
            comboBox1.Items.Add("Exclamation");
            comboBox1.Items.Add("Stop");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Error")
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox1.Text == "Information")
            {
                MessageBox.Show("Information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBox1.Text == "Warning")
            {
                MessageBox.Show("Warning", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBox1.Text == "Question")
            {
                MessageBox.Show("Question", "Question", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (comboBox1.Text == "Exclamation")
            {
                MessageBox.Show("Exclamation", "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Stop", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
