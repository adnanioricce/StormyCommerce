using FluentValidation;
using FluentValidation.Results;
using SimplCommerce.Infrastructure;
using SimplCommerce.Module.ShoppingCart.Models;

namespace StormyCommerce.Module.Orders.Validators.Carts
{
    public class CartToOrderValidator : BaseValidator<Cart>
    {        
        public CartToOrderValidator()
        {            
            RuleFor(c => c.Id)
                .NotNull()
                    .WithMessage(c => $"Cart with id {c.Id} cannot be found");
            RuleFor(c => c.LockedOnCheckout)
                .NotEqual(true)
                    .WithMessage("this cart is locked for checkout");
            RuleFor(c => c.Items)
                .NotEmpty()
                    .WithMessage("You can't build a order without items");
            RuleFor(c => c)
                .Must(c => c.CustomerId == c.CreatedById)
                    .WithMessage("The customer that created this cart and that is related are diferent");
            //If the product didn't has this Tracking flag, what I would be selling?                           
            RuleForEach(c => c.Items)
                .Must(i => i.Product != null)
                    .WithMessage("the product cannot be null");            
            RuleForEach(c => c.Items)                                                    
                .Must(i =>  i.Product.StockTrackingIsEnabled && !(i.Quantity > i.Product.StockQuantity))                                            
                    .WithMessage($"there's currently no enough stock of given product")
                .Must(i => i.Product.IsAllowToOrder || !i.Product.IsPublished || i.Product.IsDeleted)
                    .WithMessage((c, i) => $"product {i.ProductId} cannot be ordered");                
            RuleFor(c => c.LockedOnCheckout)
                .Equal(false)
                    .WithMessage("This cart is locked for Checkout");
            
        }                

    }
}
