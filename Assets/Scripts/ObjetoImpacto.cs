using UnityEngine;

public class ObjetoImpacto : MonoBehaviour
{
    // Esta funcion nos permite controlar
    // Que se debe de hacer cuando
    // es chocado por algo como el jugador
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Algo me golpeó!");
    }
}
