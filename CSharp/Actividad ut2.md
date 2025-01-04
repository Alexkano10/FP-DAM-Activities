Actividad Práctica. UT2

Objetivo:
Reforzar los conocimientos sobre el uso de un IDE como Visual Studio mediante la
creación de un proyecto que simule el entrenamiento diario de los astronautas en una
estación espacial. El estudiante podrá crear, compilar, depurar y ejecutar una aplicación
de consola en C#.

Contexto:
Imagina que formas parte del equipo de desarrollo de software para una estación
espacial. Los astronautas siguen un programa de entrenamiento diario, por lo que tu tarea
es crear una aplicación de consola que les permita registrar sus actividades físicas diarias,
recibir recomendaciones y analizar su progreso.

Instrucciones:

1. Crear un proyecto de consola que permita registrar las actividades diarias de los
astronautas (ejercicios físicos).

2. Funciones principales:
a. Ingresar el nombre del astronauta.
b. Ingresar las actividades físicas realizadas (por ejemplo, correr, levantar
pesas, bicicleta estática) y la duración en minutos.
c. Mostrar una recomendación basada en la duración total del entrenamiento
(si es suficiente o si debe mejorar).
d. Guardar las actividades de varios días para mostrar el progreso.

3. Código:

a. Declaración de variables:

i. Crea las variables necesarias para almacenar el nombre del
astronauta, las actividades físicas y sus respectivas duraciones.

ii. Utiliza una lista (List<string>) para almacenar las actividades y otra
lista (List<int>) para las duraciones. Declara también una variable
para almacenar la duración total del entrenamiento.

b. Entrada de datos:

i. Pide al usuario que ingrese el nombre del astronauta utilizando la
función Console.ReadLine().

ii. Solicita al usuario que introduzca una actividad física realizada y la
duración de esta, repitiendo el proceso hasta que el usuario indique
que no desea agregar más actividades. Usa un bucle do-while para
gestionar las entradas.

c. Estructuras condicionales:

i. Implementa una condición para verificar si la duración total de las
actividades es inferior a 60 minutos, mostrando una recomendación
para realizar más ejercicio si es necesario. Si la duración es mayor
o igual a 60 minutos, muestra un mensaje indicando que el
entrenamiento es suficiente.
d. Mostrar el resumen del entrenamiento:

i. Después de que el usuario haya terminado de ingresar todas las
actividades, utiliza un bucle for para mostrar un resumen de las
actividades y sus duraciones.

ii. Finalmente, muestra la duración total del entrenamiento y la
recomendación correspondiente (suficiente o insuficiente).