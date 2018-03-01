using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode {
    public class Vertex<T> {
        private T data;
        private LinkedList<Vertex<T>> neighbors;
    }
 }
