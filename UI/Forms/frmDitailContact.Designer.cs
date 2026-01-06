namespace UI.Forms
{
    partial class frmDitailContact
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblId = new Label();
            lblName = new Label();
            lblLastName = new Label();
            lblCompany = new Label();
            lblPhoneNumber = new Label();
            lblCreateAt = new Label();
            lblDescription = new Label();
            btnclose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 24);
            label1.Name = "label1";
            label1.Size = new Size(34, 18);
            label1.TabIndex = 0;
            label1.Text = "شناسه:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 55);
            label2.Name = "label2";
            label2.Size = new Size(20, 18);
            label2.TabIndex = 1;
            label2.Text = "نام:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 92);
            label3.Name = "label3";
            label3.Size = new Size(57, 18);
            label3.TabIndex = 2;
            label3.Text = "نام خانوادگی:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 124);
            label4.Name = "label4";
            label4.Size = new Size(34, 18);
            label4.TabIndex = 3;
            label4.Text = "شرکت:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 158);
            label5.Name = "label5";
            label5.Size = new Size(52, 18);
            label5.TabIndex = 4;
            label5.Text = "شماره تلفن:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(89, 189);
            label6.Name = "label6";
            label6.Size = new Size(49, 18);
            label6.TabIndex = 5;
            label6.Text = "تاریخ ثبت:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(89, 223);
            label7.Name = "label7";
            label7.Size = new Size(47, 18);
            label7.TabIndex = 6;
            label7.Text = "توضیحات:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(220, 24);
            lblId.Name = "lblId";
            lblId.Size = new Size(41, 18);
            lblId.TabIndex = 7;
            lblId.Text = "label8";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(220, 55);
            lblName.Name = "lblName";
            lblName.Size = new Size(41, 18);
            lblName.TabIndex = 8;
            lblName.Text = "label9";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(214, 92);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(47, 18);
            lblLastName.TabIndex = 9;
            lblLastName.Text = "label10";
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Location = new Point(214, 124);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(47, 18);
            lblCompany.TabIndex = 10;
            lblCompany.Text = "label11";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(214, 158);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(47, 18);
            lblPhoneNumber.TabIndex = 11;
            lblPhoneNumber.Text = "label12";
            // 
            // lblCreateAt
            // 
            lblCreateAt.AutoSize = true;
            lblCreateAt.Location = new Point(214, 189);
            lblCreateAt.Name = "lblCreateAt";
            lblCreateAt.Size = new Size(47, 18);
            lblCreateAt.TabIndex = 12;
            lblCreateAt.Text = "label13";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(214, 223);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(47, 18);
            lblDescription.TabIndex = 13;
            lblDescription.Text = "label14";
            // 
            // btnclose
            // 
            btnclose.Location = new Point(121, 271);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(102, 41);
            btnclose.TabIndex = 14;
            btnclose.Text = "برگشت";
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // frmDitailContact
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 324);
            Controls.Add(btnclose);
            Controls.Add(lblDescription);
            Controls.Add(lblCreateAt);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblCompany);
            Controls.Add(lblLastName);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("B Nazanin", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmDitailContact";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmDitailContact";
            Load += frmDitailContact_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblId;
        private Label lblName;
        private Label lblLastName;
        private Label lblCompany;
        private Label lblPhoneNumber;
        private Label lblCreateAt;
        private Label lblDescription;
        private Button btnclose;
    }
}