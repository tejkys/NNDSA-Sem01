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

namespace NNDSA_Sem01
{
    public partial class AddDialogEdge : Form
    {
        public Rail.Rail? ResultValue { get; set; }
        public RailStop StartPoint { get; set; }
        public RailStop EndPoint { get; set; }


        public AddDialogEdge(Graph<RailStop, Rail.Rail> graph)
        {
            InitializeComponent();
            comboBoxEdgeStart.Items.AddRange(graph.GetVertexes().ToArray());
            comboBoxEdgeEnd.Items.AddRange(graph.GetVertexes().ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxEdgeEnd.SelectedItem == null || comboBoxEdgeStart.SelectedItem == null || string.IsNullOrEmpty(textBoxEdgeName.Text))
            {
                MessageBox.Show("Start and end vertexes must be selected and name have not to be omitted!", "Validation");
                return;
            }

            StartPoint = comboBoxEdgeStart.SelectedItem as RailStop;
            EndPoint = comboBoxEdgeEnd.SelectedItem as RailStop;
            ResultValue = new()
            {
                Name = textBoxEdgeName.Text,

                Length = (double)numericUpDownEdgeDistance.Value,

                Blocked = comboBoxBlocked.SelectedIndex != 0,
                
                StartFreeSpace = (double)numericUpDownFreeSpaceStart.Value,
                EndFreeSpace = (double)numericUpDownFreeSpaceEnd.Value,

                Type = comboBoxEdgeSwitching.SelectedIndex switch
                {
                    0 => Rail.TrailType.Normal,
                    1 => Rail.TrailType.Switching,
                    _ => Rail.TrailType.Normal
                }

            };
            this.Close();
        }

        private void AddDialogEdge_Load(object sender, EventArgs e)
        {
            comboBoxEdgeSwitching.SelectedIndex = 0;
            comboBoxBlocked.SelectedIndex = 0;
        }

        private void comboBoxBlocked_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBoxBlockingState.Enabled = comboBoxBlocked.SelectedIndex != 0;
        }
    }
}
