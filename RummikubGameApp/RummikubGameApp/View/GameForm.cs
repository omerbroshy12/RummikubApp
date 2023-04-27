using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RummikubGameApp
{
    public partial class RumiApp : Form
    {
        public RumiApp()
        {
            InitializeComponent();
            Draw();
        }
        public PictureBox pb1black = new PictureBox();
        public PictureBox pb2black = new PictureBox();
        public PictureBox pb3black = new PictureBox();
        public PictureBox pb4black = new PictureBox();
        public PictureBox pb5black = new PictureBox();
        public PictureBox pb6black = new PictureBox();
        public void Draw()
        {

            pb1black.Size = new Size(32, 45);
            pb1black.Image = Properties.Resources._1black;


            pb2black.Size = new Size(32, 45);
            pb2black.Image = Properties.Resources._2black;


            pb3black.Size = new Size(32, 45);
            pb3black.Image = Properties.Resources._3black;


            pb4black.Size = new Size(32, 45);
            pb4black.Image = Properties.Resources._4black;


            pb5black.Size = new Size(32, 45);
            pb5black.Image = Properties.Resources._5black;


            pb6black.Size = new Size(32, 45);
            pb6black.Image = Properties.Resources._6black;

            PictureBox pb7black = new PictureBox();
            pb7black.Size = new Size(32, 45);
            pb7black.Image = Properties.Resources._7black;

            PictureBox pb8black = new PictureBox();
            pb8black.Size = new Size(32, 45);
            pb8black.Image = Properties.Resources._8black;

            PictureBox pb9black = new PictureBox();
            pb9black.Size = new Size(32, 45);
            pb9black.Image = Properties.Resources._9black;

            PictureBox pb10black = new PictureBox();
            pb10black.Size = new Size(32, 45);
            pb10black.Image = Properties.Resources._10black;

            PictureBox pb11black = new PictureBox();
            pb11black.Size = new Size(32, 45);
            pb11black.Image = Properties.Resources._11black;

            PictureBox pb12black = new PictureBox();
            pb12black.Size = new Size(32, 45);
            pb12black.Image = Properties.Resources._12black;

            PictureBox pb13black = new PictureBox();
            pb13black.Size = new Size(32, 45);
            pb13black.Image = Properties.Resources._13black;

            PictureBox pb1red = new PictureBox();
            pb1red.Size = new Size(32, 45);
            pb1red.Image = Properties.Resources._1red;

            PictureBox pb2red = new PictureBox();
            pb2red.Size = new Size(32, 45);
            pb2red.Image = Properties.Resources._2red;

            PictureBox pb3red = new PictureBox();
            pb3red.Size = new Size(32, 45);
            pb3red.Image = Properties.Resources._3red;

            PictureBox pb4red = new PictureBox();
            pb4red.Size = new Size(32, 45);
            pb4red.Image = Properties.Resources._4red;

            PictureBox pb5red = new PictureBox();
            pb5red.Size = new Size(32, 45);
            pb5red.Image = Properties.Resources._5red;

            PictureBox pb6red = new PictureBox();
            pb6red.Size = new Size(32, 45);
            pb6red.Image = Properties.Resources._6red;

            PictureBox pb7red = new PictureBox();
            pb7red.Size = new Size(32, 45);
            pb7red.Image = Properties.Resources._7red;

            PictureBox pb8red = new PictureBox();
            pb8red.Size = new Size(32, 45);
            pb8red.Image = Properties.Resources._8red;

            PictureBox pb9red = new PictureBox();
            pb9red.Size = new Size(32, 45);
            pb9red.Image = Properties.Resources._9red;

            PictureBox pb10red = new PictureBox();
            pb10red.Size = new Size(32, 45);
            pb10red.Image = Properties.Resources._10red;

            PictureBox pb11red = new PictureBox();
            pb11red.Size = new Size(32, 45);
            pb11red.Image = Properties.Resources._11red;

            PictureBox pb12red = new PictureBox();
            pb12red.Size = new Size(32, 45);
            pb12red.Image = Properties.Resources._12red;

            PictureBox pb13red = new PictureBox();
            pb13red.Size = new Size(32, 45);
            pb13red.Image = Properties.Resources._13red;

            PictureBox pb1yellow = new PictureBox();
            pb1yellow.Size = new Size(32, 45);
            pb1yellow.Image = Properties.Resources._1yellow;

            PictureBox pb2yellow = new PictureBox();
            pb2yellow.Size = new Size(32, 45);
            pb2yellow.Image = Properties.Resources._2yellow;

            PictureBox pb3yellow = new PictureBox();
            pb3yellow.Size = new Size(32, 45);
            pb3yellow.Image = Properties.Resources._3yellow;

            PictureBox pb4yellow = new PictureBox();
            pb4yellow.Size = new Size(32, 45);
            pb4yellow.Image = Properties.Resources._4yellow;

            PictureBox pb5yellow = new PictureBox();
            pb5yellow.Size = new Size(32, 45);
            pb5yellow.Image = Properties.Resources._5yellow;

            PictureBox pb6yellow = new PictureBox();
            pb6yellow.Size = new Size(32, 45);
            pb6yellow.Image = Properties.Resources._6yellow;

            PictureBox pb7yellow = new PictureBox();
            pb7yellow.Size = new Size(32, 45);
            pb7yellow.Image = Properties.Resources._7yellow;

            PictureBox pb8yellow = new PictureBox();
            pb8yellow.Size = new Size(32, 45);
            pb8yellow.Image = Properties.Resources._8yellow;

            PictureBox pb9yellow = new PictureBox();
            pb9yellow.Size = new Size(32, 45);
            pb9yellow.Image = Properties.Resources._9yellow;

            PictureBox pb10yellow = new PictureBox();
            pb10yellow.Size = new Size(32, 45);
            pb10yellow.Image = Properties.Resources._10yellow;

            PictureBox pb11yellow = new PictureBox();
            pb11yellow.Size = new Size(32, 45);
            pb11yellow.Image = Properties.Resources._11yellow;

            PictureBox pb12yellow = new PictureBox();
            pb12yellow.Size = new Size(32, 45);
            pb12yellow.Image = Properties.Resources._12yellow;

            PictureBox pb13yellow = new PictureBox();
            pb13yellow.Size = new Size(32, 45);
            pb13yellow.Image = Properties.Resources._13yellow;

            PictureBox pb1blue = new PictureBox();
            pb1blue.Size = new Size(32, 45);
            pb1blue.Image = Properties.Resources._1blue;

            PictureBox pb2blue = new PictureBox();
            pb2blue.Size = new Size(32, 45);
            pb2blue.Image = Properties.Resources._2blue;

            PictureBox pb3blue = new PictureBox();
            pb3blue.Size = new Size(32, 45);
            pb3blue.Image = Properties.Resources._3blue;

            PictureBox pb4blue = new PictureBox();
            pb4blue.Size = new Size(32, 45);
            pb4blue.Image = Properties.Resources._4blue;

            PictureBox pb5blue = new PictureBox();
            pb5blue.Size = new Size(32, 45);
            pb5blue.Image = Properties.Resources._5blue;

            PictureBox pb6blue = new PictureBox();
            pb6blue.Size = new Size(32, 45);
            pb6blue.Image = Properties.Resources._6blue;

            PictureBox pb7blue = new PictureBox();
            pb7blue.Size = new Size(32, 45);
            pb7blue.Image = Properties.Resources._7blue;

            PictureBox pb8blue = new PictureBox();
            pb8blue.Size = new Size(32, 45);
            pb8blue.Image = Properties.Resources._8blue;

            PictureBox pb9blue = new PictureBox();
            pb9blue.Size = new Size(32, 45);
            pb9blue.Image = Properties.Resources._9blue;

            PictureBox pb10blue = new PictureBox();
            pb10blue.Size = new Size(32, 45);
            pb10blue.Image = Properties.Resources._10blue;

            PictureBox pb11blue = new PictureBox();
            pb11blue.Size = new Size(32, 45);
            pb11blue.Image = Properties.Resources._11blue;

            PictureBox pb12blue = new PictureBox();
            pb12blue.Size = new Size(32, 45);
            pb12blue.Image = Properties.Resources._12blue;

            PictureBox pb13blue = new PictureBox();
            pb13blue.Size = new Size(32, 45);
            pb13blue.Image = Properties.Resources._13blue;

            PictureBox pbredjoker = new PictureBox();
            pbredjoker.Size = new Size(32, 45);
            pbredjoker.Image = Properties.Resources.redjoker;

            PictureBox pbblackjoker = new PictureBox();
            pbblackjoker.Size = new Size(32, 45);
            pbblackjoker.Image = Properties.Resources.blackjoker;


            var instance = new GameLogic();
            Tile[] hand = instance.StartGame();

            int placeX = 20;
            int placeY = 300;
            for (int i = 0; i < 14; i++)
            {
                if (hand[i].Color == "Joker")
                {
                    if (hand[i].Value == 0)
                    {
                        pbredjoker.Location = new Point(placeX, placeY);
                        this.Controls.Add(pbredjoker);
                        pbredjoker.MouseDown += PictureBox_MouseDown;
                        pbredjoker.MouseUp += PictureBox_MouseUp;
                        pbredjoker.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 14)
                    {
                        pbblackjoker.Location = new Point(placeX, placeY);
                        this.Controls.Add(pbblackjoker);
                        pbblackjoker.MouseDown += PictureBox_MouseDown;
                        pbblackjoker.MouseUp += PictureBox_MouseUp;
                        pbblackjoker.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                }
                if (hand[i].Color == "Black")
                {
                    if (hand[i].Value == 1)
                    {
                        pb1black.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb1black);
                        pb1black.MouseDown += PictureBox_MouseDown;
                        pb1black.MouseUp += PictureBox_MouseUp;
                        pb1black.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 2)
                    {
                        pb2black.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb2black);
                        pb2black.MouseDown += PictureBox_MouseDown;
                        pb2black.MouseUp += PictureBox_MouseUp;
                        pb2black.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 3)
                    {
                        pb3black.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb3black);
                        pb3black.MouseDown += PictureBox_MouseDown;
                        pb3black.MouseUp += PictureBox_MouseUp;
                        pb3black.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 4)
                    {
                        pb4black.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb4black);
                        pb4black.MouseDown += PictureBox_MouseDown;
                        pb4black.MouseUp += PictureBox_MouseUp;
                        pb4black.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 5)
                    {
                        pb5black.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb5black);
                        pb5black.MouseDown += PictureBox_MouseDown;
                        pb5black.MouseUp += PictureBox_MouseUp;
                        pb5black.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 6)
                    {
                        pb6black.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb6black);
                        pb6black.MouseDown += PictureBox_MouseDown;
                        pb6black.MouseUp += PictureBox_MouseUp;
                        pb6black.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 7)
                    {
                        pb7black.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb7black);
                        pb7black.MouseDown += PictureBox_MouseDown;
                        pb7black.MouseUp += PictureBox_MouseUp;
                        pb7black.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 8)
                    {
                        pb8black.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb8black);
                        pb8black.MouseDown += PictureBox_MouseDown;
                        pb8black.MouseUp += PictureBox_MouseUp;
                        pb8black.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 9)
                    {
                        pb9black.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb9black);
                        pb9black.MouseDown += PictureBox_MouseDown;
                        pb9black.MouseUp += PictureBox_MouseUp;
                        pb9black.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 10)
                    {
                        pb10black.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb10black);
                        pb10black.MouseDown += PictureBox_MouseDown;
                        pb10black.MouseUp += PictureBox_MouseUp;
                        pb10black.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 11)
                    {
                        pb11black.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb11black);
                        pb11black.MouseDown += PictureBox_MouseDown;
                        pb11black.MouseUp += PictureBox_MouseUp;
                        pb11black.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 12)
                    {
                        pb12black.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb12black);
                        pb12black.MouseDown += PictureBox_MouseDown;
                        pb12black.MouseUp += PictureBox_MouseUp;
                        pb12black.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 13)
                    {
                        pb13black.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb13black);
                        pb13black.MouseDown += PictureBox_MouseDown;
                        pb13black.MouseUp += PictureBox_MouseUp;
                        pb13black.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                }
                if (hand[i].Color == "Red")
                {
                    if (hand[i].Value == 1)
                    {
                        pb1red.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb1red);
                        pb1red.MouseDown += PictureBox_MouseDown;
                        pb1red.MouseUp += PictureBox_MouseUp;
                        pb1red.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 2)
                    {
                        pb2red.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb2red);
                        pb2red.MouseDown += PictureBox_MouseDown;
                        pb2red.MouseUp += PictureBox_MouseUp;
                        pb2red.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 3)
                    {
                        pb3red.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb3red);
                        pb3red.MouseDown += PictureBox_MouseDown;
                        pb3red.MouseUp += PictureBox_MouseUp;
                        pb3red.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 4)
                    {
                        pb4red.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb4red);
                        pb4red.MouseDown += PictureBox_MouseDown;
                        pb4red.MouseUp += PictureBox_MouseUp;
                        pb4red.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 5)
                    {
                        pb5red.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb5red);
                        pb5red.MouseDown += PictureBox_MouseDown;
                        pb5red.MouseUp += PictureBox_MouseUp;
                        pb5red.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 6)
                    {
                        pb6red.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb6red);
                        pb6red.MouseDown += PictureBox_MouseDown;
                        pb6red.MouseUp += PictureBox_MouseUp;
                        pb6red.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 7)
                    {
                        pb7red.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb7red);
                        pb7red.MouseDown += PictureBox_MouseDown;
                        pb7red.MouseUp += PictureBox_MouseUp;
                        pb7red.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 8)
                    {
                        pb8red.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb8red);
                        pb8red.MouseDown += PictureBox_MouseDown;
                        pb8red.MouseUp += PictureBox_MouseUp;
                        pb8red.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 9)
                    {
                        pb9red.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb9red);
                        pb9red.MouseDown += PictureBox_MouseDown;
                        pb9red.MouseUp += PictureBox_MouseUp;
                        pb9red.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 10)
                    {
                        pb10red.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb10red);
                        pb10red.MouseDown += PictureBox_MouseDown;
                        pb10red.MouseUp += PictureBox_MouseUp;
                        pb10red.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 11)
                    {
                        pb11red.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb11red);
                        pb11red.MouseDown += PictureBox_MouseDown;
                        pb11red.MouseUp += PictureBox_MouseUp;
                        pb11red.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 12)
                    {
                        pb12red.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb12red);
                        pb12red.MouseDown += PictureBox_MouseDown;
                        pb12red.MouseUp += PictureBox_MouseUp;
                        pb12red.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 13)
                    {
                        pb13red.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb13red);
                        pb13red.MouseDown += PictureBox_MouseDown;
                        pb13red.MouseUp += PictureBox_MouseUp;
                        pb13red.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                }
                if (hand[i].Color == "Yellow")
                {
                    if (hand[i].Value == 1)
                    {
                        pb1yellow.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb1yellow);
                        pb1yellow.MouseDown += PictureBox_MouseDown;
                        pb1yellow.MouseUp += PictureBox_MouseUp;
                        pb1yellow.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 2)
                    {
                        pb2yellow.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb2yellow);
                        pb2yellow.MouseDown += PictureBox_MouseDown;
                        pb2yellow.MouseUp += PictureBox_MouseUp;
                        pb2yellow.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 3)
                    {
                        pb3yellow.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb3yellow);
                        pb3yellow.MouseDown += PictureBox_MouseDown;
                        pb3yellow.MouseUp += PictureBox_MouseUp;
                        pb3yellow.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 4)
                    {
                        pb4yellow.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb4yellow);
                        pb4yellow.MouseDown += PictureBox_MouseDown;
                        pb4yellow.MouseUp += PictureBox_MouseUp;
                        pb4yellow.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 5)
                    {
                        pb5yellow.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb5yellow);
                        pb5yellow.MouseDown += PictureBox_MouseDown;
                        pb5yellow.MouseUp += PictureBox_MouseUp;
                        pb5yellow.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 6)
                    {
                        pb6yellow.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb6yellow);
                        pb6yellow.MouseDown += PictureBox_MouseDown;
                        pb6yellow.MouseUp += PictureBox_MouseUp;
                        pb6yellow.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 7)
                    {
                        pb7yellow.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb7yellow);
                        pb7yellow.MouseDown += PictureBox_MouseDown;
                        pb7yellow.MouseUp += PictureBox_MouseUp;
                        pb7yellow.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 8)
                    {
                        pb8yellow.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb8yellow);
                        pb8yellow.MouseDown += PictureBox_MouseDown;
                        pb8yellow.MouseUp += PictureBox_MouseUp;
                        pb8yellow.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 9)
                    {
                        pb9yellow.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb9yellow);
                        pb9yellow.MouseDown += PictureBox_MouseDown;
                        pb9yellow.MouseUp += PictureBox_MouseUp;
                        pb9yellow.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 10)
                    {
                        pb10yellow.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb10yellow);
                        pb10yellow.MouseDown += PictureBox_MouseDown;
                        pb10yellow.MouseUp += PictureBox_MouseUp;
                        pb10yellow.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 11)
                    {
                        pb11yellow.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb11yellow);
                        pb11yellow.MouseDown += PictureBox_MouseDown;
                        pb11yellow.MouseUp += PictureBox_MouseUp;
                        pb11yellow.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 12)
                    {
                        pb12yellow.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb12yellow);
                        pb12yellow.MouseDown += PictureBox_MouseDown;
                        pb12yellow.MouseUp += PictureBox_MouseUp;
                        pb12yellow.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 13)
                    {
                        pb13yellow.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb13yellow);
                        pb13yellow.MouseDown += PictureBox_MouseDown;
                        pb13yellow.MouseUp += PictureBox_MouseUp;
                        pb13yellow.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                }
                if (hand[i].Color == "Blue")
                {
                    if (hand[i].Value == 1)
                    {
                        pb1blue.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb1blue);
                        pb1blue.MouseDown += PictureBox_MouseDown;
                        pb1blue.MouseUp += PictureBox_MouseUp;
                        pb1blue.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 2)
                    {
                        pb2blue.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb2blue);
                        pb2blue.MouseDown += PictureBox_MouseDown;
                        pb2blue.MouseUp += PictureBox_MouseUp;
                        pb2blue.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 3)
                    {
                        pb3blue.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb3blue);
                        pb3blue.MouseDown += PictureBox_MouseDown;
                        pb3blue.MouseUp += PictureBox_MouseUp;
                        pb3blue.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 4)
                    {
                        pb4blue.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb4blue);
                        pb4blue.MouseDown += PictureBox_MouseDown;
                        pb4blue.MouseUp += PictureBox_MouseUp;
                        pb4blue.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 5)
                    {
                        pb5blue.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb5blue);
                        pb5blue.MouseDown += PictureBox_MouseDown;
                        pb5blue.MouseUp += PictureBox_MouseUp;
                        pb5blue.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 6)
                    {
                        pb6blue.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb6blue);
                        pb6blue.MouseDown += PictureBox_MouseDown;
                        pb6blue.MouseUp += PictureBox_MouseUp;
                        pb6blue.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 7)
                    {
                        pb7blue.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb7blue);
                        pb7blue.MouseDown += PictureBox_MouseDown;
                        pb7blue.MouseUp += PictureBox_MouseUp;
                        pb7blue.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 8)
                    {
                        pb8blue.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb8blue);
                        pb8blue.MouseDown += PictureBox_MouseDown;
                        pb8blue.MouseUp += PictureBox_MouseUp;
                        pb8blue.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 9)
                    {
                        pb9blue.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb9blue);
                        pb9blue.MouseDown += PictureBox_MouseDown;
                        pb9blue.MouseUp += PictureBox_MouseUp;
                        pb9blue.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 10)
                    {
                        pb10blue.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb10blue);
                        pb10blue.MouseDown += PictureBox_MouseDown;
                        pb10blue.MouseUp += PictureBox_MouseUp;
                        pb10blue.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 11)
                    {
                        pb11blue.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb11blue);
                        pb11blue.MouseDown += PictureBox_MouseDown;
                        pb11blue.MouseUp += PictureBox_MouseUp;
                        pb11blue.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 12)
                    {
                        pb12blue.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb12blue);
                        pb12blue.MouseDown += PictureBox_MouseDown;
                        pb12blue.MouseUp += PictureBox_MouseUp;
                        pb12blue.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                    if (hand[i].Value == 13)
                    {
                        pb13blue.Location = new Point(placeX, placeY);
                        this.Controls.Add(pb13blue);
                        pb13blue.MouseDown += PictureBox_MouseDown;
                        pb13blue.MouseUp += PictureBox_MouseUp;
                        pb13blue.MouseMove += PictureBox_MouseMove;
                        placeX += 35;
                    }
                }
            }
        }

        public string GetPictureBoxNameByLocation(Point location)
        {
            foreach (Control control in Controls)
            {
                if (control is PictureBox pictureBox && pictureBox.Location == location)
                {
                    return pictureBox.Name;
                }
            }
            return null;
        }

        private Point _mouseDownLocation;
        private string _pictureBoxName;

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDownLocation = e.Location;
            _pictureBoxName = ((PictureBox)sender).Name;
        }
        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            // Check if the left mouse button is down
            if (e.Button == MouseButtons.Left)
            {
                PictureBox pictureBox = (PictureBox)sender;
                // Calculate the new position of the picture box based on the mouse position and the offset
                int x = pictureBox.Location.X + e.X - _mouseDownLocation.X;
                int y = pictureBox.Location.Y + e.Y - _mouseDownLocation.Y;

                // Move the picture box to the new position
                pictureBox.Location = new Point(x, y);
            }
        }

        private int col;
        private int row;
        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            Point mouseUpLocation = e.Location;
            Point newLocation = ((PictureBox)sender).Location;

            int deltaX = mouseUpLocation.X - _mouseDownLocation.X;
            int deltaY = mouseUpLocation.Y - _mouseDownLocation.Y;

            newLocation.X += deltaX;
            newLocation.Y += deltaY;

            int finalX = newLocation.X + deltaX;
            int finalY = newLocation.Y + deltaY;
            if ((finalY < 300) && (finalY > 15))
            {
                if (finalY / 55 > 3.5)
                {
                    finalY = 225;
                    row = 3;

                }
                else if (finalY / 55 > 2.5)
                {
                    finalY = 170;
                    row = 2;
                }
                else if (finalY / 55 > 1.5)
                {
                    finalY = 115;
                    row = 1;
                }
                else
                {
                    finalY = 60;
                    row = 0;
                }
            }
            if (finalX / 32 < 0.5)
            {
                finalX = 15;
                col = 0;
            }
            else if (finalX / 32 < 1.5)
            {
                finalX = 15 + 32;
                col = 1;
            }
            else if (finalX / 32 < 2.5)
            {
                finalX = 15 + 32 * 2;
                col = 2;
            }
            else if (finalX / 32 < 3.5)
            {
                finalX = 15 + 32 * 3;
                col = 3;
            }
            else if (finalX / 32 < 4.5)
            {
                finalX = 15 + 32 * 4;
                col = 4;
            }
            else if (finalX / 32 < 5.5)
            {
                finalX = 15 + 32 * 5;
                col = 5;
            }
            else if (finalX / 32 < 6.5)
            {
                finalX = 15 + 32 * 6;
                col = 6;
            }
            else if (finalX / 32 < 7.5)
            {
                finalX = 15 + 32 * 7;
                col = 7;
            }
            else if (finalX / 32 < 8.5)
            {
                finalX = 15 + 32 * 8;
                col = 8;
            }
            else if (finalX / 32 < 9.5)
            {
                finalX = 15 + 32 * 9;
                col = 9;
            }
            else if (finalX / 32 < 10.5)
            {
                finalX = 15 + 32 * 10;
                col = 10;
            }
            else if (finalX / 32 < 11.5)
            {
                finalX = 15 + 32 * 11;
                col = 11;
            }
            else if (finalX / 32 < 12.5)
            {
                finalX = 15 + 32 * 12;
                col = 12;
            }
            else if (finalX / 32 < 13.5)
            {
                finalX = 15 + 32 * 13;
                col = 13;
            }
            else if (finalX / 32 < 14.5)
            {
                finalX = 15 + 32 * 14;
                col = 14;
            }
            else if (finalX / 32 < 15.5)
            {
                finalX = 15 + 32 * 15;
                col = 15;
            }
            else if (finalX / 32 < 16.5)
            {
                finalX = 15 + 32 * 16;
                col = 16;
            }
            else if (finalX / 32 < 17.5)
            {
                finalX = 15 + 32 * 17;
                col = 17;
            }
            else if (finalX / 32 < 18.5)
            {
                finalX = 15 + 32 * 18;
                col = 18;
            }
            else if (finalX / 32 < 19.5)
            {
                finalX = 15 + 32 * 19;
                col = 19;
            }
            else if (finalX / 32 < 20.5)
            {
                finalX = 15 + 32 * 20;
                col = 20;
            }
            newLocation.X = finalX;
            newLocation.Y = finalY;

            ((PictureBox)sender).Location = newLocation;
        }




        private void ByColor_Click(object sender, EventArgs e)
        {
            var instance = new GameLogic();
            Tile[] hand = instance.bycolor();
        }

        private void ByNumber_Click(object sender, EventArgs e)
        {
            var instance = new GameLogic();
            Tile[] hand = instance.bynumber();

        }

        private int placeX = 20;
        private void PlusOrCheck_Click(object sender, EventArgs e)
        {
            int placeY = 355;
            var instance = new GameLogic();
            Tile addtile = instance.AddTileToHand();
            if (addtile.Color == "Joker")
            {
                if (addtile.Value == 0)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources.blackjoker;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 1)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources.redjoker;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
            }
            if (addtile.Color == "Black")
            {
                if (addtile.Value == 1)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._1black;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 2)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._2black;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 3)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._3black;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 4)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._4black;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 5)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._5black;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 6)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._6black;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 7)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._7black;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 8)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._8black;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 9)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._9black;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 10)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._10black;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 11)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._11black;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 12)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._12black;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 13)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._13black;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
            }
            if (addtile.Color == "Red")
            {
                if (addtile.Value == 1)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._1red;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 2)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._2red;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 3)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._3red;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 4)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._4red;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 5)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._5red;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 6)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._6red;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 7)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._7red;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 8)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._8red;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 9)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._9red;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 10)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._10red;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 11)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._11red;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 12)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._12red;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 13)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._13red;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
            }
            if (addtile.Color == "Yellow")
            {
                if (addtile.Value == 1)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._1yellow;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 2)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._2yellow;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 3)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._3yellow;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 4)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._4yellow;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 5)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._5yellow;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 6)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._6yellow;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 7)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._7yellow;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 8)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._8yellow;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 9)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._9yellow;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 10)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._10yellow;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 11)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._11yellow;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 12)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._12yellow;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 13)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._13yellow;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
            }
            if (addtile.Color == "Blue")
            {
                if (addtile.Value == 1)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._1blue;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 2)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._2blue;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 3)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._3blue;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 4)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._4blue;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 5)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._5blue;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 6)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._6blue;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 7)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._7blue;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 8)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._8blue;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 9)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._9blue;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 10)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._10blue;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 11)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._11blue;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 12)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._12blue;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
                if (addtile.Value == 13)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(32, 45);
                    pictureBox.Image = Properties.Resources._13blue;
                    pictureBox.Location = new Point(placeX, placeY);
                    this.Controls.Add(pictureBox);
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    placeX += 35;
                }
            }
        }

        private void drawboard()
        {
            const int BOARD_ROWS = 4;
            const int BOARD_COLS = 20;

            // Create the 2D array of labels
            Label[,] boardLabels = new Label[BOARD_ROWS, BOARD_COLS];
            int placeX = 15, placeY = 5;

            // Loop through the rows and columns of the board
            for (int row = 0; row < BOARD_ROWS; row++)
            {
                placeX = 15;
                placeY += 55;
                for (int col = 0; col < BOARD_COLS; col++)
                {
                    // Create a new label for each cell of the board
                    Label label = new Label();

                    // Set the properties of the label (size, location, background color, text, etc.)
                    label.Size = new Size(32, 45); // Example size: 50x50 pixels
                    label.Location = new Point(placeX, placeY); // Example spacing: 50 pixels between cells
                    placeX += 32;
                    label.BackColor = Color.LightBlue; // Example background color: white
                    label.BorderStyle = BorderStyle.FixedSingle; // Example border style: single line
                    label.Text = ""; // Example initial text: empty

                    // Add the label to the board panel control
                    this.Controls.Add(label);

                    // Store the label in the 2D array for future reference
                    boardLabels[row, col] = label;
                }
            }
        }



        private void donebutton_Click_1(object sender, EventArgs e)
        {
            var instance = new GameLogic();
            instance.checkdeck();
            bool flag = instance.CheckLegalDeck();
            if (!flag)
                MessageBox.Show("Something is wrong...");
            else
                MessageBox.Show("Something is right...");
        }
        private void rewindbutton_Click_1(object sender, EventArgs e)
        { 
            var instance = new GameLogic();
            instance.RewindPlay();
        }
        private void CheckGameOver(Tile[] hand, Tile[] AIhand)
        {
            if (hand == null)
                MessageBox.Show("You Won!");
            if (AIhand == null)
                MessageBox.Show("Opponent has won...");
            this.Close();
        }
    }
}
