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
        this.Close();
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
}