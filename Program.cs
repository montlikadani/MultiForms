using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MultiForms {
    internal static class Program {

        public static NyitoForm Nyito { get; private set; }
        public static MySqlConnection Connection { get; private set; }
        public static MySqlCommand SqlCommand { get; private set; }

        [STAThread]
        static void Main() {
            try {
                (Connection = new MySqlConnection("server=localhost;user=root;database=gyumolcsok;")).Open();
                SqlCommand = Connection.CreateCommand();
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Adatbázis kapcsolódás sikertelen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Nyito = new NyitoForm();
            LoadItemsFromDatabase();

            Application.Run(Nyito);
        }

        public static void LoadItemsFromDatabase() {
            SqlCommand.CommandText = "select * from gyumolcsok;";

            using (MySqlDataReader reader = SqlCommand.ExecuteReader()) {
                while (reader.Read()) {
                    Nyito.gyumolcsList.Items.Add(new Fruit(reader.GetInt32("id"), reader.GetString("nev"), reader.GetDecimal("egysegar"), reader.GetInt32("mennyiseg")));
                }
            }
        }

        public static async System.Threading.Tasks.Task<bool> ExecuteSql() {
            try {
                if ((await SqlCommand.ExecuteNonQueryAsync()) != 1) {
                    return false;
                }
            } catch (System.Data.Common.DbException ex) {
                MessageBox.Show("Hiba lépett fel az adatbázis parancs végrehajtásakor: " + ex.Message, "Adatbázis hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
