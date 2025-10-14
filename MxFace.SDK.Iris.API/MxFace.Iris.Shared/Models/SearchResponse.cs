using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MxFace.Iris.Shared.Models;

public class SearchResponse: BaseResult
{
    public string ExternalId { get; set; }
    public int MatchingScore { get; set; }
}
