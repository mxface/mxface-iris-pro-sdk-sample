using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MxFace.Iris.Shared.Models;

public class MatchRequest
{
    [Required]
    public byte[] SourceTemplate { get; set; }

    [Required]
    public byte[] TargetTemplate { get; set; }
}