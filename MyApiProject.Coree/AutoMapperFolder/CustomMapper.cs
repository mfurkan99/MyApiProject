using AutoMapper;
using AutoMapper.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MyApiProject.Coree.AutoMapperFolder
{
    public class CustomMapper : AutoMapperFolder.IMapper // Class ismi değiştirildi
    {
        public static List<TypePair> typePairs = new();
        private AutoMapper.IMapper MapperContainer; // AutoMapper'ın IMapper arayüzü kullanılıyor

        // TSource ve TDestination ile eşleşme yapılıyor
        public TDestination Map<TDestination, TSource>(TSource source, string? ignore = null)
        {
            Config<TDestination, TSource>(5, ignore);
            return MapperContainer.Map<TSource, TDestination>(source); // TSource ve TDestination eşleşmesi sağlandı
        }

        public IList<TDestination> Map<TDestination, TSource>(IList<TSource> source, string? ignore = null)
        {
            Config<TDestination, TSource>(5, ignore);
            return MapperContainer.Map<IList<TSource>, IList<TDestination>>(source);
        }

        public TDestination Map<TDestination>(object source, string? ignore = null)
        {
            Config<TDestination, object>(5, ignore);
            return MapperContainer.Map<TDestination>(source);
        }

        public IList<TDestination> Map<TDestination>(IList<object> source, string? ignore = null)
        {
            Config<TDestination, object>(5, ignore); // Tip olarak object kullanılıyor
            return source.Select(s => MapperContainer.Map<TDestination>(s)).ToList(); // Her objeyi TDestination'a map yapıyor
        }

        // Mapping configürasyonunun doğru çalışmasını sağlar
        protected void Config<TDestination, TSource>(int depth = 5, string? ignore = null)
        {
            var typePair = new TypePair(typeof(TSource), typeof(TDestination));

            // Zaten varsa tekrar ekleme yapmaz
            if (typePairs.Any(a => a.DestinationType == typePair.DestinationType && a.SourceType == typePair.SourceType) && ignore is null)
                return;

            typePairs.Add(typePair);

            // Mapping konfigürasyonu oluşturuluyor
            var config = new MapperConfiguration(cfg =>
            {
                foreach (var item in typePairs)
                {
                    if (ignore is not null)
                        cfg.CreateMap(item.SourceType, item.DestinationType)
                           .MaxDepth(depth)
                           .ForMember(ignore, x => x.Ignore())
                           .ReverseMap();
                    else
                        cfg.CreateMap(item.SourceType, item.DestinationType)
                           .MaxDepth(depth)
                           .ReverseMap();
                }
            });

            MapperContainer = config.CreateMapper(); // Mapper oluşturuluyor
        }
    }
}