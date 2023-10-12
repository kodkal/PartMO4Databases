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

    private void BtnSortLN_Click(object sender, EventArgs e)
    {
      this.phoneListTableTableAdapter.SortByLastName(this.localPhoneDbDataSet1.PhoneListTable);
    }

    private void BtnAge30_Click(object sender, EventArgs e)
    {
      this.phoneListTableTableAdapter.FillByAge30(this.localPhoneDbDataSet1.PhoneListTable);
    }

    private void BtnAvgAge_Click(object sender, EventArgs e)
    {
      MessageBox.Show($"The average age is: {this.phoneListTableTableAdapter.AverageAge()}");
    }

    private void BtnClear_Click(object sender, EventArgs e)
    {
      this.phoneListTableTableAdapter.Fill(this.localPhoneDbDataSet1.PhoneListTable);
    }

    private void BtnSearch_Click(object sender, EventArgs e)
    {
      this.phoneListTableTableAdapter.FillByFirstName(this.localPhoneDbDataSet1.PhoneListTable, TxtBoxFirstName.Text);
    }
  }
}
