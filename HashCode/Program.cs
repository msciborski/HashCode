using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode {
    public class Program {
        static void Main(string[] args) {
            var roadMap = CreateMap(5, 6);

            ReadFromFile();
            Console.ReadKey();
        }
        static Corner[,] CreateMap(int row, int column) {
            var roadMap = new Corner[row, column];
           
            for (var index0 = 0; index0 < roadMap.GetLength(0); index0++)
            for (var index1 = 0; index1 < roadMap.GetLength(1); index1++) {
                roadMap[index0, index1] = new Corner() {Row = index0, Column = index1};
            }
            return roadMap;
        }
        private static void CreateVehicles() {
            FirstLine firstLine = null;
            List<Ride> rides = new List<Ride>();
            List<string> linesFromFile = ReadFromFile().AsEnumerable().ToList();

            int counter = 0;
            while (linesFromFile.Count != 0) {
                string[] firstLineSplited = linesFromFile.First().Split(' ');
                linesFromFile.RemoveAt(0);

                counter++;

                firstLine = ProcessFirstLine(firstLineSplited);

                for (int i = 0; i < firstLine.Rides; i++) {
                    string[] ride = linesFromFile.First().Split(' ');
                }
            }

        }
        private static Ride ProcessRide(string[] ride) {
            for(int i = 0; i < ride.Length; i++) {
                if(i+2 == ride.Length) {
                    
                }
            }
        }
        private static FirstLine ProcessFirstLine(string[] firstLine) {
            return new FirstLine() {
                Rows= Int32.Parse(firstLine[0]),
                Columns = Int32.Parse(firstLine[1]),
                Vehicles = Int32.Parse(firstLine[2]),
                Rides = Int32.Parse(firstLine[3]),
                Bonus = Int32.Parse(firstLine[4]),
                Steps = Int32.Parse(firstLine[5])
            };
        }
        private static string[] ReadFromFile() {
            string[] lines = File.ReadAllLines("C:\\Users\\mscib\\source\\repos\\HashCode\\a_example.in");
            foreach (var line in lines) {
                Console.WriteLine(line);
            }
        }

    }
}
