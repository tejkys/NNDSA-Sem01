namespace NNDSA_Sem01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listBoxVertexes = new ListBox();
            listBoxEdges = new ListBox();
            groupBox1 = new GroupBox();
            buttonEdgeFind = new Button();
            buttonEdgeAdd = new Button();
            buttonEdgeRemove = new Button();
            Vertexes = new GroupBox();
            buttonVertexFind = new Button();
            buttonVertexRemove = new Button();
            buttonVertexAdd = new Button();
            toolStrip1 = new ToolStrip();
            toolStripButtonFindPath = new ToolStripButton();
            toolStripButtonSave = new ToolStripButton();
            toolStripButtonLoad = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            groupBox2 = new GroupBox();
            propertyGrid1 = new PropertyGrid();
            groupBox1.SuspendLayout();
            Vertexes.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxVertexes
            // 
            listBoxVertexes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxVertexes.FormattingEnabled = true;
            listBoxVertexes.ItemHeight = 20;
            listBoxVertexes.Location = new Point(6, 23);
            listBoxVertexes.Name = "listBoxVertexes";
            listBoxVertexes.Size = new Size(345, 404);
            listBoxVertexes.TabIndex = 0;
            listBoxVertexes.SelectedIndexChanged += listBoxVertexes_SelectedIndexChanged;
            // 
            // listBoxEdges
            // 
            listBoxEdges.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxEdges.FormattingEnabled = true;
            listBoxEdges.ItemHeight = 20;
            listBoxEdges.Location = new Point(0, 23);
            listBoxEdges.Name = "listBoxEdges";
            listBoxEdges.Size = new Size(349, 404);
            listBoxEdges.TabIndex = 1;
            listBoxEdges.SelectedIndexChanged += listBoxEdges_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBoxEdges);
            groupBox1.Controls.Add(buttonEdgeFind);
            groupBox1.Controls.Add(buttonEdgeAdd);
            groupBox1.Controls.Add(buttonEdgeRemove);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(355, 480);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Edges";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // buttonEdgeFind
            // 
            buttonEdgeFind.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonEdgeFind.Location = new Point(206, 437);
            buttonEdgeFind.Name = "buttonEdgeFind";
            buttonEdgeFind.Size = new Size(94, 29);
            buttonEdgeFind.TabIndex = 9;
            buttonEdgeFind.Text = "Find";
            buttonEdgeFind.UseVisualStyleBackColor = true;
            buttonEdgeFind.Click += buttonEdgeFind_Click;
            // 
            // buttonEdgeAdd
            // 
            buttonEdgeAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonEdgeAdd.Location = new Point(6, 437);
            buttonEdgeAdd.Name = "buttonEdgeAdd";
            buttonEdgeAdd.Size = new Size(94, 29);
            buttonEdgeAdd.TabIndex = 5;
            buttonEdgeAdd.Text = "Add";
            buttonEdgeAdd.UseVisualStyleBackColor = true;
            buttonEdgeAdd.Click += buttonEdgeAdd_Click;
            // 
            // buttonEdgeRemove
            // 
            buttonEdgeRemove.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonEdgeRemove.Location = new Point(106, 437);
            buttonEdgeRemove.Name = "buttonEdgeRemove";
            buttonEdgeRemove.Size = new Size(94, 29);
            buttonEdgeRemove.TabIndex = 6;
            buttonEdgeRemove.Text = "Remove";
            buttonEdgeRemove.UseVisualStyleBackColor = true;
            buttonEdgeRemove.Click += buttonEdgeRemove_Click;
            // 
            // Vertexes
            // 
            Vertexes.Controls.Add(buttonVertexFind);
            Vertexes.Controls.Add(listBoxVertexes);
            Vertexes.Controls.Add(buttonVertexRemove);
            Vertexes.Controls.Add(buttonVertexAdd);
            Vertexes.Dock = DockStyle.Fill;
            Vertexes.Location = new Point(0, 0);
            Vertexes.Name = "Vertexes";
            Vertexes.Size = new Size(357, 480);
            Vertexes.TabIndex = 3;
            Vertexes.TabStop = false;
            Vertexes.Text = "Vertices";
            // 
            // buttonVertexFind
            // 
            buttonVertexFind.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonVertexFind.Location = new Point(206, 437);
            buttonVertexFind.Name = "buttonVertexFind";
            buttonVertexFind.Size = new Size(94, 29);
            buttonVertexFind.TabIndex = 10;
            buttonVertexFind.Text = "Find";
            buttonVertexFind.UseVisualStyleBackColor = true;
            buttonVertexFind.Click += buttonVertexFind_Click;
            // 
            // buttonVertexRemove
            // 
            buttonVertexRemove.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonVertexRemove.Location = new Point(106, 437);
            buttonVertexRemove.Name = "buttonVertexRemove";
            buttonVertexRemove.Size = new Size(94, 29);
            buttonVertexRemove.TabIndex = 8;
            buttonVertexRemove.Text = "Remove";
            buttonVertexRemove.UseVisualStyleBackColor = true;
            buttonVertexRemove.Click += buttonVertexRemove_Click;
            // 
            // buttonVertexAdd
            // 
            buttonVertexAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonVertexAdd.Location = new Point(6, 437);
            buttonVertexAdd.Name = "buttonVertexAdd";
            buttonVertexAdd.Size = new Size(94, 29);
            buttonVertexAdd.TabIndex = 7;
            buttonVertexAdd.Text = "Add";
            buttonVertexAdd.UseVisualStyleBackColor = true;
            buttonVertexAdd.Click += buttonVertexAdd_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonFindPath, toolStripButtonSave, toolStripButtonLoad });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1010, 27);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonFindPath
            // 
            toolStripButtonFindPath.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonFindPath.Image = (Image)resources.GetObject("toolStripButtonFindPath.Image");
            toolStripButtonFindPath.ImageTransparentColor = Color.Magenta;
            toolStripButtonFindPath.Name = "toolStripButtonFindPath";
            toolStripButtonFindPath.Size = new Size(131, 24);
            toolStripButtonFindPath.Text = "Find shortest path";
            toolStripButtonFindPath.Click += toolStripButton1_Click;
            // 
            // toolStripButtonSave
            // 
            toolStripButtonSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonSave.Image = (Image)resources.GetObject("toolStripButtonSave.Image");
            toolStripButtonSave.ImageTransparentColor = Color.Magenta;
            toolStripButtonSave.Name = "toolStripButtonSave";
            toolStripButtonSave.Size = new Size(44, 24);
            toolStripButtonSave.Text = "Save";
            toolStripButtonSave.Click += toolStripButtonSave_Click;
            // 
            // toolStripButtonLoad
            // 
            toolStripButtonLoad.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonLoad.Image = (Image)resources.GetObject("toolStripButtonLoad.Image");
            toolStripButtonLoad.ImageTransparentColor = Color.Magenta;
            toolStripButtonLoad.Name = "toolStripButtonLoad";
            toolStripButtonLoad.Size = new Size(46, 24);
            toolStripButtonLoad.Text = "Load";
            toolStripButtonLoad.Click += toolStripButton3_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(14, 37);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(991, 480);
            splitContainer1.SplitterDistance = 355;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 6;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(3, 4, 3, 4);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(Vertexes);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(groupBox2);
            splitContainer2.Size = new Size(631, 480);
            splitContainer2.SplitterDistance = 357;
            splitContainer2.SplitterWidth = 5;
            splitContainer2.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(propertyGrid1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(269, 480);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Properties";
            // 
            // propertyGrid1
            // 
            propertyGrid1.Dock = DockStyle.Fill;
            propertyGrid1.Location = new Point(3, 24);
            propertyGrid1.Margin = new Padding(3, 4, 3, 4);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.Size = new Size(263, 452);
            propertyGrid1.TabIndex = 4;
            propertyGrid1.Click += propertyGrid1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 523);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "NNDSA Sem01 Matejka";
            Load += Form1_Load_2;
            groupBox1.ResumeLayout(false);
            Vertexes.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxVertexes;
        private ListBox listBoxEdges;
        private GroupBox groupBox1;
        private GroupBox Vertexes;
        private Button buttonEdgeAdd;
        private Button buttonEdgeRemove;
        private Button buttonVertexRemove;
        private Button buttonVertexAdd;
        private Button buttonEdgeFind;
        private Button buttonVertexFind;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonFindPath;
        private SplitContainer splitContainer1;
        private ToolStripButton toolStripButtonSave;
        private ToolStripButton toolStripButtonLoad;
        private PropertyGrid propertyGrid1;
        private SplitContainer splitContainer2;
        private GroupBox groupBox2;
    }
}