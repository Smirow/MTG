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
            // TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// Parcours en profondeur
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="v">sommet d'origine du parcours</param>
        /// <returns>Retourne la liste des sommets dans l'ordre exploré</returns>
        public static IList<Vertex> DFS(IGraph graph, Vertex v)
        {
            // TODO
            throw new NotImplementedException();
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
    }
}
