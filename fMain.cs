using System;
using System.Windows.Forms;

namespace Lab3_WinForms_Processor
{
    public partial class fMain : Form
    {
        public fMain(Processor processor)
        {
            InitializeComponent();
            btnAddProcessor.Click += btnAddProcessor_Click;
            btnClose.Click += btnClose_Click;

        }
        private void fMain_Load(object sender, EventArgs e)
        {
        }
        private void btnAddProcessor_Click(object sender, EventArgs e)
        {
            Processor p = new Processor(); 
            fProcessor form = new fProcessor(p); 
            if (form.ShowDialog() == DialogResult.OK) 
            {
                tbProcessorsInfo.AppendText(p.ToString() + Environment.NewLine); 
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Приминити роботу застосунку?", "Підтвердження",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Close(); 
            }
        }
    }
}
