using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineOrdering
{
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(Customer customer)
        {
            _products = new List<Product>();
            _customer = customer;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public double CalculateTotalCost()
        {
            double total = _products.Sum(p => p.GetTotalCost());

         
            total += _customer.LiveInUsa() ? 5 : 35;

            return total;
        }

        public string GetPackingLabel()
        {
            string label = "Packing Label:\n";

            foreach (Product product in _products)
            {
                label += $"- {product.GetName()}\n";
            }

            return label;
        }

        public string GetShippingLabel()
        {
            string label = "Shipping Label:\n";
            label += _customer.GetName() + "\n";
            label += _customer.GetAddress().GetDisplayAddress();

            return label;
        }
    }
}