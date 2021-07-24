using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProducer.Pages
{
    public partial class Cell
    {
        public int RowIndex;
        public int ColIndex;

        public Cell(int rowIndex, int colIndex)
        {
            RowIndex = rowIndex;
            ColIndex = colIndex;
        }
    }
}
