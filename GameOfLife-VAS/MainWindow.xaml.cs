using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace GameOfLife_VAS
{
    public partial class MainWindow : Window
    {
        public const int gridSize = 50;

        Uri uriSource = new Uri("/Kuca.png", UriKind.Relative);
        Random RNG = new Random();
        DispatcherTimer timer = new DispatcherTimer();
        Image[,] polja = new Image[gridSize, gridSize];
        Creature[,] creatures = new Creature[gridSize, gridSize];
        public MainWindow()
        {
            InitializeComponent();

            kuca.Source = new BitmapImage(uriSource);
            grid.Arrange(new Rect(0.0, 0.0, grid.DesiredSize.Width, grid.DesiredSize.Height));

            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    var rand = RNG.Next(0, 2) == 1;
                    Image img = new Image();
                    Creature c = new Creature();
                    img.Width = grid.ActualWidth / gridSize;
                    img.Height = grid.ActualHeight / gridSize;
                    img.Source = rand ? new BitmapImage(uriSource) : null;
                    c.ziv = rand ? 0 : 1;
                    c.lokacija = new int[] { i, j };
                    polja[i, j] = img;
                    creatures[i, j] = c;
                    Canvas.SetTop(img, i * grid.ActualHeight / gridSize);
                    Canvas.SetLeft(img, j * grid.ActualWidth / gridSize);
                    grid.Children.Add(img);
                }
            }
            timer.Start();
            timer.Tick += Next_gen;
        }

        int[] maxLoc;
        int brojGen;

        private void Next_gen(object sender, EventArgs e)
        {
            int maxStarost = 0;
            int trZivih = 0;
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    creatures[i, j].NadiSusjede(creatures, gridSize);
                }
            }

            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    if (creatures[i, j].brSusjeda < 2 || creatures[i, j].brSusjeda > 3)
                    {
                        creatures[i, j].ziv = 0;
                        creatures[i, j].starost = 0;
                        polja[i, j].Source = null;

                    }
                    else if (creatures[i, j].brSusjeda == 3)
                    {

                        creatures[i, j].ziv = 1;
                        creatures[i, j].starost++;
                        polja[i, j].Source = new BitmapImage(uriSource);
                        trZivih++;
                    }
                    if (creatures[i, j].starost >= maxStarost)
                    {
                        maxStarost = creatures[i, j].starost;
                        maxLoc = new int[] { i, j };
                    }

                }
            }
            curGen.Content = "Trenutna generacija: " + brojGen++;
            starostLbl.Content = maxStarost.ToString()+" generacija.";
            aliveLbl.Content = "Trenutno živih agenata: " + trZivih;
            polja[maxLoc[0], maxLoc[1]].Source = new BitmapImage(new Uri("/Kuca_crvena.png", UriKind.Relative));
            Thread.Sleep(100);

        }

       
    }
}
