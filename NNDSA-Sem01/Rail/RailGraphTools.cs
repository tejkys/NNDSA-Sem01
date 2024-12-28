using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace NNDSA_Sem01.Rail
{
    public class RailGraphTools
    {
        private readonly Graph<RailStop, NNDSA_Sem01.Rail.Rail> _graph;

        public RailGraphTools(Graph<RailStop, Rail> graph)
        {
            _graph = graph;
        }

        public class DijkstraResult
        {
            public Dictionary<RailStop, double> Distances { get; set; } = new();
            public Dictionary<RailStop, RailStop> Previous { get; set; } = new();
            public Dictionary<Tuple<RailStop, RailStop>, Path> Maneuvers { get; set; } = new();

        }
        public DijkstraResult FindPath(RailStop from, double trainLength)
        {
            PriorityQueue<Tuple<Rail,RailStop>, double> toVisit = new();
            toVisit.Enqueue(new(null, from), 0);
            foreach (var edge in _graph.GetSucceedingEdges(from))
            {
                toVisit.Enqueue(new(edge, _graph.GetDestinationVertex(from, edge)), edge.Length);
            }
            HashSet<RailStop> visited = new() { };
            DijkstraResult result = new();

            foreach (var vertex in _graph.GetVertexes())
            {
                result.Distances[vertex] = vertex == from ? 0 : double.PositiveInfinity;
                result.Previous[vertex] = null;
            }
            while (toVisit.TryDequeue(out var vertexAndPreviousEdge, out double distance))
            {
                visited.Add(vertexAndPreviousEdge.Item2);
                foreach (var edge in _graph.GetSucceedingEdges(vertexAndPreviousEdge.Item2))
                {
                    bool switching = false;
                    Path? maneuverPath = null;

                    if (!visited.Contains(_graph.GetDestinationVertex(vertexAndPreviousEdge.Item2, edge)) && !edge.Blocked)
                    {
                        if (edge.Type == TrailType.Switching && vertexAndPreviousEdge.Item1?.Type == TrailType.Switching )
                        {
                            switching = true;

                            var initPath = new Path()
                            {
                                LastVertex = vertexAndPreviousEdge.Item2,
                                ForbiddenRails = new(){edge, vertexAndPreviousEdge.Item1}
                            };
                            maneuverPath = FindSwitchingManeuver(initPath, trainLength);

                        }
                        if(!switching || (switching && maneuverPath is not null))
                        {
                            toVisit.Enqueue(new(edge, _graph.GetDestinationVertex(vertexAndPreviousEdge.Item2, edge)), edge.Length + distance);
                            if (edge.Length + distance < result.Distances[_graph.GetDestinationVertex(vertexAndPreviousEdge.Item2, edge)])
                            {
                                result.Distances[_graph.GetDestinationVertex(vertexAndPreviousEdge.Item2, edge)] = distance + edge.Length;
                                result.Previous[_graph.GetDestinationVertex(vertexAndPreviousEdge.Item2, edge)] = vertexAndPreviousEdge.Item2;

                                result.Maneuvers[new(vertexAndPreviousEdge.Item2, _graph.GetDestinationVertex(vertexAndPreviousEdge.Item2, edge))] = maneuverPath;

                            }
                        }
                    }
                }
            }

            return result;
        }

        public Path? FindSwitchingManeuver(Path initPath, double trainLength)
        {
            var successors = new Stack<Path>();
            HashSet<Path> visited = new() { };
            successors.Push(initPath);
            while (successors.Count != 0)
            {
                Path currentPath = successors.Pop();
                if (!visited.Contains(currentPath))
                {
                    foreach (var nextEdge in _graph.GetSucceedingEdges(currentPath.LastVertex).Except(currentPath.ForbiddenRails))
                    {
                        if (!currentPath.Edges.Contains(nextEdge))
                        {
                            //Not able to move over switching rails
                            if (nextEdge.Type == TrailType.Switching &&
                                currentPath.Edges.LastOrDefault()?.Type == TrailType.Switching)
                            {
                                continue;
                            }

                            var newPath = new Path()
                            {
                                LastVertex = _graph.GetDestinationVertex(currentPath.LastVertex, nextEdge),
                                Length = currentPath.Length + (!nextEdge.Blocked ? nextEdge.Length : (_graph.GetEdgeStartVertex(nextEdge).Id == currentPath.LastVertex.Id ? nextEdge.StartFreeSpace : nextEdge.EndFreeSpace)),
                                Edges = currentPath.Edges.ToList(),
                                ForbiddenRails = currentPath.ForbiddenRails.ToList(),
                            };
                            newPath.Edges.Add(nextEdge);

                            if (newPath.Length >= trainLength)
                                return newPath;
                                
                            if(!nextEdge.Blocked)
                                successors.Push(newPath);
                            

                        }
                    }
                }
            }
            return null;
        }
        public class Path
        {
            public List<Rail> ForbiddenRails = new();
            public List<Rail> Edges { get; set; } = new();
            public double Length { get; set; } = 0;
            public RailStop LastVertex { get; set; }

            protected bool Equals(Path other)
            {
                return Edges.SequenceEqual(other.Edges);
            }

            public override bool Equals(object? obj)
            {
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != this.GetType()) return false;
                return Equals((Path)obj);
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    int hash = 19;
                    foreach (var edge in Edges)
                    {
                        hash = hash * 31 + edge.GetHashCode();
                    }
                    return hash;
                }
            }
        }
    }
}
