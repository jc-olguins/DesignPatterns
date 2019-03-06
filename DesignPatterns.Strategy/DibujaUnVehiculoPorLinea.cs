using System;
using System.Collections.Generic;

public class DibujaUnVehiculoPorLinea : DibujaCatalogo
{

    public void dibuja(IList<VistaVehiculo> contenido)
    {
        Console.WriteLine(
          "Dibuja los veh�culos mostrando un veh�culo por l�nea");
        foreach (VistaVehiculo vistaVehiculo in contenido)
        {
            vistaVehiculo.dibuja();
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
