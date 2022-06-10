using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
public GameObject[] objects;
public void Spawn()
{
  Instantiate(objects[Random.Range(0,objects.Length)],transform.position,transform.rotation);
}
}
