using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VeriSifrelemeImzalamaUygulamasi
{
    public partial class Form3PersonalDetails : Form
    {
        // Kullanicilarin isim, email, yorum, passphrase bilgilerinin alinmasi

        bool isCompleteName = false;
        bool isCompleteEmail = true;
        
        public Form3PersonalDetails()
        {
            InitializeComponent();
        }

        private void FormPersonalDetails_Load(object sender, EventArgs e)
        {
            textBoxPassphrase.KeyPress += new KeyPressEventHandler(textBoxPassphrase_KeyPress);
            textBoxRepeat.KeyPress += new KeyPressEventHandler(textBoxPassphrase_KeyPress);

            buttonNextInfo.Enabled = false;
            labelWarning.Visible = false;
            buttonTogglePassphrase.Visible = false;

            groupBoxInfo.Visible = true;
            groupBoxPassphrase.Visible = false;
            Height = groupBoxInfo.Height + 60;
            Width = groupBoxInfo.Width + 35;

            progressBarQuality.Minimum = 0;
            progressBarQuality.Maximum = 10;
            progressBarQuality.Step = 1;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            while (textBoxName.Text.Length != 0 && textBoxName.Text[textBoxName.Text.Length - 1] == ' ')
            {
                textBoxName.Text = textBoxName.Text.Substring(0, textBoxName.Text.Length - 1);
            }
            if (textBoxName.Text.Length >= 3)
            {
                if (isCompleteEmail)
                {
                    buttonNextInfo.Enabled = true;
                    labelWarning.Visible = false;
                }
                isCompleteName = true;
            }
            else
            {
                buttonNextInfo.Enabled = false;
                labelWarning.Text = "Ad tamamlanmadı.";
                labelWarning.Visible = true;
                isCompleteName = false;
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Length != 0 && !IsValidEmail(textBoxEmail.Text))
            {
                buttonNextInfo.Enabled = false;
                if (isCompleteName)
                {
                    labelWarning.Text = "E-posta tamamlanmadı.";
                }
                labelWarning.Visible = true;
                isCompleteEmail = false;
            }
            else
            {
                if (isCompleteName)
                {
                    buttonNextInfo.Enabled = true;
                    labelWarning.Visible = false;
                }
                isCompleteEmail = true;
            }
        }

        bool IsValidEmail(string strIn) // https://stackoverflow.com/a/13704625/5589417
        {
            return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        private void buttonNextInfo_Click(object sender, EventArgs e)
            {
            if (isCompleteName && isCompleteEmail)
            {
                groupBoxInfo.Visible = false;
                groupBoxPassphrase.Visible = true;
                Height = groupBoxPassphrase.Height + 60;
                Width = groupBoxPassphrase.Width + 35;
            }
        }

        Form4Warning warning;
        string passphrase = "";
        private void buttonNextKey_Click(object sender, EventArgs e)
        {
            passphrase = textBoxPassphrase.Text;
            if (passphrase.Equals(textBoxRepeat.Text))
            {
                if (Regex.IsMatch(passphrase, @"^[a-zA-Z]+$") || passphrase.Length < 8)
                {
                    warning = new Form4Warning(); //
                    warning.Show(this);
                    warning.Disposed += warning_FormClosed;
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Parolalar eşleşmiyor.");
            }
        }

        private void warning_FormClosed(object sender, EventArgs e)
        {
            if (warning.DialogResult == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxPassphrase_TextChanged(object sender, EventArgs e)
        {
            buttonNextKey.Enabled = (textBoxPassphrase.Text.Length != 0);
            buttonTogglePassphrase.Visible = (textBoxPassphrase.Text.Length != 0);
            progressBarQuality.Value = Math.Min(progressBarQuality.Maximum, textBoxPassphrase.Text.Length);
        }

        private void textBoxPassphrase_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keys key = (Keys)e.KeyChar;
            if (key == Keys.Space)
            {
                e.Handled = true;
            }
        }

        bool hide = true;
        private void buttonTogglePassphrase_Click(object sender, EventArgs e)
        {
            if (hide)
            {
                hide = false;
                textBoxPassphrase.PasswordChar = '\0';
                textBoxRepeat.PasswordChar = '\0';
            }
            else
            {
                hide = true;
                textBoxPassphrase.PasswordChar = '●';
                textBoxRepeat.PasswordChar = '●';
            }
            this.Focus();
        }
    }
}