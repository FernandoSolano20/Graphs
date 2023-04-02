using bl;
using bl.Structures.AdjacencyList;
using bl.Structures.AdjacencyMatrix;

namespace dl;
public class Controller
{
    private readonly Business _bl;
    public Controller()
    {
        _bl = new Business();
    }

    public void AddInMultipleAdjacencyList(string value)
    {
        _bl.AddInMultipleAdjacencyList(value);
    }

    public string AddArcInMultipleAdjacencyList(string predecessorValue, string successorValue, int value)
    {
        return _bl.AddArcInMultipleAdjacencyList(predecessorValue, successorValue, value);
    }

    public string ShowMultipleAdjacencyList()
    {
        return _bl.ShowMultipleAdjacencyList();
    }

    public void AddInAdjacencyList(string value)
    {
        _bl.AddInAdjacencyList(value);
    }

    public string AddArcInAdjacencyList(string predecessorValue, string successorValue, int value)
    {
        return _bl.AddArcInAdjacencyList(predecessorValue, successorValue, value);
    }

    public string ShowAdjacencyList()
    {
        return _bl.ShowAdjacencyList();
    }

    public string AddInAdjacencyMatrix(string value)
    {
        return _bl.AddInAdjacencyMatrix(value);
    }

    public string AddArcInAdjacencyMatrix(string predecessorValue, string successorValue, int value)
    {
        return _bl.AddArcInAdjacencyMatrix(predecessorValue, successorValue, value);
    }

    public string ShowAdjacencyMatrix()
    {
        return _bl.ShowAdjacencyMatrix();
    }
}