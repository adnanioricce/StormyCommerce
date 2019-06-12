using System;
namespace StormyCommerce.Api.Framework.Controllers
{

	[ApiController]
	public class BaseApiController : BaseController 
	{
		public object ReturnToAction(string actionName)
		{
			throw new NotImplementedException();
		}

	}
}
