using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace Hanan_csharp_backend_teamwork.src.Entities;

public class Address
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string StreetName { get; set; }
    public int PostalCode { get; set; }
    public int ZipCode { get; set; }
    public IEnumerable<Order> Orders { get; set; }



}
