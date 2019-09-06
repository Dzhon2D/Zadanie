﻿using System;
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
    public partial class Тур : Form
    {
        private IDbConnection connection = new SqlConnection(WindowsFormsApp1.Properties.Settings.Default.BDConnectionString);
        public Тур()
        {
            InitializeComponent();
        }

        private void Тур_Load(object sender, EventArgs e)
        {
            dataGrid_load(); //Заполнить таблицу данными из бд
        }
        private void dataGrid_load() //Заполнить таблицу данными из бд
        {
            IDbConnection connection = new SqlConnection(WindowsFormsApp1.Properties.Settings.Default.BDConnectionString);
            connection.Open();
            IDbCommand cmd = new SqlCommand("SELECT Nomer, Name, Price, Chislo_tyristov FROM Tyr");
            cmd.Connection = connection;
            IDataReader reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            int i = 0;
            while (reader.Read())
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = reader.GetInt32(0);
                dataGridView1.Rows[i].Cells[1].Value = reader.GetString(1);
                dataGridView1.Rows[i].Cells[2].Value = reader.GetInt32(2);
                dataGridView1.Rows[i].Cells[3].Value = reader.GetInt32(3);
                i++;
            }
            reader.Close();
            connection.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close(); //Закрыть форму
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dataGrid_load(); //Заполнить таблицу данными из бд
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try //Проверка на ошибку, выделена ли строка в таблице
            {
                connection.Open();
                IDbCommand cmd = new SqlCommand("DELETE FROM Tyr WHERE Nomer=@Nomer");
                cmd.Connection = connection;
                cmd.Parameters.Add(new SqlParameter("@Nomer", Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value)));
                cmd.ExecuteNonQuery();
                connection.Close();
                dataGrid_load();
            }
            catch
            {
                MessageBox.Show("Данная строка не может быть удалена, из-за связей к ней");
                connection.Close();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try //Проверка на ошибку, выделена ли строка в таблице
            {
                Тур_добавить_изменить n = new Тур_добавить_изменить(Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value));
                this.Visible = false;
                n.Text = "Изменить";
                n.ShowDialog();
                this.Visible = true;
                dataGrid_load();
            }
            catch
            {
                MessageBox.Show("Выберите строку которую хотите изменить");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Тур_добавить_изменить n = new Тур_добавить_изменить(0);
            this.Visible = false;
            n.Text = "Добавить";
            n.ShowDialog();
            this.Visible = true;
            dataGrid_load();
        }
    }
}
