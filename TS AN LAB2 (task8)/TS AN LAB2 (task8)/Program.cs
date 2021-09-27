using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS_AN_LAB2__task8_
{
    public class Invoice
    {
       
        public readonly int Account;
        public readonly string Customer;
        public readonly string Provider;

        
        private string _article = String.Empty;
        private int _quantity;

        public string Article
        {
            get => _article;
            set => _article = value;
        }

        public int Quantity
        {
            get => _quantity;
            set => _quantity = value;
        }

        public Invoice(int account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }

        public Invoice(int account, string customer, string provider, string article, int quantity) : this(account, customer, provider)
        {
            _article = article;
            _quantity = quantity;
        }

        public double GetAccountWithNds(double nds = 0.5)
        {
            return Account + (Account * nds);
        }

        public void Show()
        {
            Console.WriteLine($" {Customer} закав у {Provider} {_quantity} {_article} і виставив рахунок," +
                $"\n який буде складати {Account} без Ндс, і {GetAccountWithNds()} з Ндс");
        }
    }

    class starter
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(13550, "ООО Білі вітрила", "ООО Чорний лебідь")
            {
                Quantity = 20,
                Article = "столів"
            };
            invoice.GetAccountWithNds();
            invoice.Show();
        }
    }
}
