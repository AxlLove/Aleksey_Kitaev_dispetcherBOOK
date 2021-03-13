using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aleksey_Kitaev_dispetcherBOOK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            string[] substations = { "ТП-40", "ТП-69", "ТП-95", "ТП-660", "ТП-816", "ТП-816", "ТП-912", "ТП-395", "ТП-401", "ТП-460",
                "ТП-467", "ТП - 468", "ТП-469", "ТП - 477", "ТП - 672",
                "ТП - 717", "ТП - 729", "ТП - 825", "ТП - 879", "ТП - 892"};
            listBox1.Items.AddRange(substations);
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
         // substations.
        }
        void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  listBox1.Items[0]
            string selectedCountry = listBox1.SelectedItem.ToString();
            textBox1.Text = (selectedCountry);
        }
    }
}
