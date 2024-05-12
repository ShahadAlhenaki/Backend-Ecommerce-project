using System.ComponentModel.DataAnnotations;
namespace sda_onsite_2_csharp_backend_teamwork.src.DTOs;

public class ProductReadDTO
{
    public Guid CategoryId { get; set; }
    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
}
public class ProductDTO
{
    public Guid Id { get; set; }

    public Guid CategoryId { get; set; }
    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
}
