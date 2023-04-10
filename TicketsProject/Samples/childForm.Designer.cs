namespace TicketsProject
{
    partial class childForm
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
            components = new System.ComponentModel.Container();
            table_child = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            id_train = new TextBox();
            s_out = new TextBox();
            s_in = new TextBox();
            search_road = new Button();
            add_road = new Button();
            sqlConnectionBindingSource = new BindingSource(components);
            open_road = new Button();
            label1 = new Label();
            id_place = new TextBox();
            ((System.ComponentModel.ISupportInitialize)table_child).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sqlConnectionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // table_child
            // 
            table_child.BackgroundColor = Color.White;
            table_child.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_child.Location = new Point(124, 12);
            table_child.Name = "table_child";
            table_child.RowTemplate.Height = 25;
            table_child.Size = new Size(389, 150);
            table_child.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(169, 202);
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
            label3.Location = new Point(169, 231);
            label3.Name = "label3";
            label3.Size = new Size(180, 23);
            label3.TabIndex = 3;
            label3.Text = "Станция отправления";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(169, 259);
            label4.Name = "label4";
            label4.Size = new Size(157, 23);
            label4.TabIndex = 4;
            label4.Text = "Станция прибытия";
            // 
            // id_train
            // 
            id_train.Location = new Point(367, 202);
            id_train.Name = "id_train";
            id_train.Size = new Size(100, 23);
            id_train.TabIndex = 6;
            // 
            // s_out
            // 
            s_out.Location = new Point(367, 231);
            s_out.Name = "s_out";
            s_out.Size = new Size(100, 23);
            s_out.TabIndex = 7;
            // 
            // s_in
            // 
            s_in.Location = new Point(367, 259);
            s_in.Name = "s_in";
            s_in.Size = new Size(100, 23);
            s_in.TabIndex = 8;
            // 
            // search_road
            // 
            search_road.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            search_road.Location = new Point(205, 299);
            search_road.Name = "search_road";
            search_road.Size = new Size(75, 23);
            search_road.TabIndex = 9;
            search_road.Text = "Найти";
            search_road.UseVisualStyleBackColor = true;
            search_road.Click += search_road_Click;
            // 
            // add_road
            // 
            add_road.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            add_road.Location = new Point(286, 299);
            add_road.Name = "add_road";
            add_road.Size = new Size(75, 23);
            add_road.TabIndex = 10;
            add_road.Text = "Добавить";
            add_road.UseVisualStyleBackColor = true;
            add_road.Click += add_road_Click;
            // 
            // sqlConnectionBindingSource
            // 
            sqlConnectionBindingSource.DataSource = typeof(Microsoft.Data.SqlClient.SqlConnection);
            // 
            // open_road
            // 
            open_road.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            open_road.Location = new Point(367, 299);
            open_road.Name = "open_road";
            open_road.Size = new Size(75, 23);
            open_road.TabIndex = 11;
            open_road.Text = "Открыть";
            open_road.UseVisualStyleBackColor = true;
            open_road.Click += open_road_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(169, 174);
            label1.Name = "label1";
            label1.Size = new Size(122, 23);
            label1.TabIndex = 12;
            label1.Text = "Код маршрута";
            // 
            // id_place
            // 
            id_place.Location = new Point(367, 174);
            id_place.Name = "id_place";
            id_place.Size = new Size(100, 23);
            id_place.TabIndex = 13;
            // 
            // childForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_midle;
            ClientSize = new Size(615, 358);
            Controls.Add(id_place);
            Controls.Add(label1);
            Controls.Add(open_road);
            Controls.Add(add_road);
            Controls.Add(search_road);
            Controls.Add(s_in);
            Controls.Add(s_out);
            Controls.Add(id_train);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(table_child);
            Name = "childForm";
            Text = "Маршрут";
            ((System.ComponentModel.ISupportInitialize)table_child).EndInit();
            ((System.ComponentModel.ISupportInitialize)sqlConnectionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView table_child;
        private Label label2;
        private Label label3;
        private Label label4;
        public TextBox id_train;
        public TextBox s_out;
        public TextBox s_in;
        private Button search_road;
        private Button add_road;
        private BindingSource sqlConnectionBindingSource;
        private Button open_road;
        private Label label1;
        private TextBox id_place;
    }
}