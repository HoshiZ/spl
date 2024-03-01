using QuickGraph;
using QuickGraph.Algorithms.Observers;
using QuickGraph.Algorithms.ShortestPath;
using SPL.Extensions;
using SPL.Models;
using SPL.Services.IServices;
using System;

namespace SPL.Services
{
    public class GraphService : IGraphService
    {
        public IEnumerable<string> GetPath(string pathA, string pathB)
        {
            var graph = new AdjacencyGraph<Line, Edge<Line>>();

            var line1 = new Line("1", "10001", "0", "0", "0");
            var line2 = new Line("2", "10002", "0", "0", "1");
            var line3 = new Line("3", "10003", "0", "0", "2");
            var line4 = new Line("4", "10004", "0", "0", "3");
            var line5 = new Line("5", "10005", "0", "0", "4");
            var line6 = new Line("6", "10006", "0", "1", "1");
            var line7 = new Line("7", "10007", "0", "2", "1");
            var line8 = new Line("8", "10008", "0", "2", "2");
            var line9 = new Line("9", "10009", "0", "2", "3");
            var line10 = new Line("10", "10010", "0", "1", "3");

            //var lineList = new List<Line>();
            //lineList.Add(line1);
            //lineList.Add(line2);

            graph.AddVertex(line1);
            graph.AddVertex(line2);
            graph.AddVertex(line3);
            graph.AddVertex(line4);
            graph.AddVertex(line5);
            graph.AddVertex(line6);
            graph.AddVertex(line7);
            graph.AddVertex(line8);
            graph.AddVertex(line9);
            graph.AddVertex(line10);
            //graph.AddVertexRange(lineList);

            var line12 = new Edge<Line>(line1, line2);
            var line23 = new Edge<Line>(line2, line3);
            var line34 = new Edge<Line>(line3, line4);
            var line45 = new Edge<Line>(line4, line5);
            var line26 = new Edge<Line>(line2, line6);
            var line67 = new Edge<Line>(line6, line7);
            var line78 = new Edge<Line>(line7, line8);
            var line89 = new Edge<Line>(line8, line9);
            var line910 = new Edge<Line>(line9, line10);
            var line104 = new Edge<Line>(line10, line4);

            graph.AddEdge(line12);
            graph.AddEdge(line23);
            graph.AddEdge(line34);
            graph.AddEdge(line45);
            graph.AddEdge(line26);
            graph.AddEdge(line67);
            graph.AddEdge(line78);
            graph.AddEdge(line89);
            graph.AddEdge(line910);
            graph.AddEdge(line104);

            var edgeCost = new Func<Edge<Line>, double>(e =>
            {
                return 1;
            });

            var dijkstra = new DijkstraShortestPathAlgorithm<Line, Edge<Line>>(graph, edgeCost);
            var observer = new VertexPredecessorPathRecorderObserver<Line, Edge<Line>>();
            using (observer.Attach(dijkstra))
            {
                // 起始点
                dijkstra.Compute(line1);
            }

            // 终止点
            var targetLine = line8;
            List<Line> linePath = new List<Line>();
            var currentLine = targetLine;

            while (currentLine != line1)
            {
                linePath.Add(currentLine);
                Edge<Line> edge;
                if (!observer.VertexPredecessors.TryGetValue(currentLine, out edge))
                    break;

                currentLine = edge.Source;
            }

            linePath.Add(currentLine);
            linePath.Reverse();

            var lineNames = linePath.GetListLineNames();

            return lineNames;
        }
    }
}
