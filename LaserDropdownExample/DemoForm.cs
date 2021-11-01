using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaserDropdownExample
{
    public partial class DemoForm : Form
    {

        public BeltWidth beltWidth = new BeltWidth();
        public CarcassStyle carcass = new CarcassStyle();
        public MshaCertification mshaCertification = new MshaCertification();
        //The empty list is used as a default when no Minehaul or Mineflex carcass is selected.
        public IList<string> emptyList = new List<string>() { "" }; 

        public DemoForm()
        {
            InitializeComponent();
            InitializeBeltWidthCombobox();
            InitializeCarcassStyleCombobox();
        }

        private void InitializeBeltWidthCombobox()
        {
            cmbBeltWidth.DataSource = new BindingSource(beltWidth.BeltWidths, null);
            cmbBeltWidth.DisplayMember = "Key";
            cmbBeltWidth.ValueMember = "Value";
        }

        private void InitializeCarcassStyleCombobox()
        {
            cmbCarcassStyle.DataSource = new BindingSource(carcass.CarcassStyles, null);
            cmbCarcassStyle.DisplayMember = "Key";
        }

        //Listens for changes in the Carcass Style combo box, and populates the MSHA Cert. combo box accordingling.
        private void cmbCarcassStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            string selectedCarcass = (string)cmbCarcassStyle.SelectedItem;

            if (selectedCarcass == "MINEHAUL SUPREME")
            {
                cmbMshaCertification.DataSource = new BindingSource(mshaCertification.MinehaulCertifications, null);
            }
            else if (selectedCarcass == "MINEFLEX SUPREME")
            {
                cmbMshaCertification.DataSource = new BindingSource(mshaCertification.MineflexCertifications, null);
            }
            else
            {
                cmbMshaCertification.DataSource = emptyList;
            }
        }

    }
}
