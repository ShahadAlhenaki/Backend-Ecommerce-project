namespace sda_onsite_2_csharp_backend_teamwork.src.DTOs;
public class CategoryCreateDto
{
    public string Name { get; set; }
}
public class CategoryReadDto
{
    public Guid Id { get; set; }

    public string Name { get; set; }

}