using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Treasure:Collectable
    {
        private int score;

        public int Score { get { return score; } set { score = value; } }
        

        public Treasure(string description, int scr): base(description)
        {
            
            Score = scr;
        }

        

        public void UpdateTotalScore()
        {
            Board.TotalScore = Board.TotalScore + score;
            Console.WriteLine($"Total Score is updated to: {Board.TotalScore}");
        }



        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalScore();
        }
    }
}