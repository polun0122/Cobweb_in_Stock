namespace Cobweb_in_Stock
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbStockNumber = new System.Windows.Forms.TextBox();
            this.tbStockName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxOpStrategy = new System.Windows.Forms.GroupBox();
            this.nbSellInterval = new System.Windows.Forms.NumericUpDown();
            this.nbExpectAmount = new System.Windows.Forms.NumericUpDown();
            this.nbBuyInterval = new System.Windows.Forms.NumericUpDown();
            this.tbStrategyDetail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.groupBoxReserveInfo = new System.Windows.Forms.GroupBox();
            this.nbReserveCost = new System.Windows.Forms.NumericUpDown();
            this.nbReserveAmount = new System.Windows.Forms.NumericUpDown();
            this.nbReserveUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.dateReserveDealDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nbMaxInvestMoney = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.groupBoxOpStrategy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbSellInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbExpectAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbBuyInterval)).BeginInit();
            this.groupBoxReserveInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbReserveCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbReserveAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbReserveUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbMaxInvestMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(27, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "股票代碼";
            // 
            // tbStockNumber
            // 
            this.tbStockNumber.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbStockNumber.Location = new System.Drawing.Point(30, 58);
            this.tbStockNumber.MaxLength = 10;
            this.tbStockNumber.Name = "tbStockNumber";
            this.tbStockNumber.Size = new System.Drawing.Size(83, 27);
            this.tbStockNumber.TabIndex = 3;
            this.tbStockNumber.Text = "00675L";
            // 
            // tbStockName
            // 
            this.tbStockName.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbStockName.Location = new System.Drawing.Point(136, 58);
            this.tbStockName.Name = "tbStockName";
            this.tbStockName.Size = new System.Drawing.Size(155, 27);
            this.tbStockName.TabIndex = 4;
            this.tbStockName.Text = "富邦台灣加權正2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(133, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "股票名稱";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(317, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "預計投入金額";
            // 
            // groupBoxOpStrategy
            // 
            this.groupBoxOpStrategy.Controls.Add(this.nbSellInterval);
            this.groupBoxOpStrategy.Controls.Add(this.nbExpectAmount);
            this.groupBoxOpStrategy.Controls.Add(this.nbBuyInterval);
            this.groupBoxOpStrategy.Controls.Add(this.tbStrategyDetail);
            this.groupBoxOpStrategy.Controls.Add(this.label7);
            this.groupBoxOpStrategy.Controls.Add(this.label6);
            this.groupBoxOpStrategy.Controls.Add(this.label5);
            this.groupBoxOpStrategy.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxOpStrategy.Location = new System.Drawing.Point(30, 100);
            this.groupBoxOpStrategy.Name = "groupBoxOpStrategy";
            this.groupBoxOpStrategy.Size = new System.Drawing.Size(546, 129);
            this.groupBoxOpStrategy.TabIndex = 12;
            this.groupBoxOpStrategy.TabStop = false;
            this.groupBoxOpStrategy.Text = "操作策略";
            // 
            // nbSellInterval
            // 
            this.nbSellInterval.DecimalPlaces = 2;
            this.nbSellInterval.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nbSellInterval.Location = new System.Drawing.Point(256, 35);
            this.nbSellInterval.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nbSellInterval.Name = "nbSellInterval";
            this.nbSellInterval.Size = new System.Drawing.Size(70, 27);
            this.nbSellInterval.TabIndex = 8;
            this.nbSellInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nbSellInterval.ValueChanged += new System.EventHandler(this.updateStrategy);
            // 
            // nbExpectAmount
            // 
            this.nbExpectAmount.Location = new System.Drawing.Point(463, 35);
            this.nbExpectAmount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nbExpectAmount.Name = "nbExpectAmount";
            this.nbExpectAmount.Size = new System.Drawing.Size(70, 27);
            this.nbExpectAmount.TabIndex = 9;
            this.nbExpectAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nbExpectAmount.ValueChanged += new System.EventHandler(this.updateStrategy);
            // 
            // nbBuyInterval
            // 
            this.nbBuyInterval.DecimalPlaces = 2;
            this.nbBuyInterval.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nbBuyInterval.Location = new System.Drawing.Point(91, 35);
            this.nbBuyInterval.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nbBuyInterval.Name = "nbBuyInterval";
            this.nbBuyInterval.Size = new System.Drawing.Size(70, 27);
            this.nbBuyInterval.TabIndex = 7;
            this.nbBuyInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nbBuyInterval.ValueChanged += new System.EventHandler(this.updateStrategy);
            // 
            // tbStrategyDetail
            // 
            this.tbStrategyDetail.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbStrategyDetail.Location = new System.Drawing.Point(17, 82);
            this.tbStrategyDetail.MaxLength = 10;
            this.tbStrategyDetail.Name = "tbStrategyDetail";
            this.tbStrategyDetail.ReadOnly = true;
            this.tbStrategyDetail.Size = new System.Drawing.Size(516, 27);
            this.tbStrategyDetail.TabIndex = 11;
            this.tbStrategyDetail.TabStop = false;
            this.tbStrategyDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(354, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "單次操作股數";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(179, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "賣出區間";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(14, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "買入區間";
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSend.Location = new System.Drawing.Point(473, 360);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(103, 32);
            this.buttonSend.TabIndex = 20;
            this.buttonSend.Text = "存檔";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // groupBoxReserveInfo
            // 
            this.groupBoxReserveInfo.Controls.Add(this.nbReserveCost);
            this.groupBoxReserveInfo.Controls.Add(this.nbReserveAmount);
            this.groupBoxReserveInfo.Controls.Add(this.nbReserveUnitPrice);
            this.groupBoxReserveInfo.Controls.Add(this.label10);
            this.groupBoxReserveInfo.Controls.Add(this.dateReserveDealDate);
            this.groupBoxReserveInfo.Controls.Add(this.label1);
            this.groupBoxReserveInfo.Controls.Add(this.label8);
            this.groupBoxReserveInfo.Controls.Add(this.label9);
            this.groupBoxReserveInfo.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxReserveInfo.Location = new System.Drawing.Point(30, 235);
            this.groupBoxReserveInfo.Name = "groupBoxReserveInfo";
            this.groupBoxReserveInfo.Size = new System.Drawing.Size(546, 119);
            this.groupBoxReserveInfo.TabIndex = 13;
            this.groupBoxReserveInfo.TabStop = false;
            this.groupBoxReserveInfo.Text = "庫存資訊";
            // 
            // nbReserveCost
            // 
            this.nbReserveCost.Location = new System.Drawing.Point(266, 75);
            this.nbReserveCost.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nbReserveCost.Name = "nbReserveCost";
            this.nbReserveCost.Size = new System.Drawing.Size(90, 27);
            this.nbReserveCost.TabIndex = 15;
            this.nbReserveCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nbReserveCost.ThousandsSeparator = true;
            // 
            // nbReserveAmount
            // 
            this.nbReserveAmount.Location = new System.Drawing.Point(150, 75);
            this.nbReserveAmount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nbReserveAmount.Name = "nbReserveAmount";
            this.nbReserveAmount.Size = new System.Drawing.Size(90, 27);
            this.nbReserveAmount.TabIndex = 14;
            this.nbReserveAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nbReserveAmount.ValueChanged += new System.EventHandler(this.updateReserveCost);
            // 
            // nbReserveUnitPrice
            // 
            this.nbReserveUnitPrice.DecimalPlaces = 2;
            this.nbReserveUnitPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nbReserveUnitPrice.Location = new System.Drawing.Point(27, 75);
            this.nbReserveUnitPrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nbReserveUnitPrice.Name = "nbReserveUnitPrice";
            this.nbReserveUnitPrice.Size = new System.Drawing.Size(90, 27);
            this.nbReserveUnitPrice.TabIndex = 13;
            this.nbReserveUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nbReserveUnitPrice.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nbReserveUnitPrice.ValueChanged += new System.EventHandler(this.updateReserveCost);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(386, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "成交日期";
            // 
            // dateReserveDealDate
            // 
            this.dateReserveDealDate.CalendarFont = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateReserveDealDate.CustomFormat = "yyyy/MM/dd";
            this.dateReserveDealDate.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateReserveDealDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateReserveDealDate.Location = new System.Drawing.Point(389, 75);
            this.dateReserveDealDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateReserveDealDate.Name = "dateReserveDealDate";
            this.dateReserveDealDate.Size = new System.Drawing.Size(116, 27);
            this.dateReserveDealDate.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(263, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "庫存總成本";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(147, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "買入股數";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(24, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "買入單價";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(470, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "蛛網上限單價";
            // 
            // nbMaxInvestMoney
            // 
            this.nbMaxInvestMoney.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nbMaxInvestMoney.Location = new System.Drawing.Point(320, 58);
            this.nbMaxInvestMoney.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nbMaxInvestMoney.Name = "nbMaxInvestMoney";
            this.nbMaxInvestMoney.Size = new System.Drawing.Size(103, 27);
            this.nbMaxInvestMoney.TabIndex = 5;
            this.nbMaxInvestMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nbMaxInvestMoney.ThousandsSeparator = true;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numericUpDown5.Location = new System.Drawing.Point(473, 58);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(103, 27);
            this.numericUpDown5.TabIndex = 6;
            this.numericUpDown5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 409);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.nbMaxInvestMoney);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBoxReserveInfo);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.groupBoxOpStrategy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbStockName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbStockNumber);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "新增股票Excel檔";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.groupBoxOpStrategy.ResumeLayout(false);
            this.groupBoxOpStrategy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbSellInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbExpectAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbBuyInterval)).EndInit();
            this.groupBoxReserveInfo.ResumeLayout(false);
            this.groupBoxReserveInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbReserveCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbReserveAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbReserveUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbMaxInvestMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbStockNumber;
        private System.Windows.Forms.TextBox tbStockName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxOpStrategy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbStrategyDetail;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.GroupBox groupBoxReserveInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateReserveDealDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nbReserveCost;
        private System.Windows.Forms.NumericUpDown nbReserveAmount;
        private System.Windows.Forms.NumericUpDown nbReserveUnitPrice;
        private System.Windows.Forms.NumericUpDown nbBuyInterval;
        private System.Windows.Forms.NumericUpDown nbSellInterval;
        private System.Windows.Forms.NumericUpDown nbExpectAmount;
        private System.Windows.Forms.NumericUpDown nbMaxInvestMoney;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
    }
}