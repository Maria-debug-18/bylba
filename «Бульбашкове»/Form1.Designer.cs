namespace _Бульбашкове_
{
    partial class frmBubbleSort
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btGenerate = new System.Windows.Forms.Button();
            this.dgvMass = new System.Windows.Forms.DataGridView();
            this.txtArray = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btBubbleSort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBubbleSort = new System.Windows.Forms.TextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btGenerate);
            this.groupBox1.Controls.Add(this.dgvMass);
            this.groupBox1.Controls.Add(this.txtArray);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(123, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Генерація масиву";
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(145, 189);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(276, 41);
            this.btGenerate.TabIndex = 5;
            this.btGenerate.Text = "Згенерувати порожній масив";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.TextChanged += new System.EventHandler(this.btGenerate_Click);
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // dgvMass
            // 
            this.dgvMass.AllowUserToOrderColumns = true;
            this.dgvMass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMass.Location = new System.Drawing.Point(162, 21);
            this.dgvMass.Name = "dgvMass";
            this.dgvMass.RowHeadersWidth = 51;
            this.dgvMass.RowTemplate.Height = 24;
            this.dgvMass.Size = new System.Drawing.Size(419, 150);
            this.dgvMass.TabIndex = 0;
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(52, 105);
            this.txtArray.Name = "txtArray";
            this.txtArray.Size = new System.Drawing.Size(100, 22);
            this.txtArray.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введіть кількість \r\nелементів:\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btBubbleSort);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtBubbleSort);
            this.groupBox2.Location = new System.Drawing.Point(123, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 107);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "«Бульбашкова» сортування";
            // 
            // btBubbleSort
            // 
            this.btBubbleSort.Location = new System.Drawing.Point(15, 38);
            this.btBubbleSort.Name = "btBubbleSort";
            this.btBubbleSort.Size = new System.Drawing.Size(111, 42);
            this.btBubbleSort.TabIndex = 6;
            this.btBubbleSort.Text = "Сортувати";
            this.btBubbleSort.UseVisualStyleBackColor = true;
            this.btBubbleSort.TextChanged += new System.EventHandler(this.btBubbleSort_Click);
            this.btBubbleSort.Click += new System.EventHandler(this.btBubbleSort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Масив після сортування:";
            // 
            // txtBubbleSort
            // 
            this.txtBubbleSort.Location = new System.Drawing.Point(145, 48);
            this.txtBubbleSort.Name = "txtBubbleSort";
            this.txtBubbleSort.Size = new System.Drawing.Size(276, 22);
            this.txtBubbleSort.TabIndex = 5;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(285, 390);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(129, 48);
            this.btExit.TabIndex = 7;
            this.btExit.Text = "Вихід";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // frmBubbleSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBubbleSort";
            this.Text = "Сортування «бульбашкою»";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.DataGridView dgvMass;
        private System.Windows.Forms.TextBox txtArray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btBubbleSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBubbleSort;
        private System.Windows.Forms.Button btExit;
    }
}

