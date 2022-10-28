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
    public partial class EditAccount : Form
    {
        public int ID_account = 0;

        public EditAccount(int ID_acc, string mode, int ID)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            if (mode == "chng")
            {
                login_box.Visible = false;
                password_box.Visible = false;
            }

            getBoxes("Select loot_name from loot;", login_box);
            getBoxes("Select password_user from register;", password_box);
            get_Info(ID_acc);
            ID_account = ID_acc;
        }


        public void get_Info(int ID)
        {
            string query = "Select login_user, password_user from register WHERE id_user ="+ID.ToString()+";";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    login_label.Text = rd.GetString(0);
                    password_label.Text = rd.GetString(1);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибка загрузки информации!" + Environment.NewLine + ex.Message);
            }
        }
        private void EditAccount_Load(object sender, EventArgs e)
        {

        }
        public void getBoxes(string query, ComboBox box)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        box.Items.Add(rd.GetString(0));
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибка загрузки информации!" + Environment.NewLine + ex.Message);
            }
        }

        private void chng_btn_Click(object sender, EventArgs e)
        {
            switch (chng_btn.Text)
            {
                case "Изменить данные":
                    chng_btn.Text = "Сохранить данные";
                    login_label.Visible = false;
                    password_label.Visible = false;

                    login_box.Visible = true;
                    password_box.Visible = true;
                    del_btn.Visible = false;

                    login_box.Text = login_label.Text;
                    password_box.Text = password_label.Text;
                    break;
                case "Сохранить данные":
                    doAction("update register set login_user='"+login_box.Text+"', password_user='"+password_box.Text+"' where id_user="+ID_account.ToString()+";");
                    login_label.Visible = true;
                    password_label.Visible = true;

                    login_box.Visible = false;
                    password_box.Visible = false;
                    del_btn.Visible = true;
                    chng_btn.Text = "Изменить данные";
                    get_Info(ID_account);
                    break;
            }

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

        private void del_btn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы уверены, что нужно удалить этого пользователя?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                doAction("delete from register where id_user ="+ID_account+";");
                Owner.Show();
                this.Close();
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
    }
}
