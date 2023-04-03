using System.Data.SqlClient;
using System.Data;

namespace TicketsProject;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();

        this.pass_win.AutoSize = false;
        this.pass_win.Size = new Size(this.pass_win.Size.Width, 38);
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

    private void LoginBtn_Click(object sender, EventArgs e)
    {

        DB db = new DB();

        DataTable table = new DataTable();

        SqlDataAdapter adapter = new SqlDataAdapter();

        SqlCommand command = new SqlCommand("select * from UserAPP where login = @login and password = @password", db.getConnection());
        command.Parameters.Add("@login", SqlDbType.NVarChar).Value = log_win.Text;
        command.Parameters.Add("@password", SqlDbType.NVarChar).Value = pass_win.Text;

        adapter.SelectCommand = command;
        adapter.Fill(table);

        if (table.Rows.Count > 0)
        {
            MessageBox.Show("Вы успешно вошли в аккаунт");
        }
        else
        {
            MessageBox.Show("Проверьте введенные данные и повтори попытку");
        }
    }

    private void registerLabel_Click(object sender, EventArgs e)
    {
        this.Hide();
        RegisterForm registerForm = new RegisterForm();
        registerForm.Show();
    }
}