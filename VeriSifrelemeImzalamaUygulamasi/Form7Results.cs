using System;
using System.Windows.Forms;

namespace VeriSifrelemeImzalamaUygulamasi
{
    public partial class Form7Results : Form
    {
        public Form7Results()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
