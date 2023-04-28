using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace RummikubGameApp
{
    public class Deck
    {
        public Tile[,] Tiles { get; private set; }

        public Deck()
        {
            Tiles = new Tile[4, 20];
            // Initialize the board with the initial set of tiles
            // This could be done using a separate method or class
        }

        public void AddTile(int row, int col, Tile tile)
        {
            Tiles[row, col] = tile;
        }

        public void RemoveTile(int row, int col)
        {
            Tiles[row, col] = null;
        }

        public bool IsValidMove(Tile[] tileseries)
        {
            // Check whether the given set of tiles can be played on the board
            int count = 0;
            while (tileseries[count] != null)
                count++;
            if (count < 3)
            {
                return false;
            }
            if (count > 13)
            {
                return false;
            }

            bool isRun = true;
            int runCount = 0;

            if (count == 3)
            {
                if ((tileseries[0].Color != tileseries[1].Color) && (tileseries[1].Color != tileseries[2].Color) && (tileseries[0].Color != tileseries[2].Color))
                {
                    if ((tileseries[0].Value == tileseries[1].Value) && (tileseries[1].Value == tileseries[2].Value))
                        return true;
                }
                if ((tileseries[0].Color == tileseries[1].Color) && (tileseries[1].Color == tileseries[2].Color))
                {
                    if ((tileseries[0].Value == tileseries[1].Value - 1) && (tileseries[1].Value != tileseries[2].Value - 1))
                    {
                        return true;
                    }
                }
                return false;
            }
            if (count == 4)
            {
                if ((tileseries[0].Color != tileseries[1].Color) && (tileseries[0].Color != tileseries[2].Color) &&
                    (tileseries[0].Color != tileseries[3].Color) && (tileseries[1].Color != tileseries[2].Color) &&
                    (tileseries[1].Color != tileseries[3].Color) && (tileseries[2].Color != tileseries[3].Color))
                {
                    if ((tileseries[0].Value == tileseries[1].Value) && (tileseries[1].Value == tileseries[2].Value) && (tileseries[2].Value == tileseries[3].Value))
                        return true;
                }
                if ((tileseries[0].Color == tileseries[1].Color) && (tileseries[1].Color == tileseries[2].Color) && (tileseries[2].Color == tileseries[3].Color))
                {
                    if ((tileseries[0].Value == tileseries[1].Value - 1) && (tileseries[1].Value != tileseries[2].Value - 1) && (tileseries[2].Value != tileseries[3].Value - 1))
                    {
                        return true;
                    }
                }
                return false;
            }
            if (count > 4)
            {
                for (int i = 0; i < count - 1; i++)
                {
                    if ((tileseries[i].Color != tileseries[i + 1].Color))
                        isRun = false;
                }
                while (isRun && (runCount < count - 1) && (count > 4))
                {
                    if ((tileseries[runCount].Value != tileseries[runCount + 1].Value - 1))
                        isRun = false;
                    runCount++;
                }
            }
            return isRun;
        }
    }
}
