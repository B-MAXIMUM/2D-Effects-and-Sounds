using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiBoobs : MonoBehaviour
{
    public float leftBounds = -15;
    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < leftBounds)
        {
            Destroy(this.gameObject);
        }
    }
}
