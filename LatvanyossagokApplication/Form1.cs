using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatvanyossagokApplication
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();

            conn = new MySqlConnection("Server=localhost;Port=3306;Database=latvanyossagokdb;Uid=root;Pwd=;");
            conn.Open();
        }

        public void TablaLetrehoz()
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS varosok (ID INTEGER AUTO_INCREMENT PRIMARY KEY, NEV VARCHAR(255) NOT NULL, LAKOSSAG INTEGER NOT NULL)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS latvanyossag (ID INTEGER AUTO_INCREMENT PRIMARY KEY, NEV VARCHAR(255) NOT NULL UNIQUE, LEIRAS VARCHAR(255) NOT NULL, AR INTEGER NOT NULL, VAROS_ID INTEGER NOT NULL)";
            cmd.ExecuteNonQuery();
        }

        private void btnVarosHozzaAd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbVnev.Text))
            {
                MessageBox.Show("Minden mezőt ki kell tölteni!");
                return;
            }

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO varosok (nev, lakossag)
                             VALUES (@nev,@lakossag)";
            cmd.Parameters.AddWithValue("@nev", tbVnev.Text);
            cmd.Parameters.AddWithValue("@lakossag", nUDLakossag.Value);

            cmd.ExecuteNonQuery();
        }
    }
}
