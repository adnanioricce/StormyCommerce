using System;
using AutoMapper;
using StormyCommerce.Core.Models.Shipment.Responses;
using StormyCommerce.Module.Orders.Area.Models.Correios;
using SimplCommerce.Module.Shipments.Models.Request;

namespace StormyCommerce.WebHost.Mappings
{
    public class ShippingProfile : Profile
    {
        public ShippingProfile()
        {
            //TODO:Define mappings 
            CreateMap<DeliveryCalculationRequest,CalcPrecoPrazoModel>()
                .ForMember(dest => dest.nVlComprimento,opt => opt.MapFrom(src => src.Length))
                .ForMember(dest => dest.nVlAltura,opt => opt.MapFrom(src => src.Height))
                .ForMember(dest => dest.nVlDiametro,opt => opt.MapFrom(src => src.Diameter))
                .ForMember(dest => dest.nVlLargura,opt => opt.MapFrom(src => src.Width))
                .ForMember(dest => dest.sCepDestino,opt => opt.MapFrom(src => src.DestinationPostalCode))                
                .ForMember(dest => dest.nVlPeso,opt => opt.MapFrom(src => src.Weight.ToString()))
                .ForMember(dest => dest.nVlValorDeclarado,opt => opt.MapFrom(src => src.ValorDeclarado))
                .ForMember(dest => dest.sCdAvisoRecebimento,opt => opt.MapFrom(src => src.WarningOfReceiving))
                .ForMember(dest => dest.sCdMaoPropria,opt => opt.MapFrom(src => src.MaoPropria))
                .ForMember(dest => dest.nCdServico,opt => opt.MapFrom(src => src.ShipmentMethod))
                .ForMember(dest => dest.nCdFormato,opt => opt.MapFrom(src => src.FormatCode));
            CreateMap<cResultado,DeliveryCalculationResponse>()
                .ForMember(dest => dest.Options,opt => opt.MapFrom(src => src.Servicos));
            CreateMap<cServico,DeliveryCalculationOptionResponse>()
                .ForMember(dest => dest.DeliveryDate,opt => opt.MapFrom(src => DateTime.Now.AddDays(Convert.ToInt32(src.PrazoEntrega))))
                .ForMember(dest => dest.DeliveryMaxDate,opt => opt.MapFrom(src => DateTime.Now.AddDays(Convert.ToInt32(src.DataMaxEntrega))))
                .ForMember(dest => dest.HourOfDay,opt => opt.MapFrom(src => DateTime.Now.AddDays(Convert.ToInt32(src.HoraMaxEntrega))))
                .ForMember(dest => dest.Price,opt => opt.MapFrom(src => src.Valor))
                .ForMember(dest => dest.Service,opt => opt.MapFrom(src => src.Codigo.ToString()));                
        }        
    }
}
