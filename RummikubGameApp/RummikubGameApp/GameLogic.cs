using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RummikubGameApp
{
    public class GameLogic
    {
        private Tile[] tiles;
        public static Tile[] hand;
        private Tile[] AIhand;
        private Tile[,] deck;
        private int currentPlayerIndex;
        private int tilesIndex;

        public GameLogic()
        {
            this.tiles = new Tile[106];
            hand = new Tile[106];
            this.AIhand = new Tile[106];
            this.deck = new Tile[4, 20];
            this.currentPlayerIndex = 2;
            this.currentPlayerIndex = 28;
        }

        public Tile[] StartGame()
        {
            // Initialize the game by creating the tiles and shuffling them
            
            InitializeTiles();
            Shuffle();
            Tile[] arr = Deal();
            // Set the first player as the current player
            currentPlayerIndex = 0;
            return arr;
        }


        public void InitializeTiles()
        {
            int index = 0;
            for (int i = 1; i <= 13; i++)
            {
                tiles[index++] = new Tile { Color = "Red", Value = i };
                tiles[index++] = new Tile { Color = "Red", Value = i };
                tiles[index++] = new Tile { Color = "Blue", Value = i };
                tiles[index++] = new Tile { Color = "Blue", Value = i };
                tiles[index++] = new Tile { Color = "Yellow", Value = i };
                tiles[index++] = new Tile { Color = "Yellow", Value = i };
                tiles[index++] = new Tile { Color = "Black", Value = i };
                tiles[index++] = new Tile { Color = "Black", Value = i };
            }
            tiles[index++] = new Tile { Color = "Joker", Value = 0 };
            tiles[index++] = new Tile { Color = "Joker", Value = 14 };
        }
        public Tile[] Shuffle()
        {
            // Shuffle the tiles randomly
            Random random = new Random();
            for (int i = 0; i < tiles.Length; i++)
            {
                int j = random.Next(i, tiles.Length);
                Tile temp = tiles[i];
                tiles[i] = tiles[j];
                tiles[j] = temp;
            }
            return tiles;
        }

       
        public Tile[] Deal()
        {
            // Deal 14 tiles from the deck to start the game
            for (int i = 0; i < 14; i++)
            {
                hand[i] = tiles[i];
            }
            return hand;
        }
        public Tile[] DealAI()
        {
            // Deal 14 tiles from the deck to start the game
            for (int i = 0; i < 14; i++)
            {
                AIhand[i] = tiles[i+14];
            }
            return hand;
        }


        public Tile[] bynumber()
        {
            int count = 0;
            while (hand[count] != null)
                count++;
            for (int i = 0; i < count - 1; i++)
                for (int j = 0; j < count - i - 1; j++)
                    if (hand[j].Value > hand[j + 1].Value)
                    {
                        // swap temp and arr[i]
                        Tile temp = hand[j];
                        hand[j] = hand[j + 1];
                        hand[j + 1] = temp;
                    }
            return hand;
        }

        public Tile[] bycolor()
        {
            hand = bynumber();
            int n = 0;
            while (hand[n] != null)
                n++;
            int count = 0;
            Tile[] temp = new Tile[n];
            for (int i = 0; i < n; i++)
            {
                if (hand[i].Color == "Yellow")
                {
                    temp[count] = hand[i];
                    count++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (hand[i].Color == "Blue")
                {
                    temp[count] = hand[i];
                    count++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (hand[i].Color == "Red")
                {
                    temp[count] = hand[i];
                    count++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (hand[i].Color == "Black")
                {
                    temp[count] = hand[i];
                    count++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (hand[i].Color == "Joker")
                {
                    temp[count] = hand[i];
                    count++;
                }
            }
            return temp;
        }


        private int count = 0;
        public Tile AddTileToHand()
        {
            Tile[] tilesleft = new Tile[106];
            if (count == 0)
            {
                tilesleft = Shuffle2();
                count++;
            }
            int handlength = 0;
            while (hand[handlength] != null)
                handlength++;
            hand[handlength] = tilesleft[this.tilesIndex];
            this.tilesIndex++;
            this.currentPlayerIndex++;
            return hand[handlength];
        }


        public Tile[] Shuffle2()
        {
            int index = 0;
            Tile[] tilesleft = new Tile[106];
            for (int i = 1; i <= 13; i++)
            {
                tilesleft[index++] = new Tile { Color = "Red", Value = i };
                tilesleft[index++] = new Tile { Color = "Red", Value = i };
                tilesleft[index++] = new Tile { Color = "Blue", Value = i };
                tilesleft[index++] = new Tile { Color = "Blue", Value = i };
                tilesleft[index++] = new Tile { Color = "Yellow", Value = i };
                tilesleft[index++] = new Tile { Color = "Yellow", Value = i };
                tilesleft[index++] = new Tile { Color = "Black", Value = i };
                tilesleft[index++] = new Tile { Color = "Black", Value = i };
            }
            tilesleft[index++] = new Tile { Color = "Joker", Value = 0 };
            tilesleft[index++] = new Tile { Color = "Joker", Value = 1 };

            Random random = new Random();
            for (int i = 0; i < tilesleft.Length; i++)
            {
                int j = random.Next(i, tiles.Length);
                Tile temp = tilesleft[i];
                tilesleft[i] = tilesleft[j];
                tilesleft[j] = temp;
            }
            int handlength = 0, count = 0;
            while (hand[handlength] != null)
                handlength++;
            for (int i = 0; i < tilesleft.Length; i++)
            {
                for (int j = 0; j < handlength; j++)
                {
                    if (hand[j] == tilesleft[i])
                    {
                        Tile temp = tilesleft[count];
                        tilesleft[count] = tilesleft[i];
                        tilesleft[i] = temp;
                    }
                }
            }
            return tilesleft;
        }
        
        public void PlayTile(string name, int row, int col)
        {

            Tile tile = new Tile();
            string tileColor;
            string resultString = Regex.Match(name, @"\d+").Value;
            int tileValue = Int32.Parse(resultString);
            if (tileValue < 10)
            {
                tileColor = name.Substring(3);
            }
            else
            {
                tileColor = name.Substring(4);
            }
            tileColor = char.ToUpper(tileColor[0]) + tileColor.Substring(1);
            tile.Color = tileColor;
            tile.Value = tileValue;

            deck[row, col] = tile;
        }

        public void AIPlayTile(string name, int row, int col)
        {

            Tile tile = new Tile();
            string tileColor;
            string resultString = Regex.Match(name, @"\d+").Value;
            int tileValue = Int32.Parse(resultString);
            if (tileValue < 10)
            {
                tileColor = name.Substring(1);
            }
            else
            {
                tileColor = name.Substring(2);
            }
            tile.Color = tileColor;
            tile.Value = tileValue;
            
            deck[row, col] = tile;
        }

        public void checkdeck()
        {
            const int BOARD_ROWS = 4;
            const int BOARD_COLS = 20;

            int placeX = 15, placeY = 5;
            string pname;

            for (int row = 0; row < BOARD_ROWS; row++)
            {
                placeX = 15;
                placeY += 55;
                for (int col = 0; col < BOARD_COLS; col++)
                {
                    Point loc = new Point(placeX, placeY);
                    var instance = new RumiApp();
                    pname = instance.GetPictureBoxNameByLocation(loc);
                    if (pname != null)
                    {
                        MessageBox.Show("wow");
                        PlayTile(pname, row, col);
                    }
                    placeX += 32;
                }
            }
        }

        public void RewindPlay()
        {
            
        }
        public bool CheckLegalDeck()
        {
            int counttiles = 0, i = 1;
            Tile[] series = new Tile[13];
            bool flag = false;
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 20; col += i)
                {
                    if (deck[row, col] == null)
                    {
                        i = 1;
                    }
                    else
                    {
                        series[counttiles] = deck[row, col];
                        counttiles++;
                        while ((deck[row, col + counttiles] != null) && (col + i < 20))
                        {
                            series[counttiles] = deck[row, col + counttiles];
                            counttiles++;
                            i++;
                        }
                        series[counttiles] = deck[row, col + counttiles];
                        counttiles = 0;
                        var instance = new Deck();
                        flag = instance.IsValidMove(series);
                        if (flag == false)
                            return false;
                        series = new Tile[13];
                    }
                }
            }
            if (flag)
                this.currentPlayerIndex++;
            return flag;
        }
    }
}
