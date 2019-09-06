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
    public partial class Регион_добавить_изменить : Form
    {
        private int id;
        private Dictionary<int, string> dir = new Dictionary<int, string>();
        private IDbConnection connection = new SqlConnection(WindowsFormsApp1.Properties.Settings.Default.BDConnectionString);
        List<int> groups = new List<int>();
        public Регион_добавить_изменить(int i)
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
                    groups.Add(reader.GetInt32(0));
                    dir.Add(reader.GetInt32(0), reader.GetString(1));
                    comboBox1.Items.Add(reader.GetString(1));
                }
                connection.Close();
            }
    }

        private void Регион_добавить_изменить_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                //Изменить
                button2.Text = "Изменить";
                IDbConnection connection = new SqlConnection(WindowsFormsApp1.Properties.Settings.Default.BDConnectionString);
                connection.Open();
                IDbCommand cmd = new SqlCommand("SELECT ID_Strana, Name FROM Region");
                cmd.Connection = connection;
                IDataReader reader = cmd.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    if (dir.ContainsKey(reader.GetInt32(0)) && i == id-1)
                    {
                        comboBox1.Text = dir[reader.GetInt32(0)].ToString();
                        textBox1.Text = reader.GetString(1);
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
                IDbCommand cmd = new SqlCommand("UPDATE Region SET ID_Strana=@1, Name=@2 WHERE Nomer=@nomer");
                cmd.Connection = connection;
                cmd.Parameters.Add(new SqlParameter("@1", groups[comboBox1.SelectedIndex]));
                cmd.Parameters.Add(new SqlParameter("@2", textBox1.Text));
                cmd.Parameters.Add(new SqlParameter("@nomer", id));
                cmd.ExecuteNonQuery();
                connection.Close();
                comboBox1.Text = "";
                textBox1.Text = "";
                MessageBox.Show("ИЗМЕНЕНО");
                Close();
            }
            else
            {
                connection.Open();
                IDbCommand cmd = new SqlCommand("INSERT INTO Region (ID_Strana, Name) VALUES (@adq, @adw)");
                cmd.Connection = connection;
                cmd.Parameters.Add(new SqlParameter("@adq", groups[comboBox1.SelectedIndex]));
                cmd.Parameters.Add(new SqlParameter("@adw", textBox1.Text));
                cmd.ExecuteNonQuery();
                connection.Close();
                comboBox1.Text = textBox1.Text = "";
                MessageBox.Show("Готово");
                Close();
            }
        }
    }
}
