namespace UI.Forms
{
    partial class frmAddContact
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
            dcLblName = new Label();
            dcLblLastName = new Label();
            dcLblCompany = new Label();
            dcLblPhoneNumber = new Label();
            dcLblDescription = new Label();
            dcBtnNewContact = new Button();
            dcTxtName = new TextBox();
            dcTxtLastName = new TextBox();
            dcTxtCompany = new TextBox();
            dcTxtPhoneNumber = new TextBox();
            dcTxtDescription = new TextBox();
            label6 = new Label();
            dcBtnClose = new Button();
            SuspendLayout();
            // 
            // dcLblName
            // 
            dcLblName.AutoSize = true;
            dcLblName.Font = new Font("B Nazanin", 12F);
            dcLblName.Location = new Point(113, 88);
            dcLblName.Name = "dcLblName";
            dcLblName.Size = new Size(26, 24);
            dcLblName.TabIndex = 0;
            dcLblName.Text = "نام:";
            // 
            // dcLblLastName
            // 
            dcLblLastName.AutoSize = true;
            dcLblLastName.Font = new Font("B Nazanin", 12F);
            dcLblLastName.Location = new Point(113, 130);
            dcLblLastName.Name = "dcLblLastName";
            dcLblLastName.Size = new Size(75, 24);
            dcLblLastName.TabIndex = 1;
            dcLblLastName.Text = "نام خانوادگی:";
            // 
            // dcLblCompany
            // 
            dcLblCompany.AutoSize = true;
            dcLblCompany.Font = new Font("B Nazanin", 12F);
            dcLblCompany.Location = new Point(113, 172);
            dcLblCompany.Name = "dcLblCompany";
            dcLblCompany.Size = new Size(45, 24);
            dcLblCompany.TabIndex = 2;
            dcLblCompany.Text = "شرکت:";
            // 
            // dcLblPhoneNumber
            // 
            dcLblPhoneNumber.AutoSize = true;
            dcLblPhoneNumber.Font = new Font("B Nazanin", 12F);
            dcLblPhoneNumber.Location = new Point(113, 216);
            dcLblPhoneNumber.Name = "dcLblPhoneNumber";
            dcLblPhoneNumber.Size = new Size(68, 24);
            dcLblPhoneNumber.TabIndex = 3;
            dcLblPhoneNumber.Text = "شماره تلفن:";
            // 
            // dcLblDescription
            // 
            dcLblDescription.AutoSize = true;
            dcLblDescription.Font = new Font("B Nazanin", 12F);
            dcLblDescription.Location = new Point(113, 260);
            dcLblDescription.Name = "dcLblDescription";
            dcLblDescription.Size = new Size(60, 24);
            dcLblDescription.TabIndex = 4;
            dcLblDescription.Text = "توضیحات:";
            // 
            // dcBtnNewContact
            // 
            dcBtnNewContact.Location = new Point(60, 374);
            dcBtnNewContact.Name = "dcBtnNewContact";
            dcBtnNewContact.Size = new Size(188, 35);
            dcBtnNewContact.TabIndex = 5;
            dcBtnNewContact.Text = "ثبت مخاطب جدید";
            dcBtnNewContact.UseVisualStyleBackColor = true;
            dcBtnNewContact.Click += dcBtnNewContact_Click;
            // 
            // dcTxtName
            // 
            dcTxtName.Location = new Point(236, 81);
            dcTxtName.Name = "dcTxtName";
            dcTxtName.Size = new Size(175, 25);
            dcTxtName.TabIndex = 8;
            // 
            // dcTxtLastName
            // 
            dcTxtLastName.Location = new Point(236, 123);
            dcTxtLastName.Name = "dcTxtLastName";
            dcTxtLastName.Size = new Size(175, 25);
            dcTxtLastName.TabIndex = 9;
            // 
            // dcTxtCompany
            // 
            dcTxtCompany.Location = new Point(236, 165);
            dcTxtCompany.Name = "dcTxtCompany";
            dcTxtCompany.Size = new Size(175, 25);
            dcTxtCompany.TabIndex = 10;
            // 
            // dcTxtPhoneNumber
            // 
            dcTxtPhoneNumber.Location = new Point(236, 209);
            dcTxtPhoneNumber.Name = "dcTxtPhoneNumber";
            dcTxtPhoneNumber.Size = new Size(175, 25);
            dcTxtPhoneNumber.TabIndex = 11;
            // 
            // dcTxtDescription
            // 
            dcTxtDescription.Location = new Point(236, 253);
            dcTxtDescription.Multiline = true;
            dcTxtDescription.Name = "dcTxtDescription";
            dcTxtDescription.Size = new Size(175, 80);
            dcTxtDescription.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("B Nazanin", 15F);
            label6.Location = new Point(156, 29);
            label6.Name = "label6";
            label6.Size = new Size(143, 29);
            label6.TabIndex = 13;
            label6.Text = "افزودن مخاطب جدید";
            // 
            // dcBtnClose
            // 
            dcBtnClose.Location = new Point(277, 374);
            dcBtnClose.Name = "dcBtnClose";
            dcBtnClose.Size = new Size(105, 31);
            dcBtnClose.TabIndex = 14;
            dcBtnClose.Text = "برگشت";
            dcBtnClose.UseVisualStyleBackColor = true;
            // 
            // frmAddContact
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 421);
            Controls.Add(dcBtnClose);
            Controls.Add(label6);
            Controls.Add(dcTxtDescription);
            Controls.Add(dcTxtPhoneNumber);
            Controls.Add(dcTxtCompany);
            Controls.Add(dcTxtLastName);
            Controls.Add(dcTxtName);
            Controls.Add(dcBtnNewContact);
            Controls.Add(dcLblDescription);
            Controls.Add(dcLblPhoneNumber);
            Controls.Add(dcLblCompany);
            Controls.Add(dcLblLastName);
            Controls.Add(dcLblName);
            Font = new Font("B Nazanin", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAddContact";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmAddContact";
            Load += frmAddContact_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dcLblName;
        private Label dcLblLastName;
        private Label dcLblCompany;
        private Label dcLblPhoneNumber;
        private Label dcLblDescription;
        private Button dcBtnNewContact;
        private TextBox dcTxtName;
        private TextBox dcTxtLastName;
        private TextBox dcTxtCompany;
        private TextBox dcTxtPhoneNumber;
        private TextBox dcTxtDescription;
        private Label label6;
        private Button dcBtnClose;
    }
}