using System;
using System.Linq;
using AutoMapper;
using PagarMe;
using SimplCommerce.Module.Orders.Models;
using SimplCommerce.Module.Payments.Models;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Customer;


using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos;
 

 

using StormyCommerce.Core.Models.Shipment.Request;
using StormyCommerce.Module.Orders.Area.Models.Orders;

using StormyCommerce.Module.Orders.Models.Requests;

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
            CreateMap<CheckoutBoletoRequest, Transaction>()
                .ForMember(dest => dest.Amount,opt => opt.MapFrom(src => (int)(src.Amount * 100)));
            CreateMap<Transaction, Order>()
                .ForMember(p => p.OrderTotal, opt => opt.MapFrom(src => (src.Amount / 100)));                                
        }
        public void CustomerMap()
        {

            CreateMap<CustomerDto, Customer>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FullName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.FullName));
            CreateMap<Core.Entities.Common.AddressDetail, Address>()
                .ForMember(dest => dest.Complementary,opt => opt.MapFrom(src => src.Complement))
                .ForMember(dest => dest.Neighborhood,opt => opt.MapFrom(src => src.DistrictName))
                .ForMember(dest => dest.StreetNumber,opt => opt.MapFrom(src => src.Number))
                .ForMember(dest => dest.Zipcode,opt => opt.MapFrom(src => src.ZipCode));
            CreateMap<User, Billing>()            
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FullName))                                                
                .AfterMap((src,dest) => {
                    dest.Id = null;
                });
            CreateMap<User, Customer>()
                .ForMember(dest => dest.ExternalId,opt => opt.MapFrom(src => src.Id))    
                .ForMember(dest => dest.Id,opt => opt.Ignore())                    
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FullName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))                               
                .ForMember(dest => dest.Birthday,opt => opt.MapFrom(src => src.DateOfBirth.Value.ToString("yyyy-MM-dd")))                                            
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

            CreateMap<Customer, User>()                
                .ForMember(p => p.Id, opt => opt.MapFrom(src => src.ExternalId))
                .ForMember(p => p.FullName, opt => opt.MapFrom(src => src.Name));                
            CreateMap<Core.Entities.Common.AddressDetail,Address>()
                .ForMember(dest => dest.Complementary,opt => opt.MapFrom(src => src.Complement))
                .ForMember(dest => dest.Zipcode,opt => opt.MapFrom(src => src.ZipCode))
                .ForMember(dest => dest.Neighborhood,opt => opt.MapFrom(src => src.DistrictName))
                .ForMember(dest => dest.StreetNumber,opt => opt.MapFrom(src => src.Number));
            CreateMap<Core.Entities.Common.AddressDetail,Shipping>()                
                .ForPath(dest => dest.Address.Complementary,opt => opt.MapFrom(src => src.Complement))
                .ForPath(dest => dest.Address.Zipcode,opt => opt.MapFrom(src => src.ZipCode))
                .ForPath(dest => dest.Address.Neighborhood,opt => opt.MapFrom(src => src.DistrictName))
                .ForPath(dest => dest.Address.StreetNumber,opt => opt.MapFrom(src => src.Number))
                .ForPath(dest => dest.Address.Street,opt => opt.MapFrom(src => src.Street))
                .ForPath(dest => dest.Address.Country,opt => opt.MapFrom(src => src.CountryCode))
                .ForPath(dest => dest.Address.City,opt => opt.MapFrom(src => src.City))
                .ForPath(dest => dest.Address.State,opt => opt.MapFrom(src => src.State));                
            CreateMap<CustomerAddress,Address>()                                       
                .ForPath(dest => dest.Complementary,opt => opt.MapFrom(src => src.Details.Complement))                
                .ForPath(dest => dest.Zipcode,opt => opt.MapFrom(src => src.Details.ZipCode))
                .ForPath(dest => dest.Neighborhood,opt => opt.MapFrom(src => src.Details.DistrictName))
                .ForPath(dest => dest.StreetNumber,opt => opt.MapFrom(src => src.Details.Number))
                .ForPath(dest => dest.Street,opt => opt.MapFrom(src => src.Details.Street))
                .ForPath(dest => dest.Country,opt => opt.MapFrom(src => src.Details.CountryCode))
                .ForPath(dest => dest.City,opt => opt.MapFrom(src => src.Details.City))
                .ForPath(dest => dest.State,opt => opt.MapFrom(src => src.Details.State));                
            CreateMap<CustomerAddress,Shipping>()                
                .ForPath(dest => dest.Address.Id,opt => opt.MapFrom(src => src.Id))
                .ForPath(dest => dest.Address.Complementary,opt => opt.MapFrom(src => src.Details.Complement))
                .ForPath(dest => dest.Address.Zipcode,opt => opt.MapFrom(src => src.Details.ZipCode))
                .ForPath(dest => dest.Address.Neighborhood,opt => opt.MapFrom(src => src.Details.DistrictName))
                .ForPath(dest => dest.Address.StreetNumber,opt => opt.MapFrom(src => src.Details.Number))
                .ForPath(dest => dest.Address.Street,opt => opt.MapFrom(src => src.Details.Street))
                .ForPath(dest => dest.Address.Country,opt => opt.MapFrom(src => src.Details.CountryCode))
                .ForPath(dest => dest.Address.City,opt => opt.MapFrom(src => src.Details.City))
                .ForPath(dest => dest.Address.State,opt => opt.MapFrom(src => src.Details.State));
            
        }
    }
}
