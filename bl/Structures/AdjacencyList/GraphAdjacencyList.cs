using System.Text;

namespace bl.Structures.AdjacencyList;
public class GraphAdjacencyList
{
    private Node _root { get; set; }

    public GraphAdjacencyList()
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
        if (nodePredecessor.Adjacency == null)
        {
            nodePredecessor.Adjacency = new Arc()
            {
                Value = value,
                Node = new Node()
                {
                    Value = nodeSuccessor.Value
                }
            };
        }
        else
        {
            var aux = nodePredecessor.Adjacency;
            while (aux.Next != null)
            {
                aux = aux.Next;
            }

            aux.Next = new Arc()
            {
                Value = value,
                Node = new Node()
                {
                    Value = nodeSuccessor.Value
                }
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
            var adjacencies = aux.Adjacency;
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
