using API.Catalog.Models;
using BuildingBlocks.CQRS;

namespace API.Catalog.Products.CreateProduct;

public record CreateProductCommand
(
    string Name,
    List<string> Category,
    string Description,
    string ImageFile,
    decimal Price
) : ICommand<CreateProductResult>;

public record CreateProductResult(Guid Id);

internal class CreateProductHandler : 
    ICommandHandler<CreateProductCommand, CreateProductResult>
{
    public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        //Create Product entity from command object
        //Save to database
        //Return CreateProductResult result

        var product = new Product
        {
            Name = command.Name,
            Description = command.Description,
            Category = command.Category,
            ImageFile = command.ImageFile,
            Price = command.Price,
        };

        return new CreateProductResult(Guid.NewGuid()); 
        
        throw new NotImplementedException();
    }
}
