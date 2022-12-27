﻿using System;
using System.Collections.Generic;

namespace MyDataService.Models;

public partial class Gubudik
{
    public long AlbumId { get; set; }

    public string Title { get; set; } = null!;

    public long ArtistId { get; set; }

    public virtual Artist Artist { get; set; } = null!;

    public virtual ICollection<Track> Tracks { get; } = new List<Track>();
}