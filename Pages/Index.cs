using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProducer.Pages
{
    public partial class Index
    {
        public List<Tuple<int, int>> Tuples = new List<Tuple<int, int>>();
        private Dictionary<Tuple<int, int>, Cell> CellComponents = new Dictionary<Tuple<int, int>, Cell>();
    }
}
