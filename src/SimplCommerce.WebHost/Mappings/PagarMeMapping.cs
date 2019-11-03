using System;
using System.Linq;
using AutoMapper;
using PagarMe;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Entities.Payments;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Module.Orders.Area.Models.Orders;
using StormyCommerce.Module.PagarMe.Area.PagarMe.ViewModels;
using Document = StormyCommerce.Module.PagarMe.Area.PagarMe.ViewModels.Document;

namespace StormyCommerce.WebHost.Mappings
{
    public class PagarMeMapping : Profile
    {
        public PagarMeMapping()
        {
            this.ItemMap();                                                                                                                    
            this.TransactionMap();
            this.CustomerMap();
        }
        public void ItemMap()
        {
            CreateMap<Item, PagarMeItem>();                            
            CreateMap<OrderItemDto, Item>();      
            CreateMap<Item, OrderItemDto>();
            CreateMap<OrderItemDto, Item>();                
            CreateMap<PagarMeItem, OrderItem>()
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => Price.GetPriceFromCents("R$", src.UnitPrice)))
                .ForPath(dest => dest.Product.ProductName, opt => opt.MapFrom(src => src.Title));                                
        }
        public void TransactionMap()
        {
            CreateMap<TransactionVm, Transaction>()
                .ForMember(tr => tr.Billing, opt => opt.MapFrom(src => src.Billing))
                .ForMember(tr => tr.Address, opt => opt.MapFrom(src => src.Address))
                .ForMember(tr => tr.Customer, opt => opt.MapFrom(src => src.Customer))
                .ForMember(tr => tr.Item, opt => opt.MapFrom(src => src.Items))                
                .ForMember(tr => tr.Shipping, opt => opt.MapFrom(src => src.Shipping));
            CreateMap<TransactionVm,Payment>()
                .ForMember(dest => dest.Amount,opt => opt.MapFrom(src => src.Amount))
                .ForMember(dest => dest.CreatedOn,opt => opt.MapFrom(src => src.DateCreated))
                .ForMember(dest => dest.GatewayTransactionId,opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.PaymentFee,opt => opt.MapFrom(src => src.Cost))
                .ForMember(dest => dest.PaymentMethod,opt => opt.MapFrom(src => src.PaymentMethod.ToString()))
                .ForMember(dest => dest.FailureMessage,opt => opt.MapFrom(src => src.Status));                
                //TODO:Need better way to map this                
            
            CreateMap<TransactionVm,StormyOrder>()
                .ForMember(p => p.TotalPrice,opt => opt.MapFrom(src => (src.Amount / 100)))                
                .ForPath(p => p.Shipment.DestinationAddress,opt => opt.MapFrom(src => src.Shipping.Address))
                .ForPath(p => p.Shipment.ShipmentMethod,opt => opt.MapFrom(src => src.Shipping.Name))
                .ForPath(p => p.Shipment.DeliveryCost,opt => opt.MapFrom(src => Convert.ToDecimal(src.Shipping.Fee)))
                .ForPath(p => p.Shipment.DeliveryDate,opt => opt.MapFrom(src => Convert.ToDateTime(src.Shipping.DeliveryDate)))                
                .ForPath(p => p.Payment.PaymentMethod,opt => opt.MapFrom(src => src.PaymentMethod))                                
                .ForPath(p => p.Payment.PaymentFee,opt => opt.MapFrom(src => src.Cost))
                .ForPath(p => p.Payment.Amount,opt => opt.MapFrom(src => src.Amount));  
            CreateMap<BoletoCheckoutRequest,TransactionVm>()
                .ForMember(p => p.Amount,opt => opt.MapFrom(src => src.Amount))
                .ForMember(p => p.PaymentMethod,opt => opt.MapFrom(src => src.PaymentMethod));                
                // .ForMember(p => p.Customer,opt => opt.MapFrom(src => src.));                                                              
        }
        public void CustomerMap()
        {
            
            CreateMap<CustomerDto,PagarMeCustomerVm>()
                .ForMember(dest => dest.Name,opt => opt.MapFrom(src => src.FullName))
                .ForMember(dest => dest.Email,opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Billing,opt => opt.MapFrom(src => src.DefaultBillingAddress))
                .ForMember(dest => dest.Shipping,opt => opt.MapFrom(src => src.DefaultShippingAddress))
                .ForMember(dest => dest.Country,opt => opt.MapFrom(src => src.FullName))
                .AfterMap((dto,vm) => {
                    vm.PhoneNumbers.Add(dto.PhoneNumber); 
                    vm.Documents.Add( new Document{
                        Type = "cpf",
                        Number = dto.CPF                        
                        });
                    });
            CreateMap<StormyCustomer, PagarMeCustomerVm>()
                .ForMember(dest => dest.ExternalId,opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.Name,opt => opt.MapFrom(src => src.FullName))
                .ForMember(dest => dest.Email,opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Billing,opt => opt.MapFrom(src => src.DefaultBillingAddress))
                .ForMember(dest => dest.Shipping,opt => opt.MapFrom(src => src.DefaultShippingAddress))
                .ForMember(dest => dest.Country,opt => opt.MapFrom(src => src.FullName))                
                .AfterMap((dto,vm) => {
                    vm.PhoneNumbers.Add(dto.PhoneNumber); 
                    vm.Documents.Add( new Document{
                        Type = "cpf",
                        Number = dto.CPF                        
                        });
                    });                
            CreateMap<PagarMeCustomerVm, StormyCustomer>()
                .ForMember(p => p.DefaultBillingAddress,opt => opt.MapFrom(src => src.Billing))
                .ForMember(p => p.DefaultShippingAddress,opt => opt.MapFrom(src => src.Shipping))
                .ForMember(p => p.UserId,opt => opt.MapFrom(src => src.ExternalId))
                .ForMember(p => p.FullName,opt => opt.MapFrom(src => src.Name))
                .ForMember(p => p.PhoneNumber,opt => opt.MapFrom(src => src.PhoneNumbers.Count > 0 ? src.PhoneNumbers.First() : ""));
            CreateMap<BillingVm,Address>()
                .ForPath(dest => dest.Zipcode,opt => opt.MapFrom(src => src.Address.PostalCode))
                .ForPath(dest => dest.StreetNumber,opt => opt.MapFrom(src => src.Address.Number))
                .ForPath(dest => dest.Neighborhood,opt => opt.MapFrom(src => src.Address.District));
            CreateMap<BillingVm, Billing>();
            CreateMap<Billing, BillingVm>()
                .ForMember(dest => dest.Address,opt => opt.MapFrom(src => src.Address));
        }
    }
}
