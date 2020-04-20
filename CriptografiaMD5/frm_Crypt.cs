using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriptografiaMD5
{
    public partial class frm_Crypt : Form
    {
        public frm_Crypt()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_encrypt_Click(object sender, EventArgs e)
        {
            string strToCript = txt_toEncript.Text;
            strToCript = MD5Crypt.Criptografar(strToCript);
            txt_ResultEncript.Text = strToCript;
        }

        private void bt_decript_Click(object sender, EventArgs e)
        {
            string strToDecript = txt_toDecript.Text;
            strToDecript = MD5Crypt.Descriptografar(strToDecript);
            txt_ResultDecript.Text = strToDecript;
        }
    }
}
