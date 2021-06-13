using System;

namespace Reply21
{
    public class Input
    {
        public Grid GetGrid(string pathToInputFile)
        {
            Grid grid = new Grid(4, 5, 10);
            grid.lstAntenna.Add(new Antenna(0, 5, 2));
            return grid;
        }
    }
}
