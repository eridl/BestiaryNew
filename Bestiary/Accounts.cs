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
    public partial class Accounts : Form
    {
        public int ID = 0;

        public Accounts(int ID_acc)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            get_Info("select id_user, login_user as 'Логин', password_user as 'Пароль' from register");
            ID = ID_acc;
        }

        class DoubleBufferedDataGridView : DataGridView
        {
            protected override bool DoubleBuffered { get => true; }
        }
        public void get_Info(string query)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.ClearSelection();
                dataGridView1.Columns[0].Visible = false;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так" + Environment.NewLine + ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                EditAccount win = new EditAccount(Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString()), "chng", ID);
                win.Owner = this;
                this.Hide();
                win.Show();
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            get_Info("select id_user, login_user as 'Логин', password_user as 'Пароль' from register");
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            get_Info("select id_user, login_user as 'Логин', password_user as 'Пароль' from register where concat (login_user, password_user) like '%"+search.Text+"%';");
        }

        private void Accounts_Load(object sender, EventArgs e)
        {

        }
    }
}
