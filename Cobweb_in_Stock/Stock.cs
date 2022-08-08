using System.Text.RegularExpressions;

namespace Cobweb_in_Stock
{
    class Stock
    {
        //public class BasicData
        //{
            /* 固定的變數 */
            string name;
            string number; // 股票代碼
            string execelName; // 檔案名稱
            float price_ub; // 蛛網設定之股價上限
            float price_lb; // 蛛網設定之股價下限
            float buyInterval; // 買進區間
            float sellInterval; // 售出區間
            float expectAmount; // 預期每次操作股數

            double feeRate = 0.001425 * 0.6;//手續費率
            double taxRate; //證交稅率
            int minFee = 1; // 最低手續費
            int minTax = 1; // 最低證交稅

        //    public BasicData()
        //    {

        //    }
        //}

        /* 浮動的變數 */
        float nextBuyPrice; // 下一次買進價格
        float nextSellPrice; // 下一次買進價格
        float dealAmount; // 成交股數
        float dealUnitPrice; // 成交單價
        float dealPrice; // 成交總價
        float fee; //手續費
        float tax; //證交稅

        public Stock(string name, string number, float buyInterval, float sellInterval, float expectAmount, float price_ub, float price_lb)
        {
            this.name = name;
            this.number = number;
            this.price_ub = price_ub;
            this.price_lb = price_lb;
            this.buyInterval = buyInterval;
            this.sellInterval = sellInterval;
            this.expectAmount = expectAmount;

            /* 設定稅率 */
            taxRate = this.isSpecialStock() ? 0.001 : 0.003;
        }

        public void SetBasicData(/*BasicData basicData*/)
        {
            //this.name = name;
            //this.number = number;
            //this.price_ub = price_ub;
            //this.price_lb = price_lb;
            //this.buyInterval = buyInterval;
            //this.sellInterval = sellInterval;
            //this.expectAmount = expectAmount;
            //this.nextBuyPrice = (price_lb + price_ub) / 2;
            //this.nextSellPrice = (price_lb + price_ub) / 2;

        }

        public void setNextPrice(float nextBuyPrice, float nextSellPrice)
        {
            this.nextBuyPrice = nextBuyPrice;
            this.nextSellPrice = nextSellPrice;
        }

        public float getNextBuyPrice() { return this.nextBuyPrice; }

        public float getNextSellPrice() { return this.nextSellPrice; }

        public float getFee() { return fee; }

        public float getTax() { return tax; }

        public float getDealPrice() { return dealPrice; }

        public float getBuyInterval() { return buyInterval; }
        
        public float getSellInterval() { return sellInterval; }

        public bool isSpecialStock()
        {
            Regex rx = new Regex("[A-Z]$");
            return rx.IsMatch(number);
        }

        public int updateTransactionPrice(string mode, float dealUnitPrice, int dealAmount)
        {
            /* return code:
             * 0: Error
             * 1: Succeed
             * 2: Alarm, amount unequal to expected amount
             * 3: Alarm, bought price higher than target price
             * 4: Alarm, Sold price lower than target price
             */
            this.dealUnitPrice = dealUnitPrice;
            this.dealAmount = dealAmount;

            //手續費
            fee = (float)(this.dealUnitPrice * this.dealAmount * feeRate);
            if (fee < minFee)
                fee = minFee;

            //證交稅
            if (mode == "買進")
            {
                tax = 0;
                this.dealPrice = (int)(this.dealUnitPrice * this.dealAmount + (int)fee + (int)tax);
                if (this.dealUnitPrice > nextBuyPrice)
                    return 3;
            }
            else
            {
                tax = (float)(this.dealUnitPrice * this.dealAmount * taxRate);
                if (tax < minTax)
                    tax = minTax;
                this.dealPrice = (int)(this.dealUnitPrice * this.dealAmount - (int)fee - (int)tax);
                if (this.dealUnitPrice < nextSellPrice)
                    return 4;
            }

            if (this.dealAmount != expectAmount)
                return 2;
            return 1;
        }
    }
}
