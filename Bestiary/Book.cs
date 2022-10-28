using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bestiary
{
    public partial class Book : Form
    {
        public int ID = 0;
        public Book(int ID_log)
        {
            InitializeComponent();
            ID = ID_log;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                conn.Close();
            } catch(Exception ex)
            {
                MessageBox.Show("Не удалось открыть книгу. Похоже на древнюю магическую печать." + Environment.NewLine + ex.Message);
            }
            Contents win = new Contents();
            win.Owner = this;
            this.Hide();
            win.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приветствую, пользователь."+Environment.NewLine+""+Environment.NewLine+ "Программа может создавать, удалять и редактировать данные разных таблиц (монстров и пользователей)."+Environment.NewLine+""+Environment.NewLine+ "Мною планировалось реализовать в этой программе роли, которые позволили бы ограничивать права на редактирование любому, но спустя кучу тщетных попыток я оставил все как есть."+Environment.NewLine+""+Environment.NewLine+"С прошлой версией бестиария была добавлена авторизация и регистрация, удаление и редактирование созданных аккаунтов и поиск нужного среди них.");
        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось открыть страницу с аккаунтами." + Environment.NewLine + ex.Message);
            }
            Accounts win = new Accounts(ID);
            win.Owner = this;
            this.Hide();
            win.Show();
        }

        private void Book_Load(object sender, EventArgs e)
        {

        }
    }
}
