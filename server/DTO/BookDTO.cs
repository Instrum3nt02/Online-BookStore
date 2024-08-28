namespace server.DTO
{
    public class BookDTO
    {
  

    public string? Title { get; set; }


    public int? PagesCount { get; set; }

    public string? Language { get; set; }

    public string? Category {get; set;}

    public int? PublisherId { get; set; }

    public DateOnly? PublishedDate { get; set; }

    public double? PublishedVersion { get; set; }

    public decimal? Price { get; set; }

    public string? Description { get; set; }

    public string? ImageUrl { get; set; }

    public string? Author { get; set; }  
    }
}