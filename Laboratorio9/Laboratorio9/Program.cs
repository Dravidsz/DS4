using System;

class Program
{
    static void Main()
    {

        double precio, billetes, vuelto;
        int formaPago;
        string tarjeta;
        do
        {
            Console.WriteLine("Ingrese el precio del producto(Que se valido)");
            precio = Double.Parse(Console.ReadLine());
           

        } while (precio <= 0);

        do
        {
            Console.WriteLine("Que forma de pago utilizara describa 1 para efectivo y 0 para targeta");
            formaPago = int.Parse(Console.ReadLine());

        } while (formaPago != 0 && formaPago != 1);

        if(formaPago == 1)
        {
            Console.WriteLine("Ingrese la valor de billete");
            billetes = Double.Parse(Console.ReadLine());
            vuelto = billetes - precio;
            Console.WriteLine("A pagado: " + precio + " y su vuelto es de " + vuelto);
        } else if(formaPago == 0)
        {
            do
            {
                Console.WriteLine("Ingrese el numero de targeta debe ser igual a 16 valores");
                tarjeta = Console.ReadLine();

            } while (tarjeta.Length != 16);
            
            
            
            Console.WriteLine("La targeta que ingreso es valida");
            Console.WriteLine("A pagado con su tageta " + tarjeta + " el total de " + precio);
        }
        else
        {
            Console.WriteLine("Transacion invalida");
        }

      
        



    }


}
