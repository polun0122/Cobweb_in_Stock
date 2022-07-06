using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobweb_in_Stock
{
    internal class Stock
    {
        string name;
        int number;
        string execelName; // 檔案名稱
        float price_ub; // 蛛網設定之股價上限
        float price_lb; // 蛛網設定之股價下限
        float buyInterval; // 買進區間
        float soldInterval; // 售出區間
        float nextBuyPrice; // 下一次買進價格
        float nextSellPrice; // 下一次買進價格
        float unitQuantity; // 每次操作股數
    }
}
