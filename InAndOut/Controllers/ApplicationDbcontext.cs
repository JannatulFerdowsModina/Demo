using System.Collections.Generic;
using InAndOut.Models;

namespace InAndOut.Controllers
{
    internal class ApplicationDbcontext
    {
        public IEnumerable<Item> Items { get; internal set; }
    }
}