using BLL.Services;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI.Forms
{
    public partial class frmAddContact : Form

    {
        private readonly ContactService ContactService;
        public frmAddContact()
        {
            InitializeComponent();
            ContactService = new ContactService();
        }

        private void frmAddContact_Load(object sender, EventArgs e)
        {

        }

        private void dcBtnNewContact_Click(object sender, EventArgs e)
        {
            var result = ContactService.AddNewContact(new BLL.Dto.AddNewContactDto
            {
                Name = dcTxtName.Text,
                LastName = dcTxtLastName.Text,
                Company = dcTxtCompany.Text,
                PhoneNumber = dcTxtPhoneNumber.Text,
                Description = dcTxtDescription.Text,
            });
            if (result.IsSuccess)
            {
                MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
            MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
