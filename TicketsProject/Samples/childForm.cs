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

namespace TicketsProject
{
    public partial class childForm : Form
    {
        DB db = new DB();
        SqlCommand command;

        public childForm()
        {
            InitializeComponent();
        }

        private void add_road_Click(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("insert into (Код_маршрута, Код_поезда, Станция_отправления, Станция_прибытия) values (@id_train, @s_out, @s_in) from Маршрут", db.getConnection());
                command.Parameters.Add("@id_train", SqlDbType.NVarChar).Value = id_train.Text;
                command.Parameters.Add("@id_place", SqlDbType.NVarChar).Value = id_place.Text;
                command.Parameters.Add("@s_out", SqlDbType.NVarChar).Value = s_out.Text;
                command.Parameters.Add("@s_in", SqlDbType.NVarChar).Value = s_in.Text;
                db.openConnection();
                command.Connection = db.getConnection();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    table_child.DataSource = dt;
                }
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void search_road_Click(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("select * from Маршрут where Код_поезда = @id_road or Станция_отправления = @s_out or Станция_прибытия = @s_in", db.getConnection());
                command.Parameters.Add("@id_train", SqlDbType.NVarChar).Value = id_train.Text;
                command.Parameters.Add("@s_out", SqlDbType.NVarChar).Value = s_out.Text;
                command.Parameters.Add("@s_in", SqlDbType.NVarChar).Value = s_in.Text;
                db.openConnection();
                command.Connection = db.getConnection();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    table_child.DataSource = dt;
                }
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void open_road_Click(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("select * from Маршрут", db.getConnection());
                db.openConnection();
                command.Connection = db.getConnection();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    table_child.DataSource = dt;
                }
            }
            finally
            {
                db.closeConnection();
            }
        }
    }
}

