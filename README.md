# Endless Runner 2D 

![Unity](https://img.shields.io/badge/Unity-2022+-black?style=flat&logo=unity)
![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=c-sharp&logoColor=white)
![Platform](https://img.shields.io/badge/Platform-PC-blue)
![Status](https://img.shields.io/badge/Status-Complete-success)

## Descripción

Endless Runner 2D es un juego arcade minimalista desarrollado en Unity donde el jugador debe esquivar obstáculos en una carrera infinita. Con mecánicas simples pero adictivas, el objetivo es sobrevivir el mayor tiempo posible mientras la dificultad aumenta progresivamente.

Perfecto para aprender los fundamentos de desarrollo de juegos 2D en Unity, incluyendo física, detección de colisiones, generación procedural y gestión de estados del juego.

##  Características Principales

### Jugabilidad
- **Movimiento automático**: El personaje avanza constantemente hacia la derecha
- **Salto responsive**: Controles precisos con barra espaciadora o clic izquierdo
- **Sistema de física**: Implementado con Rigidbody2D para movimiento realista
- **Detección de suelo**: El jugador solo puede saltar cuando está en tierra

### Sistema de Obstáculos
- **Generación procedural**: Los obstáculos aparecen dinámicamente
- **Spawn inteligente**: Sistema que asegura un espaciado adecuado
- **Dificultad escalable**: Fácil de ajustar para modificar el desafío

### Game Management
- **Sistema de Game Over**: Detección de colisiones con obstáculos
- **Gestión de estados**: Control del flujo del juego
- **Arquitectura modular**: Código limpio y fácil de mantener

##  Controles

| Acción | Tecla/Botón |
|--------|-------------|
| Saltar | **Barra Espaciadora** o **Clic Izquierdo** |
| Reiniciar | **R** (después de Game Over) |

##  Estructura del Proyecto

```
Mini-Juego-Endless-Runner-2D/
├── Assets/
│   ├── Prefabs/          # Prefabs del jugador y obstáculos
│   ├── Scenes/           # Escena principal del juego
│   ├── Scripts/          # Lógica del juego
│   │   ├── GameManager.cs
│   │   ├── PlayerController.cs
│   │   └── ObstacleSpawner.cs
│   ├── Settings/         # Configuraciones del proyecto
│   └── TextMesh Pro/     # Assets de UI
├── Packages/             # Dependencias de Unity
└── ProjectSettings/      # Configuración del proyecto
```

##  Tecnologías Utilizadas

- **Unity 2022+**: Motor de desarrollo de juegos
- **C#**: Lenguaje de programación principal
- **Unity Physics 2D**: Sistema de física y colisiones
- **TextMesh Pro**: Sistema de renderizado de texto

##  Scripts Principales

### `PlayerController.cs`
- Control del movimiento del jugador
- Gestión del salto con física realista
- Detección de colisiones con suelo y obstáculos
- Integración con GameManager para Game Over

**Parámetros configurables:**
- `moveSpeed`: Velocidad de movimiento horizontal (5f por defecto)
- `jumpForce`: Fuerza del salto (7f por defecto)

### `ObstacleSpawner.cs`
- Generación procedural de obstáculos
- Control de espaciado y frecuencia
- Gestión del pool de objetos

### `GameManager.cs`
- Gestión del estado del juego (Playing, GameOver)
- Control del flujo del juego
- Reinicio de partida

##  Instalación y Ejecución

### Requisitos Previos
- Unity 2022.1 o superior
- Visual Studio o Visual Studio Code (opcional, para editar scripts)

### Pasos de Instalación

1. **Clonar el repositorio**
   ```bash
   git clone https://github.com/Kronus2812/Mini-Juego-Endless-Runner-2D.git
   cd Mini-Juego-Endless-Runner-2D
   ```

2. **Abrir en Unity**
   - Abre Unity Hub
   - Click en "Add" y selecciona la carpeta del proyecto
   - Abre el proyecto con Unity 2022.1 o superior

3. **Ejecutar el juego**
   - Abre la escena principal en `Assets/Scenes/`
   - Presiona el botón **Play** en el editor de Unity
   - O construye el juego: `File > Build Settings > Build`

##  Cómo Jugar

1. El juego comienza automáticamente al iniciar la escena
2. Tu personaje se moverá constantemente hacia la derecha
3. Presiona **Espacio** o **Clic Izquierdo** para saltar
4. Esquiva todos los obstáculos que aparezcan
5. Si chocas con un obstáculo, es Game Over
6. Presiona **R** para reiniciar (si está implementado)

##  Desarrollo y Personalización

### Modificar la Dificultad

En `ObstacleSpawner.cs`, puedes ajustar:
- **Frecuencia de spawn**: Modifica el intervalo de generación
- **Velocidad de obstáculos**: Cambia la velocidad de movimiento
- **Tipos de obstáculos**: Añade nuevos prefabs al spawner

### Añadir Nuevas Características

Ideas para expandir el juego:
- Sistema de puntuación basado en distancia recorrida
- Power-ups (invencibilidad, doble salto, etc.)
- Diferentes tipos de obstáculos
- Sistema de niveles o fases
- Música y efectos de sonido
- Sistema de high scores con PlayerPrefs
- Animaciones del personaje
- Parallax background para profundidad

##  Conceptos de Unity Demostrados

- **Rigidbody2D**: Física 2D y movimiento
- **Collider2D**: Detección de colisiones
- **Tags**: Identificación de GameObjects
- **Prefabs**: Reutilización de objetos
- **Instantiate/Destroy**: Gestión dinámica de objetos
- **MonoBehaviour Lifecycle**: Awake(), Start(), Update()
- **Input System**: Detección de entrada del jugador
- **Singleton Pattern**: GameManager accesible globalmente

##  Mejores Prácticas Aplicadas

-  Código modular y reutilizable
-  Nombres descriptivos de variables y métodos
-  Separación de responsabilidades entre scripts
-  Uso de prefabs para instanciación eficiente
-  Comentarios en el código para claridad
-  Estructura de carpetas organizada

##  Contribuciones

Este es un proyecto educativo abierto a mejoras. Si deseas contribuir:

1. Fork el repositorio
2. Crea una rama para tu feature (`git checkout -b feature/NuevaCaracteristica`)
3. Commit tus cambios (`git commit -m 'Añadir nueva característica'`)
4. Push a la rama (`git push origin feature/NuevaCaracteristica`)
5. Abre un Pull Request

---

## Desarrollador

**Kronus2812**

Stack: Frontend, Backend, Python, JavaScript, SQL, PHP, React, CSS, HTML

Repositorio: [github.com/Kronus2812/Mini-Juego](https://github.com/Kronus2812/Mini-Juego-Endless-Runner-2D)

---

