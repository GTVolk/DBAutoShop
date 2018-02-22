using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using DBAutoShop.Controllers;

namespace DBAutoShop.MainForms
{
    public partial class ConnectionWizard : Form
    {
        string ConnectString = "";
        string ConnectStringMasked = "";
        string PasswordMask = "";
        byte ConnectStatus = 0;
        bool LastCheckState = false;

        public ConnectionWizard()
        {
            InitializeComponent();

            DatabaseControlService.ReadINI();
            UserName.Text = DatabaseControlService.UserName;
            DataSource.Text = DatabaseControlService.DataSource;
            if (DatabaseControlService.SavePassword)
            {
                ConnectBySQL.Checked = true;
                string Pass = "";
                DatabaseControlService.PasswordLoad(ref Pass);
                Password.Text = Pass;
                UpdateMask();
                PasswordCheck.Checked = true;
            }
            else
            {
                UpdateParameters();
                PasswordCheck.Enabled = false;
            }
            if (DatabaseControlService.ConnectString != "") ConnectionString.Text = DatabaseControlService.ConnectString;
            UpdateConnectString();
        }

        private void UpdateConnectString()
        {
            if (PasswordMask != "")
                ConnectString = ConnectionString.Text.Replace(PasswordMask, Password.Text);
        }

        private void UpdateMask()
        {
            PasswordMask = "";
            for (int i = 0; i < Password.TextLength; i++)
                PasswordMask = PasswordMask + "*";
        }

        private void UpdateParameters()
        {
            if (ConnectByWindows.Checked)
            {
                if (DataSource.Text != "")
                    ConnectString = "Data Source = " + DataSource.Text + "; Initial Catalog = AutoShop; Integrated Security = True";
                else ConnectString = "Initial Catalog = AutoShop; Integrated Security = True";
                ConnectStringMasked = ConnectString;
                ConnectionString.Text = ConnectStringMasked;
            }
            if (ConnectBySQL.Checked)
            {
                if (DataSource.Text != "")
                    ConnectString = "Data Source = " + DataSource.Text + "; Initial Catalog = AutoShop; Integrated Security = False; User ID = " + UserName.Text + "; Password = " + Password.Text;
                else ConnectString = "Initial Catalog = AutoShop; Integrated Security = False; User ID = " + UserName.Text + "; Password = " + Password.Text;
                if (DataSource.Text != "")
                    ConnectStringMasked = "Data Source = " + DataSource.Text + "; Initial Catalog = AutoShop; Integrated Security = False; User ID = " + UserName.Text + "; Password = " + PasswordMask;
                else ConnectStringMasked = "Initial Catalog = AutoShop; Integrated Security = False; User ID = " + UserName.Text + "; Password = " + PasswordMask;
                ConnectionString.Text = ConnectStringMasked;
            }
        }

        private void ConnectByWindows_CheckedChanged(object sender, EventArgs e)
        {
            UserName.Enabled = false;
            Password.Enabled = false;
            PasswordCheck.Enabled = false;
            PasswordCheck.Checked = false;
            UpdateParameters();
        }

        private void ConnectBySQL_CheckedChanged(object sender, EventArgs e)
        {
            UserName.Enabled = true;
            Password.Enabled = true;
            PasswordCheck.Enabled = true;
            if (ConnectByWindows.Checked) LastCheckState = PasswordCheck.Checked;
            if (LastCheckState) PasswordCheck.Checked = true;
            UpdateParameters();
        }

        private void UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            UpdateParameters();
        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (!Char.IsControl(e.KeyChar))
            {
                (sender as MaskedTextBox).Text = (sender as MaskedTextBox).Text + e.KeyChar;
            }
            if (e.KeyChar == '\b')
                if ((sender as MaskedTextBox).Text != "")
                    (sender as MaskedTextBox).Text = (sender as MaskedTextBox).Text.Remove((sender as MaskedTextBox).TextLength - 1);
            (sender as MaskedTextBox).SelectionStart = (sender as MaskedTextBox).TextLength;
            PasswordMask = "";
            for (int i = 0; i < (sender as MaskedTextBox).TextLength; i++)
                PasswordMask = PasswordMask + "*";
            UpdateParameters();
        }

        private void DataSource_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (!Char.IsControl(e.KeyChar))
            {
                (sender as TextBox).Text = (sender as TextBox).Text + e.KeyChar;
            }
            if (e.KeyChar == '\b')
                if ((sender as TextBox).Text != "")
                    (sender as TextBox).Text = (sender as TextBox).Text.Remove((sender as TextBox).TextLength - 1);
            (sender as TextBox).SelectionStart = (sender as TextBox).TextLength;
            UpdateParameters();
        }

        private void ConnectionString_TextChanged(object sender, EventArgs e)
        {
            UpdateConnectString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ConnectionString.Text != "")
                if (DatabaseControlService.SQL.CheckConnection(ConnectString))
                {
                    DatabaseControlService.SQL.ConnectString = ConnectString;
                    MessageBox.Show("Подключение успешно! Приятной работы", "Подключение установлено!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConnectStatus = 1;
                    if (PasswordCheck.Checked) DatabaseControlService.PasswordSave(Password.Text);
                    DatabaseControlService.DataSource = DataSource.Text;
                    DatabaseControlService.SavePassword = PasswordCheck.Checked;
                    DatabaseControlService.UserName = UserName.Text;
                    UpdateMask();
                    if (PasswordCheck.Checked)
                        DatabaseControlService.ConnectString = ConnectionString.Text;
                    else if (PasswordMask != "") DatabaseControlService.ConnectString = ConnectionString.Text.Replace(PasswordMask, " ");
                    this.Close();
                }
                else MessageBox.Show("Не удалось подключиться!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else MessageBox.Show("Запоните строку подключения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Exit()
        {
            if (ConnectStatus != 1)
            {
                DatabaseControlService.DataSource = DataSource.Text;
                DatabaseControlService.WriteINI();
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void ConnectionWizard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Exit();
        }

    }
}
