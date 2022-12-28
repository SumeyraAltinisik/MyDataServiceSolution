using System;
using System.Collections.Generic;

namespace MyDataService.Models;

public partial class Gubudik
{
    public long AlbumId { get; set; }

    public string Title { get; set; } = null!;

    public long ArtistId { get; set; }
}
