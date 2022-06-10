using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    public GameObject Tp;
    public float _speed = 2;
    public float _endPosX;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void StartFloating(float speed, float endPosX)
    {
        _speed = speed;
        _endPosX = endPosX;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * (Time.deltaTime * _speed));
        if (transform.position.x < _endPosX)
        {
            transform.position = new Vector2(Tp.transform.position.x, Tp.transform.position.y);
        }
    }
}
