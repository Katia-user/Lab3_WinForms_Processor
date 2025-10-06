using System;
using System.Windows.Forms;

namespace Lab3_WinForms_Processor
{
    public partial class fProcessor : Form
    {
        public Processor TheProcessor;

        public fProcessor(Processor processor)
        {
            InitializeComponent();
            TheProcessor = processor;

            btnOk.Click += btnOk_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                TheProcessor.Brand = tbBrand.Text;
                TheProcessor.Model = tbModel.Text;
                TheProcessor.Generation = int.Parse(tbGeneration.Text);
                TheProcessor.Frequency = double.Parse(tbFrequency.Text.Replace('.', ','));
                TheProcessor.Cores = int.Parse(tbCores.Text);
                TheProcessor.Year = int.Parse(tbYear.Text);
                TheProcessor.Cache = int.Parse(tbCache.Text);
                TheProcessor.HasIntegratedGraphics = chbIntegratedGraphics.Checked;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Перевірте правильність введених числових даних!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
