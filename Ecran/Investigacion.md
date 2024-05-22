# Investigación

## Miembros De Clase:

- **Fields (Campos):** Variables declaradas directamente en la clase, fuera de cualquier método. Son utilizadas por todos los métodos de la clase.

- **Constructor:** Método especial para inicializar objetos de una clase, llamado automáticamente al crear un objeto.

- **Métodos:** Funciones que pertenecen a una clase, pueden tener parámetros y un valor de retorno. Ejemplos en tu código: `ShowEcran()`, `HideEcran()`, y `ClearLastLine()`.

- **Propiedades:** Mecanismos flexibles para leer, escribir o calcular el valor de un campo privado. Pueden ser de lectura-escritura, solo lectura o solo escritura.

- **Finalizador:** Método especial para liberar recursos no administrados, definido en C# con `~ClassName()`.

- **Indicador (Indexer):** Miembro que permite a los objetos de una clase ser indexados como arrays.

- **Operador:** Métodos especiales que definen acciones para operadores del lenguaje como +, -, *, /.

## Qué Son Los Eventos?

Los eventos en C# permiten que una clase u objeto notifique a otros cuando ocurre algo de interés, siendo clave en el modelo de programación basado en eventos, útil en aplicaciones GUI.

Un evento en C# encapsula la gestión de eventos en tiempo de ejecución. Son utilizados por las clases .NET para informar a los clientes cuando ocurre una acción, enviando una notificación para señalar dicha ocurrencia.

Ejemplo:

```csharp
public class Publisher
{
    public delegate void MyEventHandler(string message);
    public event MyEventHandler MyEvent;

    public void DoSomething()
    {
        OnMyEvent("¡Evento disparado!");
    }

    protected virtual void OnMyEvent(string message)
    {
        MyEvent?.Invoke(message);
    }
}

public class Subscriber
{
    public void Subscribe(Publisher pub)
    {
        pub.MyEvent += RespondToEvent;
    }

    private void RespondToEvent(string message)
    {
        Console.WriteLine("El evento fue disparado: " + message);
    }
}
```

En este ejemplo, la clase `Publisher` tiene un evento llamado `MyEvent`. La clase `Subscriber` se suscribe a este evento y define un método `RespondToEvent` que se ejecutará cuando se dispare el evento.
