using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMove : MonoBehaviour
{
    public float speed;
    GameObject target;
    public float rotationSpeed = 1f;

    Quaternion rotateToTarget;
    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        dir = (target.transform.position - transform.position).normalized;
        float angle = Mathf.Atan2(dir.y,dir.x) * Mathf.Rad2Deg;
        rotateToTarget = Quaternion.AngleAxis(angle,Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation,rotateToTarget,Time.deltaTime * rotationSpeed);
        transform.Translate(new Vector3(dir.x*2,dir.y*2,0) * speed * Time.deltaTime);
    }
}
