using System.ComponentModel.DataAnnotations;
using MongoDB.Entities;

namespace SearchServices.Model;

public class Item : Entity
{
    public int ReservePrice { get; set; }
    [Required]
    public string Seller { get; set; }
    [Required]
    public string Status { get; set; }
    [Required]
    public string Make { get; set; }
    [Required]
    public string Model { get; set; }
    [Required]
    public string Color { get; set; }
    [Required]
    public string ImageUrl { get; set; }
    public string Winner { get; set; }
    public int? SoldAmount { get; set; }
    public int? CurrentHighBid { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime AuctionEnd { get; set; }
    public int Year { get; set; }
    public int Mileage { get; set; }
}
