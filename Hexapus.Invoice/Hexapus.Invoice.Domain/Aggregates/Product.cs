using System;
using System.Collections.Generic;
using System.Text;

namespace Hexapus.Invoice.Domain.Aggregates
{
    public class Product
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Note { get; }
        public long SalePrice { get; }
        public Currency Currency { get; }
        public MeasurementUnit Unit { get; }

        public Product(string name, string note, long salePrice, Currency currency, MeasurementUnit unit)
        {
            Name = name;
            Note = note;
            SalePrice = salePrice;
            Currency = currency;
            Unit = unit;
        }
    }
}
