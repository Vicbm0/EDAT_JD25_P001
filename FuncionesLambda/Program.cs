internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Funciones lambda como funcion");

        //Func<int, int> b = (a) => a * 2;
        //int resultado = b(4);
        //Console.WriteLine("el resultado es: "+resultado);


        //Func<int, int, int> suma = (a,b) => a + b;
        //int resultado = suma(4, 6);
        //Console.WriteLine("el resultado es: " + resultado);

        //Func<int, int, int> mayor = (a, b) =>
        //{
        //    if (a > b)
        //    {

        //        return a;

        //    }
        //    else
        //    {

        //        return b;
        //    }

        //};
        //int res = mayor(45, 20);
        //Console.WriteLine("el resultado es: " + res);


        //var numeros = new List<int> {8, 5, 9, 4, 2, 26, 8};
        //Func<int, bool> ObtenerPares = (num) => num % 2 == 0;
        //var pares = numeros.Where(ObtenerPares);
        //var pares = numeros.Where((num) => num % 2 == 0);
        //Console.WriteLine("Hola ");


        //Persona pers = new Persona();
        //int edad = 18;
        //edad++;
        //edad++;
        //Sirve para fijar el objeto en memoria
        //GCHandle handle = GCHandle.Alloc(edad, GCHandleType.Pinned);
        //Sirve para obtener la direccion del objeto fijado
        //IntPtr address = handle.AddrOfPinnedObject();
        //Console.WriteLine("El valor de la variable edad es: " + edad);
        //Console.WriteLine("La direccion de mermoria es: " + address);


        Console.ReadKey();
    }
}