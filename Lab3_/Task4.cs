using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Invoice 
    {
    public Invoice(int account, string customer, string provider)
    {
        this.account = account;
        this.customer = customer;
        this.provider = provider;
    }
    private int account;
    private string customer;
    private string provider;
    private string article;
    private int quantity; 
    public string Article
    {
        get { return article; }
        set { article = value; }
    }
    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

    public void calc(int account)
    {
        double grossprice;
        double netprice;
        account *= quantity;
        grossprice = account;
        netprice = account * 0.8;
        Console.WriteLine($"Gross price is: {grossprice}");
        Console.WriteLine($"Net price is: {netprice}");
    }
    }

