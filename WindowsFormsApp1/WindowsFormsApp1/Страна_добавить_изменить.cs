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
    public partial class Страна_добавить_изменить : Form
    {
        private int id;
        private Dictionary<int, string> dir = new Dictionary<int, string>();
        private IDbConnection connection = new SqlConnection(WindowsFormsApp1.Properties.Settings.Default.BDConnectionString);
        List<int> groups = new List<int>();
        public Страна_добавить_изменить(int i)
        {
            InitializeComponent();
            id = i;
        }

        private void Страна_добавить_изменить_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                //Изменить
                button2.Text = "Изменить";
                IDbConnection connection = new SqlConnection(WindowsFormsApp1.Properties.Settings.Default.BDConnectionString);
                connection.Open();
                IDbCommand cmd = new SqlCommand("SELECT Nomer, Name FROM Strana");
                cmd.Connection = connection;
                IDataReader reader = cmd.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    if (i == id-1)
                    {
                        textBox1.Text = reader.GetString(1);
                        break;
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
                IDbCommand cmd = new SqlCommand("UPDATE Strana SET Name=@1 WHERE Nomer=@nomer");
                cmd.Connection = connection;
                cmd.Parameters.Add(new SqlParameter("@1", textBox1.Text));
                cmd.Parameters.Add(new SqlParameter("@nomer", id));
                cmd.ExecuteNonQuery();
                connection.Close();
                textBox1.Text = "";
                MessageBox.Show("ИЗМЕНЕНО");
                Close();
            }
            else
            {
                connection.Open();
                IDbCommand cmd = new SqlCommand("INSERT INTO Strana (Name) VALUES ( @adw)");
                cmd.Connection = connection;
                cmd.Parameters.Add(new SqlParameter("@adw", textBox1.Text));
                cmd.ExecuteNonQuery();
                connection.Close();
                textBox1.Text = "";
                MessageBox.Show("Готово");
                Close();
            }
        }
    }
}
