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
            var trip = CreateTrip();
            ReadFromFile();
            Console.ReadKey();
        }

        private static void Calculate()
        {
            /*
                for(int i = 0; i < T; i++)
                {
                    
                }
            */
        }

        static Corner[,] CreateMap(int row, int column) {
            var roadMap = new Corner[row, column];
           
            for (var index0 = 0; index0 < roadMap.GetLength(0); index0++)
            for (var index1 = 0; index1 < roadMap.GetLength(1); index1++) {
                roadMap[index0, index1] = new Corner() {Row = index0, Column = index1};
            }
            return roadMap;
        }
        private static Trip CreateTrip() {
            Trip trip = new Trip();
            FirstLine firstLine = null;
            List<Ride> rides = new List<Ride>();
            List<Trip> trips = new List<Trip>();

            List<string> linesFromFile = ReadFromFile().AsEnumerable().ToList();

            int counter = 0;
            foreach (var line in linesFromFile) {
                
                if (counter == 0) {
                    string[] firstLineSplited = linesFromFile.First().Split(' ');
                    trip.FirstLine = ProcessFirstLine(firstLineSplited);
                    counter++;
                }
                string[] ride = linesFromFile[counter].Split(' ');
                rides.Add(ProcessRide(ride));
            }
            trip.Rides = rides;
            trip.Map = CreateMap(trip.FirstLine.Rows, trip.FirstLine.Columns);
            return trip;
        }

        private static Ride ProcessRide(string[] ride) {
            return new Ride() {
                Start = new Corner() { Row =Int32.Parse(ride[0]), Column = Int32.Parse(ride[1])},
                Stop = new Corner() { Row = Int32.Parse(ride[2]), Column = Int32.Parse(ride[3])},
                Earliest = Int32.Parse(ride[4]),
                Latest = Int32.Parse(ride[5])
            };
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
            return lines;
        }



        private static int PathLength(Corner begin, Corner end)
        {
            return (Math.Abs(begin.Row - end.Row) + Math.Abs(begin.Column - end.Column));
        }
    }
}
