using System;
using System.Collections.Generic;

class ProgramaEntrenamientoAstronauta
{
    static void Main()
    {
        // a. Declaración de variables
        string nombreAstronauta;
        List<string> actividades = new List<string>();  // Lista para almacenar las actividades
        List<int> duraciones = new List<int>();  // Lista para almacenar las duraciones de cada actividad
        int duracionTotal = 0;  // Variable para almacenar la duración total del entrenamiento

        // b. Entrada de datos
        Console.WriteLine("Bienvenido al sistema de registro de entrenamiento de astronautas.");
        
        // Solicitar el nombre del astronauta
        Console.Write("Ingrese el nombre del astronauta: ");
        nombreAstronauta = Console.ReadLine();

        // Bucle para ingresar las actividades físicas y su duración
        bool continuar = true;
        do
        {
            Console.Write("Ingrese una actividad física realizada (ej. correr, levantar pesas, bicicleta estática): ");
            string actividad = Console.ReadLine();  // Leer la actividad realizada
            actividades.Add(actividad);  // Agregar la actividad a la lista

            Console.Write("Ingrese la duración de la actividad en minutos: ");
            int duracion = int.Parse(Console.ReadLine());  // Leer la duración de la actividad
            duraciones.Add(duracion);  // Agregar la duración a la lista

            // Sumar la duración al total
            duracionTotal += duracion;

            // Preguntar al usuario si desea agregar más actividades
            Console.Write("¿Desea agregar otra actividad? (s/n): ");
            continuar = Console.ReadLine().ToLower() == "s";  // Repetir el proceso si responde "s"

        } while (continuar);

        // c. Estructuras condicionales
        // Verificar si la duración total es suficiente o si debe mejorar
        if (duracionTotal < 60)
        {
            Console.WriteLine("\n¡Recomendación! Debe realizar más ejercicio para mejorar su rendimiento.");
        }
        else
        {
            Console.WriteLine("\n¡Buen trabajo! El entrenamiento fue suficiente.");
        }

        // d. Mostrar el resumen del entrenamiento
        Console.WriteLine($"\nResumen del entrenamiento de {nombreAstronauta}:");

        // Mostrar todas las actividades y sus duraciones
        for (int i = 0; i < actividades.Count; i++)
        {
            Console.WriteLine($"{actividades[i]}: {duraciones[i]} minutos");
        }

        // Mostrar la duración total del entrenamiento
        Console.WriteLine($"\nDuración total del entrenamiento: {duracionTotal} minutos");
    }
}
