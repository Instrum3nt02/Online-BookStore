﻿namespace server.Models.DB;

public partial class Author
{
    public int AuthorId { get; set; }

    public string? AuthorName { get; set; }

    public string? Bio { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
