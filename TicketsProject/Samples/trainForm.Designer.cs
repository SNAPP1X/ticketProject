namespace TicketsProject
{
    partial class trainForm
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
            table_train = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            id_train = new TextBox();
            namber = new TextBox();
            search_train = new Button();
            add_train = new Button();
            open_train = new Button();
            ((System.ComponentModel.ISupportInitialize)table_train).BeginInit();
            SuspendLayout();
            // 
            // table_train
            // 
            table_train.BackgroundColor = Color.White;
            table_train.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_train.Location = new Point(124, 12);
            table_train.Name = "table_train";
            table_train.RowTemplate.Height = 25;
            table_train.Size = new Size(389, 150);
            table_train.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(195, 203);
            label1.Name = "label1";
            label1.Size = new Size(98, 23);
            label1.TabIndex = 1;
            label1.Text = "Код поезда";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(195, 246);
            label2.Name = "label2";
            label2.Size = new Size(110, 23);
            label2.TabIndex = 2;
            label2.Text = "Кол-во мест";
            // 
            // id_train
            // 
            id_train.Location = new Point(311, 203);
            id_train.Name = "id_train";
            id_train.Size = new Size(100, 23);
            id_train.TabIndex = 3;
            // 
            // namber
            // 
            namber.Location = new Point(311, 249);
            namber.Name = "namber";
            namber.Size = new Size(100, 23);
            namber.TabIndex = 4;
            // 
            // search_train
            // 
            search_train.BackColor = Color.FromArgb(255, 27, 68);
            search_train.FlatAppearance.BorderSize = 0;
            search_train.FlatStyle = FlatStyle.System;
            search_train.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            search_train.Location = new Point(205, 299);
            search_train.Name = "search_train";
            search_train.Size = new Size(75, 23);
            search_train.TabIndex = 5;
            search_train.Text = "Найти";
            search_train.UseVisualStyleBackColor = false;
            search_train.Click += search_train_Click;
            // 
            // add_train
            // 
            add_train.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            add_train.Location = new Point(286, 299);
            add_train.Name = "add_train";
            add_train.Size = new Size(75, 23);
            add_train.TabIndex = 6;
            add_train.Text = "Добавить";
            add_train.UseVisualStyleBackColor = true;
            add_train.Click += add_train_Click;
            // 
            // open_train
            // 
            open_train.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            open_train.Location = new Point(367, 299);
            open_train.Name = "open_train";
            open_train.Size = new Size(75, 23);
            open_train.TabIndex = 7;
            open_train.Text = "Открыть";
            open_train.UseVisualStyleBackColor = true;
            open_train.Click += open_train_Click;
            // 
            // trainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_midle;
            ClientSize = new Size(615, 358);
            Controls.Add(open_train);
            Controls.Add(add_train);
            Controls.Add(search_train);
            Controls.Add(namber);
            Controls.Add(id_train);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(table_train);
            Name = "trainForm";
            Text = "Поезда";
            ((System.ComponentModel.ISupportInitialize)table_train).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView table_train;
        private Label label1;
        private Label label2;
        private TextBox id_train;
        private TextBox namber;
        private Button search_train;
        private Button add_train;
        private Button open_train;
    }
}