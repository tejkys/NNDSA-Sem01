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
    public partial class FindPathDialog : Form
    {
        private readonly Graph<RailStop, Rail.Rail> _graph;
        private readonly RailGraphTools _graphTools;
        public FindPathDialog(Graph<RailStop, Rail.Rail> graph)
        {
            InitializeComponent();
            _graph = graph;
            _graphTools = new RailGraphTools(_graph);
            comboBoxStartPoint.Items.AddRange(graph.GetVertexes().ToArray());
            comboBoxEndPoint.Items.AddRange(graph.GetVertexes().ToArray());
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            if (comboBoxStartPoint.SelectedItem == null || comboBoxEndPoint.SelectedItem == null)
            {
                MessageBox.Show("Start and end vertexes must be selected!", "Validation");
            }
            else
            {
                textBox1.Text = string.Empty;
                var path = _graphTools.FindPath((RailStop)comboBoxStartPoint.SelectedItem, (double)numericUpDownTrainLength.Value);

                var endPoint = (RailStop)comboBoxEndPoint.SelectedItem;
                List<string> resultMessage = new();
                double totalDistance = path.Distances[endPoint];
                while (endPoint != null)
                {
                    var distance = path.Distances[endPoint] -
                               (path.Previous[endPoint] is null ? 0 : path.Distances[path.Previous[endPoint]]);
                    
                    resultMessage.Add($"Go to {endPoint.Name} with distance: +{distance}");
                    var maneuverKey = path.Maneuvers.Keys.FirstOrDefault(k => k.Item1.Equals(path.Previous[endPoint]) && k.Item2.Equals(endPoint));
                    if (maneuverKey is not null)
                    {
                        var maneuver = path.Maneuvers[maneuverKey];
                        if (maneuver is not null)
                        {
                            resultMessage.Add($"==Evading distance: +{(double)numericUpDownTrainLength.Value}==");
                            totalDistance += (double)numericUpDownTrainLength.Value;
                            for (var i = maneuver.Edges.Count - 1; i >= 0; i--)
                            {
                                resultMessage.Add($"Evading into rail {maneuver.Edges[i].Name}");

                            }
                            
                        }
                    }
                    endPoint = path.Previous[endPoint];
                }
                resultMessage.Add($"===Total distance: {totalDistance}===");
                for (var i = resultMessage.Count - 1; i >= 0; i--)
                {
                    textBox1.Text += resultMessage[i] + Environment.NewLine;
                }
            }
        }
    }
}
