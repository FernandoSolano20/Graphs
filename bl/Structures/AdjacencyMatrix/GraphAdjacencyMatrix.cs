using System.Text;

namespace bl.Structures.AdjacencyMatrix;
public class GraphAdjacencyMatrix
{
    private string[] _values;
    private int[,] _edges;
    private int _count;
    private int _length;

    public GraphAdjacencyMatrix(int length)
    {
        _values = new string[length];
        _edges = new int[length, length];
        _count = 0;
        _length = length;
    }

    public string Add(string value)
    {
        if (IsFull())
        {
            return "Grafo lleno, no se puede agregar mas";
        }

        _values[_count] = value;
        _count++;
        return "Agregado exitosamente";
    }

    public string AddSuccessor(string predecessorValue, string successorValue, int value)
    {
        var indexPredecessorIndex = GetIndex(predecessorValue);
        var indexSuccessorIndex = GetIndex(successorValue);

        if (indexSuccessorIndex == Int32.MinValue)
        {
            return "El nodo sucesor no se encontro";
        }

        if (indexPredecessorIndex == Int32.MinValue)
        {
            return "El nodo predecesor no se encontro";
        }

        _edges[indexPredecessorIndex, indexSuccessorIndex] = value;
        return "Agregado";
    }

    public string Show()
    {
        var stringBuilder = new StringBuilder();
        for (int i = 0; i < _length; i++)
        {
            if (_values[i] == null)
            {
                break;
            }

            stringBuilder.Append($"Valor: {_values[i]},");
            stringBuilder.Append(" Arcos: ");
            for (int j = 0; j < _length; j++)
            {
                if (_edges[i, j] != 0)
                {
                    stringBuilder.Append($"(Nodo:{_values[j]}, Valor:{_edges[i, j]}); ");
                }
            }
            stringBuilder.Append("\n");
        }

        return stringBuilder.ToString();
    }

    private bool IsFull()
    {
        return _length <= _count;
    }

    private int GetIndex(string value)
    {
        var index = Int32.MinValue;
        for (var i = 0; i < _length; i++)
        {
            if (_values[i] != value)
            {
                continue;
            }

            index = i;
            break;
        }

        return index;
    }
}
