using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace NNDSA_Sem01
{
    public interface IGraphElement
    {
        public string Id { get; }
    }
    [DataContract]
    public class Graph<V, E> where V: IGraphElement where E: IGraphElement
    {
        [DataMember]
        private Dictionary<string,Vertex> _vertices = new();
        [DataMember]
        private Dictionary<string, Edge> _edges = new();

        [DataContract]
        private class Vertex
        {
            [DisplayName("Data")]
            [Description("Associated object with the edge")]
            [DataMember] public V Data { get; set; }
            [DataMember] public List<string> IncidentEdges = new();

        }
        [DataContract]
        private class Edge
        {
            [DisplayName("Data")]
            [Description("Associated object with the edge")]
            [DataMember] public E Data { get; set; }
            [DataMember] public Vertex Start { get; set; }
            [DataMember] public Vertex End { get; set; }
        }

        public V? FindVertex(string hashCode)
        {
            return _vertices.ContainsKey(hashCode) ? _vertices[hashCode].Data : default;
        }
        public E? FindEdge(string hashCode) 
        {
            return _edges.ContainsKey(hashCode) ? _edges[hashCode].Data : default;
        }
        public void InsertEdge(E data, V start, V end){
            if (data is null)
                throw new ArgumentException("Data can not be null");
            
            var startVertex = _vertices.Values.FirstOrDefault(v => v.Data.Id == start.Id);
            var endVertex = _vertices.Values.FirstOrDefault(v => v.Data.Id == end.Id);
            
            if (startVertex is null || endVertex is null)
                throw new ArgumentException("One of the vertices does not exist");

            var edge = new Edge()
            {
                Data = data,
                Start = startVertex,
                End = endVertex
            };

            edge.Start.IncidentEdges.Add(data.Id);
            edge.End.IncidentEdges.Add(data.Id);

            _edges.Add(data.Id, edge);
        }
        public void InsertVertex(V data)
        {
            if (data is null)
                throw new ArgumentException("Data can not be null");

            _vertices.Add(data.Id, new Vertex() { Data = data });
        }
        public void RemoveEdge(E data)
        {
            if (data is null)
                throw new ArgumentException("Data can not be null");
            
            var edge = _edges.First(v => v.Value.Data.Id == data.Id);

            edge.Value.Start.IncidentEdges.Remove(edge.Key);
            edge.Value.End.IncidentEdges.Remove(edge.Key);

            _edges.Remove(edge.Key);
        }
        public void RemoveVertex(V data)
        {
            if (data is null)
                throw new ArgumentException("Data can not be null");
            
            foreach (var edge in _edges.ToDictionary(e=> e.Key, e=> e.Value).Where(edge => edge.Value.Start.Data.Id == data.Id || edge.Value.End.Data.Id == data.Id))
            {
                edge.Value.Start.IncidentEdges.Remove(edge.Key);
                edge.Value.End.IncidentEdges.Remove(edge.Key);
                _edges.Remove(edge.Key);
            }
            var vertex = _vertices.First(v => v.Value.Data.Id == data.Id);
            _vertices.Remove(vertex.Key);
        }
        public List<V> GetVertexes() { 
            return _vertices.Values.Select(v=>v.Data).ToList();
        }
        public List<E> GetEdges()
        {
            return _edges.Values.Select(e => e.Data).ToList();
        }
        public List<E?> GetSucceedingEdges(V vertex)
        {
            if (vertex is null || !_vertices.ContainsKey(vertex.Id))
                throw new ArgumentException("Data can not be null");

            return _vertices[vertex.Id].IncidentEdges.Select(FindEdge).ToList();
        }
        public V GetDestinationVertex(V from, E edge)
        {
            if (from is null || edge is null || !_edges.ContainsKey(edge.Id))
                throw new ArgumentException("Arguments can not be empty");
            return _edges[edge.Id].Start.Data.Id == from.Id ? _edges[edge.Id].End.Data : _edges[edge.Id].Start.Data;
        }

        public V GetEdgeStartVertex(E edge)
        {
            return _edges[edge.Id].Start.Data;
        }
        public V GetEdgeEndVertex(E edge)
        {
            return _edges[edge.Id].End.Data;
        }
    }
}
