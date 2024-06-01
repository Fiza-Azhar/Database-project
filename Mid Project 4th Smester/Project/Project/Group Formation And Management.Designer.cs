
namespace Project
{
    partial class Group_Formation_And_Management
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
            this.lbHeading1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelData = new System.Windows.Forms.TableLayoutPanel();
            this.lbStd = new System.Windows.Forms.Label();
            this.GroupStudent = new System.Windows.Forms.DataGridView();
            this.lbGroupStd = new System.Windows.Forms.Label();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHeading1
            // 
            this.lbHeading1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbHeading1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHeading1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeading1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbHeading1.Location = new System.Drawing.Point(3, 0);
            this.lbHeading1.Name = "lbHeading1";
            this.lbHeading1.Size = new System.Drawing.Size(1097, 48);
            this.lbHeading1.TabIndex = 0;
            this.lbHeading1.Text = "Group Student";
            this.lbHeading1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lbHeading1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1103, 48);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanelData
            // 
            this.tableLayoutPanelData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelData.ColumnCount = 3;
            this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.96236F));
            this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.037643F));
            this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 445F));
            this.tableLayoutPanelData.Controls.Add(this.GroupStudent, 0, 2);
            this.tableLayoutPanelData.Controls.Add(this.lbStd, 2, 0);
            this.tableLayoutPanelData.Controls.Add(this.lbGroupStd, 0, 0);
            this.tableLayoutPanelData.Controls.Add(this.dataGridViewStudents, 2, 2);
            this.tableLayoutPanelData.Location = new System.Drawing.Point(47, 65);
            this.tableLayoutPanelData.Name = "tableLayoutPanelData";
            this.tableLayoutPanelData.RowCount = 3;
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelData.Size = new System.Drawing.Size(1002, 298);
            this.tableLayoutPanelData.TabIndex = 4;
            // 
            // lbStd
            // 
            this.lbStd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbStd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbStd.Location = new System.Drawing.Point(559, 0);
            this.lbStd.Name = "lbStd";
            this.lbStd.Size = new System.Drawing.Size(440, 40);
            this.lbStd.TabIndex = 4;
            this.lbStd.Text = "Available Students";
            this.lbStd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupStudent
            // 
            this.GroupStudent.AllowUserToAddRows = false;
            this.GroupStudent.AllowUserToDeleteRows = false;
            this.GroupStudent.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GroupStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Remove});
            this.GroupStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupStudent.Location = new System.Drawing.Point(3, 58);
            this.GroupStudent.Name = "GroupStudent";
            this.GroupStudent.ReadOnly = true;
            this.GroupStudent.Size = new System.Drawing.Size(511, 237);
            this.GroupStudent.TabIndex = 13;
            this.GroupStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GroupStudent_CellContentClick);
            // 
            // lbGroupStd
            // 
            this.lbGroupStd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbGroupStd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbGroupStd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGroupStd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbGroupStd.Location = new System.Drawing.Point(3, 0);
            this.lbGroupStd.Name = "lbGroupStd";
            this.lbGroupStd.Size = new System.Drawing.Size(511, 40);
            this.lbGroupStd.TabIndex = 4;
            this.lbGroupStd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "Remove";
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Text = "Remove";
            this.Remove.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Add});
            this.dataGridViewStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStudents.Location = new System.Drawing.Point(559, 58);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.Size = new System.Drawing.Size(440, 237);
            this.dataGridViewStudents.TabIndex = 14;
            this.dataGridViewStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellClick_1);
            // 
            // Add
            // 
            this.Add.HeaderText = "Add";
            this.Add.Name = "Add";
            this.Add.ReadOnly = true;
            this.Add.Text = "Add";
            this.Add.UseColumnTextForButtonValue = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.64596F));
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(50, 474);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(103, 44);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 38);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // Group_Formation_And_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1103, 541);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanelData);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MinimumSize = new System.Drawing.Size(1119, 580);
            this.Name = "Group_Formation_And_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Group_Formation_And_Management";
            this.Load += new System.EventHandler(this.Group_Formation_And_Management_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbHeading1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelData;
        private System.Windows.Forms.DataGridView GroupStudent;
        private System.Windows.Forms.Label lbStd;
        private System.Windows.Forms.Label lbGroupStd;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.DataGridViewButtonColumn Add;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnBack;
    }
}