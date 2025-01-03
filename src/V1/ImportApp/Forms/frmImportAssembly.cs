using Mono.Cecil;
using ImportApp.Model;

namespace ImportApp.Forms
{
    public partial class frmImportAssembly : Form
    {
        private ImportAssemblyConfig _config;
        private List<TypeDefinition> _types;

        public frmImportAssembly()
        {
            InitializeComponent();
        }

        public bool LoadFormData(string filename)
        {
            try
            {
                // Get all the types in the assembly
                _types = AssemblyDefinition
                    .ReadAssembly(filename)
                    .MainModule
                    .Types
                    .ToList();

                // Add them to the listbox
                foreach (var t in _types)
                {
                    clbObjects.Items.Add(t);
                }

                // Store our config
                _config = new ImportAssemblyConfig()
                {
                    Filename = filename
                };
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading assembly " + filename + ". Exception: " + ex.Message);
                return false;
            }
        }

        private void txtModule_TextChanged(object sender, EventArgs e)
        {
            if (txtModule.Text.Contains(" "))
                txtModule.Text = txtModule.Text.Replace(" ", "");
            _config.Module = txtModule.Text;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Validation
            if (txtName.Text.Length == 0)
            {
                MessageBox.Show("Please enter a valid value for microservice name");
                return;
            }
            if (txtName.Text.Length == 0)
            {
                MessageBox.Show("Please enter a valid value for microservice description");
                return;
            }
            if (txtModule.Text.Length == 0)
            {
                MessageBox.Show("Please enter a valid value for microservice module ");
                return;
            }
            if (clbObjects.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one item");
                return;
            }

            // Set config values
            _config.Name = txtName.Text;
            _config.Description = txtDescription.Text;
            _config.Module = txtModule.Text;
            _config.AssumeFirstPropIsPk = ckbAssumeFirstPropIsPk.Checked;

            // Add all selected objects
            _config.TypeDefinitions.Clear();
            foreach (var t in clbObjects.CheckedItems)
                _config.TypeDefinitions.Add((Mono.Cecil.TypeDefinition)t);

            // Show the next form
            frmImportAssemblyObjects frm = new frmImportAssemblyObjects();
            if (frm.LoadFormData(_config))
                Program.SetMainForm(frm);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            Program.SetMainForm(frm);
        }
    }
}