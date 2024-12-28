namespace NNDSA_Sem01
{
    partial class AddDialogEdge
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxEdgeStart = new ComboBox();
            comboBoxEdgeEnd = new ComboBox();
            label1 = new Label();
            textBoxEdgeName = new TextBox();
            numericUpDownEdgeDistance = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonOk = new Button();
            label5 = new Label();
            comboBoxEdgeSwitching = new ComboBox();
            label6 = new Label();
            numericUpDownFreeSpaceStart = new NumericUpDown();
            label7 = new Label();
            numericUpDownFreeSpaceEnd = new NumericUpDown();
            comboBoxBlocked = new ComboBox();
            label8 = new Label();
            groupBoxBlockingState = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdgeDistance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFreeSpaceStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFreeSpaceEnd).BeginInit();
            groupBoxBlockingState.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxEdgeStart
            // 
            comboBoxEdgeStart.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEdgeStart.FormattingEnabled = true;
            comboBoxEdgeStart.Location = new Point(167, 55);
            comboBoxEdgeStart.Margin = new Padding(3, 4, 3, 4);
            comboBoxEdgeStart.Name = "comboBoxEdgeStart";
            comboBoxEdgeStart.Size = new Size(217, 28);
            comboBoxEdgeStart.TabIndex = 0;
            // 
            // comboBoxEdgeEnd
            // 
            comboBoxEdgeEnd.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEdgeEnd.FormattingEnabled = true;
            comboBoxEdgeEnd.Location = new Point(167, 93);
            comboBoxEdgeEnd.Margin = new Padding(3, 4, 3, 4);
            comboBoxEdgeEnd.Name = "comboBoxEdgeEnd";
            comboBoxEdgeEnd.Size = new Size(217, 28);
            comboBoxEdgeEnd.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 59);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 2;
            label1.Text = "Start node";
            // 
            // textBoxEdgeName
            // 
            textBoxEdgeName.Location = new Point(167, 16);
            textBoxEdgeName.Margin = new Padding(3, 4, 3, 4);
            textBoxEdgeName.Name = "textBoxEdgeName";
            textBoxEdgeName.Size = new Size(217, 27);
            textBoxEdgeName.TabIndex = 3;
            // 
            // numericUpDownEdgeDistance
            // 
            numericUpDownEdgeDistance.Location = new Point(167, 204);
            numericUpDownEdgeDistance.Margin = new Padding(3, 4, 3, 4);
            numericUpDownEdgeDistance.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numericUpDownEdgeDistance.Name = "numericUpDownEdgeDistance";
            numericUpDownEdgeDistance.Size = new Size(217, 27);
            numericUpDownEdgeDistance.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 97);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 5;
            label2.Text = "End node";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 20);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 6;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 207);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 7;
            label4.Text = "Length";
            // 
            // buttonOk
            // 
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Location = new Point(114, 351);
            buttonOk.Margin = new Padding(3, 4, 3, 4);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(128, 31);
            buttonOk.TabIndex = 8;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 136);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 9;
            label5.Text = "Type";
            // 
            // comboBoxEdgeSwitching
            // 
            comboBoxEdgeSwitching.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEdgeSwitching.FormattingEnabled = true;
            comboBoxEdgeSwitching.Items.AddRange(new object[] { "Normal", "Switching" });
            comboBoxEdgeSwitching.Location = new Point(167, 132);
            comboBoxEdgeSwitching.Margin = new Padding(3, 4, 3, 4);
            comboBoxEdgeSwitching.Name = "comboBoxEdgeSwitching";
            comboBoxEdgeSwitching.Size = new Size(217, 28);
            comboBoxEdgeSwitching.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 23);
            label6.Name = "label6";
            label6.Size = new Size(174, 19);
            label6.TabIndex = 12;
            label6.Text = "Free space from Start node";
            // 
            // numericUpDownFreeSpaceStart
            // 
            numericUpDownFreeSpaceStart.Location = new Point(26, 57);
            numericUpDownFreeSpaceStart.Margin = new Padding(3, 4, 3, 4);
            numericUpDownFreeSpaceStart.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numericUpDownFreeSpaceStart.Name = "numericUpDownFreeSpaceStart";
            numericUpDownFreeSpaceStart.Size = new Size(137, 27);
            numericUpDownFreeSpaceStart.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(200, 23);
            label7.Name = "label7";
            label7.Size = new Size(168, 19);
            label7.TabIndex = 13;
            label7.Text = "Free space from End node";
            // 
            // numericUpDownFreeSpaceEnd
            // 
            numericUpDownFreeSpaceEnd.Location = new Point(218, 57);
            numericUpDownFreeSpaceEnd.Margin = new Padding(3, 4, 3, 4);
            numericUpDownFreeSpaceEnd.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numericUpDownFreeSpaceEnd.Name = "numericUpDownFreeSpaceEnd";
            numericUpDownFreeSpaceEnd.Size = new Size(137, 27);
            numericUpDownFreeSpaceEnd.TabIndex = 14;
            // 
            // comboBoxBlocked
            // 
            comboBoxBlocked.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBlocked.FormattingEnabled = true;
            comboBoxBlocked.Items.AddRange(new object[] { "False", "True" });
            comboBoxBlocked.Location = new Point(167, 168);
            comboBoxBlocked.Margin = new Padding(3, 4, 3, 4);
            comboBoxBlocked.Name = "comboBoxBlocked";
            comboBoxBlocked.Size = new Size(217, 28);
            comboBoxBlocked.TabIndex = 15;
            comboBoxBlocked.SelectedIndexChanged += comboBoxBlocked_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 171);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 16;
            label8.Text = "Blocked";
            // 
            // groupBoxBlockingState
            // 
            groupBoxBlockingState.Controls.Add(label6);
            groupBoxBlockingState.Controls.Add(numericUpDownFreeSpaceStart);
            groupBoxBlockingState.Controls.Add(label7);
            groupBoxBlockingState.Controls.Add(numericUpDownFreeSpaceEnd);
            groupBoxBlockingState.Enabled = false;
            groupBoxBlockingState.Location = new Point(12, 238);
            groupBoxBlockingState.Name = "groupBoxBlockingState";
            groupBoxBlockingState.Size = new Size(372, 106);
            groupBoxBlockingState.TabIndex = 17;
            groupBoxBlockingState.TabStop = false;
            groupBoxBlockingState.Text = "Blocking state";
            // 
            // AddDialogEdge
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(405, 396);
            Controls.Add(groupBoxBlockingState);
            Controls.Add(label8);
            Controls.Add(comboBoxBlocked);
            Controls.Add(comboBoxEdgeSwitching);
            Controls.Add(label5);
            Controls.Add(buttonOk);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(numericUpDownEdgeDistance);
            Controls.Add(textBoxEdgeName);
            Controls.Add(label1);
            Controls.Add(comboBoxEdgeEnd);
            Controls.Add(comboBoxEdgeStart);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddDialogEdge";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Edge";
            Load += AddDialogEdge_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdgeDistance).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFreeSpaceStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFreeSpaceEnd).EndInit();
            groupBoxBlockingState.ResumeLayout(false);
            groupBoxBlockingState.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxEdgeStart;
        private ComboBox comboBoxEdgeEnd;
        private Label label1;
        private TextBox textBoxEdgeName;
        private NumericUpDown numericUpDownEdgeDistance;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonOk;
        private Label label5;
        private ComboBox comboBoxEdgeSwitching;
        private Label label6;
        private NumericUpDown numericUpDownFreeSpaceStart;
        private Label label7;
        private NumericUpDown numericUpDownFreeSpaceEnd;
        private ComboBox comboBoxBlocked;
        private Label label8;
        private GroupBox groupBoxBlockingState;
    }
}