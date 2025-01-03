namespace ImportApp.Forms
{
    partial class frmImportAssembly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportAssembly));
            tableLayoutPanel1 = new TableLayoutPanel();
            clbObjects = new CheckedListBox();
            label1 = new Label();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label4 = new Label();
            txtName = new TextBox();
            label5 = new Label();
            txtDescription = new TextBox();
            label6 = new Label();
            txtModule = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            ckbAssumeFirstPropIsPk = new CheckBox();
            label2 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            btnNext = new Button();
            btnBack = new Button();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(clbObjects, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 2, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 2, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 1, 3);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 2, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(784, 561);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // clbObjects
            // 
            clbObjects.Dock = DockStyle.Fill;
            clbObjects.FormattingEnabled = true;
            clbObjects.Location = new Point(23, 43);
            clbObjects.Name = "clbObjects";
            clbObjects.Size = new Size(440, 430);
            clbObjects.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 2;
            label1.Text = "Select Database Objects";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(469, 20);
            label3.Name = "label3";
            label3.Size = new Size(187, 20);
            label3.TabIndex = 4;
            label3.Text = "Microservice Information";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(txtName);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(txtDescription);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(txtModule);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(469, 43);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(291, 430);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 0;
            label4.Text = "Microservice Name";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Control;
            txtName.Location = new Point(3, 23);
            txtName.Name = "txtName";
            txtName.Size = new Size(297, 27);
            txtName.TabIndex = 2;
            txtName.Text = "Example Microservice";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 53);
            label5.Name = "label5";
            label5.Size = new Size(172, 20);
            label5.TabIndex = 2;
            label5.Text = "Microservice Description";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.Control;
            txtDescription.Location = new Point(3, 76);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(297, 27);
            txtDescription.TabIndex = 3;
            txtDescription.Text = "This is an example microservice built using ServiceBricks";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 106);
            label6.Name = "label6";
            label6.Size = new Size(191, 20);
            label6.TabIndex = 4;
            label6.Text = "Microservice Module Name";
            // 
            // txtModule
            // 
            txtModule.BackColor = SystemColors.Control;
            txtModule.Location = new Point(3, 129);
            txtModule.Name = "txtModule";
            txtModule.Size = new Size(297, 27);
            txtModule.TabIndex = 4;
            txtModule.Text = "Example";
            txtModule.TextChanged += txtModule_TextChanged;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(ckbAssumeFirstPropIsPk);
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(23, 479);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(440, 59);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // ckbAssumeFirstPropIsPk
            // 
            ckbAssumeFirstPropIsPk.AutoSize = true;
            ckbAssumeFirstPropIsPk.Checked = true;
            ckbAssumeFirstPropIsPk.CheckState = CheckState.Checked;
            ckbAssumeFirstPropIsPk.Location = new Point(3, 3);
            ckbAssumeFirstPropIsPk.Name = "ckbAssumeFirstPropIsPk";
            ckbAssumeFirstPropIsPk.Size = new Size(322, 24);
            ckbAssumeFirstPropIsPk.TabIndex = 1;
            ckbAssumeFirstPropIsPk.Text = "Assume The First Property Is The Primary Key";
            ckbAssumeFirstPropIsPk.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 30);
            label2.Name = "label2";
            label2.Size = new Size(372, 20);
            label2.TabIndex = 3;
            label2.Text = "Select all of the database objects for your microservice";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(btnNext);
            flowLayoutPanel3.Controls.Add(btnBack);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel3.Location = new Point(469, 479);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(291, 59);
            flowLayoutPanel3.TabIndex = 7;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNext.BackColor = SystemColors.Control;
            btnNext.Location = new Point(184, 3);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(104, 37);
            btnNext.TabIndex = 5;
            btnNext.Text = "&Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.BackColor = SystemColors.Control;
            btnBack.Location = new Point(74, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(104, 37);
            btnBack.TabIndex = 6;
            btnBack.Text = "&Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // frmImportAssembly
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 561);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(697, 348);
            Name = "frmImportAssembly";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Import From Assembly";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnNext;
        private CheckedListBox clbObjects;
        private Label label1;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label4;
        private TextBox txtModule;
        private TextBox txtName;
        private Label label5;
        private TextBox txtDescription;
        private Label label6;
        private FlowLayoutPanel flowLayoutPanel2;
        private CheckBox ckbAssumeFirstPropIsPk;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button btnBack;
    }
}