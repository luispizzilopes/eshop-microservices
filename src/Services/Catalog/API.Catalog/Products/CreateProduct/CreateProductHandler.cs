﻿using MediatR;

namespace API.Catalog.Products.CreateProduct;

public record CreateProductCommand
(
    string Name,
    List<string> Category,
    string Description,
    string ImageFile,
    decimal Price
) : IRequest<CreateProductResult>;

public record CreateProductResult(Guid Id);

internal class CreateProductHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
{
    public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        //Lógica de negócio para criar o produto
        throw new NotImplementedException();
    }
}
