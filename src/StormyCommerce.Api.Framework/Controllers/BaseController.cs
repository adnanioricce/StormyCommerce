using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Core.Interfaces.Infraestructure;
using StormyCommerce.Core.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StormyCommerce.Api.Framework.Controllers
{
    
    [ApiController]
    [Route("api/[controller]/[action]")]
    public abstract class BaseApiController : Controller 
	{
        private readonly DomainNotificationHandler notifications;
        private readonly IMediatorHandler mediator;
        public BaseApiController(INotificationHandler<DomainNotification> _notifications,IMediatorHandler _mediator)
        {
            notifications = (DomainNotificationHandler)_notifications;
            mediator = _mediator;
        }
        protected IEnumerable<DomainNotification> Notifications => notifications.GetNotifications();
        protected bool IsValidOperation()
        {
            return (!notifications.HasNotifications());
        }
        protected new IActionResult Response(object result = null)
        {
            if (IsValidOperation())
            {
                return Ok(new
                {
                    success = true,
                    data = result
                });                
            }
            return BadRequest(new
            {
                success = false,
                errors = notifications.GetNotifications().Select(f => f.Value)
            });
        }
        protected void NotifyModelStateErrors()
        {
            var errors = ModelState.Values.SelectMany(e => e.Errors);
            errors.ToList().ForEach(f =>
            {
                var errorMessage = f.Exception == null ? f.ErrorMessage : f.Exception.Message;
                NotifyError(String.Empty, errorMessage);
            });
        }

        private void NotifyError(string code, string message)
        {
            mediator.RaiseEvent(new DomainNotification(code, message));
        }
        protected void AddIdentityErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                NotifyError(result.ToString(), error.Description);
            }
        }        
	}
}
