using System.Collections.Generic;
using SimplCommerce.Module.Correios.Models;

namespace SimplCommerce.Module.Correios.Interfaces
{
    public interface IPackageBuilder
    {
        Package BuildPackage(ICollection<PackageItem> items);        
        Package BoxItems(ICollection<PackageItem> items);
        // Package 
    }
}