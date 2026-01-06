namespace UI.Forms
{
    partial class frmMain
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
            dataGridView1 = new DataGridView();
            txtSearchKey = new TextBox();
            button1 = new Button();
            label1 = new Label();
            btndelete = new Button();
            btnDetail = new Button();
            dcBtnSaveContact = new Button();
            ecBtnEditContact = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 166);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(797, 344);
            dataGridView1.TabIndex = 0;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // txtSearchKey
            // 
            txtSearchKey.Location = new Point(81, 103);
            txtSearchKey.Name = "txtSearchKey";
            txtSearchKey.Size = new Size(252, 29);
            txtSearchKey.TabIndex = 1;
            txtSearchKey.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(355, 103);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 2;
            button1.Text = "جستوجو";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 103);
            label1.Name = "label1";
            label1.Size = new Size(54, 23);
            label1.TabIndex = 3;
            label1.Text = "جستوجو:";
            // 
            // btndelete
            // 
            btndelete.Location = new Point(680, 126);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(105, 34);
            btndelete.TabIndex = 4;
            btndelete.Text = "حذف مخاطب";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnDetail
            // 
            btnDetail.Location = new Point(680, 90);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(105, 30);
            btnDetail.TabIndex = 5;
            btnDetail.Text = "نمایش جزئیات";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click;
            // 
            // dcBtnSaveContact
            // 
            dcBtnSaveContact.Location = new Point(680, 55);
            dcBtnSaveContact.Name = "dcBtnSaveContact";
            dcBtnSaveContact.Size = new Size(105, 29);
            dcBtnSaveContact.TabIndex = 6;
            dcBtnSaveContact.Text = "ثبت مخاطب جدید ";
            dcBtnSaveContact.UseVisualStyleBackColor = true;
            dcBtnSaveContact.Click += dcBtnSaveContact_Click;
            // 
            // ecBtnEditContact
            // 
            ecBtnEditContact.Location = new Point(680, 12);
            ecBtnEditContact.Name = "ecBtnEditContact";
            ecBtnEditContact.Size = new Size(105, 37);
            ecBtnEditContact.TabIndex = 7;
            ecBtnEditContact.Text = "ویرایش مخاطب";
            ecBtnEditContact.UseVisualStyleBackColor = true;
            ecBtnEditContact.Click += ecBtnEditContact_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 510);
            Controls.Add(ecBtnEditContact);
            Controls.Add(dcBtnSaveContact);
            Controls.Add(btnDetail);
            Controls.Add(btndelete);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtSearchKey);
            Controls.Add(dataGridView1);
            Font = new Font("B Nazanin", 11F);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "frmMain";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtSearchKey;
        private Button button1;
        private Label label1;
        private Button btndelete;
        private Button btnDetail;
        private Button dcBtnSaveContact;
        private Button ecBtnEditContact;
    }
}