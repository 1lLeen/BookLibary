﻿using LibaryAPI.Domain.DTOs.ReadersNewsletter;

namespace LibaryAPI.Application.Services.Interfaces;

public interface IReaderNewsletterService : IAbstractService<GetReaderNewsletter, CreateReaderNewsletter, UpdateReaderNewsletter>
{
    Task<IEnumerable<GetReaderNewsletter>> GetReadersDelayAsync();
    Task<IEnumerable<GetReaderNewsletter>> GetReadersByReaderIdAsync(int readerId);
    Task<IEnumerable<GetReaderNewsletter>> GetReadersByBookIdAsync(int bookId);
}
