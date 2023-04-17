using System;
using System.Collections.Generic;

namespace Train;

public partial class Book
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Genre { get; set; }

    public string? Author { get; set; }

    public decimal? Price { get; set; }

    public int? CountInShop { get; set; }

    public int? CountInStock { get; set; }

    public string? Description { get; set; }

    public string? Image { get; set; }
}
