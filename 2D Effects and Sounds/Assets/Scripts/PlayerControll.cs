using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    public float jumpForce = 10;
    private Animator _playerAnim;
    public bool IsOnGround = false;
    public bool isGameOver = false;
    public AudioClip jumpSound;
    public AudioClip pain;
    private AudioSource _playerAudio;
    private Rigidbody2D _playerRB;

    // Start is called before the first frame update
    void Start()
    {
        _playerRB = GetComponent<Rigidbody2D>();
        _playerAnim = GetComponent<Animator>();
        _playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && IsOnGround && !isGameOver)
        {
            _playerRB.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            IsOnGround = false;
            _playerAnim.SetBool("IsOnGround", false);
            _playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            IsOnGround = true;
            _playerAnim.SetBool("IsOnGround", true);
        }
        else if(other.gameObject.CompareTag("Rock"))
        {
            isGameOver = true;
            _playerAnim.SetTrigger("IsDead");
            _playerAudio.PlayOneShot(pain, 1.0f);
        }
    }
}