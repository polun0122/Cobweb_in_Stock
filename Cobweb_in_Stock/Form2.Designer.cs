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
            this.tbMaxInvestMoney = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbStrategyDetail = new System.Windows.Forms.TextBox();
            this.tbExpectAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSellInterval = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBuyInterval = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(27, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "股票代碼";
            // 
            // tbStockNumber
            // 
            this.tbStockNumber.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbStockNumber.Location = new System.Drawing.Point(113, 41);
            this.tbStockNumber.MaxLength = 10;
            this.tbStockNumber.Name = "tbStockNumber";
            this.tbStockNumber.Size = new System.Drawing.Size(83, 27);
            this.tbStockNumber.TabIndex = 3;
            this.tbStockNumber.Text = "00675L";
            // 
            // tbStockName
            // 
            this.tbStockName.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbStockName.Location = new System.Drawing.Point(296, 41);
            this.tbStockName.Name = "tbStockName";
            this.tbStockName.Size = new System.Drawing.Size(155, 27);
            this.tbStockName.TabIndex = 4;
            this.tbStockName.Text = "富邦台灣加權正2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(213, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "股票名稱";
            // 
            // tbMaxInvestMoney
            // 
            this.tbMaxInvestMoney.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbMaxInvestMoney.Location = new System.Drawing.Point(588, 41);
            this.tbMaxInvestMoney.MaxLength = 10;
            this.tbMaxInvestMoney.Name = "tbMaxInvestMoney";
            this.tbMaxInvestMoney.Size = new System.Drawing.Size(103, 27);
            this.tbMaxInvestMoney.TabIndex = 5;
            this.tbMaxInvestMoney.Text = "60000";
            this.tbMaxInvestMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(469, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "預計投入金額";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbStrategyDetail);
            this.groupBox1.Controls.Add(this.tbExpectAmount);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbSellInterval);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbBuyInterval);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(30, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 148);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作策略";
            // 
            // tbStrategyDetail
            // 
            this.tbStrategyDetail.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbStrategyDetail.Location = new System.Drawing.Point(27, 92);
            this.tbStrategyDetail.MaxLength = 10;
            this.tbStrategyDetail.Name = "tbStrategyDetail";
            this.tbStrategyDetail.ReadOnly = true;
            this.tbStrategyDetail.Size = new System.Drawing.Size(604, 27);
            this.tbStrategyDetail.TabIndex = 11;
            this.tbStrategyDetail.TabStop = false;
            this.tbStrategyDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbExpectAmount
            // 
            this.tbExpectAmount.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbExpectAmount.Location = new System.Drawing.Point(541, 36);
            this.tbExpectAmount.MaxLength = 10;
            this.tbExpectAmount.Name = "tbExpectAmount";
            this.tbExpectAmount.Size = new System.Drawing.Size(90, 27);
            this.tbExpectAmount.TabIndex = 10;
            this.tbExpectAmount.Text = "100";
            this.tbExpectAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbExpectAmount.TextChanged += new System.EventHandler(this.updateStrategy);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(427, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "單次操作股數";
            // 
            // tbSellInterval
            // 
            this.tbSellInterval.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbSellInterval.Location = new System.Drawing.Point(313, 36);
            this.tbSellInterval.MaxLength = 10;
            this.tbSellInterval.Name = "tbSellInterval";
            this.tbSellInterval.Size = new System.Drawing.Size(90, 27);
            this.tbSellInterval.TabIndex = 8;
            this.tbSellInterval.Text = "1";
            this.tbSellInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSellInterval.TextChanged += new System.EventHandler(this.updateStrategy);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(227, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "賣出區間";
            // 
            // tbBuyInterval
            // 
            this.tbBuyInterval.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbBuyInterval.Location = new System.Drawing.Point(110, 36);
            this.tbBuyInterval.MaxLength = 10;
            this.tbBuyInterval.Name = "tbBuyInterval";
            this.tbBuyInterval.Size = new System.Drawing.Size(90, 27);
            this.tbBuyInterval.TabIndex = 6;
            this.tbBuyInterval.Text = "0.5";
            this.tbBuyInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbBuyInterval.TextChanged += new System.EventHandler(this.updateStrategy);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(24, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "買入區間";
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSend.Location = new System.Drawing.Point(588, 245);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(103, 40);
            this.buttonSend.TabIndex = 13;
            this.buttonSend.Text = "存檔";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 309);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbMaxInvestMoney);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbStockName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbStockNumber);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "新增股票Excel檔";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbStockNumber;
        private System.Windows.Forms.TextBox tbStockName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMaxInvestMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbExpectAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSellInterval;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbBuyInterval;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbStrategyDetail;
        private System.Windows.Forms.Button buttonSend;
    }
}