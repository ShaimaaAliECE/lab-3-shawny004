using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class CollectionBoard
    {
        private int totalScore, totalValue;

        public int TotalScore { get { return totalScore; } set { totalScore = value; } }
        public int TotalValue { get { return totalValue; } set { totalValue = value; } }
    }
}