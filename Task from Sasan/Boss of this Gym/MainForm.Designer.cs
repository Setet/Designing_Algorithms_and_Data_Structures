namespace Boss_of_this_Gym
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonSdeck = new System.Windows.Forms.Button();
            this.buttonOPN = new System.Windows.Forms.Button();
            this.buttonSortings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAutomat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSdeck
            // 
            this.buttonSdeck.Image = ((System.Drawing.Image)(resources.GetObject("buttonSdeck.Image")));
            this.buttonSdeck.Location = new System.Drawing.Point(12, 25);
            this.buttonSdeck.Name = "buttonSdeck";
            this.buttonSdeck.Size = new System.Drawing.Size(343, 135);
            this.buttonSdeck.TabIndex = 0;
            this.buttonSdeck.UseVisualStyleBackColor = true;
            this.buttonSdeck.Click += new System.EventHandler(this.buttonSdeck_Click);
            // 
            // buttonOPN
            // 
            this.buttonOPN.Image = ((System.Drawing.Image)(resources.GetObject("buttonOPN.Image")));
            this.buttonOPN.Location = new System.Drawing.Point(12, 179);
            this.buttonOPN.Name = "buttonOPN";
            this.buttonOPN.Size = new System.Drawing.Size(343, 135);
            this.buttonOPN.TabIndex = 1;
            this.buttonOPN.UseVisualStyleBackColor = true;
            this.buttonOPN.Click += new System.EventHandler(this.buttonOPN_Click);
            // 
            // buttonSortings
            // 
            this.buttonSortings.Image = ((System.Drawing.Image)(resources.GetObject("buttonSortings.Image")));
            this.buttonSortings.Location = new System.Drawing.Point(12, 333);
            this.buttonSortings.Name = "buttonSortings";
            this.buttonSortings.Size = new System.Drawing.Size(343, 135);
            this.buttonSortings.TabIndex = 2;
            this.buttonSortings.UseVisualStyleBackColor = true;
            this.buttonSortings.Click += new System.EventHandler(this.buttonSortings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(316, 625);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "v1.06";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(141, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "СортировОчки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(167, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ОПН";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(167, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Сдек";
            // 
            // buttonAutomat
            // 
            this.buttonAutomat.Image = ((System.Drawing.Image)(resources.GetObject("buttonAutomat.Image")));
            this.buttonAutomat.Location = new System.Drawing.Point(12, 487);
            this.buttonAutomat.Name = "buttonAutomat";
            this.buttonAutomat.Size = new System.Drawing.Size(343, 135);
            this.buttonAutomat.TabIndex = 7;
            this.buttonAutomat.UseVisualStyleBackColor = true;
            this.buttonAutomat.Click += new System.EventHandler(this.buttonAutomat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(141, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Автоботы";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 647);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAutomat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSortings);
            this.Controls.Add(this.buttonOPN);
            this.Controls.Add(this.buttonSdeck);
            this.Name = "MainForm";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSdeck;
        private System.Windows.Forms.Button buttonOPN;
        private System.Windows.Forms.Button buttonSortings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAutomat;
        private System.Windows.Forms.Label label5;
    }
}

