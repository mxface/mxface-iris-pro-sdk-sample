using System.ComponentModel.DataAnnotations;

namespace MxFace.Iris.Shared.Models;

public class EnrollRequest
{
    [Required]
    public byte[] TemplateData { get; set; }
    public string? PersonId { get; set; }

    public string? Group { get; set; }
}
