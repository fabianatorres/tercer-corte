using System;

namespace fabianatercercorte 
{
	
public class Program
{
	public static void Main()
	{
		int tam;
		int edad;
        double peso;
		int actividad;
		
        Console.WriteLine("¡BIENVENIDO! Aquí descubrirás la cantidad de alimento ideal para tu perro");
            
        Console.WriteLine("Introduzca el tamaño del perro:\n Miniatura (1) \n Pequeño(2) \n Mediano(3) \n Grande(4)");
        tam = Convert.ToInt32(Console.ReadLine());
            
        Console.WriteLine("Introduzca la edad de su mascota en meses");
        edad = Convert.ToInt32(Console.ReadLine());
            
            
        Console.WriteLine("¿Cuánto pesa su perro? (En Kg)");
        peso = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("¿Su perro es activo? \n Su actividad es alta (1) \n Su actividad normal(2) \n Su actividad es baja(3)");
        actividad = Convert.ToInt32(Console.ReadLine());
            
            //adultos
            if (edad > 12) {
                if (peso >= 2 &&  peso <= 5) {
                    switch (actividad)
                    {
                        case 1:
                            Console.WriteLine("El alimento IDEAL para su perro va de 60 a 115 gramos diarios");
                            break;
                        case 2:
                            Console.WriteLine("El alimento IDEAL para su perro va de 55 a 100 gramos diarias");
                            break;
                        case 3:
                            Console.WriteLine("El alimento IDEAL para su perro va de 45 a 85 gramos diarios");
                            break;
                    }
                }

                 if (peso > 5 && peso <= 10) {
                        switch (actividad)
                        {
                            case 1:
                                Console.WriteLine("El alimento IDEAL para su perro va de 115 a 190 gramos diarios");
                                break;
                            case 2:
                                Console.WriteLine("El alimento IDEAL para su perro va de 100 a 170 gramos diarios");
                                break;
                            case 3:
                                Console.WriteLine("El alimento IDEAL para su perro va de 85 a 145 gramos diarios");
                                break;
                        }
                }
            
            if (peso > 10 && peso <= 15)
            {
                switch (actividad)
                {
                    case 1:
                        Console.WriteLine("El alimento IDEAL para su perro va de 190 a 255 gramos diarios");
                        break;
                    case 2:
                        Console.WriteLine("El alimento IDEAL para su perro va de 170 a 225 gramos diarios");
                        break;
                    case 3:
                        Console.WriteLine("El alimento IDEAL para su perro va de 145 a 195 gramos diarios");
                        break;
                
                }
            
            }
            
            if (peso > 15 && peso <= 25)
            {
                switch (actividad)
                {
                    case 1:
                        Console.WriteLine("El alimento IDEAL para su perro va de 255 a 380 gramos diarios");
                        break;
                    case 2:
                        Console.WriteLine("El alimento IDEAL para su perro va de255 a 330 gramos  diarios");
                        break;
                    case 3:
                        Console.WriteLine("El alimento IDEAL para su perro va de 195 a 285 gramos diarios");
                        break;
                
                }
            
            }
            
            if (peso > 25 && peso <= 40)
            {
                switch (actividad)
                {
                    case 1:
                        Console.WriteLine("El alimento IDEAL para su perro va de 380 a 535 gramos diarios");
                        break;
                    case 2:
                        Console.WriteLine("El alimento IDEAL para su perro va de 330 a 475 gramos diarios");
                        break;
                    case 3:
                        Console.WriteLine("El alimento IDEAL para su perro va de 285 a 410 gramos diarios");
                        break;
                
                }
            
            
           
    }}
     if (edad <=12) {
         Console.WriteLine("prueba");
                if(edad == 2) {
                    if ( peso >= 2 && peso < 5) Console.WriteLine("El alimento IDEAL para su perro es de 50 gramos diarios");
                    if ( peso >= 5 && peso < 10) Console.WriteLine("El alimento IDEAL para su perro es de 95 gramos diarios");
                    if ( peso >= 10 && peso < 17) Console.WriteLine("El alimento IDEAL para su perro es de 155 gramos diarios");
                    if ( peso >= 17 && peso < 25) Console.WriteLine("El alimento IDEAL para su perro es de 215 gramos diarios");
                    if ( peso >= 25 && peso < 32) Console.WriteLine("El alimento IDEAL para su perro es de 270 gramos diarios");
                    if ( peso >= 32 && peso < 40) Console.WriteLine("El alimento IDEAL para su perro es de 300 gramos diarios");
                    if ( peso >= 40 && peso < 50) Console.WriteLine("El alimento IDEAL para su perro es de 355 gramos diarios");
                    if ( peso >= 50 && peso < 60) Console.WriteLine("El alimento IDEAL para su perro es de 405 gramos diarios");
                    if ( peso >= 60 && peso < 70) Console.WriteLine("El alimento IDEAL para su perro es de 450 gramos diarios");
                    if ( peso >= 70 && peso < 90) Console.WriteLine("El alimento IDEAL para su perro es de 485 gramos diarios");
                    if ( peso >= 90) Console.WriteLine("El alimento IDEAL para su perro es de 580 gramos diarios");
                }
                
            if(edad == 3) {
                    if ( peso >= 2 && peso < 5) Console.WriteLine("El alimento IDEAL para su perro es de 60 gramos diarios");
                    if ( peso >= 5 && peso < 10) Console.WriteLine("El alimento IDEAL para su perro es de 110 gramos diarios");
                    if ( peso >= 10 && peso < 17) Console.WriteLine("El alimento IDEAL para su perro es de 185 gramos diarios");
                    if ( peso >= 17 && peso < 25) Console.WriteLine("El alimento IDEAL para su perro es de 265 gramos diarios");
                    if ( peso >= 25 && peso < 32) Console.WriteLine("El alimento IDEAL para su perro es de 350 gramos diarios");
                    if ( peso >= 32 && peso < 40) Console.WriteLine("El alimento IDEAL para su perro es de 400 gramos diarios");
                    if ( peso >= 40 && peso < 50) Console.WriteLine("El alimento IDEAL para su perro es de 475 gramos diarios");
                    if ( peso >= 50 && peso < 60) Console.WriteLine("El alimento IDEAL para su perro es de 545 gramos diarios");
                    if ( peso >= 60 && peso < 70) Console.WriteLine("El alimento IDEAL para su perro es de 605 gramos diarios");
                    if ( peso >= 70 && peso < 90) Console.WriteLine("El alimento IDEAL para su perro es de 670 gramos diarios");
                    if ( peso >= 90) Console.WriteLine("El alimento IDEAL para su perro es de 670 gramos diarios");
                }
            
            if(edad == 4) {
                    if ( peso >= 2 && peso < 5) Console.WriteLine("El alimento IDEAL para su perro es de 60 gramos diarios");
                    if ( peso >= 5 && peso < 10) Console.WriteLine("El alimento IDEAL para su perro es de 115 gramos diarios");
                    if ( peso >= 10 && peso < 17) Console.WriteLine("El alimento IDEAL para su perro es de 195 gramos diarios");
                    if ( peso >= 17 && peso < 25) Console.WriteLine("El alimento IDEAL para su perro es de 285 gramos diarios");
                    if ( peso >= 25 && peso < 32) Console.WriteLine("El alimento IDEAL para su perro es de 375 gramos diarios");
                    if ( peso >= 32 && peso < 40) Console.WriteLine("El alimento IDEAL para su perro es de 445 gramos diarios");
                    if ( peso >= 40 && peso < 50) Console.WriteLine("El alimento IDEAL para su perro es de 525 gramos diarios");
                    if ( peso >= 50 && peso < 60) Console.WriteLine("El alimento IDEAL para su perro es de 610 gramos diarios");
                    if ( peso >= 60 && peso < 70) Console.WriteLine("El alimento IDEAL para su perro es de 685 gramos diarios");
                    if ( peso >= 70 && peso < 90) Console.WriteLine("El alimento IDEAL para su perro es de 685 gramos diarios");
                    if ( peso >= 90) Console.WriteLine("El alimento IDEAL para su perro es de 685 gramos diarios");
                }
            
            if(edad == 5) {
                   if ( peso >= 2 && peso < 5) Console.WriteLine("El alimento IDEAL para su perro es de 60 gramos diarios");
                    if ( peso >= 5 && peso < 10) Console.WriteLine("El alimento IDEAL para su perro es de 115 gramos diarios");
                    if ( peso >= 10 && peso < 17) Console.WriteLine("El alimento IDEAL para su perro es de 190 gramos diarios");
                    if ( peso >= 17 && peso < 25) Console.WriteLine("El alimento IDEAL para su perro es de 285 gramos diarios");
                    if ( peso >= 25 && peso < 32) Console.WriteLine("El alimento IDEAL para su perro es de 375 gramos diarios");
                    if ( peso >= 32 && peso < 40) Console.WriteLine("El alimento IDEAL para su perro es de 450 gramos diarios");
                    if ( peso >= 40 && peso < 50) Console.WriteLine("El alimento IDEAL para su perro es de 530 gramos diarios");
                    if ( peso >= 50 && peso < 60) Console.WriteLine("El alimento IDEAL para su perro es de 625 gramos diarios");
                    if ( peso >= 60 && peso < 70) Console.WriteLine("El alimento IDEAL para su perro es de 685 gramos diarios");
                    if ( peso >= 70 && peso < 90) Console.WriteLine("El alimento IDEAL para su perro es de 685 gramos diarios");
                    if ( peso >= 90) Console.WriteLine("El alimento IDEAL para su perro es de 685 gramos diarios");
            }
            
                if(edad >=6) {
                     if ( peso >= 2 && peso < 5) Console.WriteLine("El alimento IDEAL para su perro es de 55 gramos diarios");
                    if ( peso >= 5 && peso < 10) Console.WriteLine("El alimento IDEAL para su perro es de 110 gramos diarios");
                    if ( peso >= 10 && peso < 17) Console.WriteLine("El alimento IDEAL para su perro es de 185 gramos diarios");
                    if ( peso >= 17 && peso < 25) Console.WriteLine("El alimento IDEAL para su perro es de 280 gramos diarios");
                    if ( peso >= 25 && peso < 32) Console.WriteLine("El alimento IDEAL para su perro es de 370 gramos diarios");
                    if ( peso >= 32 && peso < 40) Console.WriteLine("El alimento IDEAL para su perro es de 450 gramos diarios");
                    if ( peso >= 40 && peso < 50) Console.WriteLine("El alimento IDEAL para su perro es de 530 gramos diarios");
                    if ( peso >= 50 && peso < 60) Console.WriteLine("El alimento IDEAL para su perro es de 685 gramos diarios");
                    if ( peso >= 60 && peso < 70) Console.WriteLine("El alimento IDEAL para su perro es de 685 gramos diarios");
                    if ( peso >= 70 && peso < 90) Console.WriteLine("El alimento IDEAL para su perro es de 685 gramos diarios");
                    if ( peso >= 90) Console.WriteLine("El alimento IDEAL para su perro es de 685 gramos diarios");
                }
            }
    }
}
}