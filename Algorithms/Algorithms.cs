using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Graph;
using Graph.Vertices;

namespace GraphAlgorithms
{
    public static class Algorithms
    {
        /// <summary>
        /// Parcours en largeur
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="v">sommet d'origine du parcours</param>
        /// <returns>Retourne la liste des sommets dans l'ordre exploré</returns>
        public static IList<Vertex> BFS(IGraph graph, Vertex v)
        {

            IList<Vertex> res = new List<Vertex>();
            int nbVertices = graph.NumberOfVertices;
            int nbVerticesDiscovered = 0;

            v.IsDiscovered = true;
            nbVerticesDiscovered+=1;

            res.Add(v);


            List<Vertex> lastFloor = new List<Vertex>();

            lastFloor.Add(v);

            Console.WriteLine("-------------------------------"+ '\n');
            Console.WriteLine("BFS : ");

            for(int j=0;j<lastFloor.Count;j++)                      
            {
                Vertex ver = lastFloor[j];
                Vertex[] next = graph.GetSuccessors(ver).ToArray();

                for (int i = 0;i< next.Length;i++)
                {
                    if (next[i].IsDiscovered == false)
                    {
                        res.Add(next[i]);
                        lastFloor.Add(next[i]);
                        next[i].IsDiscovered = true;
                        nbVerticesDiscovered += 1;

                    }
                }
                
            }


            return res;
            
        }

        /// <summary>
        /// Parcours en profondeur
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="v">sommet d'origine du parcours</param>
        /// <returns>Retourne la liste des sommets dans l'ordre exploré</returns>
        public static IList<Vertex> DFS(IGraph graph, Vertex v)
        {
            IList<Vertex> res = new List<Vertex>();
            int nbVertices = graph.NumberOfVertices;
            int nbVerticesDiscovered = 0;

            v.IsDiscovered = true;
            nbVerticesDiscovered += 1;

            res.Add(v);


            List<Vertex> lastFloor = new List<Vertex>();

            lastFloor.Add(v);

            Console.WriteLine("-------------------------------" + '\n');
            Console.WriteLine("DFS : ");
            Console.WriteLine(res.Last() + " a été ajouté");


            while (nbVerticesDiscovered < nbVertices)
            {
                foreach(Vertex ver in lastFloor)
                {

                }


            }

            return res;
        }

        /// <summary>
        /// Liste des composantes fortements connexes
        /// </summary>
        /// <param name="graph"></param>
        /// <returns>Une liste de liste de sommets connexes</returns>
        public static IList<IList<Vertex>> Malgrange(IGraph graph)
        {
            // TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calcul la fermeture transitive
        /// </summary>
        /// <param name="ajdacentMatrix"></param>
        /// <returns>Fermeture transitive</returns>
        public static bool[,] Warshall(IGraph graph)
        {
            // TODO
            throw new NotImplementedException();
        }


        public static Vertex[,] getMatriceIncidence(IGraph graph)
        {

            int nbEdges = graph.NumberOfEdges;
            Vertex[,] res = new Vertex[(nbEdges+1)*2, 2];


            if (graph.IsOriented)
            {
                for (int i = 0; i < nbEdges; i++)
                {
                    int nbEdgesAdded = 0;
                    foreach (Vertex vDebut in graph.Vertices)
                    {

                        foreach (Vertex vFin in graph.GetSuccessors(vDebut))
                        {
                            res[nbEdgesAdded, 0] = vDebut;
                            res[nbEdgesAdded, 1] = vFin;
                            nbEdgesAdded = nbEdgesAdded + 1;
                        }
                    }
                }
            }
            else
            {
                for(int i=0;i<nbEdges;i++)
                {
                    int nbEdgesAdded = 0;
                    foreach(Vertex vDebut in graph.Vertices)
                    {

                        foreach (Vertex vFin in graph.GetSuccessors(vDebut))
                        {
                            res[nbEdgesAdded, 0] = vDebut;
                            res[nbEdgesAdded, 1] = vFin;
                            nbEdgesAdded = nbEdgesAdded + 1;
                        }
                    }
                }
            }

            return res;
        }
    }
}
