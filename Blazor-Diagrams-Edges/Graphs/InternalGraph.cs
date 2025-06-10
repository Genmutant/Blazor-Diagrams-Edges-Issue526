using Blazor.Diagrams.Core.Geometry;

namespace Graphs;

public record InternalGraph(IList<InternalGraph.Node> Nodes, IList<InternalGraph.Edge> Edges)
{
    public readonly record struct Edge(string Source, string Target);
    
    public sealed class Node
    {
        public required string NodeId { get; init; }
        public required Point Position { get; init; }
        public required Size Size { get; init; }
    }
}