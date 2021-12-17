// See https://aka.ms/new-console-template for more information
using System;

namespace MyApplication
{
  class Vehiculo  // Base class (parent) 
  {
    public virtual void MotorVehiculo()
    {
      Console.WriteLine("Los vehiculos tienen diferentes motores");
    }
  }

  class VolvoV40 : Vehiculo  // Derived class (child) 
  {
    public override void MotorVehiculo()
    {
      Console.WriteLine("El motor de un Volvo V40 es 1.6 ");
    }
  }

  class BmwSerie2: Vehiculo  // Derived class (child) 
  {
    public override void MotorVehiculo()
    {
      Console.WriteLine("El motor de un BMW serie 2 es 2.5");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Vehiculo MyVehiculo = new Vehiculo();  
      Vehiculo  MyVolvo= new VolvoV40();  
      Vehiculo MyBmw = new BmwSerie2(); 
      
      MyVehiculo.MotorVehiculo();
      MyVolvo.MotorVehiculo();
      MyBmw.MotorVehiculo();
    }
  }
}