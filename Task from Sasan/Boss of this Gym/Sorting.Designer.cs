namespace Boss_of_this_Gym
{
    partial class Sorting
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sorting));
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPrintInFail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RichTextBoxJournal = new System.Windows.Forms.RichTextBox();
            this.buttonGreateMassiv = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.RichTextBoxTime = new System.Windows.Forms.RichTextBox();
            this.buttonTree = new System.Windows.Forms.Button();
            this.buttonSelection = new System.Windows.Forms.Button();
            this.buttonInsertion = new System.Windows.Forms.Button();
            this.buttonShaker = new System.Windows.Forms.Button();
            this.buttonBubble = new System.Windows.Forms.Button();
            this.buttonComp = new System.Windows.Forms.Button();
            this.buttonSmooth = new System.Windows.Forms.Button();
            this.buttonHeap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.zMain = new ZedGraph.ZedGraphControl();
            this.buttonBuild = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Виды сортировок";
            // 
            // buttonPrintInFail
            // 
            this.buttonPrintInFail.Location = new System.Drawing.Point(8, 341);
            this.buttonPrintInFail.Name = "buttonPrintInFail";
            this.buttonPrintInFail.Size = new System.Drawing.Size(133, 76);
            this.buttonPrintInFail.TabIndex = 25;
            this.buttonPrintInFail.Text = "Запись в файл";
            this.buttonPrintInFail.UseVisualStyleBackColor = true;
            this.buttonPrintInFail.Click += new System.EventHandler(this.buttonPrintInFail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Журнал";
            // 
            // RichTextBoxJournal
            // 
            this.RichTextBoxJournal.Enabled = false;
            this.RichTextBoxJournal.Location = new System.Drawing.Point(8, 54);
            this.RichTextBoxJournal.Name = "RichTextBoxJournal";
            this.RichTextBoxJournal.ReadOnly = true;
            this.RichTextBoxJournal.Size = new System.Drawing.Size(299, 126);
            this.RichTextBoxJournal.TabIndex = 23;
            this.RichTextBoxJournal.Text = "";
            // 
            // buttonGreateMassiv
            // 
            this.buttonGreateMassiv.Location = new System.Drawing.Point(8, 8);
            this.buttonGreateMassiv.Name = "buttonGreateMassiv";
            this.buttonGreateMassiv.Size = new System.Drawing.Size(133, 27);
            this.buttonGreateMassiv.TabIndex = 22;
            this.buttonGreateMassiv.Text = "Сгенерировать массив";
            this.buttonGreateMassiv.UseVisualStyleBackColor = true;
            this.buttonGreateMassiv.Click += new System.EventHandler(this.buttonGreateMassiv_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(161, 325);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(46, 13);
            this.label.TabIndex = 21;
            this.label.Text = "Таймер";
            // 
            // RichTextBoxTime
            // 
            this.RichTextBoxTime.Enabled = false;
            this.RichTextBoxTime.Location = new System.Drawing.Point(147, 341);
            this.RichTextBoxTime.Name = "RichTextBoxTime";
            this.RichTextBoxTime.ReadOnly = true;
            this.RichTextBoxTime.Size = new System.Drawing.Size(160, 76);
            this.RichTextBoxTime.TabIndex = 20;
            this.RichTextBoxTime.Text = "";
            // 
            // buttonTree
            // 
            this.buttonTree.Location = new System.Drawing.Point(164, 293);
            this.buttonTree.Name = "buttonTree";
            this.buttonTree.Size = new System.Drawing.Size(143, 27);
            this.buttonTree.TabIndex = 19;
            this.buttonTree.Text = "Деревом";
            this.buttonTree.UseVisualStyleBackColor = true;
            this.buttonTree.Click += new System.EventHandler(this.buttonTree_Click);
            // 
            // buttonSelection
            // 
            this.buttonSelection.Location = new System.Drawing.Point(12, 293);
            this.buttonSelection.Name = "buttonSelection";
            this.buttonSelection.Size = new System.Drawing.Size(143, 27);
            this.buttonSelection.TabIndex = 18;
            this.buttonSelection.Text = "Выбором";
            this.buttonSelection.UseVisualStyleBackColor = true;
            this.buttonSelection.Click += new System.EventHandler(this.buttonSelection_Click);
            // 
            // buttonInsertion
            // 
            this.buttonInsertion.Location = new System.Drawing.Point(12, 260);
            this.buttonInsertion.Name = "buttonInsertion";
            this.buttonInsertion.Size = new System.Drawing.Size(143, 27);
            this.buttonInsertion.TabIndex = 17;
            this.buttonInsertion.Text = "Вставкой";
            this.buttonInsertion.UseVisualStyleBackColor = true;
            this.buttonInsertion.Click += new System.EventHandler(this.buttonInsertion_Click);
            // 
            // buttonShaker
            // 
            this.buttonShaker.Location = new System.Drawing.Point(11, 227);
            this.buttonShaker.Name = "buttonShaker";
            this.buttonShaker.Size = new System.Drawing.Size(143, 27);
            this.buttonShaker.TabIndex = 16;
            this.buttonShaker.Text = "Шейкер";
            this.buttonShaker.UseVisualStyleBackColor = true;
            this.buttonShaker.Click += new System.EventHandler(this.buttonShaker_Click);
            // 
            // buttonBubble
            // 
            this.buttonBubble.Location = new System.Drawing.Point(12, 197);
            this.buttonBubble.Name = "buttonBubble";
            this.buttonBubble.Size = new System.Drawing.Size(143, 24);
            this.buttonBubble.TabIndex = 15;
            this.buttonBubble.Text = "Пузырёк";
            this.buttonBubble.UseVisualStyleBackColor = true;
            this.buttonBubble.Click += new System.EventHandler(this.buttonBubble_Click);
            // 
            // buttonComp
            // 
            this.buttonComp.Location = new System.Drawing.Point(164, 196);
            this.buttonComp.Name = "buttonComp";
            this.buttonComp.Size = new System.Drawing.Size(143, 27);
            this.buttonComp.TabIndex = 27;
            this.buttonComp.Text = "Расчёской";
            this.buttonComp.UseVisualStyleBackColor = true;
            this.buttonComp.Click += new System.EventHandler(this.buttonComp_Click);
            // 
            // buttonSmooth
            // 
            this.buttonSmooth.Location = new System.Drawing.Point(164, 227);
            this.buttonSmooth.Name = "buttonSmooth";
            this.buttonSmooth.Size = new System.Drawing.Size(143, 27);
            this.buttonSmooth.TabIndex = 28;
            this.buttonSmooth.Text = "Плавная";
            this.buttonSmooth.UseVisualStyleBackColor = true;
            this.buttonSmooth.Click += new System.EventHandler(this.buttonSmooth_Click);
            // 
            // buttonHeap
            // 
            this.buttonHeap.Location = new System.Drawing.Point(164, 260);
            this.buttonHeap.Name = "buttonHeap";
            this.buttonHeap.Size = new System.Drawing.Size(143, 27);
            this.buttonHeap.TabIndex = 29;
            this.buttonHeap.Text = "Пирамидальная";
            this.buttonHeap.UseVisualStyleBackColor = true;
            this.buttonHeap.Click += new System.EventHandler(this.buttonHeap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(917, 430);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // zMain
            // 
            this.zMain.Location = new System.Drawing.Point(313, 8);
            this.zMain.Name = "zMain";
            this.zMain.ScrollGrace = 0D;
            this.zMain.ScrollMaxX = 0D;
            this.zMain.ScrollMaxY = 0D;
            this.zMain.ScrollMaxY2 = 0D;
            this.zMain.ScrollMinX = 0D;
            this.zMain.ScrollMinY = 0D;
            this.zMain.ScrollMinY2 = 0D;
            this.zMain.Size = new System.Drawing.Size(588, 409);
            this.zMain.TabIndex = 31;
            this.zMain.UseExtendedPrintDialog = true;
            // 
            // buttonBuild
            // 
            this.buttonBuild.Location = new System.Drawing.Point(313, 393);
            this.buttonBuild.Name = "buttonBuild";
            this.buttonBuild.Size = new System.Drawing.Size(143, 24);
            this.buttonBuild.TabIndex = 32;
            this.buttonBuild.Text = "Посторить график";
            this.buttonBuild.UseVisualStyleBackColor = true;
            this.buttonBuild.Click += new System.EventHandler(this.buttonBuild_Click);
            // 
            // Sorting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 429);
            this.Controls.Add(this.buttonBuild);
            this.Controls.Add(this.zMain);
            this.Controls.Add(this.buttonHeap);
            this.Controls.Add(this.buttonSmooth);
            this.Controls.Add(this.buttonComp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPrintInFail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RichTextBoxJournal);
            this.Controls.Add(this.buttonGreateMassiv);
            this.Controls.Add(this.label);
            this.Controls.Add(this.RichTextBoxTime);
            this.Controls.Add(this.buttonTree);
            this.Controls.Add(this.buttonSelection);
            this.Controls.Add(this.buttonInsertion);
            this.Controls.Add(this.buttonShaker);
            this.Controls.Add(this.buttonBubble);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Sorting";
            this.Text = "Sorting";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPrintInFail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RichTextBoxJournal;
        private System.Windows.Forms.Button buttonGreateMassiv;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.RichTextBox RichTextBoxTime;
        private System.Windows.Forms.Button buttonTree;
        private System.Windows.Forms.Button buttonSelection;
        private System.Windows.Forms.Button buttonInsertion;
        private System.Windows.Forms.Button buttonShaker;
        private System.Windows.Forms.Button buttonBubble;
        private System.Windows.Forms.Button buttonComp;
        private System.Windows.Forms.Button buttonSmooth;
        private System.Windows.Forms.Button buttonHeap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ZedGraph.ZedGraphControl zMain;
        private System.Windows.Forms.Button buttonBuild;
    }
}