using System;
using System.Linq;
using System.Collections.Generic;
using SimplCommerce.Infrastructure.Models;
namespace StormyCommerce.Module.Catalog.Models
{
    public class Price : ValueObject
    {        
        private readonly decimal _value = decimal.Zero;                
        public string Currency { get; }
        public string Value { get { return $"{Currency}{_value}"; } }        
        private Price(string currency,decimal value)
        {
            Currency = currency;               
            _value = value;         
        }                
        public static Price GetPriceFromCents(string currency,decimal value)
        {            
            return new Price(currency, value / 100);
        }
        public static Price GetPriceFromString(string price)
        {             
            var digits = String.Join("",price.Replace(",",".").SkipWhile(p => !char.IsDigit(p)));
            var value = Convert.ToDecimal(digits);
            var currency = price.Substring(0,2);
            return GetPriceFromCents(currency,value);                                    
        }
        public decimal GetPriceValueInDecimal()
        {
            return _value;
        }        
        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Currency;
            yield return Value;
        }
        
    }
}