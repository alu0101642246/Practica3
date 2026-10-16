using UnityEngine;

public class Ejercicio5 : MonoBehaviour
{
    public bool lanzando = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.X))
        {
            lanzando = true;
        }
        
    }
    void FixedUpdate()
    {
        if (lanzando)
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0f,1f,1f), ForceMode.Impulse);
            lanzando = false;
        }
    }
}