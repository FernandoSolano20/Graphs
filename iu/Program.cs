using dl;

var controller = new Controller();
var option = 0;
var predecessorValue = string.Empty;
var successorValue = string.Empty;
var value = 0;

do
{
    Console.WriteLine("Escoga una opcion:");
    Console.WriteLine("1- Agregar elemento grafo de matriz de adyacencia");
    Console.WriteLine("2- Agregar arco grafo de matriz de adyacencia");
    Console.WriteLine("3- Mostrar grafo de matriz de adyacencia");
    Console.WriteLine("4- Agregar elemento grafo de lista de adyacencia");
    Console.WriteLine("5- Agregar arco grafo de lista de adyacencia");
    Console.WriteLine("6- Mostrar grafo de lista de adyacencia");
    Console.WriteLine("7- Agregar elemento grafo de lista encadenada múltiple de adyacencia");
    Console.WriteLine("8- Agregar arco grafo de lista encadenada múltiple de adyacencia");
    Console.WriteLine("9- Mostrar grafo de lista encadenada múltiple de adyacencia");
    Console.WriteLine("10- Salir");
    option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.WriteLine("Digite el valor");
            Console.WriteLine(controller.AddInAdjacencyMatrix(ReadValue()));
            break;

        case 2:
            Console.WriteLine("Digite el predecesor");
            predecessorValue = ReadValue();
            Console.WriteLine("Digite el antecesor");
            successorValue = ReadValue();
            Console.WriteLine("Digite el valor");
            value = ReadNumber();
            Console.WriteLine(controller.AddArcInAdjacencyMatrix(predecessorValue, successorValue, value));
            break;

        case 3:
            Console.WriteLine(controller.ShowAdjacencyMatrix());
            break;

        case 4:
            Console.WriteLine("Digite el valor");
            controller.AddInAdjacencyList(ReadValue());
            break;

        case 5:
            Console.WriteLine("Digite el predecesor");
            predecessorValue = ReadValue();
            Console.WriteLine("Digite el antecesor");
            successorValue = ReadValue();
            Console.WriteLine("Digite el valor");
            value = ReadNumber();
            Console.WriteLine(controller.AddArcInAdjacencyList(predecessorValue, successorValue, value));
            break;

        case 6:
            Console.WriteLine(controller.ShowAdjacencyList());
            break;

        case 7:
            Console.WriteLine("Digite el valor");
            controller.AddInMultipleAdjacencyList(ReadValue());
            break;

        case 8:
            Console.WriteLine("Digite el predecesor");
            predecessorValue = ReadValue();
            Console.WriteLine("Digite el antecesor");
            successorValue = ReadValue();
            Console.WriteLine("Digite el valor");
            value = ReadNumber();
            Console.WriteLine(controller.AddArcInMultipleAdjacencyList(predecessorValue, successorValue, value));
            break;

        case 9:
            Console.WriteLine(controller.ShowMultipleAdjacencyList());
            break;

        case 10:
            Console.WriteLine("Adios");
            break;

        default:
            Console.WriteLine("Opcion no valida");
            break;
    }
} while (option != 10);

static string ReadValue()
{
    var number = Console.ReadLine() ?? string.Empty;
    return number;
}

static int ReadNumber()
{
    var number = Convert.ToInt32(Console.ReadLine());
    return number;
}