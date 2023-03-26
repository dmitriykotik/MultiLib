using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiLib
{
    public partial class qrAuth : Form
    {
        public qrAuth()
        {
            InitializeComponent();
        }

        private void qrcode_Click(object sender, EventArgs e)
        {

        }

        public void start(string name, string email, string secretKey, System.IO.Stream image)
        {
            nameL.Text = "Имя: " + name;
            epl.Text = @"Email\Phone...:" + email;
            sec.Text = secretKey;
            qrcode.Image = Image.FromStream(image);
            Show();
        }

    }
}
