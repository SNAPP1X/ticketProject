using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TicketsProject
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            userName.Text = "Введите имя";
            userName.ForeColor = Color.Gray;
            userSurname.Text = "Введите фамилию";
            userSurname.ForeColor = Color.Gray;
            log_win.Text = "Введите логин";
            log_win.ForeColor = Color.Gray;
            pass_win.Text = "Введите пароль";
            pass_win.ForeColor = Color.Gray;

        }
        private void Form_close_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseBtn_MouseEnter(object sender, EventArgs e)
        {
            CloseBtn.ForeColor = Color.Yellow;
        }

        private void CloseBtn_MouseLeave(object sender, EventArgs e)
        {
            CloseBtn.ForeColor = Color.White;
        }

        Point LastPoint;
        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void userName_Enter(object sender, EventArgs e)
        {
            if (userName.Text == "Введите имя")
            {
                userName.Text = "";
                userName.ForeColor = Color.Black;
            }
        }

        private void userSurname_Enter(object sender, EventArgs e)
        {
            if (userSurname.Text == "Введите фамилию")
            {
                userSurname.Text = "";
                userSurname.ForeColor = Color.Black;
            }
        }

        private void log_win_Enter(object sender, EventArgs e)
        {
            if (log_win.Text == "Введите логин")
            {
                log_win.Text = "";
                log_win.ForeColor = Color.Black;
            }
        }

        private void pass_win_Enter(object sender, EventArgs e)
        {
            if (pass_win.Text == "Введите пароль")
            {
                pass_win.Text = "";
                pass_win.ForeColor = Color.Black;
                pass_win.PasswordChar = '*';
            }
        }

        private void pass_is_empty(object sender, EventArgs e)
        {
            if (pass_win.Text.Length <= 0)
            {
                pass_win.PasswordChar = (char)0;
            }
        }

        private void userName_Leave(object sender, EventArgs e)
        {
            if (userName.Text == "")
            {
                userName.Text = "Введите имя";
                userName.ForeColor = Color.Gray;
            }
        }

        private void userSurname_Leave(object sender, EventArgs e)
        {
            if (userSurname.Text == "")
            {
                userSurname.Text = "Введите фамилию";
                userSurname.ForeColor = Color.Gray;
            }
        }

        private void log_win_Leave(object sender, EventArgs e)
        {
            if (log_win.Text == "")
            {
                log_win.Text = "Введите логин";
                log_win.ForeColor = Color.Gray;
            }
        }

        private void pass_win_Leave(object sender, EventArgs e)
        {
            if (pass_win.Text == "")
            {
                pass_win.ForeColor = Color.Gray;
                pass_win.Text = "Введите пароль";

            }

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (userName.Text == "Введите имя")
            {
                MessageBox.Show("Проверьте окно ввода имени");
                return;
            }
            if (userSurname.Text == "Введите фимилию")
            {
                MessageBox.Show("Проверьте окно ввода фамилии");
                return;
            }
            if (log_win.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (pass_win.Text == "Введите пароль")
            {
                MessageBox.Show("Укажите пароль");
                return;
            }
            if (isUserExists())
            {
                return;
            }

            DB db = new DB();
            SqlCommand command = new SqlCommand("insert into UserAPP (login, password, name, surname) values(@login, @password, @name, @surname)", db.getConnection());

            command.Parameters.Add("@login", SqlDbType.NVarChar).Value = log_win.Text;
            command.Parameters.Add("@password", SqlDbType.NVarChar).Value = pass_win.Text;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = userName.Text;
            command.Parameters.Add("@surname", SqlDbType.NVarChar).Value = userSurname.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Пользователь " + log_win.Text + " зарегестрирован");
            else
                MessageBox.Show("Ошибка");

            db.closeConnection();
        }

        public Boolean isUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("select * from UserAPP where login = @login", db.getConnection());
            command.Parameters.Add("@login", SqlDbType.NVarChar).Value = log_win.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Аккаунт уже существует");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
