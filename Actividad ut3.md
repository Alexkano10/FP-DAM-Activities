Actividad Práctica. UT3
Objetivo:
Esta actividad refuerza conceptos como el uso de controles básicos al igual que
avanzados en Windows Forms, el manejo de eventos, personalización de la interfaz e
interacción dinámica entre los elementos de la UI.
Contexto:
Imagina que eres parte de un equipo que está desarrollando una aplicación de control
para un submarino que realiza investigaciones en el fondo del océano. El objetivo es crear
una interfaz gráfica (GUI) con Windows Forms que simule un tablero de control del
submarino.
Instrucciones:
1. Crear el proyecto:
o Abre Visual Studio y crea un nuevo proyecto de Windows Forms.
o Nómbralo "SubmarinoControl".
2. Diseño del formulario:
o Añade los siguientes controles a la interfaz:
▪ Botones: Un botón de "Iniciar inmersión", un botón de "Ascender" y
un botón de "Detener motor".
▪ Cuadro de texto (TextBox): Un cuadro de texto que muestre la
profundidad actual del submarino.
▪ Cuadro de lista (ListBox): Un cuadro de lista que muestre los
sensores activos (temperatura del agua, presión, etc.).
▪ Barra de progreso (ProgressBar): Una barra de progreso que
indique el nivel de oxígeno restante.
▪ Casillas de verificación (CheckBox): Para activar/desactivar
funciones como luces externas, cámara de alta definición, y
micrófono subacuático.
▪ Etiqueta (Label): Muestra mensajes de advertencia o el estado
actual del submarino.
3. Interacción con los controles:
o Programa los eventos para que los botones y casillas de verificación
afecten los valores de los controles. Por ejemplo:
▪ El botón "Iniciar inmersión" debe actualizar el cuadro de texto con la
profundidad (simulada).
▪ Las casillas de verificación deben activar/desactivar los sensores y
mostrarlos en la lista.
▪ La barra de progreso debe disminuir cuando se activa un sensor
que consume oxígeno.
4. Desafíos avanzados:
o Usa el control DataGridView para mostrar una tabla con datos en tiempo
real de la presión del agua a diferentes profundidades.
o Implementa un evento que se dispare cuando el nivel de oxígeno en la
barra de progreso llegue a un punto crítico, mostrando un mensaje de
advertencia en la etiqueta.
5. Estilos y temas:
o Personaliza la interfaz usando colores oscuros para simular el ambiente del
submarino y fuentes que den una sensación futurista. Puedes crear un
botón personalizado que simule un aspecto "tecnológico" para el botón
"Iniciar inmersión".