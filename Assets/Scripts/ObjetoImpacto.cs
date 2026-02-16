using UnityEngine;

public class ObjetoImpacto : MonoBehaviour
{
    // Esta funcion nos permite controlar
    // Que se debe de hacer cuando
    // es chocado por algo como el jugador
    private void OnCollisionEnter(Collision collision)
    {
        // Con esta fiunción se obtiene el componente de un objeto par
        // modificar sus propiedades.
        // Entonces cuando haya colision las paredes u obstaculos
        // cambiarán a color magenta

        if (collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.magenta;
        }
        
        // Debug.Log("Algo me golpeó!");
    }
}
