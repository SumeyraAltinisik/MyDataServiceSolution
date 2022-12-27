using System;
using System.Collections.Generic;

namespace MyDataService.Models;

public partial class Genre
{
    public long GenreId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Track> Tracks { get; } = new List<Track>();
}
