# JuegoUnityProgeso1
![image](https://github.com/Ji07y/JuegoUnityProgeso1/assets/85076732/7ed9a750-af68-41ad-b356-970dac1bf451)

Aplicación de principios y arquitecturas de sistemas hipermedia

link video en YouTube https://youtu.be/03obFz_IVro



# Cuatro Features del juego:

# 1.Misiones del Juego
Este es un script en C# para Unity que gestiona las misiones del juego. El script activa una imagen y muestra un texto cuando el jugador entra en un área específica y desactiva la imagen cuando el jugador sale de esa área.

## Características
Activación de elementos visuales cuando el jugador entra en un área designada.
Desactivación de elementos visuales cuando el jugador sale del área designada.
Requisitos
Unity (compatible con la versión en la que se desarrolló el script).
TextMeshPro (para el objeto de texto).

## Uso
Asigna los GameObjects desde el editor:

![image](https://github.com/Ji07y/JuegoUnityProgeso1/assets/85076732/74807bd1-3680-412c-9ba2-20619e096f70)

jugador: Asigna el GameObject del jugador.
imagenActivar: Asigna la imagen que se activará cuando el jugador entre en el área.
textoMostrarMision: Asigna el objeto de texto que mostrará la misión.
¡Listo para utilizar en tu juego!
Personaliza el mensaje de la misión en el código dentro del método OnTriggerEnter.

![image](https://github.com/Ji07y/JuegoUnityProgeso1/assets/85076732/44cd4a4c-2c4c-4e7a-b640-ff1b67f5155b)

# 2.Generador de Vidas
Este script en C# para Unity gestiona la generación de vidas en el juego. Las vidas se generan en posiciones aleatorias dentro de un área definida. Puedes ajustar el tiempo entre generaciones y las coordenadas dentro de las cuales aparecerán las vidas.

# Características
Generación periódica de vidas en posiciones aleatorias.
Control del tiempo entre generaciones y las coordenadas de aparición.
# Requisitos
Unity (compatible con la versión en la que se desarrolló el script).
#Uso
Asigna el GameObject prefabVidas desde el editor.

![image](https://github.com/Ji07y/JuegoUnityProgeso1/assets/85076732/470b0206-9b96-48ee-a9f7-157fc1c3524b)

Este GameObject debe representar el objeto de vida que se generará en el juego.
Ajusta el tiempo entre generaciones y las coordenadas de aparición en el método Start.

![image](https://github.com/Ji07y/JuegoUnityProgeso1/assets/85076732/b9e9571a-59d5-44a7-82d2-4fc08f940d50)

Asegúrate de que la imagen inicialmente esté desactivada en el editor.
Asigna el prefabVidas desde el editor.

# 3.Daño al Enemigo

Este script en C# para Unity maneja la lógica de daño al jugador, controlando la cantidad de vidas y reproduciendo sonidos correspondientes. También gestiona la carga de la escena de "GameOver" cuando el jugador se queda sin vidas.

## Características

- Control de vidas del jugador.
- Reproducción de sonidos al recibir daño.
- Manejo de colisiones con enemigos y objetos de vida.

## Requisitos

- Unity (compatible con la versión en la que se desarrolló el script).
- `Image` (para las vidas en el HUD).
- `TextMeshProUGUI` (para mostrar el número de vidas en el HUD).
- `AudioSource` (para reproducir sonidos al recibir daño).

## Uso

1. Asigna las imágenes de vidas (`vida1`, `vida2`, `vida3`) desde el editor.
   - Estas imágenes representarán visualmente las vidas en el HUD.

2. Asigna el objeto `audioSource` desde el editor.
   - Este objeto debería contener el componente `AudioSource` para reproducir sonidos.

3. Ajusta el número máximo de vidas (`vidasMaximas`) y el número actual de vidas (`vidasActual`) desde el editor.

![image](https://github.com/Ji07y/JuegoUnityProgeso1/assets/85076732/9f3f7837-4c68-4975-823f-fbde9c80401c)

4. Personaliza la escena de carga al quedarse sin vidas en el método `Update`.

![image](https://github.com/Ji07y/JuegoUnityProgeso1/assets/85076732/79e42f41-f023-490e-8541-a2ffbbab0e8a)


5. Personaliza la lógica de colisiones en el método `OnCollisionEnter`.
   - Daño al jugador al colisionar con enemigos.
   - Recuperación de vidas al colisionar con objetos de vida.

![image](https://github.com/Ji07y/JuegoUnityProgeso1/assets/85076732/a4c2caf8-49d2-4536-83cb-0c841bdd513e)

# 4.Enemigo que Busca al Jugador

Este script en C# para Unity controla el comportamiento de un enemigo que busca al jugador utilizando la tecnología de navegación de Unity. El enemigo se activa cuando el jugador entra en su radio de detección y vuelve a su posición inicial cuando el jugador sale de ese radio.

## Características
Detección de jugador en un radio específico.
Seguimiento del jugador utilizando la tecnología de navegación de Unity.
Regreso a la posición inicial cuando el jugador sale del radio de detección.
## Requisitos
Unity (compatible con la versión en la que se desarrolló el script).
NavMeshAgent (para el componente de navegación).
## Uso
Asigna la posición inicial del enemigo desde el editor.

![image](https://github.com/Ji07y/JuegoUnityProgeso1/assets/85076732/91e906c1-9405-4716-ab7e-902415a3330d)

Ajusta el radio de detección y la velocidad del enemigo desde el editor.

![image](https://github.com/Ji07y/JuegoUnityProgeso1/assets/85076732/32abf035-6ffb-41d5-9c60-1660ea4ea276)

Asegúrate de que el enemigo tenga un componente NavMeshAgent en el editor.

Personaliza la lógica de detección y seguimiento del jugador en el método Update.

![image](https://github.com/Ji07y/JuegoUnityProgeso1/assets/85076732/7f3eacd0-15b6-43cb-8622-c59ec0483cb2)

Ajusta las funciones VolverAPosicionInicial, ActivarNavMeshAgent y DesactivarNavMeshAgent según sea necesario.

![image](https://github.com/Ji07y/JuegoUnityProgeso1/assets/85076732/82aea8b7-37fc-4f93-8d1a-9f71288232af)

# Instalación
Clona el repositorio en tu máquina local:

bash
Copy code:
(https://github.com/Ji07y/JuegoUnityProgeso1.git)https://github.com/Ji07y/JuegoUnityProgeso1.git

Abre el proyecto en Unity.






