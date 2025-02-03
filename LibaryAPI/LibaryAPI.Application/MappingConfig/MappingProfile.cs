using AutoMapper;
using LibaryAPI.Domain.DTOs.Books;
using LibaryAPI.Domain.DTOs.Readers;
using LibaryAPI.Domain.DTOs.ReadersNewsletter;
using LibaryAPI.Infrastructure.Models.Books;
using LibaryAPI.Infrastructure.Models.Readers;

namespace LibaryAPI.Application.MappingConfig;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        #region BookMap
        CreateMap<BookModel, GetBookDto>().ReverseMap();
        CreateMap<BookModel, CreateBookDto>().ReverseMap();
        CreateMap<BookModel, UpdateBookDto>().ReverseMap();
        CreateMap<BookModel, GetBookDto>();
        CreateMap<BookModel, CreateBookDto>();
        CreateMap<BookModel, UpdateBookDto>();
        #endregion
        #region ReaderMap
        CreateMap<ReaderModel, GetReaderDto>().ReverseMap();
        CreateMap<ReaderModel, CreateReaderDto>().ReverseMap();
        CreateMap<ReaderModel, UpdateReaderDto>().ReverseMap();
        CreateMap<ReaderModel, GetReaderDto>();
        CreateMap<ReaderModel, CreateReaderDto>();
        CreateMap<ReaderModel, UpdateReaderDto>();
        #endregion
        #region ReaderNewsletterMap
        CreateMap<ReaderNewsletterModel, GetReaderNewsletterDto>().ReverseMap();
        CreateMap<ReaderNewsletterModel, CreateReaderNewsletterDto>().ReverseMap();
        CreateMap<ReaderNewsletterModel, UpdateReaderNewsletterDto>().ReverseMap();
        CreateMap<ReaderNewsletterModel, GetReaderNewsletterDto>();
        CreateMap<ReaderNewsletterModel, CreateReaderNewsletterDto>();
        CreateMap<ReaderNewsletterModel, UpdateReaderNewsletterDto>();
        #endregion
    }
}

