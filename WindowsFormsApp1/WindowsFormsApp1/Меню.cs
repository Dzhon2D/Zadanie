using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Меню : Form
    {
        public Меню()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Страна n = new Страна();
            this.Visible = false;
            n.ShowDialog();
            this.Visible = true;
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Регион n = new Регион();
            this.Visible = false;
            n.ShowDialog();
            this.Visible = true;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Город n = new Город();
            this.Visible = false;
            n.ShowDialog();
            this.Visible = true;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Тур n = new Тур();
            this.Visible = false;
            n.ShowDialog();
            this.Visible = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Просмотр n = new Просмотр();
            this.Visible = false;
            n.ShowDialog();
            this.Visible = true;
        }
    }
}
