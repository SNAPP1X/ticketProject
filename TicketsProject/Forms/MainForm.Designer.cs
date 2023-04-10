namespace TicketsProject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            b5_sale = new Button();
            b4_passag = new Button();
            b3_place = new Button();
            b2_train = new Button();
            b1_route = new Button();
            panel3 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            Home_click = new PictureBox();
            CloseBtn = new Label();
            home = new Label();
            main_panel = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Home_click).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.BackgroundImage = Properties.Resources.ticket_giveaways;
            panel1.Controls.Add(b5_sale);
            panel1.Controls.Add(b4_passag);
            panel1.Controls.Add(b3_place);
            panel1.Controls.Add(b2_train);
            panel1.Controls.Add(b1_route);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 450);
            panel1.TabIndex = 0;
            // 
            // b5_sale
            // 
            b5_sale.BackColor = Color.FromArgb(255, 27, 68);
            b5_sale.FlatAppearance.BorderSize = 0;
            b5_sale.FlatStyle = FlatStyle.Flat;
            b5_sale.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            b5_sale.ForeColor = Color.FromArgb(255, 255, 192);
            b5_sale.Location = new Point(0, 281);
            b5_sale.Name = "b5_sale";
            b5_sale.Size = new Size(169, 41);
            b5_sale.TabIndex = 5;
            b5_sale.Text = "Продажа билетов";
            b5_sale.UseVisualStyleBackColor = false;
            b5_sale.Click += b5_sale_Click;
            // 
            // b4_passag
            // 
            b4_passag.BackColor = Color.FromArgb(255, 27, 68);
            b4_passag.FlatAppearance.BorderSize = 0;
            b4_passag.FlatStyle = FlatStyle.Flat;
            b4_passag.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            b4_passag.ForeColor = Color.FromArgb(255, 255, 192);
            b4_passag.Location = new Point(0, 223);
            b4_passag.Name = "b4_passag";
            b4_passag.Size = new Size(169, 41);
            b4_passag.TabIndex = 4;
            b4_passag.Text = "Пассажиры";
            b4_passag.UseVisualStyleBackColor = false;
            b4_passag.Click += b4_passag_Click;
            // 
            // b3_place
            // 
            b3_place.BackColor = Color.FromArgb(255, 27, 68);
            b3_place.FlatAppearance.BorderSize = 0;
            b3_place.FlatStyle = FlatStyle.Flat;
            b3_place.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            b3_place.ForeColor = Color.FromArgb(255, 255, 192);
            b3_place.Location = new Point(0, 167);
            b3_place.Name = "b3_place";
            b3_place.Size = new Size(169, 41);
            b3_place.TabIndex = 3;
            b3_place.Text = "Места поезда";
            b3_place.UseVisualStyleBackColor = false;
            b3_place.Click += b3_place_Click;
            // 
            // b2_train
            // 
            b2_train.BackColor = Color.FromArgb(255, 27, 68);
            b2_train.FlatAppearance.BorderSize = 0;
            b2_train.FlatStyle = FlatStyle.Flat;
            b2_train.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            b2_train.ForeColor = Color.FromArgb(255, 255, 192);
            b2_train.Location = new Point(0, 110);
            b2_train.Name = "b2_train";
            b2_train.Size = new Size(169, 41);
            b2_train.TabIndex = 2;
            b2_train.Text = "Поезда";
            b2_train.UseVisualStyleBackColor = false;
            b2_train.Click += b2_train_Click;
            // 
            // b1_route
            // 
            b1_route.BackColor = Color.FromArgb(255, 27, 68);
            b1_route.FlatAppearance.BorderSize = 0;
            b1_route.FlatStyle = FlatStyle.Flat;
            b1_route.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            b1_route.ForeColor = Color.FromArgb(255, 255, 192);
            b1_route.Location = new Point(0, 53);
            b1_route.Name = "b1_route";
            b1_route.Size = new Size(169, 41);
            b1_route.TabIndex = 1;
            b1_route.Text = "Маршрут";
            b1_route.UseVisualStyleBackColor = false;
            b1_route.Click += b1_route_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 255, 192);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(169, 53);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 13);
            label1.Name = "label1";
            label1.Size = new Size(124, 27);
            label1.TabIndex = 0;
            label1.Text = "S10 Tickets";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(Home_click);
            panel2.Controls.Add(CloseBtn);
            panel2.Controls.Add(home);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(169, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(631, 53);
            panel2.TabIndex = 1;
            panel2.MouseDown += mainPanel_MouseDown;
            panel2.MouseMove += mainPanel_MouseMove;
            // 
            // Home_click
            // 
            Home_click.Image = Properties.Resources.icons8_home_page_48;
            Home_click.Location = new Point(6, 11);
            Home_click.Name = "Home_click";
            Home_click.Size = new Size(38, 36);
            Home_click.SizeMode = PictureBoxSizeMode.Zoom;
            Home_click.TabIndex = 2;
            Home_click.TabStop = false;
            Home_click.Click += Home_click_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.AutoSize = true;
            CloseBtn.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CloseBtn.Location = new Point(594, 11);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(25, 29);
            CloseBtn.TabIndex = 1;
            CloseBtn.Text = "x";
            CloseBtn.Click += Form_close_click;
            CloseBtn.MouseEnter += CloseBtn_MouseEnter;
            CloseBtn.MouseLeave += CloseBtn_MouseLeave;
            // 
            // home
            // 
            home.AutoSize = true;
            home.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            home.Location = new Point(50, 13);
            home.Name = "home";
            home.Size = new Size(96, 29);
            home.TabIndex = 0;
            home.Text = "Главная";
            // 
            // main_panel
            // 
            main_panel.BackgroundImage = Properties.Resources.bg_midle;
            main_panel.Dock = DockStyle.Fill;
            main_panel.Location = new Point(169, 53);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(631, 397);
            main_panel.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(main_panel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Home_click).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button b5_sale;
        private Button b4_passag;
        private Button b3_place;
        private Button b2_train;
        private Panel panel3;
        private Label label1;
        private Panel panel2;
        private Label CloseBtn;
        private Panel main_panel;
        private Label home;
        public Button b1_route;
        private PictureBox Home_click;
    }
}