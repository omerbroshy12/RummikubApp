using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RummikubGameApp
{
    class OpponentAI
    {
        private Tile[] AIhand;

        public OpponentAI()
        {
            AIhand = new Tile[106];
        }
        public void dealtiles()
        {
            var instance = new GameLogic();
            AIhand = instance.DealAI();
        }

        public void AIbyColor()
        {
            AIbyNumber();
            int n = 0;
            while (AIhand[n] != null)
                n++;
            int count = 0;
            Tile[] temp = new Tile[n];
            for (int i = 0; i < n; i++)
            {
                if (AIhand[i].Color == "Yellow")
                {
                    temp[count] = AIhand[i];
                    count++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (AIhand[i].Color == "Blue")
                {
                    temp[count] = AIhand[i];
                    count++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (AIhand[i].Color == "Red")
                {
                    temp[count] = AIhand[i];
                    count++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (AIhand[i].Color == "Black")
                {
                    temp[count] = AIhand[i];
                    count++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (AIhand[i].Color == "Joker")
                {
                    temp[count] = AIhand[i];
                    count++;
                }
            }
            AIhand = temp;
        }

        public void AIbyNumber()
        {
            int count = 0;
            while (AIhand[count] != null)
                count++;
            for (int i = 0; i < count - 1; i++)
                for (int j = 0; j < count - i - 1; j++)
                    if (AIhand[j].Value > AIhand[j + 1].Value)
                    {
                        // swap temp and arr[i]
                        Tile temp = AIhand[j];
                        AIhand[j] = AIhand[j + 1];
                        AIhand[j + 1] = temp;
                    }
        }
    }
}
