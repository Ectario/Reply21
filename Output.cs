using System;
using System.IO;
using System.Text;

namespace Reply21
{
    public class Output
    {
        public string generateOutput(Grid grid)
        {

            int antennaNumber = grid.lstAntenna.Count;
            StringBuilder outputText = new StringBuilder(antennaNumber.ToString() + "\n");

            foreach (Antenna item in grid.lstAntenna)
            {
                outputText.AppendLine(item.id.ToString() + " " + item.x.ToString() + " " + item.y.ToString());
            }

            string path = Directory.GetCurrentDirectory() + "/output/" + grid.file.ToString() + "_output.in";


            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.Write(outputText);
            }

            return path;
        }
    }
}
