using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SINAVHESAPLAMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHespla_Click(object sender, EventArgs e)
        {
            int NOT1, NOT2;
            double sonuc;

            NOT1 =Convert.ToInt32(txtNot1.Text);
            NOT2 =Convert.ToInt32(txtNot2.Text);
            sonuc =( NOT1 + NOT2) / 2;

            lblSucu. Text = sonuc.ToString();

        }
    }
}
