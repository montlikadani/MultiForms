using System;
using System.Windows.Forms;

namespace MultiForms {
    public partial class UpdateForm : Form {

        public UpdateForm() {
            InitializeComponent();
        }

        private void ResetProperties() {
            IdBox.Text = gyumolcsNev.Text = "";
            egysegar.Value = egysegar.Minimum;
            amountBox.Value = amountBox.Minimum;
            modifyFruit.Enabled = false;
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            ResetProperties();
            Close();
        }

        private void gyumolcsData_Changed(object sender, EventArgs e) {
            modifyFruit.Enabled = gyumolcsNev.Text.Trim().Length != 0;
        }

        private async void modifyFruit_Click(object sender, EventArgs e) {
            Program.SqlCommand.CommandText = "update `gyumolcsok` set `nev` = @name, `egysegar` = @ar, `mennyiseg` = @amount where `id` = @id;";
            Program.SqlCommand.Parameters.Clear();
            Program.SqlCommand.Parameters.AddWithValue("@id", int.Parse(IdBox.Text));
            Program.SqlCommand.Parameters.AddWithValue("@name", gyumolcsNev.Text);
            Program.SqlCommand.Parameters.AddWithValue("@ar", egysegar.Value);
            Program.SqlCommand.Parameters.AddWithValue("@amount", amountBox.Value);

            if (!(await Program.ExecuteSql())) {
                return;
            }

            MessageBox.Show("Gyümölcs adatok frissítve", "Gyümölcs frissítve", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (Owner is NyitoForm) {
                ((NyitoForm) Owner).RefreshListItems();
            } else {
                Program.Nyito.RefreshListItems();
            }

            ResetProperties();
            Close();
        }
    }
}
