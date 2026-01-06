using BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class frmMain : Form
    {
        private readonly ContactService ContactService;
        public frmMain()
        {
            InitializeComponent();
            ContactService = new ContactService();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            var listContact = ContactService.GetContactLists();
            SettingGridview(listContact);

            this.Cursor = Cursors.Default;
        }

        private void SettingGridview(List<BLL.Dto.ContactListDto> listContact)
        {
            dataGridView1.DataSource = listContact;
            dataGridView1.Columns[0].HeaderText = "شناسه";
            dataGridView1.Columns[1].HeaderText = "نام";
            dataGridView1.Columns[2].HeaderText = "شماره تلفن";

            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            var listcontacts = ContactService.SearchContant(txtSearchKey.Text);
            SettingGridview(listcontacts);
            this.Cursor = Cursors.Default;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            var Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            var result = ContactService.DeleteContact(Id);
            if (result.IsSuccess == true)
            {
                MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMain_Load(null, null);
            }
            else
            {
                MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            ShowDetail();
        }

        private void ShowDetail()
        {
            var Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            frmDitailContact frmDitailContact = new frmDitailContact(Id);
            frmDitailContact.ShowDialog();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ShowDetail();
        }

        private void dcBtnSaveContact_Click(object sender, EventArgs e)
        {
            frmAddContact frmAddContact = new frmAddContact();
            frmAddContact.ShowDialog();
            frmMain_Load(null, null);
        }

        private void ecBtnEditContact_Click(object sender, EventArgs e)
        {
            var Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            frmedit frmedit = new frmedit(Id);
            frmedit.ShowDialog();
            frmMain_Load(null, null);
        }
    }
}
