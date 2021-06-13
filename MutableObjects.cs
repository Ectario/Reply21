using System;
using System.Collections.Generic;

namespace Reply21
{
    public class Grid
    {
        public Grid(int width, int height, int reward, string file)
        {
            this.width = width;
            this.height = height;
            this.reward = reward;
            this.file = file;
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
       
        public string file { get; set; }
    }

    public class Cell
    {
        public Cell(int x, int y)
        {
            this.x = x;
            this.y = y;
            building = null;
            antenna = null;
        }

        public Cell(int x, int y, Building building)
        {
            this.x = x;
            this.y = y;
            this.building = building;
            antenna = null;
        }

        public Cell(int x, int y, Antenna antenna)
        {
            this.x = x;
            this.y = y;
            building = null;
            this.antenna = antenna;
        }

        public Cell(int x, int y, Building building, Antenna antenna)
        {
            this.x = x;
            this.y = y;
            this.building = building;
            this.antenna = antenna;
        }

        public int x { get; set; }
        public int y { get; set; }
        public Building building { get; set; }
        public Antenna antenna { get; set; }
    }

    public class Building
    {
        public Building(int x, int y, int latencyWeight, int connectionSpeedWeight)
        {
            this.x = x;
            this.y = y;
            this.latencyWeight = latencyWeight;
            this.connectionSpeedWeight = connectionSpeedWeight;
        }

        public int x { get; set; }
        public int y { get; set; }

        public int latencyWeight { get; set; }

        public int connectionSpeedWeight { get; set; }
    }

    public class Antenna
    {
        public Antenna(int id, int range, int connectionSpeed)
        {
            this.id = id;
            this.x = 0;
            this.y = 0;
            this.range = range;
            this.connectionSpeed = connectionSpeed;
        }

        public Antenna(int id, int x, int y, int range, int connectionSpeed)
        {
            this.id = id;
            this.x = x;
            this.y = y;
            this.range = range;
            this.connectionSpeed = connectionSpeed;
        }

        public int id { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        public int range { get; set; }
        public int connectionSpeed { get; set; }
    }
}
