using System;
using System.Windows.Forms;

namespace MultiForms {
    public partial class Form2 : Form {

        public Form2() {
            InitializeComponent();

            amountBox.Maximum = int.MaxValue;
            egysegar.Maximum = decimal.MaxValue;
        }

        private async void addFruit_Click(object sender, EventArgs e) {
            Program.SqlCommand.CommandText = "insert into `gyumolcsok` (`nev`, `egysegar`, `mennyiseg`) VALUES (@nev, @egysegar, @mennyiseg);";
            Program.SqlCommand.Parameters.Clear();
            Program.SqlCommand.Parameters.AddWithValue("@nev", gyumolcsNev.Text);
            Program.SqlCommand.Parameters.AddWithValue("@egysegar", egysegar.Value);
            Program.SqlCommand.Parameters.AddWithValue("@mennyiseg", amountBox.Value);

            await Program.ExecuteSql();
            Program.Nyito.RefreshListItems();

            gyumolcsNev.Text = "";
            egysegar.Value = egysegar.Minimum;
            amountBox.Value = amountBox.Minimum;
            Close();
        }

        private void gyumolcsNev_TextChanged(object sender, EventArgs e) {
            addFruit.Enabled = gyumolcsNev.Text.Trim().Length != 0;
        }
    }
}
