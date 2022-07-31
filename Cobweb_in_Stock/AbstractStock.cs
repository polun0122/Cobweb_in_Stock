namespace Cobweb_in_Stock
{
    abstract class AbstractStock
    {
        abstract public object stockName { get; set; }
        abstract public object stockNumber { get; set; }
        abstract public object buyInterval { get; set; }
        abstract public object sellInterval { get; set; }
        abstract public object targetPrice { get; set; }
        abstract public object buyUnitPrice { get; set; }
        abstract public object buyAmount { get; set; }
        abstract public object buyDate { get; set; }
        abstract public object buyTotalPrice { get; set; }
    }
}
