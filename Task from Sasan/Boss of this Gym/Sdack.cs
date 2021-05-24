using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boss_of_this_Gym
{
    public partial class Sdack : Form
    {
        public Sdack()
        {
            InitializeComponent();
        }
        Deque Samurai;

        private void Init_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Размер принят");
                Samurai = new Deque(Convert.ToInt32(TextBox2.Text));
                label1.Visible = false;
                TextBox2.Visible = false;
                Init.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Некоректный размер!");
            }
        }//кол-во элем дека(должно быть максимум)

        private void Add_start_Click(object sender, EventArgs e)
        {
            int number;
            if (Int32.TryParse(TextBox1.Text, out number))
            {
                try
                {
                    Samurai.pushBack(Convert.ToInt32(TextBox1.Text));
                    RichTextBox.Text += "В дек добавлен элемент!\n";
                    TextBox1.Text = "";
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Ошибка переполнения данных!");
                    TextBox1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Ошибка ввода данных!");
                TextBox1.Text = "";
            }
        }//добавление элем в начало

        private void Add_end_Click(object sender, EventArgs e)
        {
            int number;
            if (Int32.TryParse(TextBox1.Text, out number))
            {
                try
                {
                    Samurai.pushFront(Convert.ToInt32(TextBox1.Text));
                    RichTextBox.Text += "В дек добавлен элемент!\n";
                    TextBox1.Text = "";
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Ошибка переполнения данных!");
                    TextBox1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Ошибка ввода данных!");
                TextBox1.Text = "";
            }
        }//добавление элем в конец

        private void MaxElem_Click(object sender, EventArgs e)
        {
            RichTextBox.Text += "Максимальный элемент дека = ";
            RichTextBox.Text += Samurai.operations("max").ToString() + "\n";
        }//максимальный элем дека

        private void Delete_start_Click(object sender, EventArgs e)
        {
            try
            {
                Samurai.popBack();
                RichTextBox.Text += "Из дека удален элемент!\n";
            }
            catch (IndexOutOfRangeException)
            {
                RichTextBox.Text += "Начало дека пусто!\n";
            }
        }//удаление элем из начала

        private void Delete_end_Click(object sender, EventArgs e)
        {
            try
            {
                Samurai.popFront();
                RichTextBox.Text += "Из дека удален элемент!\n";
            }
            catch (IndexOutOfRangeException)
            {
                RichTextBox.Text += "Конец дека пуст!\n";
            }
        }//удаление элем из конца

        private void MinElem_Click(object sender, EventArgs e)
        {
            RichTextBox.Text += "Минимальный элемент дека = ";
            RichTextBox.Text += Samurai.operations("min").ToString() + "\n";
        }//минимальный элем дека

        private void Start_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBox.Text += "В начале дека: \n";
                RichTextBox.Text += Samurai.getBack();
                RichTextBox.Text += "\n";
            }
            catch (Exception)
            {
                RichTextBox.Text += "Невозможно!\n";
            }
        }//начало дека

        private void EndDeck_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBox.Text += "На конце дека: \n";
                RichTextBox.Text += Samurai.getFront();
                RichTextBox.Text += "\n";
            }
            catch (Exception)
            {
                RichTextBox.Text += "Невозможно!\n";
            }
        }//конец дека

        private void AllElem_Click(object sender, EventArgs e)
        {
            int[] output = Samurai.getAll();
            RichTextBox.Text += "Элементы дека: \n";
            foreach (int Item in output)
            {
                RichTextBox.Text += Item.ToString() + " ";
            }
            RichTextBox.Text += "\n";
        }//все элем дека

        private void Sum_Click(object sender, EventArgs e)
        {
            RichTextBox.Text += "Сумма элементов дека = ";
            RichTextBox.Text += Samurai.operations("sum").ToString()+"\n";
        }//сумма элем дека

        private void Multiplex_Click(object sender, EventArgs e)
        {
            RichTextBox.Text += "Произведение элементов дека = ";
            RichTextBox.Text += Samurai.operations("mult").ToString()+"\n";
        }//произведение элем дека

        private void CountElem_Click(object sender, EventArgs e)
        {
            RichTextBox.Text += "Колличество элементов в деке = ";
            RichTextBox.Text += Samurai.getAll().Count().ToString()+"\n";
        }//кол-во элем

        private void Reverse_Click(object sender, EventArgs e)
        {
            Samurai.dequeReverse();
            RichTextBox.Text += "Дек инвертирован!\n";
        }//инвертирование дека

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            RichTextBox.SelectionStart = RichTextBox.Text.Length;
            RichTextBox.ScrollToCaret();
        }//авто скролл
    }
}
