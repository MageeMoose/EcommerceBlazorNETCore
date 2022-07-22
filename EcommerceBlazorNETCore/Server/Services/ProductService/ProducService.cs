namespace EcommerceBlazorNETCore.Server.Services.ProductService;

public class ProducService : IProductService
{
    private readonly DataContext _context;

    public ProducService(DataContext context)
    {
        _context = context;
    }
    public async Task<ServiceResponse<List<Product>>> GetProductAsync()
    {
        var response = new ServiceResponse<List<Product>>
        {
            Data = await _context.Products.ToListAsync()
        };

        return response;
    }
}