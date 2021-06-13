using System;

namespace Reply21
{
    class Program
    {
        static void Main(string[] args)
        {

            //Test output
            Console.WriteLine("Text :\n");
            Input input = new Input();

            Output output = new Output();

            Grid grid = input.GetGrid("");

            grid.lstAntenna[0].x = 6;
            grid.lstAntenna[0].y = 19;

            grid.lstAntenna.Add(new Antenna(1, 12, 34));
            grid.lstAntenna.Add(new Antenna(2, 32, 14));
            grid.lstAntenna.Add(new Antenna(3, 2, 4));

            int cptBuilding = 0;
            foreach (Building building in grid.lstBuildings)
            {
                if (cptBuilding < grid.lstAntenna.Count)
                {
                    Antenna antenna = grid.lstAntenna[cptBuilding];
                    antenna.x = building.x;
                    antenna.y = building.y;
                }
                else break;
            }


            grid.file = "";
            string pathOutput = output.generateOutput(grid);

            Console.WriteLine("Ouput generated in file : " + pathOutput);
            //End test output

        }
    }
}
