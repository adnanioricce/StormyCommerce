using System;
using AutoMapper;
using PagarMe;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Entities.Order;
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
            CreateMap<BillingVm, Billing>();
            CreateMap<Billing, BillingVm>()
                .ForMember(dest => dest.Address,opt => opt.MapFrom(src => src.Address));            
            CreateMap<StormyCustomer, PagarMeCustomerVm>();
            CreateMap<PagarMeCustomerVm, StormyCustomer>();
                
            
            CreateMap<Item, PagarMeItem>();
            CreateMap<OrderItemDto, Item>();

            CreateMap<Transaction, PaymentDto>();
            CreateMap<TransactionVm,StormyOrder>()
                .ForMember(p => p.TotalPrice,opt => opt.MapFrom(src => (src.Amount / 100).ToString()))
                .ForMember(p => p.DeliveryCost,opt => opt.MapFrom(src => src.Shipping.Fee))
                .ForMember(p => p.DeliveryDate,opt => opt.MapFrom(src => Convert.ToDateTime(src.Shipping.DeliveryDate)))
                .ForMember(p => p.PaymentMethod,opt => opt.MapFrom(src => src.PaymentMethod))
                .ForMember(p => p.Customer,opt => opt.MapFrom(src => src.Customer))
                .ForMember(p => p.ShippingAddress,opt => opt.MapFrom(src => src.Shipping.Address));

            CreateMap<Item, OrderItemDto>();
            CreateMap<OrderItemDto, Item>();
            CreateMap<PagarMeItem,OrderItem>()
                .ForMember(p => p.Price,opt => opt.MapFrom(src => $"R${src.UnitPrice}"));                
                // .ForMember(p => p.Product,opt => opt.MapFrom(src => src.));
        }
    }
}
