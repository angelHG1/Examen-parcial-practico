namespace Examen_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("\tINVENTARIO\n");

            Console.WriteLine("Seleccione el tipo de producto: \nElectronico(1) \nAlimento(2)");
            Console.Write("---> ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion) 
            { 
                case 1:
                    Console.Clear();
                    Electronico electro = new Electronico();
                    Console.WriteLine("\tELECTRONICOS");

                    Console.Write("Ingrese el nombre del producto: ");
                    electro.nombre = Console.ReadLine();
                    Console.Write("Ingrese el ID del producto: ");
                    electro.id = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el precio del producto: ");
                    electro.precio = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la cantidad del producto: ");
                    electro.cantidad = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el tiempo de garantía del producto: ");
                    electro.garantia = Console.ReadLine();
                    var impuestoE = electro.CalcularImpuesto(electro.precio);
                    electro.impuesto = impuestoE;

                    Console.Clear();
                    electro.MostrarProducto();

                    break;
                case 2:
                    Console.WriteLine("Alimento");

                    Console.Clear();
                    Alimento alimento = new Alimento();
                    Console.WriteLine("\tELECTRONICOS");

                    Console.Write("Ingrese el nombre del producto: ");
                    alimento.nombre = Console.ReadLine();
                    Console.Write("Ingrese el ID del producto: ");
                    alimento.id = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el precio del producto: ");
                    alimento.precio = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la cantidad del producto: ");
                    alimento.cantidad = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese La fecha de caducidad: ");
                    alimento.expiracion = Console.ReadLine();
                    var impuestoA = alimento.CalcularImpuesto(alimento.precio);
                    alimento.impuesto = impuestoA;

                    Console.Clear();
                    alimento.MostrarProducto();
                    break;
                default: 
                    Console.WriteLine("Opcion Invalida.");
                    break;
            
            }
        }
    }

    public class Producto
    { 
        public string nombre { get; set; }
        public int id { get; set; }
        public double precio { get; set; }
        public int cantidad { get; set; }
        public double impuesto { get; set; }

        public virtual void MostrarProducto()
        {
            Console.WriteLine("Muestra los datos del producto");
        }
        public virtual double CalcularImpuesto(double precio)
        {
            return 0;
        }
    }

    public class Electronico:Producto

    {
        public string garantia { get; set; }

        public override void MostrarProducto()
        { Console.WriteLine($"Producto: {nombre} \nID: {id} \nPrecio: {precio}$ \nCantidad: {cantidad} \nImpuesto: {impuesto}$ \nGarantia {garantia}"); }

        public override double CalcularImpuesto(double precio)
        { 
            return precio*0.18;
        }
    }

    public class Alimento:Producto

    {
        public string expiracion { get; set; }

        public override void MostrarProducto()
        { Console.WriteLine($"Producto: {nombre} \nID: {id} \nPrecio: {precio}$ \nCantidad: {cantidad} \nImpuesto: {impuesto}$ " +
            $"\nFecha de expiracion: {expiracion} "); }

        public override double CalcularImpuesto(double precio)
        {
            return precio * 0.08;
        }
    }
}
