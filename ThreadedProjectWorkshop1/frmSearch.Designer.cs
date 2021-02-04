namespace ThreadedProjectWorkshop1
{
    partial class frmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.cbSearchBy = new System.Windows.Forms.ComboBox();
            this.btnSearchBy = new System.Windows.Forms.Button();
            this.examineeDataGridView = new System.Windows.Forms.DataGridView();
            this.searchDataGridView = new System.Windows.Forms.DataGridView();
            this.btnDeleterecord = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSearchBy = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.examineeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Location = new System.Drawing.Point(933, 93);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(109, 25);
            this.lblSearchBy.TabIndex = 0;
            this.lblSearchBy.Text = "Search By:";
            // 
            // cbSearchBy
            // 
            this.cbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchBy.FormattingEnabled = true;
            this.cbSearchBy.Items.AddRange(new object[] {
            "Examinee ID",
            "Exam ID",
            "Session ID"});
            this.cbSearchBy.Location = new System.Drawing.Point(1048, 95);
            this.cbSearchBy.Name = "cbSearchBy";
            this.cbSearchBy.Size = new System.Drawing.Size(121, 33);
            this.cbSearchBy.TabIndex = 1;
            // 
            // btnSearchBy
            // 
            this.btnSearchBy.Location = new System.Drawing.Point(1313, 93);
            this.btnSearchBy.Name = "btnSearchBy";
            this.btnSearchBy.Size = new System.Drawing.Size(107, 32);
            this.btnSearchBy.TabIndex = 2;
            this.btnSearchBy.Text = "Search";
            this.btnSearchBy.UseVisualStyleBackColor = true;
            this.btnSearchBy.Click += new System.EventHandler(this.btnSearchBy_Click);
            // 
            // examineeDataGridView
            // 
            this.examineeDataGridView.AllowUserToResizeRows = false;
            this.examineeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.examineeDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.examineeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examineeDataGridView.Location = new System.Drawing.Point(37, 142);
            this.examineeDataGridView.Name = "examineeDataGridView";
            this.examineeDataGridView.RowHeadersWidth = 51;
            this.examineeDataGridView.RowTemplate.Height = 24;
            this.examineeDataGridView.Size = new System.Drawing.Size(519, 584);
            this.examineeDataGridView.TabIndex = 3;
            this.examineeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.examineeDataGridView_CellClick);
            // 
            // searchDataGridView
            // 
            this.searchDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.searchDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGridView.Location = new System.Drawing.Point(583, 142);
            this.searchDataGridView.Name = "searchDataGridView";
            this.searchDataGridView.RowHeadersWidth = 51;
            this.searchDataGridView.RowTemplate.Height = 24;
            this.searchDataGridView.Size = new System.Drawing.Size(837, 584);
            this.searchDataGridView.TabIndex = 4;
            // 
            // btnDeleterecord
            // 
            this.btnDeleterecord.Location = new System.Drawing.Point(277, 732);
            this.btnDeleterecord.Name = "btnDeleterecord";
            this.btnDeleterecord.Size = new System.Drawing.Size(114, 32);
            this.btnDeleterecord.TabIndex = 13;
            this.btnDeleterecord.Text = "Delete Record";
            this.btnDeleterecord.UseVisualStyleBackColor = true;
            this.btnDeleterecord.Click += new System.EventHandler(this.btnDeleterecord_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(157, 732);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(114, 32);
            this.btnModify.TabIndex = 12;
            this.btnModify.Text = "Modify Record";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(37, 732);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 32);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add Record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1234, 732);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 32);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1336, 732);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 32);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSearchBy
            // 
            this.txtSearchBy.Location = new System.Drawing.Point(1186, 95);
            this.txtSearchBy.Name = "txtSearchBy";
            this.txtSearchBy.Size = new System.Drawing.Size(121, 30);
            this.txtSearchBy.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // frmSearch
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1458, 796);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearchBy);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleterecord);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.searchDataGridView);
            this.Controls.Add(this.examineeDataGridView);
            this.Controls.Add(this.btnSearchBy);
            this.Controls.Add(this.cbSearchBy);
            this.Controls.Add(this.lblSearchBy);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmSearch";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examineeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.ComboBox cbSearchBy;
        private System.Windows.Forms.Button btnSearchBy;
        private System.Windows.Forms.DataGridView examineeDataGridView;
        private System.Windows.Forms.DataGridView searchDataGridView;
        private System.Windows.Forms.Button btnDeleterecord;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSearchBy;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

