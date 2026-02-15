using UnityEngine;

public class Puntaje : MonoBehaviour
{
    int choques = 0;
    void OnCollisionEnter(Collision collision)
    {
        choques++;
        Debug.Log("Has chocado contrado esta canitdad de veces: " + choques);
    }
}
