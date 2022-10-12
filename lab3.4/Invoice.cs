using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab34
{
    internal class Invoice
    {
        private int account;
        private string customer;
        private string provider;
        private string article;
        private int quantity;
        private double PDW = 0.17;
        public Invoice(int account, string customer, string provider)
        {
            this.customer = customer;
            this.provider = provider;
            this.account = account;

        }
        public double CalculateValueOrder()
        {
            int pdw = 0;
            Console.Write("Для розрахунку суми без ПДВ натисність 0, \nДля розрахунку суми з ПДВ натисніть 1: \n");
            pdw = Convert.ToInt32(Console.ReadLine());
            switch (pdw)
            {
                case 0:
                    return account;
                case 1:
                    return account * PDW + account;
            }
            return 0;
        }
    }
}

