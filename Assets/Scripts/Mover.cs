using UnityEngine;

public class Mover : MonoBehaviour
{
    // SerializeField permite hacer accesible
    // a las variables en el inspector de Unity
    // Y así poder manipular sus valores

    // [SerializeField] float xValor = 0.0f;
    // [SerializeField] float yValor = 0.01f;
    // [SerializeField] float zValor = 0.0f;

    // Time.deltaTime le dice a Unity cuanto tiempo
    // tiempo debe de tomar para ejecutar cada fps
    // Facilita la normalizacion de velocidad para 
    // diferentes equipos de computo

    [SerializeField] float velocidadMovimiento = 10.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ImprimeInstrucciones();
    }

    // Update is called once per frame
    void Update()
    {
        MoverJugador();
    }

    void ImprimeInstrucciones()
    {
        Debug.Log("Bienvenido al juego!");
        Debug.Log("Movimiento: Te mueves con AWSD o con las flechas");
        Debug.Log("Condiciones: Si tocas los obstaculos pierdes!");
    }

    void MoverJugador()
    {
        // Input.GetAxis es legacy
        // Permite manipular los valores de los ejes con el
        // teclado x (a d) y z (w s)
        float xValor = Input.GetAxis("Horizontal") * Time.deltaTime * velocidadMovimiento;
        float yValor = 0.0f;
        float zValor = Input.GetAxis("Vertical") * Time.deltaTime * velocidadMovimiento;

        transform.Translate(xValor, yValor, zValor);
    }

}
