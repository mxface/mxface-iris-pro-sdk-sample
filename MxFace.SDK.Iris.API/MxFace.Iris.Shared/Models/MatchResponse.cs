using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MxFace.Iris.Shared.Models;

public class MatchResponse : BaseResult
{
    public float Score { get; set; }
}

