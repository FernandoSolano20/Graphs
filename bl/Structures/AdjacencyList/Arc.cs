namespace bl.Structures.AdjacencyList;
public class Arc
{
    public Arc()
    {
        Node = null;
        Next = null;
        Value = 0;
    }

    public int Value { get; set; }
    public Node Node { get; set; }
    public Arc Next { get; set; }
}
