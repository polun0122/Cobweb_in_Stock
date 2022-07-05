
namespace 台達蛛網視窗輸入程式
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonFileSelect = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boxTargetUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.boxUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.boxAmount = new System.Windows.Forms.NumericUpDown();
            this.boxTotalPrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFileStatus = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxObtainedProfit = new System.Windows.Forms.TextBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTax = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxFee = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxLastUpdate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.boxTargetUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxTotalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFileSelect
            // 
            this.buttonFileSelect.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonFileSelect.Location = new System.Drawing.Point(36, 26);
            this.buttonFileSelect.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFileSelect.Name = "buttonFileSelect";
            this.buttonFileSelect.Size = new System.Drawing.Size(137, 75);
            this.buttonFileSelect.TabIndex = 0;
            this.buttonFileSelect.Text = "選擇檔案";
            this.buttonFileSelect.UseVisualStyleBackColor = true;
            this.buttonFileSelect.Click += new System.EventHandler(this.buttonFileSelect_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxFilePath.Location = new System.Drawing.Point(300, 26);
            this.textBoxFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ReadOnly = true;
            this.textBoxFilePath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxFilePath.Size = new System.Drawing.Size(399, 31);
            this.textBoxFilePath.TabIndex = 1;
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Items.AddRange(new object[] {
            "買進",
            "賣出"});
            this.comboBoxMode.Location = new System.Drawing.Point(36, 168);
            this.comboBoxMode.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(136, 28);
            this.comboBoxMode.TabIndex = 2;
            this.comboBoxMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxMode_SelectedIndexChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(545, 304);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(153, 31);
            this.dateTimePicker.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(32, 260);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "目標單價";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(201, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "成交單價";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(372, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "數量 (股)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(541, 260);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "成交日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(372, 364);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "交易金額";
            // 
            // boxTargetUnitPrice
            // 
            this.boxTargetUnitPrice.DecimalPlaces = 2;
            this.boxTargetUnitPrice.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxTargetUnitPrice.Increment = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            this.boxTargetUnitPrice.Location = new System.Drawing.Point(36, 304);
            this.boxTargetUnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.boxTargetUnitPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.boxTargetUnitPrice.Name = "boxTargetUnitPrice";
            this.boxTargetUnitPrice.Size = new System.Drawing.Size(133, 31);
            this.boxTargetUnitPrice.TabIndex = 9;
            this.boxTargetUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.boxTargetUnitPrice.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.boxTargetUnitPrice.ValueChanged += new System.EventHandler(this.boxTargetUnitPrice_ValueChanged);
            // 
            // boxUnitPrice
            // 
            this.boxUnitPrice.DecimalPlaces = 2;
            this.boxUnitPrice.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxUnitPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.boxUnitPrice.Location = new System.Drawing.Point(205, 304);
            this.boxUnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.boxUnitPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.boxUnitPrice.Name = "boxUnitPrice";
            this.boxUnitPrice.Size = new System.Drawing.Size(133, 31);
            this.boxUnitPrice.TabIndex = 10;
            this.boxUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.boxUnitPrice.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.boxUnitPrice.ValueChanged += new System.EventHandler(this.boxUnitPrice_ValueChanged);
            // 
            // boxAmount
            // 
            this.boxAmount.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxAmount.Location = new System.Drawing.Point(376, 304);
            this.boxAmount.Margin = new System.Windows.Forms.Padding(4);
            this.boxAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.boxAmount.Name = "boxAmount";
            this.boxAmount.Size = new System.Drawing.Size(133, 31);
            this.boxAmount.TabIndex = 11;
            this.boxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.boxAmount.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.boxAmount.ValueChanged += new System.EventHandler(this.boxAmount_ValueChanged);
            // 
            // boxTotalPrice
            // 
            this.boxTotalPrice.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxTotalPrice.Location = new System.Drawing.Point(376, 404);
            this.boxTotalPrice.Margin = new System.Windows.Forms.Padding(4);
            this.boxTotalPrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.boxTotalPrice.Name = "boxTotalPrice";
            this.boxTotalPrice.Size = new System.Drawing.Size(133, 31);
            this.boxTotalPrice.TabIndex = 12;
            this.boxTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.boxTotalPrice.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(196, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "檔案路徑";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(196, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "檔案狀態";
            // 
            // textBoxFileStatus
            // 
            this.textBoxFileStatus.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxFileStatus.Location = new System.Drawing.Point(300, 68);
            this.textBoxFileStatus.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFileStatus.Name = "textBoxFileStatus";
            this.textBoxFileStatus.ReadOnly = true;
            this.textBoxFileStatus.Size = new System.Drawing.Size(399, 31);
            this.textBoxFileStatus.TabIndex = 14;
            this.textBoxFileStatus.Text = "未載入";
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSend.Location = new System.Drawing.Point(545, 389);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(155, 49);
            this.buttonSend.TabIndex = 16;
            this.buttonSend.Text = "送出";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(372, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "已實現獲利";
            // 
            // textBoxObtainedProfit
            // 
            this.textBoxObtainedProfit.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxObtainedProfit.Location = new System.Drawing.Point(376, 181);
            this.textBoxObtainedProfit.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxObtainedProfit.Name = "textBoxObtainedProfit";
            this.textBoxObtainedProfit.ReadOnly = true;
            this.textBoxObtainedProfit.Size = new System.Drawing.Size(132, 31);
            this.textBoxObtainedProfit.TabIndex = 19;
            this.textBoxObtainedProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxStock
            // 
            this.textBoxStock.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxStock.Location = new System.Drawing.Point(545, 181);
            this.textBoxStock.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.ReadOnly = true;
            this.textBoxStock.Size = new System.Drawing.Size(132, 31);
            this.textBoxStock.TabIndex = 21;
            this.textBoxStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(541, 141);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "庫存股數";
            // 
            // textBoxTax
            // 
            this.textBoxTax.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxTax.Location = new System.Drawing.Point(205, 404);
            this.textBoxTax.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTax.Name = "textBoxTax";
            this.textBoxTax.ReadOnly = true;
            this.textBoxTax.Size = new System.Drawing.Size(132, 31);
            this.textBoxTax.TabIndex = 25;
            this.textBoxTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(201, 364);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "交易稅";
            // 
            // textBoxFee
            // 
            this.textBoxFee.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxFee.Location = new System.Drawing.Point(36, 404);
            this.textBoxFee.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFee.Name = "textBoxFee";
            this.textBoxFee.ReadOnly = true;
            this.textBoxFee.Size = new System.Drawing.Size(132, 31);
            this.textBoxFee.TabIndex = 23;
            this.textBoxFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(32, 364);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "手續費";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(717, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 458);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxLastUpdate
            // 
            this.textBoxLastUpdate.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxLastUpdate.Location = new System.Drawing.Point(205, 181);
            this.textBoxLastUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLastUpdate.Name = "textBoxLastUpdate";
            this.textBoxLastUpdate.ReadOnly = true;
            this.textBoxLastUpdate.Size = new System.Drawing.Size(132, 31);
            this.textBoxLastUpdate.TabIndex = 28;
            this.textBoxLastUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(201, 141);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "最後更新日";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 481);
            this.Controls.Add(this.textBoxLastUpdate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxTax);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxFee);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxObtainedProfit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxFileStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.boxTotalPrice);
            this.Controls.Add(this.boxAmount);
            this.Controls.Add(this.boxUnitPrice);
            this.Controls.Add(this.boxTargetUnitPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.comboBoxMode);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.buttonFileSelect);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.boxTargetUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxTotalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFileSelect;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown boxTargetUnitPrice;
        private System.Windows.Forms.NumericUpDown boxUnitPrice;
        private System.Windows.Forms.NumericUpDown boxAmount;
        private System.Windows.Forms.NumericUpDown boxTotalPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFileStatus;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxObtainedProfit;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxTax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxFee;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxLastUpdate;
        private System.Windows.Forms.Label label12;
    }
}

