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
    public partial class SaleForm : Form
    {
        DB db = new DB();
        SqlCommand command;

        public SaleForm()
        {
            InitializeComponent();
        }

        private void search_sale_Click(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("select * from ПродажаБилетов where Код_билета = @id_ticket or Код_поезда = @id_road or Код_места = @id_place or Код_маршрута = @id_roat or ФИО_пассажира = @fio or Стоимость = @sale", db.getConnection());
                command.Parameters.Add("@id_ticket", SqlDbType.NVarChar).Value = id_ticket.Text;
                command.Parameters.Add("@id_train", SqlDbType.NVarChar).Value = id_train.Text;
                command.Parameters.Add("@id_place", SqlDbType.NVarChar).Value = id_place.Text;
                command.Parameters.Add("@id_road", SqlDbType.NVarChar).Value = id_road.Text;
                command.Parameters.Add("@sale", SqlDbType.NVarChar).Value = sale.Text;
                command.Parameters.Add("@fio", SqlDbType.NVarChar).Value = fio.Text;
                db.openConnection();
                command.Connection = db.getConnection();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    table_sale.DataSource = dt;
                }
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void add_sale_Click(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("insert into (Код_билета, Код_места, Код_поезда, Код_ммаршрута, ФИО_пассажира, Стоимость) values (@id_ticket, @id_place, @id_train, @id_road, @fio, @sale) from ПродажаБилетов", db.getConnection());
                command.Parameters.Add("@id_ticket", SqlDbType.NVarChar).Value = id_ticket.Text;
                command.Parameters.Add("@id_train", SqlDbType.NVarChar).Value = id_train.Text;
                command.Parameters.Add("@id_place", SqlDbType.NVarChar).Value = id_place.Text;
                command.Parameters.Add("@id_road", SqlDbType.NVarChar).Value = id_road.Text;
                command.Parameters.Add("@fio", SqlDbType.NVarChar).Value = fio.Text;
                command.Parameters.Add("@sale", SqlDbType.NVarChar).Value = sale.Text;
                db.openConnection();
                command.Connection = db.getConnection();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    table_sale.DataSource = dt;
                }
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void open_sale_Click(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("select * from ПродажаБилетов", db.getConnection());
                db.openConnection();
                command.Connection = db.getConnection();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    table_sale.DataSource = dt;
                }
            }
            finally
            {
                db.closeConnection();
            }
        }
    }
}
