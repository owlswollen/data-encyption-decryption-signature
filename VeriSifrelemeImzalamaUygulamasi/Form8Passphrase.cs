using System;
using System.Windows.Forms;

namespace VeriSifrelemeImzalamaUygulamasi
{
    public partial class Form8Passphrase : Form
    {
        public Form8Passphrase(string name)
        {
            InitializeComponent();
            labelUserName.Text = "\"" + name + "\" kullanıcısının anahtar parolası:";
            buttonTogglePassphrase.Visible = false;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxPassphrase_TextChanged(object sender, EventArgs e)
        {
            buttonNext.Enabled = (textBoxPassphrase.Text.Length != 0);
            buttonTogglePassphrase.Visible = (textBoxPassphrase.Text.Length != 0);
        }

        bool hide = true;
        private void buttonTogglePassphrase_Click(object sender, EventArgs e)
        {
            if (hide)
            {
                hide = false;
                textBoxPassphrase.PasswordChar = '\0';
            }
            else
            {
                hide = true;
                textBoxPassphrase.PasswordChar = '●';
            }
            this.Focus();
        }
    }
}
