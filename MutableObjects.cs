using System;
using System.Collections.Generic;

namespace Reply21
{
    public class Grid
    {
        public Grid(int width, int height, int reward)
        {
            this.width = width;
            this.height = height;
            this.reward = reward;
            lstBuildings = new List<Building>();
            lstAntenna = new List<Antenna>();
            lstCells = new List<Cell>();
        }
        public int width { get; set; }
        public int height { get; set; }

        public int reward { get; set; }

        public List<Building> lstBuildings { get; set; }

        public List<Antenna> lstAntenna { get; set; }

        public List<Cell> lstCells { get; set; }
    }

    public class Cell
    {
        public int x { get; set; }
        public int y { get; set; }
        public Building building { get; set; }
        public Antenna antenna { get; set; }
    }

    public class Building
    {
        public int x { get; set; }
        public int y { get; set; }

        public int latencyWeight { get; set; }

        public int connectionSpeedWeight { get; set; }
    }

    public class Antenna
    {
        public int id { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        public int range { get; set; }
        public int connectionSpeed { get; set; }
    }
}
