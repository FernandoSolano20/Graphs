using bl.Structures.AdjacencyList;
using bl.Structures.AdjacencyMatrix;
using bl.Structures.MultipleAdjacencyList;

namespace bl;
public class Business
{
    private readonly GraphMultipleAdjacencyList _graphMultipleAdjacencyList;
    private readonly GraphAdjacencyList _graphAdjacencyList;
    private readonly GraphAdjacencyMatrix _graphAdjacencyMatrix;

    public Business()
    {
        _graphMultipleAdjacencyList = new GraphMultipleAdjacencyList();
        _graphAdjacencyList = new GraphAdjacencyList();
        _graphAdjacencyMatrix = new GraphAdjacencyMatrix(8);
    }

    public void AddInMultipleAdjacencyList(string value)
    {
        _graphMultipleAdjacencyList.Add(value);
    }

    public string AddArcInMultipleAdjacencyList(string predecessorValue, string successorValue, int value)
    {
        var nodePredecessor = _graphMultipleAdjacencyList.FindNodeByValue(predecessorValue);
        var nodeSuccessor = _graphMultipleAdjacencyList.FindNodeByValue(successorValue);
        if (nodeSuccessor == null)
        {
            return "El nodo sucesor no se encontro";
        }

        if (nodePredecessor == null)
        {
            return "El nodo predecesor no se encontro";
        }

        _graphMultipleAdjacencyList.AddSuccessor(nodePredecessor, nodeSuccessor, value);
        return _graphMultipleAdjacencyList.AddPredecessor(nodeSuccessor, nodePredecessor, value);
    }

    public string ShowMultipleAdjacencyList()
    {
        return _graphMultipleAdjacencyList.Show();
    }

    public void AddInAdjacencyList(string value)
    {
        _graphAdjacencyList.Add(value);
    }

    public string AddArcInAdjacencyList(string predecessorValue, string successorValue, int value)
    {
        var nodePredecessor = _graphAdjacencyList.FindNodeByValue(predecessorValue);
        var nodeSuccessor = _graphAdjacencyList.FindNodeByValue(successorValue);
        if (nodeSuccessor == null)
        {
            return "El nodo sucesor no se encontro";
        }

        if (nodePredecessor == null)
        {
            return "El nodo predecesor no se encontro";
        }

        return _graphAdjacencyList.AddSuccessor(nodePredecessor, nodeSuccessor, value);
    }

    public string ShowAdjacencyList()
    {
        return _graphAdjacencyList.Show();
    }

    public string AddInAdjacencyMatrix(string value)
    {
        return _graphAdjacencyMatrix.Add(value);
    }

    public string AddArcInAdjacencyMatrix(string predecessorValue, string successorValue, int value)
    {
        return _graphAdjacencyMatrix.AddSuccessor(predecessorValue, successorValue, value);
    }

    public string ShowAdjacencyMatrix()
    {
        return _graphAdjacencyMatrix.Show();
    }
}