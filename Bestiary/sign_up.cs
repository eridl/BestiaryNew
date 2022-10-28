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
    public partial class sign_up : Form
    {
        public sign_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void sign_up_Load(object sender, EventArgs e)
        {
            login_box.MaxLength = 50;
            password_box.MaxLength = 50;
        }

        public void doAction(string query)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                cmDB.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибка загрузки информации!" + Environment.NewLine + ex.Message);
            }
        }
        private void create_btn_Click(object sender, EventArgs e)
        {

            string query = "select count(*) from register where login_user = '"+login_box.Text+"';";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            int result = 0;
            conn.Open();
            result = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (result > 0)
            {
                MessageBox.Show("Пользователь существует");
                conn.Close();
            }
            else
            {
                MessageBox.Show("Аккаунт создан");
                
                
                doAction("insert into register (login_user, password_user) values ('" + login_box.Text + "','" + password_box.Text + "');");
                
                log_in win = new log_in();
                this.Hide();
                win.Show();
            }

        }

        private void pass_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pass_checkBox.Checked)
            {
                password_box.UseSystemPasswordChar = false;
            }
            else
            {
                password_box.UseSystemPasswordChar = true;
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            log_in win = new log_in();
            this.Hide();
            win.Show();
        }
    }
}
