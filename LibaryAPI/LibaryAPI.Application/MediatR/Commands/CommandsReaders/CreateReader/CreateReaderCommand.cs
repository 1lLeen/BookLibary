﻿using LibaryAPI.Domain.DTOs.Readers;
using MediatR;

namespace LibaryAPI.Application.MediatR.Commands.CommandsReaders.CreateReader;

public class CreateReaderCommand : IRequest<GetReaderDto>
{
    public CreateReaderDto CreateReaderDto { get; set; }
    public CreateReaderCommand(CreateReaderDto createReaderDto) => CreateReaderDto = createReaderDto;
}
