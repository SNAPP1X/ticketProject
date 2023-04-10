namespace TicketsProject
{
    partial class PlaceForm
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
            table_place = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            view = new TextBox();
            id_place = new TextBox();
            id_train = new TextBox();
            search_place = new Button();
            add_place = new Button();
            open_place = new Button();
            ((System.ComponentModel.ISupportInitialize)table_place).BeginInit();
            SuspendLayout();
            // 
            // table_place
            // 
            table_place.BackgroundColor = Color.White;
            table_place.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_place.Location = new Point(124, 12);
            table_place.Name = "table_place";
            table_place.RowTemplate.Height = 25;
            table_place.Size = new Size(389, 150);
            table_place.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(208, 173);
            label1.Name = "label1";
            label1.Size = new Size(91, 23);
            label1.TabIndex = 1;
            label1.Text = "Код места";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(208, 216);
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
            label3.Location = new Point(208, 258);
            label3.Name = "label3";
            label3.Size = new Size(92, 23);
            label3.TabIndex = 3;
            label3.Text = "Вид места";
            // 
            // view
            // 
            view.Location = new Point(336, 258);
            view.Name = "view";
            view.Size = new Size(100, 23);
            view.TabIndex = 4;
            // 
            // id_place
            // 
            id_place.Location = new Point(336, 173);
            id_place.Name = "id_place";
            id_place.Size = new Size(100, 23);
            id_place.TabIndex = 5;
            // 
            // id_train
            // 
            id_train.Location = new Point(336, 216);
            id_train.Name = "id_train";
            id_train.Size = new Size(100, 23);
            id_train.TabIndex = 6;
            // 
            // search_place
            // 
            search_place.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            search_place.Location = new Point(205, 299);
            search_place.Name = "search_place";
            search_place.Size = new Size(75, 23);
            search_place.TabIndex = 7;
            search_place.Text = "Найти";
            search_place.UseVisualStyleBackColor = true;
            search_place.Click += search_place_Click;
            // 
            // add_place
            // 
            add_place.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            add_place.Location = new Point(286, 299);
            add_place.Name = "add_place";
            add_place.Size = new Size(75, 23);
            add_place.TabIndex = 8;
            add_place.Text = "Добавить";
            add_place.UseVisualStyleBackColor = true;
            add_place.Click += add_place_Click;
            // 
            // open_place
            // 
            open_place.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            open_place.Location = new Point(367, 299);
            open_place.Name = "open_place";
            open_place.Size = new Size(75, 23);
            open_place.TabIndex = 9;
            open_place.Text = "Открыть";
            open_place.UseVisualStyleBackColor = true;
            open_place.Click += open_place_Click;
            // 
            // PlaceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_midle;
            ClientSize = new Size(615, 358);
            Controls.Add(open_place);
            Controls.Add(add_place);
            Controls.Add(search_place);
            Controls.Add(id_train);
            Controls.Add(id_place);
            Controls.Add(view);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(table_place);
            Name = "PlaceForm";
            Text = "Места поезда";
            ((System.ComponentModel.ISupportInitialize)table_place).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView table_place;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox view;
        private TextBox id_place;
        private TextBox id_train;
        private Button search_place;
        private Button add_place;
        private Button open_place;
    }
}