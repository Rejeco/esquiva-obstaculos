using UnityEngine;

public class VuelaEnJugador : MonoBehaviour
{
    // Para obtener la referencia del jugador
    // Se usa SerializeField para que en el
    // Inspector el campo Jugador que esta en 
    // el script lo relacionomes con el objeto
    // jugador Player Reny
    [SerializeField] float velocidad = 1.0f;
    [SerializeField] Transform jugador;
    Vector3 posicionJugador;

    void Start()
    {
        posicionJugador = jugador.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, posicionJugador, velocidad * Time.deltaTime);
    }
}
