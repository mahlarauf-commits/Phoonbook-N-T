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
    public partial class frmedit : Form
    {
        private readonly ContactService ContactService;
        private readonly int Contactid;
        public frmedit(int contactid)
        {
            InitializeComponent();
            ContactService = new ContactService();
            this.Contactid = contactid;
        }

        private void frmedit_Load(object sender, EventArgs e)
        {
            var contact = ContactService.GetContactDetatil(Contactid);
            if (contact.IsSuccess == false)
            {
                MessageBox.Show(contact.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtName.Text = contact.Data.Name;
                textBox2.Text = contact.Data.LastName;
                textBox3.Text = contact.Data.Company;
                textBox4.Text = contact.Data.Description;
                textBox5.Text = contact.Data.PhoneNumber;
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = ContactService.EditContact(new BLL.Dto.EditContactDto
            {
                Id = this.Contactid,
                Company = txtName.Text,
                Description = textBox2.Text,
                LastName = textBox3.Text,
                Name = textBox4.Text,
                PhoneNumber = textBox5.Text,

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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
