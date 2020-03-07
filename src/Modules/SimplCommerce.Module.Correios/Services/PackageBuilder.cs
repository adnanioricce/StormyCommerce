using System;
using System.Collections.Generic;
using System.Linq;
using SimplCommerce.Module.Correios.Interfaces;
using SimplCommerce.Module.Correios.Models;

namespace SimplCommerce.Module.Correios.Services
{
    public class PackageBuilder : IPackageBuilder
    {
        public Package BuildPackage(ICollection<PackageItem> items)
        {
            return Package.CreatePackage(BoxItems(items));            
        }
        
        public Package BoxItems(ICollection<PackageItem> items)
        {   
            var package = new Package();         
            foreach(var item in items){
                package.TotalHeight += item.Height.Value;
                package.TotalWidth += item.Width.Value;
                package.TotalLength += item.Length.Value;
                package.TotalWeight += item.UnitWeight.Value * item.Quantity;
                package.TotalArea += item.Height.Value * item.Width.Value * item.Length.Value * item.Quantity;
                package.Price += item.Price * item.Quantity;
            }   
            return package;            
        }        
    }
}