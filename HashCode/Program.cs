using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode {
    class Program {
        static void Main(string[] args) {
            var roadMap = CreateMap(5, 6);

            for (var index0 = 0; index0 < roadMap.GetLength(0); index0++) {
                for (var index1 = 0; index1 < roadMap.GetLength(1); index1++) {
                    var corner = roadMap[index0, index1];
                    Console.Write($"[{corner.Row},{corner.Column}] ");
                }
                Console.WriteLine();
            }

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

    }
}
