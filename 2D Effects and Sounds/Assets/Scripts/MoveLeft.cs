using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float MoveSpeed = 10;

    private PlayerControll _playerScript;
    // Start is called before the first frame update
    void Start()
    {
        _playerScript = GameObject.Find("Player").GetComponent<PlayerControll>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!_playerScript.isGameOver)
        {
            transform.Translate(Vector2.left * MoveSpeed * Time.deltaTime);
        }
    }
}
