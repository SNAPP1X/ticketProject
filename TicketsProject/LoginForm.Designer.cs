namespace TicketsProject
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainPanel = new Panel();
            pictureBox2 = new PictureBox();
            pass_win = new TextBox();
            pictureBox1 = new PictureBox();
            CloseBtn = new Label();
            log_win = new TextBox();
            LoginBtn = new Button();
            label1 = new Label();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackgroundImage = Properties.Resources.ticket_giveaways;
            mainPanel.Controls.Add(pictureBox2);
            mainPanel.Controls.Add(pass_win);
            mainPanel.Controls.Add(pictureBox1);
            mainPanel.Controls.Add(CloseBtn);
            mainPanel.Controls.Add(log_win);
            mainPanel.Controls.Add(LoginBtn);
            mainPanel.Controls.Add(label1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(313, 438);
            mainPanel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources._lock;
            pictureBox2.Location = new Point(13, 223);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(93, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pass_win
            // 
            pass_win.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pass_win.Cursor = Cursors.IBeam;
            pass_win.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            pass_win.Location = new Point(119, 236);
            pass_win.Multiline = true;
            pass_win.Name = "pass_win";
            pass_win.PasswordChar = '*';
            pass_win.Size = new Size(172, 38);
            pass_win.TabIndex = 8;
            pass_win.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.login__1_;
            pictureBox1.Location = new Point(13, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // CloseBtn
            // 
            CloseBtn.AutoSize = true;
            CloseBtn.BackColor = Color.Transparent;
            CloseBtn.Cursor = Cursors.Hand;
            CloseBtn.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            CloseBtn.ForeColor = Color.White;
            CloseBtn.Location = new Point(279, 0);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(34, 30);
            CloseBtn.TabIndex = 6;
            CloseBtn.Text = " х";
            CloseBtn.Click += Form_close_click;
            CloseBtn.MouseEnter += CloseBtn_MouseEnter;
            CloseBtn.MouseLeave += CloseBtn_MouseLeave;
            // 
            // log_win
            // 
            log_win.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            log_win.Cursor = Cursors.IBeam;
            log_win.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            log_win.Location = new Point(119, 149);
            log_win.Multiline = true;
            log_win.Name = "log_win";
            log_win.Size = new Size(172, 38);
            log_win.TabIndex = 4;
            log_win.TextAlign = HorizontalAlignment.Center;
            // 
            // LoginBtn
            // 
            LoginBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LoginBtn.BackColor = Color.FromArgb(255, 128, 255);
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.FlatAppearance.BorderSize = 0;
            LoginBtn.FlatAppearance.MouseDownBackColor = Color.Purple;
            LoginBtn.FlatAppearance.MouseOverBackColor = Color.Fuchsia;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.Location = new Point(104, 324);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(111, 39);
            LoginBtn.TabIndex = 3;
            LoginBtn.Text = "Войти";
            LoginBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 255, 128);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(313, 49);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.MouseDown += mainPanel_MouseDown;
            label1.MouseMove += mainPanel_MouseMove;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 438);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Label CloseBtn;
        private TextBox log_win;
        private Button LoginBtn;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox pass_win;
        private PictureBox pictureBox1;
    }
}