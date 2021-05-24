
namespace B_D_111
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
            this.dataGridView_doc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView_users = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.Label();
            this.Date_of_birth = new System.Windows.Forms.Label();
            this.Middle_name = new System.Windows.Forms.Label();
            this.Name_s = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.ID_client = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_doc)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_doc
            // 
            this.dataGridView_doc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_doc.Location = new System.Drawing.Point(12, 154);
            this.dataGridView_doc.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_doc.Name = "dataGridView_doc";
            this.dataGridView_doc.RowHeadersWidth = 51;
            this.dataGridView_doc.RowTemplate.Height = 24;
            this.dataGridView_doc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_doc.Size = new System.Drawing.Size(277, 445);
            this.dataGridView_doc.TabIndex = 0;
            this.dataGridView_doc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_doc_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Категории";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя Категории";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(11, 59);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(106, 70);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 44);
            this.button2.TabIndex = 4;
            this.button2.Text = "Изменить ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(189, 70);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 44);
            this.button3.TabIndex = 5;
            this.button3.Text = "Удалить ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(132, 24);
            this.textBoxQ.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxQ.Multiline = true;
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(117, 19);
            this.textBoxQ.TabIndex = 6;
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(148, 47);
            this.textBoxN.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxN.Multiline = true;
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(117, 19);
            this.textBoxN.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 119);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Категории";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(691, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 23);
            this.label3.TabIndex = 79;
            this.label3.Text = "Табл инфы о товаре";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(826, 43);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(79, 44);
            this.button7.TabIndex = 78;
            this.button7.Text = "Проверить";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(660, 43);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 44);
            this.button5.TabIndex = 77;
            this.button5.Text = "Удалить ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(743, 43);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(79, 44);
            this.button6.TabIndex = 76;
            this.button6.Text = "Обновить ";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(577, 43);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 44);
            this.button4.TabIndex = 75;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView_users
            // 
            this.dataGridView_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_users.Location = new System.Drawing.Point(336, 154);
            this.dataGridView_users.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_users.Name = "dataGridView_users";
            this.dataGridView_users.RowHeadersWidth = 51;
            this.dataGridView_users.RowTemplate.Height = 24;
            this.dataGridView_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_users.Size = new System.Drawing.Size(914, 445);
            this.dataGridView_users.TabIndex = 74;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(448, 20);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 19);
            this.textBox4.TabIndex = 73;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(143, 68);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 19);
            this.textBox3.TabIndex = 72;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 45);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 19);
            this.textBox2.TabIndex = 71;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 22);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 19);
            this.textBox1.TabIndex = 70;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(448, 43);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(125, 19);
            this.textBox5.TabIndex = 69;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(448, 66);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(125, 19);
            this.textBox6.TabIndex = 68;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(281, 64);
            this.Gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(163, 21);
            this.Gender.TabIndex = 67;
            this.Gender.Text = "Цена за 1шт товара";
            // 
            // Date_of_birth
            // 
            this.Date_of_birth.AutoSize = true;
            this.Date_of_birth.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_of_birth.Location = new System.Drawing.Point(275, 45);
            this.Date_of_birth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Date_of_birth.Name = "Date_of_birth";
            this.Date_of_birth.Size = new System.Drawing.Size(169, 21);
            this.Date_of_birth.TabIndex = 66;
            this.Date_of_birth.Text = "Колличество товара";
            // 
            // Middle_name
            // 
            this.Middle_name.AutoSize = true;
            this.Middle_name.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Middle_name.Location = new System.Drawing.Point(315, 20);
            this.Middle_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Middle_name.Name = "Middle_name";
            this.Middle_name.Size = new System.Drawing.Size(129, 21);
            this.Middle_name.TabIndex = 65;
            this.Middle_name.Text = "Модель товара";
            // 
            // Name_s
            // 
            this.Name_s.AutoSize = true;
            this.Name_s.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_s.Location = new System.Drawing.Point(43, 68);
            this.Name_s.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Name_s.Name = "Name_s";
            this.Name_s.Size = new System.Drawing.Size(99, 21);
            this.Name_s.TabIndex = 64;
            this.Name_s.Text = "Имя товара";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surname.Location = new System.Drawing.Point(30, 45);
            this.Surname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(112, 21);
            this.Surname.TabIndex = 63;
            this.Surname.Text = "ID_Категории";
            // 
            // ID_client
            // 
            this.ID_client.AutoSize = true;
            this.ID_client.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_client.Location = new System.Drawing.Point(53, 20);
            this.ID_client.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID_client.Name = "ID_client";
            this.ID_client.Size = new System.Drawing.Size(86, 21);
            this.ID_client.TabIndex = 62;
            this.ID_client.Text = "ID_Товара";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 80;
            this.label4.Text = "Табл категорий";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ID_client);
            this.groupBox2.Controls.Add(this.Middle_name);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.Date_of_birth);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.Surname);
            this.groupBox2.Controls.Add(this.Gender);
            this.groupBox2.Controls.Add(this.Name_s);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(336, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(914, 119);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Товар";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 614);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_users);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView_doc);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.textBoxQ);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "БД";
            this.Load += new System.EventHandler(this.categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_doc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_doc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView_users;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label Date_of_birth;
        private System.Windows.Forms.Label Middle_name;
        private System.Windows.Forms.Label Name_s;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label ID_client;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}