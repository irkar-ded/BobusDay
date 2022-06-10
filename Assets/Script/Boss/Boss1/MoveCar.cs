using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    public float distante;
    public float speed;
    public Transform Car;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit,distante))
        {
            if(hit.collider){
                
            }
        }
        else
        {
            Car.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
        }
    }
}
