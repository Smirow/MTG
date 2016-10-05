using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Graph;
using Graph.Vertices;

namespace GraphAlgorithms
{
    internal class Helper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vertices1"></param>
        /// <param name="vertices2"></param>
        /// <returns>L'intersection des deux listes</returns>
        public static IList<Vertex> Intersection(IList<Vertex> vertices1, IList<Vertex> vertices2)
        {
            return vertices1.Where((x) => vertices2.Contains(x)).ToList();
        }

        /// <summary>
        /// Retourne la matrice d'adjacence du graphe
        /// </summary>
        /// <param name="graph"></param>
        /// <returns></returns>
        public static bool[,] GetAdjacencyMatrix(IGraph graph)
        {
            bool[,] matrix = new bool[graph.NumberOfVertices, graph.NumberOfVertices];

            for (var i = 0; i < graph.NumberOfVertices; i++)
                for (var j = 0; j < graph.NumberOfVertices; j++)
                    matrix[i, j] = i == j || graph.GetSuccessors(graph.Vertices[i]).Contains(graph.Vertices[j]);

            return matrix;
        }
    }
}
