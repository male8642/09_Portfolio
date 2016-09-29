using System;
using System.Collections.Generic;
using _09_Portfolio;

internal class Portfolio
{
    private List<IAsset> stocks;
   

    public Portfolio(List<IAsset> stocks)

    {
        this.stocks = stocks;
    }

    public Portfolio() : this(new List<IAsset>())
    {
    }

    public static double TotalValue(IAsset[] portfolio)
    {
        double total = 0;
        foreach (IAsset a in portfolio)
        {
            total = total + a.GetValue();
        }
        return total;
    }


    public double GetTotalValue()
    { 
        return Portfolio.TotalValue(stocks.ToArray());
    }

    internal void AddIAsset(IAsset stocks)
    {
        this.stocks.Add(stocks);
    }
}