using Microsoft.AspNetCore.Mvc;
using SimplCommerce.Module.SampleData.Areas.SampleData.ViewModels;
using SimplCommerce.Module.SampleData.Services;
using System.Threading.Tasks;
using StormyCommerce.Infraestructure.Data;
using System.IO;

namespace SimplCommerce.Module.SampleData.Areas.SampleData.Controllers
{
    [Route("Dgml")]
    public class DgmlController : Controller
    {
        public StormyDbContext _context { get; }


        public DgmlController(StormyDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Creates a DGML class diagram of most of the entities in the project wher you go to localhost/dgml
        /// </summary>
        /// <returns>a DGML class diagram</returns>
        [HttpGet]
        public IActionResult Get()
        {

            //System.IO.File.WriteAllText(Directory.GetCurrentDirectory() + "\\Entities.dgml",
            //    _context.AsDgml(), // https://github.com/ErikEJ/SqlCeToolbox/wiki/EF-Core-Power-Tools
            //    System.Text.Encoding.UTF8);

            //var file = System.IO.File.OpenRead(Directory.GetCurrentDirectory() + "\\Entities.dgml");
            //var response = File(file, "application/octet-stream", "Entities.dgml");
            //return response;
            return NoContent();
        }
    }
}
