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
  public partial class LandingForm : Form
  {
    public LandingForm()
    {
      InitializeComponent();
    }

    private void phoneListTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.phoneListTableBindingSource.EndEdit();
      this.tableAdapterManager.UpdateAll(this.localPhoneDbDataSet1);

    }

    private void Form1_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'localPhoneDbDataSet1.PhoneListTable' table. You can move, or remove it, as needed.
      this.phoneListTableTableAdapter.Fill(this.localPhoneDbDataSet1.PhoneListTable);

    }


    private void BtnImportedNums_Click(object sender, EventArgs e)
    {

    }

    private void BtnOnlineNums_Click(object sender, EventArgs e)
    {

    }

    private void BtnClose_Click(object sender, EventArgs e)
    {

    }

    private void BtnLocalNums_Click(object sender, EventArgs e)
    {
      LocalPhoneForm localPhoneForm = new LocalPhoneForm();
      localPhoneForm.ShowDialog();
    }
  }
}
