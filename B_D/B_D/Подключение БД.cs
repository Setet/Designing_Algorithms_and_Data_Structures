using System;
using System.Windows.Forms;

namespace B_D_111
{
    public partial class Form1 : Form
    {
        Data.Connection con = new Data.Connection();
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
            label2.Visible = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Data.Connection.dataSource();
                label1.Visible = true;
                label1.Visible = false;
                con.connClose();
                string er = "Готово";
                MessageBox.Show(er,"подключение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message, "подключение",MessageBoxButtons.OK,MessageBoxIcon.Error);
                con.connClose();
            }
            finally
            {
             
                con.connClose();
            }
         
            MainForm p = new MainForm();
            p.Show();
            this.Visible = false;
        }
    }
}
