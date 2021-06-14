using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace B_D_111
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=root;database=склад");
        MySqlCommand command;
        public void populateDGV()
        {
            string selectQuery = "SELECT * FROM категории";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView_doc.DataSource = table;
        }

        public void populateDGV2()
        {
            string selectQuery = "SELECT * FROM товар";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView_users.DataSource = table;
        }

        private void dataGridView_doc_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView_doc.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView_doc.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridView_users_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView_users.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView_users.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView_users.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView_users.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView_users.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView_users.CurrentRow.Cells[5].Value.ToString();

        }

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public void executeMyQuery(string query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Запрос выполнен");

                }
                else
                {
                    MessageBox.Show("Запрос не выполнен");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO `категории`( `ID`,`Category`) VALUES (\"" + textBoxQ.Text + "\",\"" + textBoxN.Text + "\")";
            executeMyQuery(insertQuery);
            populateDGV();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE  `категории` SET Category=\"" + textBoxN.Text + "\" WHERE ID =" + int.Parse(textBoxQ.Text);
            executeMyQuery(updateQuery);
            populateDGV();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM категории WHERE ID=" + int.Parse(textBoxQ.Text);
            executeMyQuery(deleteQuery);
            populateDGV();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO `товар`( `ID_Product`,`ID_Category`,`Name_Product`,`Model`,`Quantity`,`Price`) VALUES (\"" + textBox1.Text + "\",\"" + textBox2.Text + "\",\"" + textBox3.Text + "\",\"" + textBox4.Text + "\",\"" + textBox5.Text + "\",\"" + textBox6.Text + "\")";
            executeMyQuery(insertQuery);
            populateDGV2();
        }

        private void categories_Load(object sender, EventArgs e)
        {
            populateDGV();
            populateDGV2();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM товар WHERE ID_Product=" + int.Parse(textBox1.Text);
            executeMyQuery(deleteQuery);
            populateDGV2();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE  `товар` SET ID_Category=\"" + textBox2.Text + "\",Name_Product=\"" + textBox3.Text + "\",Model=\"" + textBox4.Text + "\",Quantity=\"" + textBox5.Text + "\",Price=\"" + textBox6.Text + "\" WHERE ID_Product =" + int.Parse(textBox1.Text);
            executeMyQuery(updateQuery);
            populateDGV2();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlDataReader mdr;
            string select = "SELECT * FROM товар WHERE ID_Product = " + int.Parse(textBox1.Text);
            command = new MySqlCommand(select, connection);
            mdr = command.ExecuteReader();
            if (mdr.Read())
            {
                textBox2.Text = mdr.GetString("ID_Category");
                textBox3.Text = mdr.GetString("Name_Product");
                textBox4.Text = mdr.GetString("Model");
                textBox5.Text = mdr.GetString("Quantity");
                textBox6.Text = mdr.GetString("Price");

            }
            connection.Close();
        }
    }
}
