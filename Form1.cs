using System;
using System.Windows.Forms;

namespace MultiForms {
    public partial class NyitoForm : Form {

        private readonly Form newFruitForm;
        private readonly UpdateForm updateFruitForm;

        public NyitoForm() {
            InitializeComponent();

            newFruitForm = new Form2();
            updateFruitForm = new UpdateForm();
            amountBox.Maximum = int.MaxValue;
            egysegar.Maximum = decimal.MaxValue;
        }

        public void RefreshListItems() {
            gyumolcsList.Items.Clear();
            Program.LoadItemsFromDatabase();
        }

        private void ResetProperties() {
            IdBox.Text = gyumolcsNev.Text = "";
            egysegar.Value = egysegar.Minimum;
            amountBox.Value = amountBox.Minimum;
            updateFruit.Enabled = removeFruit.Enabled = false;
        }

        private void newFruit_Click(object sender, EventArgs e) {
            newFruitForm.ShowDialog(this);
        }

        private void gyumolcsList_SelectedIndexChanged(object sender, EventArgs e) {
            updateFruit.Enabled = removeFruit.Enabled = gyumolcsList.SelectedItems.Count != 0;

            if (gyumolcsList.SelectedItem is Fruit fruit) {
                IdBox.Text = fruit.Id.ToString();
                gyumolcsNev.Text = fruit.Name;
                egysegar.Value = fruit.Egysegar;
                amountBox.Value = fruit.Mennyiseg;
            }
        }

        private async void removeFruit_Click(object sender, EventArgs e) {
            if (!(gyumolcsList.SelectedItem is Fruit fruit)) {
                return;
            }

            if (MessageBox.Show("Biztosan el szeretné távolítani a gyümölcsöt?", "Gyümölcs eltávolítása", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) is DialogResult.OK) {
                Program.SqlCommand.CommandText = $"delete from `gyumolcsok` where `id` = @id;";
                Program.SqlCommand.Parameters.Clear();
                Program.SqlCommand.Parameters.AddWithValue("@id", fruit.Id);

                if (!(await Program.ExecuteSql())) {
                    return;
                }

                MessageBox.Show("A kiválasztott gyümölcs eltávolítva", "Gyümölcs eltávolítva", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshListItems();
                ResetProperties();
            }
        }

        private void updateFruit_Click(object sender, EventArgs e) {
            if (!(gyumolcsList.SelectedItem is Fruit fruit)) {
                return;
            }

            updateFruitForm.IdBox.Text = fruit.Id.ToString();
            updateFruitForm.gyumolcsNev.Text = fruit.Name;
            updateFruitForm.egysegar.Value = fruit.Egysegar;
            updateFruitForm.amountBox.Value = fruit.Mennyiseg;

            ResetProperties();
            gyumolcsList.SelectedItems.Clear();
            updateFruitForm.ShowDialog(this);
        }
    }
}
