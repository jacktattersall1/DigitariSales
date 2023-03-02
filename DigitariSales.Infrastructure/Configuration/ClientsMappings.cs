using AutoMapper;
using DigitariSales.Domain;
using DigitariSales.Infrastructure.Clients.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitariSales.Infrastructure.Configuration
{
    public class ClientsMappings : Profile
    {
        public ClientsMappings()
        {
            CreateMap<CountryResponse, Country>()
                .ForMember(dest => dest.DefaultLanguage, opt => opt.MapFrom(src => src.Languages.FirstOrDefault().iso639_1))
                .ForMember(dest => dest.FlagUrl, opt => opt.MapFrom(src => src.Flag))
                .ForMember(dest => dest.NameTranslations, opt => opt.MapFrom(src => src.Translations));
        }
    }
}
