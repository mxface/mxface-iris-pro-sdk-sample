using System.ComponentModel.DataAnnotations;

namespace MxFace.Iris.Shared.Models;

public class SearchRequest
{
    [Required]
    public byte[] TemplateData { get; set; }
    public string? Group { get; set; }
}
