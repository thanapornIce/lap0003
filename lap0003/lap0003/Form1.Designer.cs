namespace lap0003
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
            this.TextBoxname = new System.Windows.Forms.TextBox();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.TextBoxbirthyear = new System.Windows.Forms.TextBox();
            this.TextBoxhight = new System.Windows.Forms.TextBox();
            this.TextBoxgrade = new System.Windows.Forms.TextBox();
            this.TextBoxmajor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clear = new System.Windows.Forms.Button();
            this.TextBoxMaxx = new System.Windows.Forms.TextBox();
            this.TextBoxMinx = new System.Windows.Forms.TextBox();
            this.TextBoxNumx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxname
            // 
            this.TextBoxname.Location = new System.Drawing.Point(71, 27);
            this.TextBoxname.Name = "TextBoxname";
            this.TextBoxname.Size = new System.Drawing.Size(126, 23);
            this.TextBoxname.TabIndex = 0;
            // 
            // TextBoxID
            // 
            this.TextBoxID.Location = new System.Drawing.Point(300, 27);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(146, 23);
            this.TextBoxID.TabIndex = 1;
            this.TextBoxID.TextChanged += new System.EventHandler(this.TextBoxID_TextChanged);
            // 
            // TextBoxbirthyear
            // 
            this.TextBoxbirthyear.Location = new System.Drawing.Point(575, 27);
            this.TextBoxbirthyear.Name = "TextBoxbirthyear";
            this.TextBoxbirthyear.Size = new System.Drawing.Size(133, 23);
            this.TextBoxbirthyear.TabIndex = 2;
            // 
            // TextBoxhight
            // 
            this.TextBoxhight.Location = new System.Drawing.Point(69, 90);
            this.TextBoxhight.Name = "TextBoxhight";
            this.TextBoxhight.Size = new System.Drawing.Size(128, 23);
            this.TextBoxhight.TabIndex = 3;
            // 
            // TextBoxgrade
            // 
            this.TextBoxgrade.Location = new System.Drawing.Point(300, 90);
            this.TextBoxgrade.Name = "TextBoxgrade";
            this.TextBoxgrade.Size = new System.Drawing.Size(146, 23);
            this.TextBoxgrade.TabIndex = 4;
            // 
            // TextBoxmajor
            // 
            this.TextBoxmajor.Location = new System.Drawing.Point(575, 90);
            this.TextBoxmajor.Name = "TextBoxmajor";
            this.TextBoxmajor.Size = new System.Drawing.Size(133, 23);
            this.TextBoxmajor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "BirthYear";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Grade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Major";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(227, 140);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 26);
            this.Add.TabIndex = 12;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(12, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(645, 218);
            this.dataGridView1.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "(none)";
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "BirthYear";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Hight";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Grade";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Major";
            this.Column6.Name = "Column6";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(421, 140);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(100, 26);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "button1";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // TextBoxMaxx
            // 
            this.TextBoxMaxx.Location = new System.Drawing.Point(664, 140);
            this.TextBoxMaxx.Name = "TextBoxMaxx";
            this.TextBoxMaxx.Size = new System.Drawing.Size(133, 23);
            this.TextBoxMaxx.TabIndex = 15;
            // 
            // TextBoxMinx
            // 
            this.TextBoxMinx.Location = new System.Drawing.Point(664, 182);
            this.TextBoxMinx.Name = "TextBoxMinx";
            this.TextBoxMinx.Size = new System.Drawing.Size(133, 23);
            this.TextBoxMinx.TabIndex = 16;
            // 
            // TextBoxNumx
            // 
            this.TextBoxNumx.Location = new System.Drawing.Point(664, 224);
            this.TextBoxNumx.Name = "TextBoxNumx";
            this.TextBoxNumx.Size = new System.Drawing.Size(133, 23);
            this.TextBoxNumx.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBoxNumx);
            this.Controls.Add(this.TextBoxMinx);
            this.Controls.Add(this.TextBoxMaxx);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxmajor);
            this.Controls.Add(this.TextBoxgrade);
            this.Controls.Add(this.TextBoxhight);
            this.Controls.Add(this.TextBoxbirthyear);
            this.Controls.Add(this.TextBoxID);
            this.Controls.Add(this.TextBoxname);
            this.Name = "Form1";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextBoxname;
        private TextBox TextBoxID;
        private TextBox TextBoxbirthyear;
        private TextBox TextBoxhight;
        private TextBox TextBoxgrade;
        private TextBox TextBoxmajor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button Add;
        private DataGridView dataGridView1;
        private Button Clear;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private TextBox TextBoxMaxx;
        private TextBox TextBoxMinx;
        private TextBox TextBoxNumx;
    }
}