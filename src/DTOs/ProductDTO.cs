using System.ComponentModel.DataAnnotations;
namespace sda_onsite_2_csharp_backend_teamwork.src.DTOs;

public class ProductReadDTO
{
    public Guid Id { get; set; }
    public Guid CategoryId { get; set; }
    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }

}


public class ProductCreateDTO
{
    public Guid CategoryId { get; set; }
    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }

}
public class ProductDTO
{
    public Guid Id { get; set; }

    public Guid CategoryId { get; set; }
    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }

}

public class ProductUpdateDto
{
    public Guid CategoryId { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }
    public string Description { get; set; }

}

public class ProductWithStock
{
    public Guid Id { get; set; }
    public Guid? StockId { get; set; }
    public Guid CategoryId { get; set; }
    [Required]
    public string? Name { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public int? Quantity { get; set; }
    public int? Price { get; set; }
    public string? Color { get; set; }
    public char? Size { get; set; }
}
// create ProductCreateDTO => without id 
// go to mappper, mapper to map ProductCreateDTO to Product 
// in service, apply mapper to map ProductCreateDTO to Product 


/// front end , in useState(), and input field you need to check carefully the name of properties 