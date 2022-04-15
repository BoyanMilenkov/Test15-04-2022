using System;
using System.Collections.Generic;

namespace FindIfPathExists
{
   
    
    class Program
    {
        private int vertices;
        private List<int>[] adjacents;
        private int exists;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public void Graph(int ver)
        {
            this.vertices = ver;
            adjacents = new List<int>[vertices];
            for (int i = 0; i < vertices ; i++)
            {
                adjacents[i] = new List<int>();
            }
        }
        public void AddEdge(int fV, int sV)
        {
            adjacents[fV].Add(sV);
            adjacents[sV].Add(fV);
        }
        public void Existence(int start, int end)
        {
            bool[] visited = new bool[vertices];
            List<int> exist = new List<int>();

            exist.Add(start);
            int c = 0;
        }
        public void ExistenceSmth(int start, int end, bool[] visited, int count)
        {
            
        }
    }
}
