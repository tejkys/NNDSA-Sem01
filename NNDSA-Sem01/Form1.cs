using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using System.Xml.Linq;
using NNDSA_Sem01.Rail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NNDSA_Sem01
{
    public partial class Form1 : Form
    {
        private Graph<RailStop, Rail.Rail> _graph = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonVertexRemove_Click(object sender, EventArgs e)
        {
            if (listBoxVertexes.SelectedItem != null)
            {
                _graph.RemoveVertex(listBoxVertexes.SelectedItem as RailStop);
                RefreshData();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonEdgeFind_Click(object sender, EventArgs e)
        {
            var InputDialog = new Dialog("Find Edge", "Enter the edge to find");
            if (InputDialog.ShowDialog() == DialogResult.OK)
            {
                string result = InputDialog.ResultValue;
            }
        }

        private void buttonVertexFind_Click(object sender, EventArgs e)
        {
            var InputDialog = new Dialog("Find Vertex", "Enter the vertex to find");
            if (InputDialog.ShowDialog() == DialogResult.OK)
            {
                string result = InputDialog.ResultValue;
                _graph.GetVertexes().ForEach(v =>
                {
                    if (v.Name == result)
                        listBoxVertexes.SelectedItem = v;
                });
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void buttonEdgeAdd_Click(object sender, EventArgs e)
        {
            var addEdgeDialog = new AddDialogEdge(_graph);
            if (addEdgeDialog.ShowDialog() == DialogResult.OK && addEdgeDialog.ResultValue != null)
            {
                if (_graph.FindVertex(addEdgeDialog.ResultValue.Id) is null)
                {
                    _graph.InsertEdge(addEdgeDialog.ResultValue, addEdgeDialog.StartPoint, addEdgeDialog.EndPoint);
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("Name already exists!", "Validation");
                }
            }
        }

        private void buttonVertexAdd_Click(object sender, EventArgs e)
        {
            var addVertexDialog = new AddDialogVertex();
            if (addVertexDialog.ShowDialog() == DialogResult.OK && addVertexDialog.ResultValue is not null)
            {
                if (_graph.FindVertex(addVertexDialog.ResultValue.Id) is null)
                {
                    _graph.InsertVertex(addVertexDialog.ResultValue);
                    listBoxVertexes.Items.Add(addVertexDialog.ResultValue);
                }
                else
                {
                    MessageBox.Show("Name already exists!", "Validation");
                }

            }
        }

        private void buttonEdgeRemove_Click(object sender, EventArgs e)
        {
            if (listBoxEdges.SelectedItem != null)
            {
                _graph.RemoveEdge(listBoxEdges.SelectedItem as Rail.Rail);
                RefreshData();
            }
        }

        private void Form1_Load_2(object sender, EventArgs e)
        {

        }
        private void RefreshData()
        {
            listBoxVertexes.Items.Clear();
            listBoxEdges.Items.Clear();
            _graph.GetVertexes().ForEach(v => listBoxVertexes.Items.Add(v));
            _graph.GetEdges().ForEach(e => listBoxEdges.Items.Add(e));
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog
                {
                    Title = "Browse Xml Files",

                    CheckFileExists = true,
                    CheckPathExists = true,

                    DefaultExt = "xml",
                    Filter = "xml files (*.xml)|*.xml",
                    FilterIndex = 2,
                    RestoreDirectory = true,
                };
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var file = openFileDialog1.FileName;
                    var content = File.ReadAllText(file);
                    var graphFile = (Graph<RailStop, Rail.Rail>)Persistence.Deserialize(content, typeof(Graph<RailStop, Rail.Rail>));

                    _graph = new Graph<RailStop, Rail.Rail>();
                    foreach (var vertex in graphFile.GetVertexes())
                    {
                        _graph.InsertVertex(vertex);
                    }
                    foreach (var edge in graphFile.GetEdges())
                    {
                        _graph.InsertEdge(edge, graphFile.GetEdgeStartVertex(edge), graphFile.GetEdgeEndVertex(edge));
                    }
                    RefreshData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deserialization went wrong: " + ex.Message);
            }
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog()
                {
                    Title = "Save graph to Xml",
                    DefaultExt = "xml",
                    Filter = "xml files (*.xml)|*.xml",
                    FilterIndex = 2,
                    RestoreDirectory = true,
                    CheckFileExists = false,
                    CheckPathExists = true,
                };

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var file = saveFileDialog1.FileName;
                    File.WriteAllText(file, Persistence.Serialize(_graph));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Serialization went wrong: " + ex.Message);
            }
        }

        private void listBoxVertexes_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxEdges.SelectedItem = null;
            propertyGrid1.SelectedObject = listBoxVertexes.SelectedItem;
        }
        private void listBoxEdges_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxVertexes.SelectedItem = null;
            propertyGrid1.SelectedObject = listBoxEdges.SelectedItem;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var findPathDialog = new FindPathDialog(_graph);
            findPathDialog.ShowDialog();
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }
    }
}