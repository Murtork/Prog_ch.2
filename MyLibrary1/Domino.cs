using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj
{

    public class Domino
    {
        private int _edge1;
        public int edge1 { 
            get { return _edge1;  } 
            set { if (value > 0 && value < 7) _edge1 = value; } 
        }
        private int _edge2;
        public int edge2
        {
            get { return _edge2; }
            set { if (value > 0 && value < 7) _edge2 = value; }
        }

        public void SetEdges()
        {
            Random rand = new Random();
            this.edge1 = rand.Next(1, 6);
            this.edge2 = rand.Next(1, 6);
        }

        public static string ReturnEdges(int edge1, int edge2)
        {
            string st = edge1 + ", " + edge2;
            return st;
        }

        public static void HandySetDomino(Domino d, int edge1, int edge2)
        {
            d.edge1 = edge1;
            d.edge2 = edge2;
        }

        public static string TestThisTurn(Domino d, Domino d2)
        {
            string result;
            if ((d.edge1 == d2.edge1) || (d.edge1 == d2.edge2) || (d.edge2 == d2.edge2) || (d.edge2 == d2.edge1))
                if ((d.edge1 > 0) & (d.edge1 < 7) & (d.edge2 > 0) & (d.edge2 < 7) & (d2.edge1 > 0) & (d2.edge1 < 7) & (d2.edge2 > 0) & (d2.edge2 < 7))
                {
                    result = "У этих домино ход существует!";
                }
                else
                {
                    result = "Неправильные или отсутствующие значения домино";
                }
            else
            {
                result = "Хода у этих домино нету";
            }

            return result;
        }

    }



}
