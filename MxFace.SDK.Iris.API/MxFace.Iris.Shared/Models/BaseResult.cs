using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MxFace.Iris.Shared.Models;

public class BaseResult
{
    public int? Code { get; set; }

    public string? Message { get; set; }
}
