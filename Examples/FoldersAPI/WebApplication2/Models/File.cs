using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApplication2.Models;

public partial class File
{
    public int FileId { get; set; }

    public string Name { get; set; } = null!;

    [JsonIgnore]
    public int? FolderId { get; set; }

    [JsonIgnore]
    public virtual Folder? Folder { get; set; }
}
