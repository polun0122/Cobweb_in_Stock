using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobweb_in_Stock
{
    internal class Stock
    {
        /* 固定的變數 */
        string name;
        int number;
        string execelName; // 檔案名稱
        float price_ub; // 蛛網設定之股價上限
        float price_lb; // 蛛網設定之股價下限
        float buyInterval; // 買進區間
        float soldInterval; // 售出區間
        float unitAmount; // 預期每次操作股數

        double feeRate = 0.001425 * 0.6;//手續費率
        double taxRate = 0.003; //證交稅率

        /* 浮動的變數 */
        float nextBuyPrice; // 下一次買進價格
        float nextSellPrice; // 下一次買進價格
        float dealAmount; // 成交股數
        float dealUnitPrice; // 成交單價
        float dealPrice; // 成交總價
        float fee; //手續費
        float tax; //證交稅

        public Stock(string name, float price_ub, float price_lb, float buyInterval, float soldInterval)
        {
            this.name = name;
            this.price_ub = price_ub;
            this.price_lb = price_lb;
            this.buyInterval = buyInterval;
            this.soldInterval = soldInterval;
            this.nextBuyPrice = (price_lb + price_ub) / 2;
            this.nextSellPrice = (price_lb + price_ub) / 2;
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

        public int updateTransactionPrice(string mode, float unitPrice, int amount)
        {
            this.dealUnitPrice = unitPrice;
            this.dealAmount = amount;
            if (dealUnitPrice == 0 || dealAmount == 0)
                return 0;

            //手續費
            fee = (float)(dealUnitPrice * dealAmount * feeRate);
            if (fee < 1)
                fee = 1;

            //證交稅
            if (mode == "買進")
            {
                tax = 0;
                this.dealPrice = dealUnitPrice * dealAmount + (int)fee + (int)tax;
            }
            else
            {
                tax = (float)(dealUnitPrice * dealAmount * taxRate);
                if (tax < 1)
                    tax = 1;
                this.dealPrice = dealUnitPrice * dealAmount - (int)fee - (int)tax;
            }

            return 1;
        }
    }
}
