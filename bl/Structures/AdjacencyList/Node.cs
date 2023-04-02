namespace bl.Structures.AdjacencyList;
public class Node
{
    public Node()
    {
        Adjacency = null;
        Next = null;
        Value = string.Empty;
    }

    public string Value { get; set; }
    public Arc Adjacency { get; set; }
    public Node Next { get; set; }
}
