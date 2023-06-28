using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApplication2.Models;

public partial class Folder
{
    public int FolderId { get; set; }

    public string Name { get; set; } = null!;

    [JsonIgnore]
    public int? UpperFolderId { get; set; }

    public virtual ICollection<File> Files { get; set; } = new List<File>();

    public virtual ICollection<Folder> InverseUpperFolder { get; set; } = new List<Folder>();
    [JsonIgnore]
    public virtual Folder? UpperFolder { get; set; }
}
