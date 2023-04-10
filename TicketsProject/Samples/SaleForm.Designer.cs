namespace TicketsProject
{
    partial class SaleForm
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
            table_sale = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            id_train = new TextBox();
            id_place = new TextBox();
            id_road = new TextBox();
            fio = new TextBox();
            sale = new TextBox();
            search_sale = new Button();
            add_sale = new Button();
            open_sale = new Button();
            label1 = new Label();
            id_ticket = new TextBox();
            ((System.ComponentModel.ISupportInitialize)table_sale).BeginInit();
            SuspendLayout();
            // 
            // table_sale
            // 
            table_sale.BackgroundColor = Color.White;
            table_sale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_sale.Location = new Point(124, 12);
            table_sale.Name = "table_sale";
            table_sale.RowTemplate.Height = 25;
            table_sale.Size = new Size(389, 150);
            table_sale.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(76, 214);
            label2.Name = "label2";
            label2.Size = new Size(98, 23);
            label2.TabIndex = 2;
            label2.Text = "Код поезда";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(76, 257);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 3;
            label3.Text = "Код места";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(304, 177);
            label4.Name = "label4";
            label4.Size = new Size(122, 23);
            label4.TabIndex = 4;
            label4.Text = "Код маршрута";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(304, 217);
            label5.Name = "label5";
            label5.Size = new Size(135, 23);
            label5.TabIndex = 5;
            label5.Text = "ФИО пассажира";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(304, 254);
            label6.Name = "label6";
            label6.Size = new Size(92, 23);
            label6.TabIndex = 6;
            label6.Text = "Стоимость";
            // 
            // id_train
            // 
            id_train.Location = new Point(180, 217);
            id_train.Name = "id_train";
            id_train.Size = new Size(100, 23);
            id_train.TabIndex = 8;
            // 
            // id_place
            // 
            id_place.Location = new Point(180, 257);
            id_place.Name = "id_place";
            id_place.Size = new Size(100, 23);
            id_place.TabIndex = 9;
            // 
            // id_road
            // 
            id_road.Location = new Point(445, 180);
            id_road.Name = "id_road";
            id_road.Size = new Size(100, 23);
            id_road.TabIndex = 10;
            // 
            // fio
            // 
            fio.Location = new Point(445, 220);
            fio.Name = "fio";
            fio.Size = new Size(100, 23);
            fio.TabIndex = 11;
            // 
            // sale
            // 
            sale.Location = new Point(445, 257);
            sale.Name = "sale";
            sale.Size = new Size(100, 23);
            sale.TabIndex = 12;
            // 
            // search_sale
            // 
            search_sale.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            search_sale.Location = new Point(205, 299);
            search_sale.Name = "search_sale";
            search_sale.Size = new Size(75, 23);
            search_sale.TabIndex = 13;
            search_sale.Text = "Найти";
            search_sale.UseVisualStyleBackColor = true;
            search_sale.Click += search_sale_Click;
            // 
            // add_sale
            // 
            add_sale.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            add_sale.Location = new Point(286, 299);
            add_sale.Name = "add_sale";
            add_sale.Size = new Size(75, 23);
            add_sale.TabIndex = 14;
            add_sale.Text = "Добавить";
            add_sale.UseVisualStyleBackColor = true;
            add_sale.Click += add_sale_Click;
            // 
            // open_sale
            // 
            open_sale.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            open_sale.Location = new Point(367, 299);
            open_sale.Name = "open_sale";
            open_sale.Size = new Size(75, 23);
            open_sale.TabIndex = 15;
            open_sale.Text = "Открыть";
            open_sale.UseVisualStyleBackColor = true;
            open_sale.Click += open_sale_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(76, 177);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 16;
            label1.Text = "Код билета";
            // 
            // id_ticket
            // 
            id_ticket.Location = new Point(180, 180);
            id_ticket.Name = "id_ticket";
            id_ticket.Size = new Size(100, 23);
            id_ticket.TabIndex = 17;
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_midle;
            ClientSize = new Size(615, 358);
            Controls.Add(id_ticket);
            Controls.Add(label1);
            Controls.Add(open_sale);
            Controls.Add(add_sale);
            Controls.Add(search_sale);
            Controls.Add(sale);
            Controls.Add(fio);
            Controls.Add(id_road);
            Controls.Add(id_place);
            Controls.Add(id_train);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(table_sale);
            Name = "SaleForm";
            Text = "Продажа билетов";
            ((System.ComponentModel.ISupportInitialize)table_sale).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView table_sale;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox id_train;
        private TextBox id_place;
        private TextBox id_road;
        private TextBox fio;
        private TextBox sale;
        private Button search_sale;
        private Button add_sale;
        private Button open_sale;
        private Label label1;
        private TextBox id_ticket;
    }
}