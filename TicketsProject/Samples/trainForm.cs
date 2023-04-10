using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TicketsProject
{
    public partial class trainForm : Form
    {

        DB db = new DB();
        SqlCommand command;

        public trainForm()
        {
            InitializeComponent();
        }

        private void search_train_Click(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("select * from Поезда where Код_поезда = @id_road or Кол_во_мест = @nam", db.getConnection());
                command.Parameters.Add("@id_train", SqlDbType.NVarChar).Value = id_train.Text;
                command.Parameters.Add("@nam", SqlDbType.NVarChar).Value = namber.Text;
                db.openConnection();
                command.Connection = db.getConnection();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    table_train.DataSource = dt;
                }
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void add_train_Click(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("insert into (Код_поезда, Кол_во_мест) values (@id_train, @nam) from Поезда", db.getConnection());
                command.Parameters.Add("@id_train", SqlDbType.NVarChar).Value = id_train.Text;
                command.Parameters.Add("@nam", SqlDbType.NVarChar).Value = namber.Text;
                db.openConnection();
                command.Connection = db.getConnection();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    table_train.DataSource = dt;
                }
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void open_train_Click(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("select * from Поезда", db.getConnection());
                db.openConnection();
                command.Connection = db.getConnection();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    table_train.DataSource = dt;
                }
            }
            finally
            {
                db.closeConnection();
            }
        }
    }
}
