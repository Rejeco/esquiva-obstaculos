using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float tiempoDeEspera = 3.0f;
    MeshRenderer miMeshRenderer;
    Rigidbody miRigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        miMeshRenderer = GetComponent<MeshRenderer>();
        miRigidbody = GetComponent<Rigidbody>();

        miMeshRenderer.enabled = false;
        miRigidbody.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > tiempoDeEspera)
        {
            miMeshRenderer.enabled = true;
            miRigidbody.useGravity = true;
        }
    }
}
