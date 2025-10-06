using System;
using System.Windows.Forms;

namespace Lab3_WinForms_Processor
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Processor firstProcessor = new Processor();
            fProcessor inputForm = new fProcessor(firstProcessor);

            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new fMain(firstProcessor));
            }
        }
    }
}


