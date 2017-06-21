using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption_Strategy_Design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private IEncrypt myEncrypt;
        private AppManager myManager;

        private void Form1_Load(object sender, EventArgs e)
        {
            myEncrypt = new ROT13();
            myManager = new AppManager(myEncrypt);
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            String myInput = txtBoxInput.Text;
            String encryptedString = myManager.encrypt(myInput);
            txtBoxOutput.Text = encryptedString;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            String myInput = txtBoxInput.Text;
            String decryptedString = myManager.decrypt(myInput);
            txtBoxOutput.Text = decryptedString;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            myManager.myEncrypt = new ROT13();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            myManager.myEncrypt = new StringReverse();
        }
    }
}
