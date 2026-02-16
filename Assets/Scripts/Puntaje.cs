using UnityEngine;

public class Puntaje : MonoBehaviour
{
    int choques = 0;
    void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Hit"))
        {
            choques++;
            Debug.Log("Has chocado contrado esta canitdad de veces: " + choques);
        }
        
    }
}
