using System;
public class Invoice
{
    private readonly int account;
    private readonly string customer;
    private readonly string provider;

    private string article;
    private int quantity;

    private double percantage = 20.0;

    public Invoice(int account, string customer, string provider, string article, int quantity)
    {
        this.account = account;
        this.customer = customer;
        this.provider = provider;
        this.article = article;
        this.quantity = quantity; 
    }

    public double PriceWithoutVAT()
    {
        double sum = (double)account * quantity;
        return sum;
    }
    public double VAT()
    {
        double vat = (double)account * quantity * (percantage/100);
        return vat;
    }

    public double PriceWithVAT()
    {
        VAT();
        double sum = VAT() + (double)account * quantity;
        return sum;
    }

    public void Print()
    {
        Console.WriteLine($"Price without VAT = {PriceWithoutVAT()}");
        Console.WriteLine($"Price with VAT = {PriceWithVAT()}");
    }
}
