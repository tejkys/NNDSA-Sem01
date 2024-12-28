namespace NNDSA_Sem01
{
    partial class FindPathDialog
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
            label1 = new Label();
            numericUpDownTrainLength = new NumericUpDown();
            comboBoxStartPoint = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            comboBoxEndPoint = new ComboBox();
            groupBox1 = new GroupBox();
            buttonSolve = new Button();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTrainLength).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 25);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Train length";
            // 
            // numericUpDownTrainLength
            // 
            numericUpDownTrainLength.Location = new Point(100, 23);
            numericUpDownTrainLength.Margin = new Padding(3, 4, 3, 4);
            numericUpDownTrainLength.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDownTrainLength.Name = "numericUpDownTrainLength";
            numericUpDownTrainLength.Size = new Size(137, 27);
            numericUpDownTrainLength.TabIndex = 1;
            // 
            // comboBoxStartPoint
            // 
            comboBoxStartPoint.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStartPoint.FormattingEnabled = true;
            comboBoxStartPoint.Location = new Point(328, 22);
            comboBoxStartPoint.Margin = new Padding(3, 4, 3, 4);
            comboBoxStartPoint.Name = "comboBoxStartPoint";
            comboBoxStartPoint.Size = new Size(138, 28);
            comboBoxStartPoint.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 25);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 3;
            label2.Text = "Start point";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(472, 25);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 4;
            label3.Text = "End point";
            // 
            // comboBoxEndPoint
            // 
            comboBoxEndPoint.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEndPoint.FormattingEnabled = true;
            comboBoxEndPoint.Location = new Point(551, 22);
            comboBoxEndPoint.Margin = new Padding(3, 4, 3, 4);
            comboBoxEndPoint.Name = "comboBoxEndPoint";
            comboBoxEndPoint.Size = new Size(138, 28);
            comboBoxEndPoint.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(buttonSolve);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBoxEndPoint);
            groupBox1.Controls.Add(numericUpDownTrainLength);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBoxStartPoint);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(792, 64);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Settings";
            // 
            // buttonSolve
            // 
            buttonSolve.Location = new Point(695, 22);
            buttonSolve.Margin = new Padding(3, 4, 3, 4);
            buttonSolve.Name = "buttonSolve";
            buttonSolve.Size = new Size(86, 31);
            buttonSolve.TabIndex = 7;
            buttonSolve.Text = "Solve";
            buttonSolve.UseVisualStyleBackColor = true;
            buttonSolve.Click += buttonSolve_Click;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 24);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(786, 192);
            textBox1.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(14, 88);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(792, 220);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Result";
            // 
            // FindPathDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 317);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FindPathDialog";
            Text = "Find path";
            ((System.ComponentModel.ISupportInitialize)numericUpDownTrainLength).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDownTrainLength;
        private ComboBox comboBoxStartPoint;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxEndPoint;
        private GroupBox groupBox1;
        private Button buttonSolve;
        private TextBox textBox1;
        private GroupBox groupBox2;
    }
}