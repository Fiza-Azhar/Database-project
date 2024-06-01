
namespace Project
{
    partial class Extra
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtGid = new System.Windows.Forms.TextBox();
            this.lbGID = new System.Windows.Forms.Label();
            this.lbSID = new System.Windows.Forms.Label();
            this.txtSid = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tableLayoutPanelData = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
            this.lbStd = new System.Windows.Forms.Label();
            this.lbGroups = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.35147F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.64853F));
            this.tableLayoutPanel1.Controls.Add(this.txtGid, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbGID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbSID, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSid, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnInsert, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 150);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtGid
            // 
            this.txtGid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGid.Location = new System.Drawing.Point(181, 3);
            this.txtGid.Multiline = true;
            this.txtGid.Name = "txtGid";
            this.txtGid.Size = new System.Drawing.Size(210, 31);
            this.txtGid.TabIndex = 2;
            // 
            // lbGID
            // 
            this.lbGID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbGID.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbGID.Location = new System.Drawing.Point(3, 0);
            this.lbGID.Name = "lbGID";
            this.lbGID.Size = new System.Drawing.Size(172, 37);
            this.lbGID.TabIndex = 0;
            this.lbGID.Text = "Group ID:";
            this.lbGID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSID
            // 
            this.lbSID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSID.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSID.Location = new System.Drawing.Point(3, 37);
            this.lbSID.Name = "lbSID";
            this.lbSID.Size = new System.Drawing.Size(172, 37);
            this.lbSID.TabIndex = 0;
            this.lbSID.Text = "Student ID:";
            this.lbSID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSid
            // 
            this.txtSid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSid.Location = new System.Drawing.Point(181, 40);
            this.txtSid.Multiline = true;
            this.txtSid.Name = "txtSid";
            this.txtSid.Size = new System.Drawing.Size(210, 31);
            this.txtSid.TabIndex = 2;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInsert.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(181, 110);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(210, 37);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(3, 110);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(172, 37);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanelData
            // 
            this.tableLayoutPanelData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelData.ColumnCount = 3;
            this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.47541F));
            this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.52459F));
            this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 238F));
            this.tableLayoutPanelData.Controls.Add(this.dataGridViewStudents, 0, 2);
            this.tableLayoutPanelData.Controls.Add(this.dataGridViewGroups, 2, 2);
            this.tableLayoutPanelData.Controls.Add(this.lbStd, 0, 0);
            this.tableLayoutPanelData.Controls.Add(this.lbGroups, 2, 0);
            this.tableLayoutPanelData.Location = new System.Drawing.Point(252, 183);
            this.tableLayoutPanelData.Name = "tableLayoutPanelData";
            this.tableLayoutPanelData.RowCount = 3;
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelData.Size = new System.Drawing.Size(525, 255);
            this.tableLayoutPanelData.TabIndex = 5;
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStudents.Location = new System.Drawing.Point(3, 58);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.Size = new System.Drawing.Size(242, 194);
            this.dataGridViewStudents.TabIndex = 3;
            // 
            // dataGridViewGroups
            // 
            this.dataGridViewGroups.AllowUserToAddRows = false;
            this.dataGridViewGroups.AllowUserToDeleteRows = false;
            this.dataGridViewGroups.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGroups.Location = new System.Drawing.Point(289, 58);
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.ReadOnly = true;
            this.dataGridViewGroups.Size = new System.Drawing.Size(233, 194);
            this.dataGridViewGroups.TabIndex = 3;
            // 
            // lbStd
            // 
            this.lbStd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbStd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbStd.Location = new System.Drawing.Point(3, 0);
            this.lbStd.Name = "lbStd";
            this.lbStd.Size = new System.Drawing.Size(242, 40);
            this.lbStd.TabIndex = 4;
            this.lbStd.Text = "Available Students";
            this.lbStd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbGroups
            // 
            this.lbGroups.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbGroups.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGroups.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbGroups.Location = new System.Drawing.Point(289, 0);
            this.lbGroups.Name = "lbGroups";
            this.lbGroups.Size = new System.Drawing.Size(233, 40);
            this.lbGroups.TabIndex = 4;
            this.lbGroups.Text = "Groups";
            this.lbGroups.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Extra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanelData);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Extra";
            this.Text = "Extra";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtGid;
        private System.Windows.Forms.Label lbGID;
        private System.Windows.Forms.Label lbSID;
        private System.Windows.Forms.TextBox txtSid;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelData;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.DataGridView dataGridViewGroups;
        private System.Windows.Forms.Label lbStd;
        private System.Windows.Forms.Label lbGroups;
    }
}