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
using StormyCommerce.Core.Models.Order;
using StormyCommerce.Core.Models.Payment.Request;
using StormyCommerce.Module.Orders.Area.Models.Orders;

namespace StormyCommerce.WebHost.Mappings
{
    public class PagarMeProfile : Profile
    {
        public PagarMeProfile()
        {
            this.ItemMap();                                                                                                                    
            this.TransactionMap();
            this.CustomerMap();
        }
        public void ItemMap()
        {                                    
            CreateMap<OrderItemDto, Item>();      
            CreateMap<Item, OrderItemDto>();
            CreateMap<OrderItemDto, Item>();                                      
        }
        public void TransactionMap()
        {           
            CreateMap<Transaction,Payment>()
                .ForMember(dest => dest.Amount,opt => opt.MapFrom(src => src.Amount))
                .ForMember(dest => dest.CreatedOn,opt => opt.MapFrom(src => src.DateCreated))
                .ForMember(dest => dest.GatewayTransactionId,opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.PaymentFee,opt => opt.MapFrom(src => src.Cost))
                .ForMember(dest => dest.PaymentMethod,opt => opt.MapFrom(src => src.PaymentMethod.ToString()))
                .ForMember(dest => dest.FailureMessage,opt => opt.MapFrom(src => src.Status));
            //TODO:Need better way to map this                
            CreateMap<SimpleBoletoCheckoutRequest, Transaction>()
                .ForMember(dest => dest.Amount,opt => opt.MapFrom(src => (int)(src.Amount * 100)));                
            CreateMap<BoletoCheckoutRequest, Transaction>();
            CreateMap<Transaction, StormyOrder>()
                .ForMember(p => p.TotalPrice,opt => opt.MapFrom(src => (src.Amount / 100)))                
                .ForPath(p => p.Shipment.DestinationAddress,opt => opt.MapFrom(src => src.Shipping.Address))
                .ForPath(p => p.Shipment.ShipmentMethod,opt => opt.MapFrom(src => src.Shipping.Name))
                .ForPath(p => p.Shipment.DeliveryCost,opt => opt.MapFrom(src => Convert.ToDecimal(src.Shipping.Fee)))
                .ForPath(p => p.Shipment.DeliveryDate,opt => opt.MapFrom(src => Convert.ToDateTime(src.Shipping.DeliveryDate)))                
                .ForPath(p => p.Payment.PaymentMethod,opt => opt.MapFrom(src => src.PaymentMethod))                                
                .ForPath(p => p.Payment.PaymentFee,opt => opt.MapFrom(src => src.Cost))
                .ForPath(p => p.Payment.Amount,opt => opt.MapFrom(src => src.Amount));  
            CreateMap<BoletoCheckoutRequest, Transaction>()
                .ForMember(p => p.Amount,opt => opt.MapFrom(src => src.Amount))
                .ForMember(p => p.PaymentMethod,opt => opt.MapFrom(src => src.PaymentMethod));                            
        }
        public void CustomerMap()
        {

            CreateMap<CustomerDto, Customer>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FullName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.FullName));
            CreateMap<Core.Entities.Common.Address, Address>()
                .ForMember(dest => dest.Complementary,opt => opt.MapFrom(src => src.Complement))
                .ForMember(dest => dest.Neighborhood,opt => opt.MapFrom(src => src.District))
                .ForMember(dest => dest.StreetNumber,opt => opt.MapFrom(src => src.Number))
                .ForMember(dest => dest.Zipcode,opt => opt.MapFrom(src => src.PostalCode));
            CreateMap<StormyCustomer, Billing>()            
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FullName))                                
                .ForPath(dest => dest.Address, opt => opt.MapFrom(src => src.DefaultBillingAddress))
                .AfterMap((src,dest) => {
                    dest.Id = null;
                });
            CreateMap<StormyCustomer, Customer>()
                .ForMember(dest => dest.ExternalId,opt => opt.MapFrom(src => src.Id))    
                .ForMember(dest => dest.Id,opt => opt.Ignore())    
                // .ForMember(dest => dest.Address,opt => opt.Ignore())
                // .ForMember(dest => dest.Addresses,opt => opt.i)        
                // .ForMember(dest => dest.DocumentNumber,opt => opt.MapFrom(src => src.CPF))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FullName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))                
                // .ForMember(dest => dest.BornAt,opt => opt.MapFrom(src => src.DateOfBirth))
                .ForMember(dest => dest.Birthday,opt => opt.MapFrom(src => src.DateOfBirth.Value.ToString("yyyy-MM-dd")))                            
                .ForPath(dest => dest.Address,opt => opt.MapFrom(src => src.DefaultBillingAddress))                
                .AfterMap((src,dest) => {
                    dest.PhoneNumbers = new string[]
                    {
                        src.PhoneNumber
                    };
                    dest.Documents = new Document[]
                    {
                        new Document
                        {
                            Type = DocumentType.Cpf,
                            Number = src.CPF
                        }
                    };
                    dest.Addresses = new Address[]{
                        dest.Address
                    };                      
                    dest.Type = CustomerType.Individual; 
                    dest.Country = "br";
                    
                });

            CreateMap<Customer, StormyCustomer>()
                .ForMember(p => p.DefaultBillingAddress, opt => opt.MapFrom(src => src.Address))
                .ForMember(p => p.DefaultShippingAddress, opt => opt.MapFrom(src => src.Address))
                .ForMember(p => p.Id, opt => opt.MapFrom(src => src.ExternalId))
                .ForMember(p => p.FullName, opt => opt.MapFrom(src => src.Name));                
            CreateMap<Core.Entities.Common.Address,Address>()
                .ForMember(dest => dest.Complementary,opt => opt.MapFrom(src => src.Complement))
                .ForMember(dest => dest.Zipcode,opt => opt.MapFrom(src => src.PostalCode))
                .ForMember(dest => dest.Neighborhood,opt => opt.MapFrom(src => src.District))
                .ForMember(dest => dest.StreetNumber,opt => opt.MapFrom(src => src.Number));
            CreateMap<Core.Entities.Common.Address,Shipping>()                
                .ForPath(dest => dest.Address.Complementary,opt => opt.MapFrom(src => src.Complement))
                .ForPath(dest => dest.Address.Zipcode,opt => opt.MapFrom(src => src.PostalCode))
                .ForPath(dest => dest.Address.Neighborhood,opt => opt.MapFrom(src => src.District))
                .ForPath(dest => dest.Address.StreetNumber,opt => opt.MapFrom(src => src.Number))
                .ForPath(dest => dest.Address.Street,opt => opt.MapFrom(src => src.Street))
                .ForPath(dest => dest.Address.Country,opt => opt.MapFrom(src => src.Country))
                .ForPath(dest => dest.Address.City,opt => opt.MapFrom(src => src.City))
                .ForPath(dest => dest.Address.State,opt => opt.MapFrom(src => src.State));                
            CreateMap<CustomerAddress,Address>()                                       
                .ForPath(dest => dest.Complementary,opt => opt.MapFrom(src => src.Complement))                
                .ForPath(dest => dest.Zipcode,opt => opt.MapFrom(src => src.PostalCode))
                .ForPath(dest => dest.Neighborhood,opt => opt.MapFrom(src => src.District))
                .ForPath(dest => dest.StreetNumber,opt => opt.MapFrom(src => src.Number))
                .ForPath(dest => dest.Street,opt => opt.MapFrom(src => src.Street))
                .ForPath(dest => dest.Country,opt => opt.MapFrom(src => src.Country))
                .ForPath(dest => dest.City,opt => opt.MapFrom(src => src.City))
                .ForPath(dest => dest.State,opt => opt.MapFrom(src => src.State));                
            CreateMap<CustomerAddress,Shipping>()                
                .ForPath(dest => dest.Address.Id,opt => opt.MapFrom(src => src.Id))
                .ForPath(dest => dest.Address.Complementary,opt => opt.MapFrom(src => src.Complement))
                .ForPath(dest => dest.Address.Zipcode,opt => opt.MapFrom(src => src.PostalCode))
                .ForPath(dest => dest.Address.Neighborhood,opt => opt.MapFrom(src => src.District))
                .ForPath(dest => dest.Address.StreetNumber,opt => opt.MapFrom(src => src.Number))
                .ForPath(dest => dest.Address.Street,opt => opt.MapFrom(src => src.Street))
                .ForPath(dest => dest.Address.Country,opt => opt.MapFrom(src => src.Country))
                .ForPath(dest => dest.Address.City,opt => opt.MapFrom(src => src.City))
                .ForPath(dest => dest.Address.State,opt => opt.MapFrom(src => src.State));
            
        }
    }
}
