using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartMO4Databases
{
  public partial class LocalPhoneForm : Form
  {
    public LocalPhoneForm()
    {
      InitializeComponent();
    }

    private void phoneListTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
            this.Validate();
            this.phoneListTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.localPhoneDbDataSet1);

        }

    private void LocalPhoneForm_Load(object sender, EventArgs e)
    {
            // TODO: This line of code loads data into the 'localPhoneDbDataSet1.PhoneListTable' table. You can move, or remove it, as needed.
            this.phoneListTableTableAdapter.Fill(this.localPhoneDbDataSet1.PhoneListTable);

        }
    }
}
