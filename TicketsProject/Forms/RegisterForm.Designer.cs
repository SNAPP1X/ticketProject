namespace TicketsProject
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainPanel = new Panel();
            loginLabel = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            userSurname = new TextBox();
            userName = new TextBox();
            pictureBox2 = new PictureBox();
            pass_win = new TextBox();
            pictureBox1 = new PictureBox();
            CloseBtn = new Label();
            log_win = new TextBox();
            RegisterBtn = new Button();
            label1 = new Label();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackgroundImage = Properties.Resources.ticket_giveaways;
            mainPanel.Controls.Add(loginLabel);
            mainPanel.Controls.Add(pictureBox4);
            mainPanel.Controls.Add(pictureBox3);
            mainPanel.Controls.Add(userSurname);
            mainPanel.Controls.Add(userName);
            mainPanel.Controls.Add(pictureBox2);
            mainPanel.Controls.Add(pass_win);
            mainPanel.Controls.Add(pictureBox1);
            mainPanel.Controls.Add(CloseBtn);
            mainPanel.Controls.Add(log_win);
            mainPanel.Controls.Add(RegisterBtn);
            mainPanel.Controls.Add(label1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(631, 438);
            mainPanel.TabIndex = 2;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.BackColor = Color.Transparent;
            loginLabel.Cursor = Cursors.Cross;
            loginLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            loginLabel.ForeColor = Color.Yellow;
            loginLabel.Location = new Point(292, 367);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(45, 15);
            loginLabel.TabIndex = 14;
            loginLabel.Text = "Войти";
            loginLabel.Click += loginLabel_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.user;
            pictureBox4.Location = new Point(351, 112);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(59, 52);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.user;
            pictureBox3.Location = new Point(14, 112);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(59, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // userSurname
            // 
            userSurname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userSurname.Cursor = Cursors.IBeam;
            userSurname.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            userSurname.Location = new Point(416, 112);
            userSurname.Multiline = true;
            userSurname.Name = "userSurname";
            userSurname.Size = new Size(193, 38);
            userSurname.TabIndex = 11;
            userSurname.TextAlign = HorizontalAlignment.Center;
            userSurname.Enter += userSurname_Enter;
            userSurname.Leave += userSurname_Leave;
            // 
            // userName
            // 
            userName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userName.Cursor = Cursors.IBeam;
            userName.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            userName.Location = new Point(79, 112);
            userName.Multiline = true;
            userName.Name = "userName";
            userName.Size = new Size(193, 38);
            userName.TabIndex = 10;
            userName.TextAlign = HorizontalAlignment.Center;
            userName.Enter += userName_Enter;
            userName.Leave += userName_Leave;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources._lock;
            pictureBox2.Location = new Point(351, 201);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pass_win
            // 
            pass_win.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pass_win.Cursor = Cursors.IBeam;
            pass_win.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            pass_win.Location = new Point(416, 201);
            pass_win.Multiline = true;
            pass_win.Name = "pass_win";
            pass_win.Size = new Size(193, 38);
            pass_win.TabIndex = 8;
            pass_win.TextAlign = HorizontalAlignment.Center;
            pass_win.Enter += pass_win_Enter;
            pass_win.Leave += pass_win_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.login__1_;
            pictureBox1.Location = new Point(14, 201);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 52);
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
            CloseBtn.Location = new Point(597, 0);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(34, 30);
            CloseBtn.TabIndex = 6;
            CloseBtn.Text = " х";
            CloseBtn.Click += Form_close_click;
            CloseBtn.MouseDown += mainPanel_MouseDown;
            CloseBtn.MouseEnter += CloseBtn_MouseEnter;
            CloseBtn.MouseLeave += CloseBtn_MouseLeave;
            CloseBtn.MouseMove += mainPanel_MouseMove;
            // 
            // log_win
            // 
            log_win.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            log_win.Cursor = Cursors.IBeam;
            log_win.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            log_win.Location = new Point(79, 201);
            log_win.Multiline = true;
            log_win.Name = "log_win";
            log_win.Size = new Size(193, 38);
            log_win.TabIndex = 4;
            log_win.TextAlign = HorizontalAlignment.Center;
            log_win.Enter += log_win_Enter;
            log_win.Leave += log_win_Leave;
            // 
            // RegisterBtn
            // 
            RegisterBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RegisterBtn.BackColor = Color.FromArgb(255, 128, 255);
            RegisterBtn.Cursor = Cursors.Hand;
            RegisterBtn.FlatAppearance.BorderSize = 0;
            RegisterBtn.FlatAppearance.MouseDownBackColor = Color.Purple;
            RegisterBtn.FlatAppearance.MouseOverBackColor = Color.Fuchsia;
            RegisterBtn.FlatStyle = FlatStyle.Flat;
            RegisterBtn.Font = new Font("Bookman Old Style", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterBtn.Location = new Point(13, 325);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(596, 39);
            RegisterBtn.TabIndex = 3;
            RegisterBtn.Text = "Зарегистрироваться";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 255, 128);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(631, 49);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.MouseDown += mainPanel_MouseDown;
            label1.MouseMove += mainPanel_MouseMove;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 438);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private PictureBox pictureBox2;
        private TextBox pass_win;
        private PictureBox pictureBox1;
        private Label CloseBtn;
        private TextBox log_win;
        private Button RegisterBtn;
        private Label label1;
        private TextBox userSurname;
        private TextBox userName;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label loginLabel;
    }
}