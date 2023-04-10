using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketsProject
{
    public partial class MainForm : Form
    {
        private Form activeForm;
        private Button currentButton;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form_close_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseBtn_MouseEnter(object sender, EventArgs e)
        {
            CloseBtn.ForeColor = Color.Red;
        }

        private void CloseBtn_MouseLeave(object sender, EventArgs e)
        {
            CloseBtn.ForeColor = Color.Black;
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

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null && btnSender is Button)
            {
                if (currentButton != (Button)btnSender)
                {
                    currentButton = (Button)btnSender;

                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                //activeForm.Close();
            }

            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(childForm);
            this.main_panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            home.Text = childForm.Text;
        }

        private void b1_route_Click(object sender, EventArgs e)
        {
            OpenChildForm(new childForm(), sender);

            b1_route.BackColor = Color.Red;
            b2_train.BackColor = Color.FromArgb(255, 27, 68);
            b3_place.BackColor = Color.FromArgb(255, 27, 68);
            b4_passag.BackColor = Color.FromArgb(255, 27, 68);
            b5_sale.BackColor = Color.FromArgb(255, 27, 68);
        }

        private void b2_train_Click(object sender, EventArgs e)
        {
            OpenChildForm(new trainForm(), sender);

            b1_route.BackColor = Color.FromArgb(255, 27, 68);
            b2_train.BackColor = Color.Red;
            b3_place.BackColor = Color.FromArgb(255, 27, 68);
            b4_passag.BackColor = Color.FromArgb(255, 27, 68);
            b5_sale.BackColor = Color.FromArgb(255, 27, 68);
        }

        private void b3_place_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PlaceForm(), sender);

            b1_route.BackColor = Color.FromArgb(255, 27, 68);
            b2_train.BackColor = Color.FromArgb(255, 27, 68);
            b3_place.BackColor = Color.Red;
            b4_passag.BackColor = Color.FromArgb(255, 27, 68);
            b5_sale.BackColor = Color.FromArgb(255, 27, 68);
        }

        private void b4_passag_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PassagForm(), sender);

            b1_route.BackColor = Color.FromArgb(255, 27, 68);
            b2_train.BackColor = Color.FromArgb(255, 27, 68);
            b3_place.BackColor = Color.FromArgb(255, 27, 68);
            b4_passag.BackColor = Color.Red;
            b5_sale.BackColor = Color.FromArgb(255, 27, 68);
        }

        private void b5_sale_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SaleForm(), sender);

            b1_route.BackColor = Color.FromArgb(255, 27, 68);
            b2_train.BackColor = Color.FromArgb(255, 27, 68);
            b3_place.BackColor = Color.FromArgb(255, 27, 68);
            b4_passag.BackColor = Color.FromArgb(255, 27, 68);
            b5_sale.BackColor = Color.Red;
        }

        private void Home_click_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home(), sender);

            b1_route.BackColor = Color.FromArgb(255, 27, 68);
            b2_train.BackColor = Color.FromArgb(255, 27, 68);
            b3_place.BackColor = Color.FromArgb(255, 27, 68);
            b4_passag.BackColor = Color.FromArgb(255, 27, 68);
            b5_sale.BackColor = Color.FromArgb(255, 27, 68);
        }
    }
}
