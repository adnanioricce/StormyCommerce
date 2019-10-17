using System;
using AutoMapper;
using PagarMe;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Module.PagarMe.Area.PagarMe.ViewModels;

namespace StormyCommerce.Module.Mapping.Mappings
{
    public class PagarMeMapping : Profile
    {
        public PagarMeMapping()
        {            
            CreateMap<TransactionVm, Transaction>()
                .ForMember(tr => tr.Billing, opt => opt.MapFrom(src => src.Billing))
                .ForMember(tr => tr.Address, opt => opt.MapFrom(src => src.Address))
                .ForMember(tr => tr.Customer, opt => opt.MapFrom(src => src.Customer))
                .ForMember(tr => tr.Item, opt => opt.MapFrom(src => src.Items))                
                .ForMember(tr => tr.Shipping, opt => opt.MapFrom(src => src.Shipping));
            CreateMap<BillingVm,Address>()
                .ForPath(dest => dest.Zipcode,opt => opt.MapFrom(src => src.Address.PostalCode))
                .ForPath(dest => dest.StreetNumber,opt => opt.MapFrom(src => src.Address.Number))
                .ForPath(dest => dest.Neighborhood,opt => opt.MapFrom(src => src.Address.District));
            CreateMap<BillingVm, Billing>();
            CreateMap<Billing, BillingVm>()
                .ForMember(dest => dest.Address,opt => opt.MapFrom(src => src.Address));            
            CreateMap<StormyCustomer, PagarMeCustomerVm>()
                .ForMember(dest => dest.ExternalId,opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.Billing,opt => opt.MapFrom(src => src.DefaultBillingAddress));                
            CreateMap<PagarMeCustomerVm, StormyCustomer>();
                
            
            CreateMap<Item, PagarMeItem>();
            CreateMap<OrderItemDto, Item>();

            CreateMap<Transaction, PaymentDto>()
                .ForMember(src => src.Amount,opt => opt.MapFrom(src => src.Amount))
                .ForMember(src => src.CreatedOn,opt => opt.MapFrom(src => src.DateCreated))
                .ForMember(src => src.GatewayTransactionId,opt => opt.MapFrom(src => src.Id))
                .ForMember(src => src.PaymentFee,opt => opt.MapFrom(src => src.Id))
                .ForMember(src => src.PaymentMethod,opt => opt.MapFrom(src => src.PaymentMethod));
                //TODO:Need better way to map this
                //.ForMember(src => src.PaymentStatus,opt => opt.MapFrom(src => src.Status)                

            //CreateMap<PaymentDto, Transaction>();                
            CreateMap<TransactionVm,StormyOrder>()
                .ForMember(p => p.TotalPrice,opt => opt.MapFrom(src => (src.Amount / 100).ToString()))
                .ForMember(p => p.DeliveryCost,opt => opt.MapFrom(src => src.Shipping.Fee))
                .ForMember(p => p.DeliveryDate,opt => opt.MapFrom(src => Convert.ToDateTime(src.Shipping.DeliveryDate)))
                .ForMember(p => p.PaymentMethod,opt => opt.MapFrom(src => src.PaymentMethod))
                .ForMember(p => p.Customer,opt => opt.MapFrom(src => src.Customer))
                .ForMember(p => p.ShippingAddress,opt => opt.MapFrom(src => src.Shipping.Address))
                .ForMember(p => p.Items,opt => opt.MapFrom(src => src.Items))
                .ForMember(p => p.Customer,opt => opt.MapFrom(src => src.Customer));                

            CreateMap<Item, OrderItemDto>();
            CreateMap<OrderItemDto, Item>();                
            CreateMap<PagarMeItem, OrderItem>()
                .ForMember(p => p.Price, opt => opt.MapFrom(src => Price.GetPriceFromCents("R$", src.UnitPrice)))
                .ForMember(p => p.ProductName, opt => opt.MapFrom(src => src.Title));                                
        }
    }
}
