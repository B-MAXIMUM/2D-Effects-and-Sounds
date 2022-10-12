using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{ 
    public GameObject obstaclePrefab;
    private Vector3 _spawnPos = new Vector3(13.76f, -2.533f, 0);
    private float _startDelay = 2;
    private float _repeatRate = 2;

    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("Cum", _startDelay, _repeatRate);
    }

    // Update is called once per frame
   void Cum()
   {
       Instantiate(obstaclePrefab, _spawnPos, obstaclePrefab.transform.rotation);
   }
}
