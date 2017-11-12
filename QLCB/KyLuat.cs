using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLCB
{
    public partial class KyLuat : Form
    {
        public KyLuat()
        {
            InitializeComponent();
        }
        private TTCBEntities cb = new TTCBEntities();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void KyLuat_Load(object sender, EventArgs e)
        {
            var kyluat = cb.Bangkyluats.ToList();
            dataGridView1.DataSource = kyluat;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var kl = new KyLuat
            {
                //Kyluatdang = 
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        
    }
}
