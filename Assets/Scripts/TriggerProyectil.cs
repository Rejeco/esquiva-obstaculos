using Unity.VisualScripting;
using UnityEngine;

public class TriggerProyectil : MonoBehaviour
{
    // Se hace referencia a los objetos de juego Proyectil
    // Por medio del Inspector gracias SerializeField
    // en el campo proyectil.

    // Cuando el jugador colisiona en el objeto trigger
    // este compara si la etiqueta es Player y
    // acitva al proyectil para realice sus instrucciones

    // Nota: Primero se debe desactivar el objeto del 
    // Juego para luego activarlo en el script.
    // Si no hará sus instrucciones independientemente
    // del trigger
    [SerializeField] GameObject proyectil;
    [SerializeField] GameObject proyectil2;
    [SerializeField] GameObject proyectil3;
    [SerializeField] GameObject proyectil4;
    [SerializeField] GameObject proyectil5;
    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            proyectil.SetActive(true);
            proyectil2.SetActive(true);
            proyectil3.SetActive(true);
            proyectil4.SetActive(true);
            proyectil5.SetActive(true);
            Destroy(gameObject); // Destruye el objeto trigger despues de hacer su accion

            // Este código verifica que los
            // proyectiles existan para
            // activarlos y así evitar un
            // error con el trigger cuando lo busca.
            /*
            SetActive(proyectil);
            SetActive(proyectil2);
            SetActive(proyectil3);
            SetActive(proyectil4);
            SetActive(proyectil5);
            */
        }    
    }

    // Este metodo obtiene el proyectil y verifica que exista
    private void SetActive(GameObject gameObject)
    {
        if (!gameObject.IsUnityNull())
        {
            gameObject.SetActive(true);
        }
    }
}
