using System;
using AutoMapper;
using StormyCommerce.Module.Orders.Area.Models;
using StormyCommerce.Module.Orders.Area.Models.Correios;

namespace StormyCommerce.Module.Mapping.Mappings
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
                .ForMember(dest => dest.sCepOrigem,opt => opt.MapFrom(src => src.OriginPostalCode))
                .ForMember(dest => dest.nVlPeso,opt => opt.MapFrom(src => src.Weight.ToString()))
                .ForMember(dest => dest.nVlValorDeclarado,opt => opt.MapFrom(src => src.ValorDeclarado))
                .ForMember(dest => dest.sCdAvisoRecebimento,opt => opt.MapFrom(src => src.WarningOfReceiving))
                .ForMember(dest => dest.sCdMaoPropria,opt => opt.MapFrom(src => src.MaoPropria))
                .ForMember(dest => dest.nCdServico,opt => opt.MapFrom(src => src.ServiceCode))
                .ForMember(dest => dest.nCdFormato,opt => opt.MapFrom(src => src.FormatCode));
            CreateMap<cResultado,DeliveryCalculationResponse>()
                .ForMember(dest => dest.Options,opt => opt.MapFrom(src => src.Servicos));
            CreateMap<cServico,DeliveryCalculationOptionResponse>()
                .ForMember(dest => dest.DeliveryDeadline,opt => opt.MapFrom(src => Convert.ToDateTime(src.PrazoEntrega)))
                .ForMember(dest => dest.DeliveryMaxDate,opt => opt.MapFrom(src => Convert.ToDateTime(src.DataMaxEntrega)))
                .ForMember(dest => dest.HourOfDay,opt => opt.MapFrom(src => src.HoraMaxEntrega))
                .ForMember(dest => dest.Price,opt => opt.MapFrom(src => src.Valor))
                .ForMember(dest => dest.Service,opt => opt.MapFrom(src => src.Codigo.ToString()));                
        }
    }
}
