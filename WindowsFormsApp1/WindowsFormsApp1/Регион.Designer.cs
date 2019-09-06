namespace WindowsFormsApp1
{
    partial class Регион
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.bDDataSet = new WindowsFormsApp1.BDDataSet();
            this.gorodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gorodTableAdapter = new WindowsFormsApp1.BDDataSetTableAdapters.GorodTableAdapter();
            this.tyrTableAdapter = new WindowsFormsApp1.BDDataSetTableAdapters.TyrTableAdapter();
            this.gorodBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.fKTyrIDGorod35BCFE0ABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKTyrIDGorod35BCFE0ABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorodBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTyrIDGorod35BCFE0ABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTyrIDGorod35BCFE0ABindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(399, 143);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bDDataSet
            // 
            this.bDDataSet.DataSetName = "BDDataSet";
            this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gorodBindingSource
            // 
            this.gorodBindingSource.DataMember = "Gorod";
            this.gorodBindingSource.DataSource = this.bDDataSet;
            // 
            // gorodTableAdapter
            // 
            this.gorodTableAdapter.ClearBeforeFill = true;
            // 
            // tyrTableAdapter
            // 
            this.tyrTableAdapter.ClearBeforeFill = true;
            // 
            // gorodBindingSource1
            // 
            this.gorodBindingSource1.DataMember = "Gorod";
            this.gorodBindingSource1.DataSource = this.bDDataSet;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(93, 161);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Изменить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(174, 161);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // fKTyrIDGorod35BCFE0ABindingSource
            // 
            this.fKTyrIDGorod35BCFE0ABindingSource.DataMember = "FK__Tyr__ID_Gorod__35BCFE0A";
            this.fKTyrIDGorod35BCFE0ABindingSource.DataSource = this.gorodBindingSource;
            // 
            // fKTyrIDGorod35BCFE0ABindingSource1
            // 
            this.fKTyrIDGorod35BCFE0ABindingSource1.DataMember = "FK__Tyr__ID_Gorod__35BCFE0A";
            this.fKTyrIDGorod35BCFE0ABindingSource1.DataSource = this.gorodBindingSource;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номер";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Регион";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Регион
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 192);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Регион";
            this.Text = "Регион";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorodBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTyrIDGorod35BCFE0ABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTyrIDGorod35BCFE0ABindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource gorodBindingSource;
        private BDDataSetTableAdapters.GorodTableAdapter gorodTableAdapter;
        private System.Windows.Forms.BindingSource fKTyrIDGorod35BCFE0ABindingSource;
        private BDDataSetTableAdapters.TyrTableAdapter tyrTableAdapter;
        private System.Windows.Forms.BindingSource fKTyrIDGorod35BCFE0ABindingSource1;
        private System.Windows.Forms.BindingSource gorodBindingSource1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

