using System;

class Program {
    static void Main() {
        
        double monto;
        double tasa;
        double tasaMensual;
        double cuota;
        int meses;

        Console.Write("Ingrese el monto del préstamo: ");
        monto = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la tasa de interés anual (%): ");
        tasa = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tiempo a pagar (meses): ");
        meses = Convert.ToInt32(Console.ReadLine());

        tasaMensual = (tasa / 100) / 12;

        cuota = (monto * tasaMensual) / (1 - Math.Pow(1 + tasaMensual, -meses));

        Console.WriteLine("Monto del préstamo: " + monto);
        Console.WriteLine("Tasa de interés: " + tasa + "%");
        Console.WriteLine("Tiempo: " + meses + " meses");
        Console.WriteLine("Cuota mensual: " + cuota);

    }
}
