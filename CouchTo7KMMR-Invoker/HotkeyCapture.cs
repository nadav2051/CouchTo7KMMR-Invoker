using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CouchTo7KMMR_Invoker
{
    public partial class HotkeyCapture : Form
    {
        TextBox targetTextbox;
        public HotkeyCapture(TextBox target)
        {
            this.targetTextbox = target;
            InitializeComponent();
        }
        public void onKeyPress(object sender, KeyEventArgs e)
        {
            this.targetTextbox.Text = e.KeyData.ToString();
            this.Close();
        }

        private void HotkeyCapture_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
