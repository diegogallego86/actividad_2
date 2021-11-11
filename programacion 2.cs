using System;

namespace actividad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            int edad = 0;
            double altura = 0.0;
            
            
            Console.WriteLine("¡Bienevenido a dunas!, por favor ingresa tu edad:");
            valor = Console.ReadLine();
            edad = Convert.ToInt32(valor);
            
            if(edad >= 18)
            {
                Console.WriteLine("Disculpe ha superado el limite de edad para dunas.");
            }
            else
            { 
                Console.WriteLine("Perfecto, indique tu altura en metros");
                valor = Console.ReadLine();
                altura = Convert.ToDouble(valor);

                if(altura < 1.50)
                {
                 Console.WriteLine("¡ahora podra disfrutar el tobogan!");
                }
                {
                    Console.WriteLine("¡excelente, tiene disponiblidad de todos los sitios !"); 
                } 
                    Console.WriteLine("¡disfrute un excelente dia!");
              
      }
    }
  }  
}