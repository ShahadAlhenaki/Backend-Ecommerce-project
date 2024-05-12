namespace sda_onsite_2_csharp_backend_teamwork.src.Entities;

public class Category
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<Product> Products { get; set; }
}
