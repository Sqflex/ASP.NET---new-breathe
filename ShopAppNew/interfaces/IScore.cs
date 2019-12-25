using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopAppNew.Models;

namespace ShopAppNew.interfaces
{
    interface IScore
    {
        IEnumerable<Score> AllScores { get; }
    }
}
