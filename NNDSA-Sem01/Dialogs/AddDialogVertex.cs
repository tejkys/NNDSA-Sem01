using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NNDSA_Sem01.Rail;
using static NNDSA_Sem01.Graph<NNDSA_Sem01.Rail.RailStop, NNDSA_Sem01.Rail.Rail>;

namespace NNDSA_Sem01
{
    public partial class AddDialogVertex : Form
    {
        public RailStop? ResultValue { get; set; }
        public AddDialogVertex()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxVertexName.Text)) {
                MessageBox.Show("Name cannot be empty!", "Validation");
                return;
            }

            ResultValue = new RailStop() { Name = textBoxVertexName.Text };
            this.Close();
        }
    }
}
