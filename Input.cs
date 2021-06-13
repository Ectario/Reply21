using System;
using System.Linq;

namespace Reply21
{
    public class Input
    {
        public Grid GetGrid(string pathToInputFile)
        {
            // Get lines from the file
            string[] lines = System.IO.File.ReadAllLines(pathToInputFile);

            // Extract info first line
            int width = int.Parse(lines[0].Split(' ')[0]);
            int height = int.Parse(lines[0].Split(' ')[1]);

            // Extract info second line
            int nBuildings = int.Parse(lines[1].Split(' ')[0]);
            int nAntennas = int.Parse(lines[1].Split(' ')[1]);
            int reward = int.Parse(lines[1].Split(' ')[2]);

            Grid grid = new Grid(width, height, reward, pathToInputFile.Split('/')[2]);

            // Extract buildings
            for (int i = 0; i < nBuildings; i++)
            {
                string[] line = lines[2 + i].Split(' ');
                int x = int.Parse(line[0]);
                int y = int.Parse(line[1]);
                Building temp = new Building(i, x, y, int.Parse(line[2]), int.Parse(line[3]));
                grid.lstBuildings.Add(temp);
                grid.lstCells.Add(new Cell(x, y, grid.lstBuildings[i]));
            }

            // Extract Antennas
            for (int i = 0; i < nAntennas; i++)
            {
                string[] line = lines[2 + nBuildings + i].Split(' ');
                grid.lstAntenna.Add(new Antenna(i, int.Parse(line[0]), int.Parse(line[1])));
            }

            return grid;
        }
    }
}
