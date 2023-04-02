using System.Text;

namespace bl.Structures.MultipleAdjacencyList;
public class GraphMultipleAdjacencyList
{
    private Node _root { get; set; }

    public GraphMultipleAdjacencyList()
    {
        _root = null;
    }

    public void Add(string value)
    {
        if (_root == null)
        {
            _root = new Node()
            {
                Value = value,
            };
        }
        else
        {
            var aux = _root;
            while (aux.Next != null)
            {
                aux = aux.Next;
            }

            aux.Next = new Node()
            {
                Value = value,
            };
        }
    }

    public string AddSuccessor(Node nodePredecessor, Node nodeSuccessor, int value)
    {
        if (nodePredecessor.Successor == null)
        {
            nodePredecessor.Successor = new Arc()
            {
                Value = value,
                Node = nodeSuccessor
            };
        }
        else
        {
            var aux = nodePredecessor.Successor;
            while (aux.Next != null)
            {
                aux = aux.Next;
            }

            aux.Next = new Arc()
            {
                Value = value,
                Node = nodeSuccessor
            };
        }

        return "Agregado exitosamente";
    }

    public string AddPredecessor(Node nodeSuccessor, Node nodePredecessor, int value)
    {
        if (nodeSuccessor.Predecessor == null)
        {
            nodeSuccessor.Predecessor = new Arc()
            {
                Value = value,
                Node = nodePredecessor
            };
        }
        else
        {
            var aux = nodeSuccessor.Predecessor;
            while (aux.Next != null)
            {
                aux = aux.Next;
            }

            aux.Next = new Arc()
            {
                Value = value,
                Node = nodePredecessor
            };
        }

        return "Agregado exitosamente";
    }

    public Node FindNodeByValue(string value)
    {
        var aux = _root;
        while (aux != null)
        {
            if (aux.Value == value)
            {
                break;
            }
            aux = aux.Next;
        }

        return aux;
    }

    public string Show()
    {
        var stringBuilder = new StringBuilder();
        var aux = _root;
        while (aux != null)
        {
            stringBuilder.Append($"Valor: {aux.Value},");
            stringBuilder.Append(" Arcos: ");
            var adjacencies = aux.Successor;
            while (adjacencies != null)
            {
                stringBuilder.Append($"(Nodo:{adjacencies.Node.Value}, Valor:{adjacencies.Value}); ");
                adjacencies = adjacencies.Next;
            }
            stringBuilder.Append("\n");
            aux = aux.Next;
        }

        return stringBuilder.ToString();
    }
}
