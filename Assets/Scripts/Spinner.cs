using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAngulo = 0f;
    [SerializeField] float yAngulo = 1f;
    [SerializeField] float zAngulo = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngulo, yAngulo, zAngulo);
    }
}
