using BLL.Services;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI.Forms 
{
    public partial class frmDitailContact : Form
    {
        private readonly ContactService ContactService;
        private readonly int ContactId;
        public frmDitailContact(int ContactId)
        {
            InitializeComponent();
            ContactService = new ContactService();
            this.ContactId = ContactId;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmDitailContact_Load(object sender, EventArgs e)
        {
            var contact = ContactService.GetContactDetatil(ContactId);
            if (contact.IsSuccess == false)
            {
                MessageBox.Show(contact.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblId.Text = contact.Data.Id.ToString();
            lblName.Text = contact.Data.Name;
            lblLastName.Text = contact.Data.LastName;
            lblCompany.Text = contact.Data.Company;
            lblPhoneNumber.Text = contact.Data.PhoneNumber;
            lblDescription.Text = contact.Data.Description;
            lblCreateAt.Text = contact.Data.CreateAt.ToString();
        }


        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
