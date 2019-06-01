using System.Threading.Tasks;
using System;
using RazorLight;
using StormyCommerce.Infraestructure.Helpers;
using StormyCommerce.Infraestructure.Models;
using StormyCommerce.Infraestructure.Extensions;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Infraestructure.Templates;

namespace StormyCommerce.Infraestructure.Services
{
    public static class TemplateGenerator 
    {                       
        //public static string CreateConfirmationEmail(string username,string link)
        //{            
        //    var template = RenderTemplate("ConfirmAccount.cshtml",new ConfirmationEmailModel{
        //        Username = username,
        //        Link = link
        //    });
        //    return template;
        //}        
        //private static string RenderTemplate<TViewModel>(string filename,TViewModel viewModel)
        //{
        //    const string BASE_PATH = "../Templates/";
        //    RazorParser engine = new RazorParser(typeof(WitthoeftStore).Assembly);                        
        //    return engine.UsingTemplateFromEmbedded(BASE_PATH + filename,viewModel);
        //}
    }
}
