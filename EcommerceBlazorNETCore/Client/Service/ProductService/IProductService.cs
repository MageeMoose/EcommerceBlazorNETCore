namespace EcommerceBlazorNETCore.Client.Service.ProductService;

public interface IProductService
{
    List<Product> Products { get; set; }
    Task GetProducts();
}