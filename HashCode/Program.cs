using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode {
    class Program {
        static void Main(string[] args) {
            var roadMap = CreateMap(5, 6);

            //for (var index0 = 0; index0 < roadMap.GetLength(0); index0++) {
            //    for (var index1 = 0; index1 < roadMap.GetLength(1); index1++) {
            //        var corner = roadMap[index0, index1];
            //        Console.Write($"[{corner.Row},{corner.Column}] ");
            //    }
            //    Console.WriteLine();
            //}
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
        private static void CreateVehicles() {
            List<string> linesFromFile = ReadFromFile().AsEnumerable().ToList();
            int counter = 0;
            while (linesFromFile.Count != 0) {
                string[] firstLineSplited = linesFromFile.First().Split(' ');
            }

        }
        private static string[] ReadFromFile() {
            string[] lines = File.ReadAllLines("C:\\Users\\mscib\\source\\repos\\HashCode\\a_example.in");
            foreach (var line in lines) {
                Console.WriteLine(line);
            }
        }



        private static int PathLength(Corner begin, Corner end)
        {
            return (Math.Abs(begin.Row - end.Row) + Math.Abs(begin.Column - end.Column));
        }
    }
}
