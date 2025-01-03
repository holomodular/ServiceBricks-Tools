using System.ComponentModel;
using ImportApp.Model;
using Newtonsoft.Json;

namespace ImportApp.Forms
{
    public partial class frmImportAssemblyObjects : Form
    {
        private const string MATCH_DOT = @".";
        private const string MATCH_SYSTEMDOT = @"System.";
        private const string MATCH_NULLABLE = @"Nullable`1";
        private const string MATCH_LESSTHAN = @"<";
        private const string MATCH_GREATERTHAN = @">";
        private const string MATCH_GENERICTYPE = @"`1";

        private ImportAssemblyConfig _config;
        private ImportObject _selected;

        public frmImportAssemblyObjects()
        {
            InitializeComponent();
        }

        public bool LoadFormData(ImportAssemblyConfig config)
        {
            _config = config;
            _config.ImportObjects = ConvertImportObjects();
            lbObjects.DisplayMember = "Name";
            lbObjects.DataSource = _config.ImportObjects;
            return true;
        }

        private List<ImportObject> ConvertImportObjects()
        {
            List<ImportObject> list = new List<ImportObject>();
            foreach (var t in _config.TypeDefinitions)
            {
                var obj = new ImportObject()
                {
                    Name = t.FullName,
                    ModelName = t.Name,
                    Description = t.Name
                };
                bool firstProp = true;
                foreach (var p in t.Properties)
                {
                    string dataTypeName = p.PropertyType.FullName;
                    dataTypeName = dataTypeName.Replace(MATCH_SYSTEMDOT, "");

                    // Change nullable syntax
                    if (dataTypeName.Contains(MATCH_NULLABLE))
                    {
                        dataTypeName = dataTypeName
                            .Replace(MATCH_NULLABLE, "")
                            .Replace(MATCH_LESSTHAN, "")
                            .Replace(MATCH_GREATERTHAN, "");
                        dataTypeName += "?";
                    }

                    // collections/generic types not supported in base model
                    if (dataTypeName.Contains(MATCH_GENERICTYPE))
                        continue;

                    // If it has a dot in the name, not a base type
                    if (dataTypeName.Contains(MATCH_DOT))
                        continue;

                    var prop = new ImportProperty()
                    {
                        Name = p.Name,
                        DotNetType = dataTypeName
                    };
                    // Check default primary key
                    if (firstProp)
                    {
                        firstProp = false;
                        if (_config.AssumeFirstPropIsPk)
                            prop.IsPrimaryKey = true;
                    }

                    // Add property
                    obj.Properties.Add(prop);
                }
                list.Add(obj);
            }
            return list;
        }

        private void lbObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selected = (ImportObject)lbObjects.SelectedItem;
            dgProperties.DataSource = _selected.Properties;
            txtModelName.Text = _selected.ModelName;
            txtDescription.Text = _selected.Description;
        }

        private void txtModelName_TextChanged(object sender, EventArgs e)
        {
            if (txtModelName.Text.Contains(" "))
                txtModelName.Text = txtModelName.Text.Replace(" ", "");
            _selected.ModelName = txtModelName.Text;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            _selected.Description = txtDescription.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate a primary key specified for all models
            foreach (var item in _config.ImportObjects)
            {
                bool pkfound = false;
                foreach (var prop in item.Properties)
                {
                    if (prop.IsPrimaryKey)
                    {
                        pkfound = true;
                        break;
                    }
                }
                if (!pkfound)
                {
                    MessageBox.Show($"Missing PrimaryKey on object {item.Name}");
                    return;
                }
            }

            // Save file dialog
            saveFileDialog1.ShowDialog(this);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string filename = saveFileDialog1.FileName;
            var microservice = ConvertToServiceBricksMicroservice();
            string data = JsonConvert.SerializeObject(microservice);
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            using (StreamWriter sw = new StreamWriter(fs))
                sw.Write(data);

            MessageBox.Show("Complete! Import your file at ServiceBricks.com");

            frmMain frmMain = new frmMain();
            Program.SetMainForm(frmMain);
        }

        private Microservice ConvertToServiceBricksMicroservice()
        {
            Microservice microservice = new Microservice()
            {
                Name = _config.Name,
                Description = _config.Description,
                ModuleName = _config.Module,
            };
            foreach (var importObj in _config.ImportObjects)
            {
                var model = new MicroserviceModel()
                {
                    Name = importObj.ModelName,
                    Description = importObj.Description,
                };
                microservice.Models.Add(model);
                foreach (var importProp in importObj.Properties)
                {
                    var prop = new MicroserviceModelProperty()
                    {
                        Name = importProp.Name,
                        Description = importProp.Description,
                        DotNetType = importProp.DotNetType,
                        IsPrimaryKey = importProp.IsPrimaryKey,
                    };
                    model.Properties.Add(prop);
                }
            }
            return microservice;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmImportAssembly frm = new frmImportAssembly();
            if (frm.LoadFormData(_config.Filename))
                Program.SetMainForm(frm);
        }
    }
}