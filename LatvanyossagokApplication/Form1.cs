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
            AdatokListazas();
            AdatokListazasa();
        }

        public void TablaLetrehoz()
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS varosok (ID INTEGER AUTO_INCREMENT PRIMARY KEY, NEV VARCHAR(255) NOT NULL, LAKOSSAG INTEGER NOT NULL)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS latvanyossag (ID INTEGER AUTO_INCREMENT PRIMARY KEY, NEV VARCHAR(255) NOT NULL UNIQUE, LEIRAS VARCHAR(255) NOT NULL, AR INTEGER NOT NULL, VAROS_ID INTEGER FOREIGN KEY REFERENCES varosok(ID) NOT NULL)";
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
            AdatokListazasa();
        }

        public void AdatokListazasa()
        {
            LBVarosok.Items.Clear();
            var command = conn.CreateCommand();
            command.CommandText = @"SELECT * FROM varosok ORDER BY nev";
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string nev = reader.GetString("nev");
                    int lakossag = reader.GetInt32("lakossag");

                    LBVarosok.Items.Add(nev + " - Lakosság: " + lakossag + " fő");
                }
            }
        }


        private void btnTorles_Click(object sender, EventArgs e)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"DELETE FROM varosok WHERE nev=@nev";
            string sor= LBVarosok.SelectedItem.ToString();
            string[] sv = new string[5];
            sv = sor.Split(' ');
            cmd.Parameters.AddWithValue("@nev", sv[0]);
            cmd.ExecuteNonQuery();
            AdatokListazasa();
        }

        private void btnModosit_Click(object sender, EventArgs e)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"UPDATE FROM varosok SET nev="+tbVnev.Text+", lakossag="+nUDLakossag.Value+" WHERE id=@id";
            tbVnev.Text += LBVarosok.SelectedIndex.ToString();
            nUDLakossag.Value += LBVarosok.SelectedIndex;
            cmd.Parameters.AddWithValue("@id", "id");
            cmd.Parameters.AddWithValue("@nev", "nev");
            cmd.Parameters.AddWithValue("@lakossag", "lakossag");
            cmd.ExecuteNonQuery();
            AdatokListazasa();
        }

        private void btnLatvanyossagHozzaAd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBLNev.Text))
            {
                MessageBox.Show("Minden mezőt ki kell tölteni!");
                return;
            }

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO latvanyossag (nev,leiras,ar,varos_id)
                             VALUES (@nev,@leiras,@ar,varos_id)";
            cmd.Parameters.AddWithValue("@nev", tBLNev.Text);
            LBLeiras.Items.Add(tBLNev.Text+","+nUDAr.Value);
            cmd.Parameters.AddWithValue("@leiras", LBLeiras.Text);
            cmd.Parameters.AddWithValue("@ar", nUDAr.Value);
            AdatokListazas();

            cmd.ExecuteNonQuery();
        }

        public void AdatokListazas()
        {
            LBVarosok.Items.Clear();
            var command = conn.CreateCommand();
            command.CommandText = @"SELECT * FROM latvanyossag ORDER BY nev";
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string nev = reader.GetString("nev");
                    string leiras = reader.GetString("leiras");
                    int ar = reader.GetInt32("ar");
                    int v_id = reader.GetInt32("varos_id");

                    LBLeiras.Items.Add("név:" + nev + " ár: " + ar);
                }
            }
        }


    }
}
