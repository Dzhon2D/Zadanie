using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Просмотр : Form
    {
        private Dictionary<int, string> Strana = new Dictionary<int, string>();
        private Dictionary<int, string> Region = new Dictionary<int, string>();
        private Dictionary<int, string> Gorod = new Dictionary<int, string>();
        public Просмотр()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close(); //Закрыть форму
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dataGrid_load(); //Заполнить таблицу данными из бд
        }

        private void Просмотр_Load(object sender, EventArgs e)
        {
            Получить_С_Р_Г(); //Получить ИД Страны, Региона и Города
            dataGrid_load(); //Заполнить таблицу данными из бд
        }

        private void dataGrid_load()
        {
            IDbConnection connection = new SqlConnection(WindowsFormsApp1.Properties.Settings.Default.BDConnectionString);
            connection.Open();
            IDbCommand cmd = new SqlCommand("SELECT Nomer, ID_Strana, ID_Region, ID_Gorod, Name, Price, Chislo_tyristov FROM Tyr");
            cmd.Connection = connection;
            IDataReader reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            int i = 0;
            while (reader.Read())
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = reader.GetInt32(0);
                dataGridView1.Rows[i].Cells[1].Value = Strana[reader.GetInt32(1)];
                dataGridView1.Rows[i].Cells[2].Value = Region[reader.GetInt32(2)];
                dataGridView1.Rows[i].Cells[3].Value = Gorod[reader.GetInt32(3)];
                dataGridView1.Rows[i].Cells[4].Value = reader.GetString(4);
                dataGridView1.Rows[i].Cells[5].Value = reader.GetInt32(5);
                dataGridView1.Rows[i].Cells[6].Value = reader.GetInt32(6);
                i++;
            }
            reader.Close();
            connection.Close();
        }
        private void Получить_С_Р_Г()
        {
            IDbConnection connection = new SqlConnection(WindowsFormsApp1.Properties.Settings.Default.BDConnectionString);
            connection.Open();
            IDbCommand cmdStrana = new SqlCommand("SELECT Nomer, Name FROM Strana");
            cmdStrana.Connection = connection;
            IDataReader readerStrana = cmdStrana.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (readerStrana.Read())
            {
                Strana.Add(readerStrana.GetInt32(0), readerStrana.GetString(1));
            }
            readerStrana.Close();

            IDbCommand cmdRegion = new SqlCommand("SELECT Nomer, Name FROM Region");
            cmdRegion.Connection = connection;
            IDataReader readerRegion = cmdRegion.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (readerRegion.Read())
            {
                Region.Add(readerRegion.GetInt32(0), readerRegion.GetString(1));
            }
            readerRegion.Close();

            IDbCommand cmdGorod = new SqlCommand("SELECT Nomer, Name FROM Gorod");
            cmdGorod.Connection = connection;
            IDataReader readerGorod = cmdGorod.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (readerGorod.Read())
            {
                Gorod.Add(readerGorod.GetInt32(0), readerGorod.GetString(1));
            }
            readerGorod.Close();
            connection.Close();
        }
    }
}
