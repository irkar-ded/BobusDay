using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCarBoss : MonoBehaviour
{
    float Timer;
    public float kd;
    public GameObject[] Cars;
    GameObject[] CarsObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CarsObject = GameObject.FindGameObjectsWithTag("Car");
        if(CarsObject.Length <= 5)
        {
            Timer += Time.deltaTime;
            if(Timer >= kd)
            {
                Instantiate(Cars[Random.Range(0,Cars.Length)],transform.position,transform.rotation);
                Timer = 0;
            }
        }
    }
}
