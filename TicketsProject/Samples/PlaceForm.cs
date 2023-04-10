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
    public partial class PlaceForm : Form
    {
        DB db = new DB();
        SqlCommand command;
        public PlaceForm()
        {
            InitializeComponent();
        }

        private void search_place_Click(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("select * from МестаПоезда where Код_места = @id_place or Код_поезда = @id_road or Вид_места = @view", db.getConnection());
                command.Parameters.Add("@view", SqlDbType.NVarChar).Value = view.Text;
                command.Parameters.Add("@id_train", SqlDbType.NVarChar).Value = id_train.Text;
                command.Parameters.Add("@id_place", SqlDbType.NVarChar).Value = id_place.Text;
                db.openConnection();
                command.Connection = db.getConnection();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    table_place.DataSource = dt;
                }
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void add_place_Click(object sender, EventArgs e)
        {

            try
            {
                command = new SqlCommand("insert into (Код_места, Код_поезда, Вид_места) values (@id_place, @id_train, @view) from МестаПоезда", db.getConnection());
                command.Parameters.Add("@view", SqlDbType.NVarChar).Value = view.Text;
                command.Parameters.Add("@id_train", SqlDbType.NVarChar).Value = id_train.Text;
                command.Parameters.Add("@id_place", SqlDbType.NVarChar).Value = id_place.Text;
                db.openConnection();
                command.Connection = db.getConnection();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    table_place.DataSource = dt;
                }
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void open_place_Click(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("select * from МестаПоезда", db.getConnection());
                db.openConnection();
                command.Connection = db.getConnection();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    table_place.DataSource = dt;
                }
            }
            finally
            {
                db.closeConnection();
            }
        }
    }
}
