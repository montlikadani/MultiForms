using Org.BouncyCastle.Asn1.X509;
using System;
using System.Windows.Forms;

namespace MultiForms {
    public partial class NyitoForm : Form {

        private readonly Form2 newTanuloForm;

        public NyitoForm() {
            InitializeComponent();

            newTanuloForm = new Form2();
            amountBox.Maximum = egysegar.Maximum = int.MaxValue;
            RefreshListItems();
        }

        public void RefreshListItems() {
            gyumolcsList.Items.Clear();
            gyumolcsList.Items.AddRange(Program.Fruits.ToArray());
        }

        private void newFruit_Click(object sender, EventArgs e) {
            newTanuloForm.ShowDialog(this);
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
    }
}
