using System;
using System.Globalization;
using SimplCommerce.Module.Core.Services;

namespace SimplCommerce.Tests
{
    public class FakeCurrencyService : ICurrencyService
    {
        public CultureInfo CurrencyCulture => new CultureInfo(1);

        public string FormatCurrency(decimal value)
        {
            return $"${value.ToString()}";
        }
    }
}
