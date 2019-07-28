using System;
using System.Windows.Forms;

namespace VeriSifrelemeImzalamaUygulamasi
{
    public partial class Form4Warning : Form
    {
        // Passphrase'in guvenliligi hakkinda uyari
        public Form4Warning()
        {
            InitializeComponent();
        }

        private void buttonPickNewOne_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonTakeThisOne_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}