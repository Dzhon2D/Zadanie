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
    public partial class Город_добавить_изменить : Form
    {
        private int id;
        private Dictionary<int, string> dir1 = new Dictionary<int, string>();
        private Dictionary<int, string> dir2 = new Dictionary<int, string>();
        private IDbConnection connection = new SqlConnection(WindowsFormsApp1.Properties.Settings.Default.BDConnectionString);
        List<int> groups1 = new List<int>();
        List<int> groups2 = new List<int>();
        public Город_добавить_изменить(int i)
        {
            InitializeComponent();
            id = i;
            {
                comboBox1.Items.Clear();
                connection.Open();
                IDbCommand cmd = new SqlCommand("SELECT Nomer, Name FROM Strana");
                cmd.Connection = connection;
                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    groups1.Add(reader.GetInt32(0));
                    dir1.Add(reader.GetInt32(0), reader.GetString(1));
                    comboBox1.Items.Add(reader.GetString(1));
                }
                connection.Close();
            }
            {
                comboBox2.Items.Clear();
                connection.Open();
                IDbCommand cmd = new SqlCommand("SELECT Nomer, Name FROM Region");
                cmd.Connection = connection;
                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    groups2.Add(reader.GetInt32(0));
                    dir2.Add(reader.GetInt32(0), reader.GetString(1));
                    comboBox2.Items.Add(reader.GetString(1));
                }
                connection.Close();
            }
        }

        private void Город_добавить_изменить_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                //Изменить
                button2.Text = "Изменить";
                IDbConnection connection = new SqlConnection(WindowsFormsApp1.Properties.Settings.Default.BDConnectionString);
                connection.Open();
                IDbCommand cmd = new SqlCommand("SELECT Nomer, ID_Strana, ID_Region, Name FROM Gorod");
                cmd.Connection = connection;
                IDataReader reader = cmd.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id)
                    {
                        comboBox1.Text = dir1[reader.GetInt32(1)];
                        comboBox2.Text = dir2[reader.GetInt32(2)];
                        textBox1.Text = reader.GetString(3);
                    }
                    i++;
                }
                reader.Close();
                connection.Close();
            }
            else
            {
                //Добавить
                button2.Text = "Добавить";

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {

                connection.Open();
                IDbCommand cmd = new SqlCommand("UPDATE Gorod SET ID_Strana=@1, ID_Region=@2, Name=@3 WHERE Nomer=@nomer");
                cmd.Connection = connection;
                cmd.Parameters.Add(new SqlParameter("@1", groups1[comboBox1.SelectedIndex]));
                cmd.Parameters.Add(new SqlParameter("@2", groups2[comboBox2.SelectedIndex]));
                cmd.Parameters.Add(new SqlParameter("@3", textBox1.Text));
                cmd.Parameters.Add(new SqlParameter("@nomer", id));
                cmd.ExecuteNonQuery();
                connection.Close();
                comboBox1.Text = comboBox2.Text = textBox1.Text = "";
                MessageBox.Show("ИЗМЕНЕНО");
                Close();
            }
            else
            {
                connection.Open();
                IDbCommand cmd = new SqlCommand("INSERT INTO Gorod (ID_Strana, ID_Region, Name) VALUES (@adq, @adw, @ade)");
                cmd.Connection = connection;
                cmd.Parameters.Add(new SqlParameter("@adq", groups1[comboBox1.SelectedIndex]));
                cmd.Parameters.Add(new SqlParameter("@adw", groups2[comboBox2.SelectedIndex]));
                cmd.Parameters.Add(new SqlParameter("@ade", textBox1.Text));
                cmd.ExecuteNonQuery();
                connection.Close();
                comboBox1.Text = comboBox2.Text = textBox1.Text = "";
                MessageBox.Show("Готово");
                Close();
            }
        }
    }
}
