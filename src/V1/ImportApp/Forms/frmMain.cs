using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportApp.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnImportAssembly_Click(object sender, EventArgs e)
        {
            fileDialogImportAssembly.ShowDialog();
        }

        private void btnImportDatabase_Click(object sender, EventArgs e)
        {
            frmImportDatabase form = new frmImportDatabase();
            form.Show();
        }

        private void fileDialogImportAssembly_FileOk(object sender, CancelEventArgs e)
        {
            string filename = fileDialogImportAssembly.FileName;
            frmImportAssembly form = new frmImportAssembly();
            if (form.LoadFormData(filename))
                Program.SetMainForm(form);
        }
    }
}