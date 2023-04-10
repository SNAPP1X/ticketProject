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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace TicketsProject
{
    public partial class PassagForm : Form
    {
        DB db = new DB();
        SqlCommand command;
        public PassagForm()
        {
            InitializeComponent();
        }

        private void search_passag_Click(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("select * from Пассажиры where Код_пассажира = @id_passag or Код_поезда = @id_road or Код_места = @id_place or Код_маршрута = @id_roat or Код_билета or ФИО_пассажира = @fio", db.getConnection());
                command.Parameters.Add("@id_passag", SqlDbType.NVarChar).Value = id_passag.Text;
                command.Parameters.Add("@id_train", SqlDbType.NVarChar).Value = id_train.Text;
                command.Parameters.Add("@id_place", SqlDbType.NVarChar).Value = id_place.Text;
                command.Parameters.Add("@id_roat", SqlDbType.NVarChar).Value = id_roat.Text;
                command.Parameters.Add("@id_ticket", SqlDbType.NVarChar).Value = id_ticket.Text;
                command.Parameters.Add("@fio", SqlDbType.NVarChar).Value = fio.Text;
                db.openConnection();
                command.Connection = db.getConnection();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    table_passag.DataSource = dt;
                }
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void add_passag_Click(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("insert into (Код_пассажира, Код_поезда, Код_места, Код_маршрута, Код_билета, ФИО_пассажира) values " +
                    "(@id_passag, @id_train, @id_place, @id_roat, @id_ticket, @fio) from Пассажиры", db.getConnection());
                command.Parameters.Add("@id_passag", SqlDbType.NVarChar).Value = id_passag.Text;
                command.Parameters.Add("@id_train", SqlDbType.NVarChar).Value = id_train.Text;
                command.Parameters.Add("@id_place", SqlDbType.NVarChar).Value = id_place.Text;
                command.Parameters.Add("@id_roat", SqlDbType.NVarChar).Value = id_roat.Text;
                command.Parameters.Add("@id_ticket", SqlDbType.NVarChar).Value = id_ticket.Text;
                command.Parameters.Add("@fio", SqlDbType.NVarChar).Value = fio.Text;
                db.openConnection();
                command.Connection = db.getConnection();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    table_passag.DataSource = dt;
                }
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void open_passag_Click(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("select * from Пассажиры", db.getConnection());
                db.openConnection();
                command.Connection = db.getConnection();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    table_passag.DataSource = dt;
                }
            }
            finally
            {
                db.closeConnection();
            }
        }
    }
}

