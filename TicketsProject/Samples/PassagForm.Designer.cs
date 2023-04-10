namespace TicketsProject
{
    partial class PassagForm
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
            table_passag = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            id_ticket = new TextBox();
            id_train = new TextBox();
            id_place = new TextBox();
            id_roat = new TextBox();
            fio = new TextBox();
            search_passag = new Button();
            add_passag = new Button();
            open_passag = new Button();
            id_passag = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)table_passag).BeginInit();
            SuspendLayout();
            // 
            // table_passag
            // 
            table_passag.BackgroundColor = Color.White;
            table_passag.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_passag.Location = new Point(124, 12);
            table_passag.Name = "table_passag";
            table_passag.RowTemplate.Height = 25;
            table_passag.Size = new Size(389, 150);
            table_passag.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(310, 174);
            label2.Name = "label2";
            label2.Size = new Size(99, 23);
            label2.TabIndex = 2;
            label2.Text = "Код билета";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(70, 210);
            label3.Name = "label3";
            label3.Size = new Size(98, 23);
            label3.TabIndex = 3;
            label3.Text = "Код поезда";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(310, 210);
            label4.Name = "label4";
            label4.Size = new Size(91, 23);
            label4.TabIndex = 4;
            label4.Text = "Код места";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(70, 251);
            label5.Name = "label5";
            label5.Size = new Size(122, 23);
            label5.TabIndex = 5;
            label5.Text = "Код маршрута";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(310, 251);
            label6.Name = "label6";
            label6.Size = new Size(135, 23);
            label6.TabIndex = 6;
            label6.Text = "ФИО пассажира";
            // 
            // id_ticket
            // 
            id_ticket.Location = new Point(451, 177);
            id_ticket.Name = "id_ticket";
            id_ticket.Size = new Size(100, 23);
            id_ticket.TabIndex = 8;
            // 
            // id_train
            // 
            id_train.Location = new Point(204, 213);
            id_train.Name = "id_train";
            id_train.Size = new Size(100, 23);
            id_train.TabIndex = 9;
            // 
            // id_place
            // 
            id_place.Location = new Point(451, 213);
            id_place.Name = "id_place";
            id_place.Size = new Size(100, 23);
            id_place.TabIndex = 10;
            // 
            // id_roat
            // 
            id_roat.Location = new Point(204, 254);
            id_roat.Name = "id_roat";
            id_roat.Size = new Size(100, 23);
            id_roat.TabIndex = 11;
            // 
            // fio
            // 
            fio.Location = new Point(451, 254);
            fio.Name = "fio";
            fio.Size = new Size(100, 23);
            fio.TabIndex = 12;
            // 
            // search_passag
            // 
            search_passag.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            search_passag.Location = new Point(205, 299);
            search_passag.Name = "search_passag";
            search_passag.Size = new Size(75, 23);
            search_passag.TabIndex = 13;
            search_passag.Text = "Найти";
            search_passag.UseVisualStyleBackColor = true;
            search_passag.Click += search_passag_Click;
            // 
            // add_passag
            // 
            add_passag.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            add_passag.Location = new Point(286, 299);
            add_passag.Name = "add_passag";
            add_passag.Size = new Size(75, 23);
            add_passag.TabIndex = 14;
            add_passag.Text = "Добавить";
            add_passag.UseVisualStyleBackColor = true;
            add_passag.Click += add_passag_Click;
            // 
            // open_passag
            // 
            open_passag.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            open_passag.Location = new Point(367, 299);
            open_passag.Name = "open_passag";
            open_passag.Size = new Size(75, 23);
            open_passag.TabIndex = 15;
            open_passag.Text = "Открыть";
            open_passag.UseVisualStyleBackColor = true;
            open_passag.Click += open_passag_Click;
            // 
            // id_passag
            // 
            id_passag.Location = new Point(204, 177);
            id_passag.Name = "id_passag";
            id_passag.Size = new Size(100, 23);
            id_passag.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(70, 174);
            label1.Name = "label1";
            label1.Size = new Size(128, 23);
            label1.TabIndex = 17;
            label1.Text = "Код пассажира";
            // 
            // PassagForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_midle;
            ClientSize = new Size(615, 358);
            Controls.Add(label1);
            Controls.Add(id_passag);
            Controls.Add(open_passag);
            Controls.Add(add_passag);
            Controls.Add(search_passag);
            Controls.Add(fio);
            Controls.Add(id_roat);
            Controls.Add(id_place);
            Controls.Add(id_train);
            Controls.Add(id_ticket);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(table_passag);
            Name = "PassagForm";
            Text = "Пассажиры";
            ((System.ComponentModel.ISupportInitialize)table_passag).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView table_passag;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox id_ticket;
        private TextBox id_train;
        private TextBox id_place;
        private TextBox id_roat;
        private TextBox fio;
        private Button search_passag;
        private Button add_passag;
        private Button open_passag;
        private TextBox id_passag;
        private Label label1;
    }
}