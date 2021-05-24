using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using ZedGraph;

namespace Boss_of_this_Gym
{
    public partial class Sorting : Form
    {
        GraphPane paneMain;

        PointPairList Bubble_list = new PointPairList();
        PointPairList Shaker_list = new PointPairList();
        PointPairList Comb_list = new PointPairList();
        PointPairList Insertion_list = new PointPairList();
        PointPairList Selection_list = new PointPairList();
        PointPairList Tree_list = new PointPairList();
        PointPairList Heap_list = new PointPairList();
        PointPairList Smooth_list = new PointPairList();

        public Sorting()
        {
            InitializeComponent();
            paneMain = zMain.GraphPane;
            paneMain.XAxis.Title.Text = "Количество эллементов";
            paneMain.YAxis.Title.Text = "Время в секундах";
            paneMain.Title.Text = "Рассчет эффективности";
        }

        Sartirovki Gachi = new Sartirovki();

        int[] Van;//самый начальный массив рандомных элементов
        int[] WorkArray;//дополнительный уже отсортированный массив

        string writePath = @"Answer.txt";

        private void buttonGreateMassiv_Click(object sender, EventArgs e)
        {
            Van = Gachi.Zapolnitel();
            WorkArray = Van;
            MessageBox.Show("Массив сгенерен!!!");
            RichTextBoxJournal.Text = "Размер массива:" + Van.Length;
        }//генерация массива рандомного размера с рандомными значениями от -10000 до 10000

        private void buttonBubble_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Gachi.Bubble_sort(WorkArray);

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = Convert.ToString(ts.TotalSeconds);
            double time = Convert.ToDouble(elapsedTime);
            Bubble_list.Add(WorkArray.Length, time);

            TimeSpan ts2 = stopWatch.Elapsed;
            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);//Формат времени секндомера
            RichTextBoxTime.Text = "чч.мм.сс.мс\n" + elapsedTime;
        }//сортировка пузырём

        private void buttonShaker_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Gachi.Shaker_sort(WorkArray);

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = Convert.ToString(ts.TotalSeconds);
            double time = Convert.ToDouble(elapsedTime);
            Shaker_list.Add(WorkArray.Length, time);

            TimeSpan ts2 = stopWatch.Elapsed;
            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);//Формат времени секндомера
            RichTextBoxTime.Text = "чч.мм.сс.мс\n" + elapsedTime;
        }//шейкерная сортировка

        private void buttonInsertion_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Gachi.Insertion_sort(WorkArray);

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = Convert.ToString(ts.TotalSeconds);
            double time = Convert.ToDouble(elapsedTime);
            Insertion_list.Add(WorkArray.Length, time);

            TimeSpan ts2 = stopWatch.Elapsed;
            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);//Формат времени секндомера
            RichTextBoxTime.Text = "чч.мм.сс.мс\n" + elapsedTime;
        }//сортировка вставкой

        private void buttonSelection_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Gachi.Selection_sort(WorkArray);

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = Convert.ToString(ts.TotalSeconds);
            double time = Convert.ToDouble(elapsedTime);
            Selection_list.Add(WorkArray.Length, time);

            TimeSpan ts2 = stopWatch.Elapsed;
            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);//Формат времени секндомера
            RichTextBoxTime.Text = "чч.мм.сс.мс\n" + elapsedTime;
        }//сортировка выбором

        private void buttonComp_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Gachi.Comb_sort(WorkArray);

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = Convert.ToString(ts.TotalSeconds);
            double time = Convert.ToDouble(elapsedTime);
            Comb_list.Add(WorkArray.Length, time);

            TimeSpan ts2 = stopWatch.Elapsed;
            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);//Формат времени секндомера
            RichTextBoxTime.Text = "чч.мм.сс.мс\n" + elapsedTime;
        }//сортировка расчёсткой

        private void buttonSmooth_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            Sartirovki.SmoothSort smooth = new Sartirovki.SmoothSort();
            stopWatch.Start();

            smooth.sort(WorkArray);

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = Convert.ToString(ts.TotalSeconds);
            double time = Convert.ToDouble(elapsedTime);
            Smooth_list.Add(WorkArray.Length, time);

            TimeSpan ts2 = stopWatch.Elapsed;
            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);//Формат времени секндомера
            RichTextBoxTime.Text = "чч.мм.сс.мс\n" + elapsedTime;
        }//плавная сортировка

        private void buttonHeap_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            Sartirovki.HeapSort heap = new Sartirovki.HeapSort();
            stopWatch.Start();

            heap.sort(WorkArray);

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = Convert.ToString(ts.TotalSeconds);
            double time = Convert.ToDouble(elapsedTime);
            Heap_list.Add(WorkArray.Length, time);

            TimeSpan ts2 = stopWatch.Elapsed;
            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);//Формат времени секндомера
            RichTextBoxTime.Text = "чч.мм.сс.мс\n" + elapsedTime;
        }//пиромидальная сортировка

        private void buttonTree_Click(object sender, EventArgs e)
        {
            Sartirovki.TreeSort Tree = new Sartirovki.TreeSort();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            WorkArray = Tree.sort(ref WorkArray);

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = Convert.ToString(ts.TotalSeconds);
            double time = Convert.ToDouble(elapsedTime);
            Tree_list.Add(WorkArray.Length, time);

            TimeSpan ts2 = stopWatch.Elapsed;
            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);//Формат времени секндомера
            RichTextBoxTime.Text = "чч.мм.сс.мс\n" + elapsedTime;
        }//сортировка деревом

        private void buttonPrintInFail_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default);
            foreach (int item in WorkArray)//Печатаем в файл
            {
                sw.Write(item);
                sw.Write("\n");
            }
            sw.Close();
        }//запись в файл

        private void buttonBuild_Click(object sender, EventArgs e)
        {
            zMain.GraphPane.CurveList.Clear();

            LineItem Bubble_Curve = paneMain.AddCurve("Bubble", Bubble_list, Color.Blue, SymbolType.None);
            LineItem Shaker_Curve = paneMain.AddCurve("Shaker", Shaker_list, Color.Brown, SymbolType.None);
            LineItem Comb_Curve = paneMain.AddCurve("Comb", Comb_list, Color.Red, SymbolType.None);
            LineItem Insertion_Curve = paneMain.AddCurve("Insertion", Insertion_list, Color.Green, SymbolType.None);
            LineItem Selection_Curve = paneMain.AddCurve("Selection", Selection_list, Color.Gray, SymbolType.None);
            LineItem Tree_Curve = paneMain.AddCurve("Tree", Tree_list, Color.Black, SymbolType.None);
            LineItem Heap_Curve = paneMain.AddCurve("Heap", Heap_list, Color.Yellow, SymbolType.None);
            LineItem Smooth_Curve = paneMain.AddCurve("Smooth", Smooth_list, Color.Magenta, SymbolType.None);

            zMain.AxisChange();
            zMain.Invalidate();
        }//построение графика
    }
}