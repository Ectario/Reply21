using System;

namespace Reply21
{
    class Program
    {
        static void Main(string[] args)
        {

            Input input = new Input();
            Output output = new Output();

            Grid grid = input.GetGrid("./scenarios/a_example.in");

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
                cptBuilding++;
            }

            string pathOutput = output.generateOutput(grid);
            Console.WriteLine("Ouput generated in file : " + pathOutput);

        }
    }
}
