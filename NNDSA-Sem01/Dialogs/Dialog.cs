using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNDSA_Sem01
{
    public partial class Dialog : Form
    {
        public string ResultValue { get; set; }
        public Dialog(string title, string label)
        {
            InitializeComponent();
            this.Text = title;
            label1.Text = label;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResultValue = textBox1.Text;
            this.Close();
        }

        private void Dialog_Load(object sender, EventArgs e)
        {

        }
    }
}
