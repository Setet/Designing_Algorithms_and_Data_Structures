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
    public partial class OPN : Form
    {
        public OPN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input;
            string GetExpression()
            {
                Answer.Text += labelNumber.Text;
                input = Convert.ToString(labelNumber);
                string output1 = string.Empty; //Строка для хранения выражения
                Stack<char> operStack = new Stack<char>(); //Стек для хранения операторов

                for (int i = 0; i < input.Length; i++) //Для каждого символа в входной строке
                {
                    //Разделители пропускаем
                    if (IsDelimeter(input[i]))
                        continue; //Переходим к следующему символу

                    //Если символ - цифра, то считывем все число
                    if (Char.IsDigit(input[i])) //Если цифра
                    {
                        //Читаем до разделителя или оператора, что бы получить число
                        while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
                        {
                            output1 += input[i]; //Добаляем каждую цифру числа к нашей строке
                            i++; //Переходим к следующему символу

                            if (i == input.Length) break; //Если символ - последний, то выходим из цикла
                        }

                        output1 += " "; //Дописываем после числа пробел в строку с выражением
                        i--; //Возвращаемся на один символ назад, к символу перед разделителем
                    }

                    //Если символ - оператор
                    if (IsOperator(input[i])) //Если оператор
                    {
                        if (input[i] == '(') //Если символ - открывающая скобка
                            operStack.Push(input[i]); //Записываем её в стек
                        else if (input[i] == ')') //Если символ - закрывающая скобка
                        {
                            //Выписываем все операторы до открывающей скобки в строку
                            char s = operStack.Pop();

                            while (s != '(')
                            {
                                output1 += s.ToString() + ' ';
                                s = operStack.Pop();
                            }
                        }
                        else //Если любой другой оператор
                        {
                            if (operStack.Count > 0) //Если в стеке есть элементы
                                if (GetPriority(input[i]) <= GetPriority(operStack.Peek())) //И если приоретет нашего оператора меньше или равен приоретету оператора на вершине стека
                                    output1 += operStack.Pop().ToString() + " "; //То добавляем последний оператор из стека в строку с выражением

                            operStack.Push(char.Parse(input[i].ToString())); //Если стек пуст, или же приоретет оператора выше - добавляем оператов на вершину стека

                        }
                    }
                }

                //Когда прошли по всем символам, выкидываем из стека все оставшиеся там операторы в строку
                while (operStack.Count > 0)
                    output1 += operStack.Pop() + " ";

                labelNumber.Text = output1;
                return output1; //Возвращаем выражение в постфиксной записи
            }//Преобразовываем выражение в постфиксную запись

            double Counting()
            {
                input = Convert.ToString(labelNumber);
                double result1 = 0; //Результат
                Stack<double> temp = new Stack<double>(); //Временный стек для решения


                for (int i = 0; i < input.Length; i++) //Для каждого символа в строке
                {
                    //Если символ - цифра, то читаем все число и записываем на вершину стека
                    if (Char.IsDigit(input[i]))
                    {
                        string a = string.Empty;

                        while (!IsDelimeter(input[i]) && !IsOperator(input[i])) //Пока не разделитель
                        {
                            a += input[i]; //Добаляем
                            i++;
                            if (i == input.Length) break;
                        }
                        temp.Push(double.Parse(a)); //Записываем в стек
                        i--;
                    }
                    else if (IsOperator(input[i])) //Если символ - оператор
                    {
                        double a = temp.Pop(); //Берем 2 последних значения из стека
                        double b = temp.Pop();
                        switch (input[i]) //И производим над ними действие, согласно оператору
                        {
                            case '+': result1 = b + a; break;
                            case '-': result1 = b - a; break;
                            case '*': result1 = b * a; break;
                            case '/': result1 = b / a; break;
                            case '^': result1 = double.Parse(Math.Pow(double.Parse(b.ToString()), double.Parse(a.ToString())).ToString()); break;
                        }
                        temp.Push(result1); //Результат вычисления записываем обратно в стек
                    }
                }
                Answer.Text += Convert.ToString("=" + result1 + "\n");
                return temp.Peek(); //Забираем результат всех вычислений из стека и возвращаем его
            }//Решаем полученное выражение

            int GetPriority(char s)
            {
                switch (s)
                {
                    case '(': return 0;
                    case ')': return 1;
                    case '+': return 2;
                    case '-': return 3;
                    case '*': return 4;
                    case '/': return 4;
                    case '^': return 5;
                    default: return 6;
                }
            }//Метод возвращает приоритет оператора

            bool IsOperator(char с)
            {
                if (("+-/*^()".IndexOf(с) != -1))
                {
                    return true;
                }
                return false;
            }//Метод возвращает true, если проверяемый символ - разделитель ("пробел" или "равно")

            bool IsDelimeter(char c)
            {
                if ((" =".IndexOf(c) != -1))
                {
                    return true;
                }
                return false;
            }//Метод возвращает true, если проверяемый символ - разделитель ("пробел" или "равно")

            GetExpression();
            Counting();
            labelNumber.Text = "";
        }

        private void Answer_TextChanged(object sender, EventArgs e)
        {
            Answer.SelectionStart = Answer.Text.Length;
            Answer.ScrollToCaret();
        }
    }
}
