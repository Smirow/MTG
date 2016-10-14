using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Graph;
using GraphAlgorithms;
using Graph.Vertices;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var xml = new XmlDocument();
            xml.Load("g1.xml");

            var graph = GraphFactory.BuildGraph(xml);

            Vertex[,] matriceIncidence = Algorithms.getMatriceIncidence(graph);


            var bfs = Algorithms.BFS(graph, graph.Vertices.First());

            foreach (Vertex l in bfs)
            {
                Console.WriteLine(l);
            }

            /*graph.resetDiscovered();
            var dfs = Algorithms.DFS(graph, graph.Vertices.First());

            graph.resetDiscovered();
            var listeFortementConnexe = Algorithms.Malgrange(graph);

            graph.resetDiscovered();
            var warshall = Algorithms.Warshall(graph);*/

            Console.ReadLine();
        }
    }
}
