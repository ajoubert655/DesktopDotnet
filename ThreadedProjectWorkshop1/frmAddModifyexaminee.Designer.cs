namespace ThreadedProjectWorkshop1
{
    partial class frmAddModifyexaminee
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label examineeEmailLabel;
            System.Windows.Forms.Label examineeFirstnameLabel;
            System.Windows.Forms.Label examineeIDLabel;
            System.Windows.Forms.Label examineeLastnameLabel;
            this.examineeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examineeEmailTextBox = new System.Windows.Forms.TextBox();
            this.examineeFirstnameTextBox = new System.Windows.Forms.TextBox();
            this.examineeIDTextBox = new System.Windows.Forms.TextBox();
            this.examineeLastnameTextBox = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            examineeEmailLabel = new System.Windows.Forms.Label();
            examineeFirstnameLabel = new System.Windows.Forms.Label();
            examineeIDLabel = new System.Windows.Forms.Label();
            examineeLastnameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.examineeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // examineeEmailLabel
            // 
            examineeEmailLabel.AutoSize = true;
            examineeEmailLabel.ForeColor = System.Drawing.Color.Black;
            examineeEmailLabel.Location = new System.Drawing.Point(27, 136);
            examineeEmailLabel.Name = "examineeEmailLabel";
            examineeEmailLabel.Size = new System.Drawing.Size(49, 16);
            examineeEmailLabel.TabIndex = 1;
            examineeEmailLabel.Text = "Email:";
            // 
            // examineeFirstnameLabel
            // 
            examineeFirstnameLabel.AutoSize = true;
            examineeFirstnameLabel.ForeColor = System.Drawing.Color.Black;
            examineeFirstnameLabel.Location = new System.Drawing.Point(27, 62);
            examineeFirstnameLabel.Name = "examineeFirstnameLabel";
            examineeFirstnameLabel.Size = new System.Drawing.Size(86, 16);
            examineeFirstnameLabel.TabIndex = 3;
            examineeFirstnameLabel.Text = "First Name:";
            // 
            // examineeIDLabel
            // 
            examineeIDLabel.AutoSize = true;
            examineeIDLabel.CausesValidation = false;
            examineeIDLabel.ForeColor = System.Drawing.Color.Black;
            examineeIDLabel.Location = new System.Drawing.Point(27, 27);
            examineeIDLabel.Name = "examineeIDLabel";
            examineeIDLabel.Size = new System.Drawing.Size(94, 16);
            examineeIDLabel.TabIndex = 5;
            examineeIDLabel.Text = "Examinee ID:";
            // 
            // examineeLastnameLabel
            // 
            examineeLastnameLabel.AutoSize = true;
            examineeLastnameLabel.ForeColor = System.Drawing.Color.Black;
            examineeLastnameLabel.Location = new System.Drawing.Point(27, 97);
            examineeLastnameLabel.Name = "examineeLastnameLabel";
            examineeLastnameLabel.Size = new System.Drawing.Size(84, 16);
            examineeLastnameLabel.TabIndex = 7;
            examineeLastnameLabel.Text = "Last Name:";
            // 
            // examineeBindingSource
            // 
            this.examineeBindingSource.DataSource = typeof(ThreadedProjectWorkshop1.Examinee);
            // 
            // examineeEmailTextBox
            // 
            this.examineeEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.examineeBindingSource, "ExamineeEmail", true));
            this.examineeEmailTextBox.Location = new System.Drawing.Point(144, 133);
            this.examineeEmailTextBox.Name = "examineeEmailTextBox";
            this.examineeEmailTextBox.Size = new System.Drawing.Size(220, 23);
            this.examineeEmailTextBox.TabIndex = 2;
            this.examineeEmailTextBox.Tag = "Email";
            // 
            // examineeFirstnameTextBox
            // 
            this.examineeFirstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.examineeBindingSource, "ExamineeFirstname", true));
            this.examineeFirstnameTextBox.Location = new System.Drawing.Point(144, 59);
            this.examineeFirstnameTextBox.Name = "examineeFirstnameTextBox";
            this.examineeFirstnameTextBox.Size = new System.Drawing.Size(220, 23);
            this.examineeFirstnameTextBox.TabIndex = 4;
            this.examineeFirstnameTextBox.Tag = "First Name";
            // 
            // examineeIDTextBox
            // 
            this.examineeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.examineeBindingSource, "ExamineeID", true));
            this.examineeIDTextBox.Location = new System.Drawing.Point(144, 24);
            this.examineeIDTextBox.Name = "examineeIDTextBox";
            this.examineeIDTextBox.ReadOnly = true;
            this.examineeIDTextBox.Size = new System.Drawing.Size(220, 23);
            this.examineeIDTextBox.TabIndex = 6;
            this.examineeIDTextBox.Tag = "Examinee ID";
            // 
            // examineeLastnameTextBox
            // 
            this.examineeLastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.examineeBindingSource, "ExamineeLastname", true));
            this.examineeLastnameTextBox.Location = new System.Drawing.Point(144, 95);
            this.examineeLastnameTextBox.Name = "examineeLastnameTextBox";
            this.examineeLastnameTextBox.Size = new System.Drawing.Size(220, 23);
            this.examineeLastnameTextBox.TabIndex = 8;
            this.examineeLastnameTextBox.Tag = "Last Name";
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(217, 193);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 22);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(80, 193);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 22);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddModifyexaminee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(395, 262);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(examineeEmailLabel);
            this.Controls.Add(this.examineeEmailTextBox);
            this.Controls.Add(examineeFirstnameLabel);
            this.Controls.Add(this.examineeFirstnameTextBox);
            this.Controls.Add(examineeIDLabel);
            this.Controls.Add(this.examineeIDTextBox);
            this.Controls.Add(examineeLastnameLabel);
            this.Controls.Add(this.examineeLastnameTextBox);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "frmAddModifyexaminee";
            this.Text = "Add/Modify";
            this.Load += new System.EventHandler(this.frmAddModifyexaminee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examineeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource examineeBindingSource;
        private System.Windows.Forms.TextBox examineeEmailTextBox;
        private System.Windows.Forms.TextBox examineeFirstnameTextBox;
        private System.Windows.Forms.TextBox examineeIDTextBox;
        private System.Windows.Forms.TextBox examineeLastnameTextBox;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}