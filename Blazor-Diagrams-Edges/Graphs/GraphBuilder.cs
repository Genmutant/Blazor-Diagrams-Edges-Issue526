namespace Graphs;

public static class GraphBuilder
{
  public static InternalGraph BuildGraph()
  {
    var nodes = new InternalGraph.Node[]
    {
      new() {
        NodeId = "34b025a7",
        Position = new(660, 0),
        Size = new(120, 80)
      },
      new() {
        NodeId = "d5ee4b5a",
        Position = new(60, -135),
        Size = new(120, 80)
      },
      new() {
        NodeId = "bbe5775c",
        Position = new(210, 0),
        Size = new(120, 80)
      },
      new() {
        NodeId = "f7756b82",
        Position = new(510, 0),
        Size = new(120, 80)
      },
      new() {
        NodeId = "fbd6ed74",
        Position = new(360, -67.5),
        Size = new(120, 80)
      },
      new() {
        NodeId = "d3294257",
        Position = new(360, 135),
        Size = new(120, 80)
      },
      new() {
        NodeId = "c52eca4a",
        Position = new(210, 135),
        Size = new(120, 80)
      },
      new() {
        NodeId = "7bd9a5b3",
        Position = new(210, -135),
        Size = new(120, 80)
      }
    };

    var edges = new InternalGraph.Edge[]
    {
      new("d5ee4b5a", "7bd9a5b3"),
      new("bbe5775c", "fbd6ed74"),
      new("f7756b82", "34b025a7"),
      new("fbd6ed74", "f7756b82"),
      new("d3294257", "f7756b82"),
      new("c52eca4a", "d3294257"),
      new("7bd9a5b3", "fbd6ed74")
    };
    return new InternalGraph(nodes, edges);
  }
}