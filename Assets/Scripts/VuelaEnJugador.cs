using UnityEngine;

public class VuelaEnJugador : MonoBehaviour
{
    // Para obtener la referencia del jugador
    // Se usa SerializeField para que en el
    // Inspector el campo jugador que esta en 
    // el script lo relacionomes con el objeto
    // jugador Player Reny
    [SerializeField] float velocidad = 1.0f;
    [SerializeField] Transform jugador;
    Vector3 posicionJugador;

    // Con el metodo Awake arranca antes del
    // metodo Start, permitiendo a los objetos
    // del juego proyectiles seguir correctamente
    // la posición del jugador porque
    // llama al objeto aunque este inactivo
    // y Start no lo hace entonces cuando el objeto
    // es activo por el TriggerProyectil.cs
    // Se actualiza la posición del jugador correctamente 
    // y los proyectiles siguen la posicion del jugador
    void Awake()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        posicionJugador = jugador.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoverAJugador();
        DestruirCuandoLlegue();
    }

    void MoverAJugador()
    {
        transform.position = Vector3.MoveTowards(transform.position, posicionJugador, velocidad * Time.deltaTime);

    }

    // Destruye el gameObject, es decir, el objeto de juego
    // que esta enlazado al Script.
    // En este caso destruye los proyectiles.
    // Destroy permite liberar recursos para hacer más eficiente
    // el juego
    void DestruirCuandoLlegue()
    {
        if (transform.position == posicionJugador)
        {
            Destroy(gameObject);
        }
    }
}
