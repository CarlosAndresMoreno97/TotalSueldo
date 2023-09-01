//Enuciado:Un vendedor recibe un sueldo base más un 10% extra por comisión de sus ventas,
//el vendedor desea saber cuánto dinero obtendrá por concepto de comisiones
//por las tres ventas que realiza en el mes y el total que recibirá en el mes tomando en cuenta
//su sueldo base y comisiones. 


public class TotalSueldo
{
    static void Main(string[] args)
    {
        double sueldobase, valorventa, comision, sueldototal;

        Console.Write("Ingresar su sueldo base: ");
        sueldobase = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresar valor de venta: ");
        valorventa = Convert.ToDouble(Console.ReadLine());

        comision = (valorventa * 10) / 100;
        sueldototal = sueldobase + comision;

        Console.Write("La comisio es: " + comision);
        Console.Write("\n");
        Console.Write("El sueldo total mensual es: " +  sueldototal);
        Console.Write("\n");

    }

}

