using System;
using System.Windows.Forms;

namespace VeriSifrelemeImzalamaUygulamasi
{
    public partial class Form1SelectUser : Form
    {
        public Form1SelectUser()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonUser.Enabled = false;
        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonUser.Enabled = (comboBoxUser.SelectedIndex != -1); 
        }

        // Gonderen ve alici kullanicilarindan hangisinin arayuzunun acilacaginin belirlenmesi
        private void buttonUser_Click(object sender, EventArgs e)
        {
            bool isSender = (comboBoxUser.SelectedIndex == 0) ? true : false;
            Form2User user = new Form2User(isSender);
            user.Show(this);
        }
    }
}
