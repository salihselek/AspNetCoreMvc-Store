using System.ComponentModel.DataAnnotations;

namespace Entities.Models;
public class Product
{
    public int Id { get; set; }
    public String? Name { get; set; } = String.Empty;
    public decimal Price { get; set; }
    public String? Summary { get; set; } = String.Empty;
    public String? ImageUrl { get; set; } = String.Empty;
    public int? CategoryId { get; set; }
    public Category? Category { get; set; }
}