using AutoMapper;
using PagarMe;
using StormyCommerce.Core.Entities.Customer;
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
                //.ForMember(tr => tr.Payables,opt => opt.MapFrom(src => src.Payables);
                //.ForMember(tr => tr.Phone,opt => opt.MapFrom(src => src.Phone))
                .ForMember(tr => tr.Shipping, opt => opt.MapFrom(src => src.Shipping));
            CreateMap<BillingVm, Billing>();
            CreateMap<Billing, BillingVm>();
            CreateMap<StormyCustomer, PagarMeCustomerVm>();
            CreateMap<PagarMeCustomerVm, StormyCustomer>();
            //CreateMap<StormyCustomer,PagarMe.Customer>
            CreateMap<Item, PagarMeItem>();
            CreateMap<OrderItemDto, Item>();

            CreateMap<Transaction, PaymentDto>();
            CreateMap<Item, OrderItemDto>();
            CreateMap<OrderItemDto, Item>();
        }
    }
}
