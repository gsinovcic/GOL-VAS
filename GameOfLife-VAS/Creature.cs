using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife_VAS
{
    public class Creature
    {
        //stanje jedinke
        public int ziv { get; set; }
        //broj susjeda jedinke
        public int brSusjeda { get; set; }
        //lokacija jedinke
        public int[] lokacija { get; set; }
        //koliko generacija je preživjela
        public int starost { get; set; }

        public void NadiSusjede(Creature[,] creatures,int gridSize)
        {
            
            brSusjeda = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    brSusjeda += creatures[(lokacija[0] + i + gridSize) % gridSize, (lokacija[1] + j + gridSize) % gridSize].ziv;
                }
            }
            brSusjeda -= creatures[lokacija[0], lokacija[1]].ziv;
        }
    }
}
