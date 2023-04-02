namespace bl.Structures.MultipleAdjacencyList;
public class Node
{
    public Node()
    {
        Successor = null;
        Predecessor = null;
        Next = null;
        Value = string.Empty;
    }

    public string Value { get; set; }
    public Arc Successor { get; set; }
    public Arc Predecessor { get; set; }
    public Node Next { get; set; }
}
