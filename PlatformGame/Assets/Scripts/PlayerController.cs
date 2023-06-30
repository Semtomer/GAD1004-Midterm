using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody _rb;
    public GameObject _jumpObject;
    Animator _animator;

    Vector3 moveVector;
    public float movementSpeed = 1;
    public float jumpHeight = 1;

    float sensivityX = 4;
    float rotateX;

    void Start()
    {
        Cursor.visible = false;

        _rb = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        rotatePlayerBody();
        Movement();
        AnimationAndJump();
    }

    void Movement()
    {
        // Character movement

        moveVector = new Vector3(Input.GetAxis("Horizontal") * movementSpeed, _rb.velocity.y, Input.GetAxis("Vertical") * movementSpeed);
        moveVector = transform.TransformDirection(moveVector);
        _rb.velocity = moveVector;
    }

    void AnimationAndJump()
    {
        // Jump codes and player animation codes

        if (Input.GetKey(KeyCode.S))
        {
            // This is for backwards run. 
            _animator.SetFloat("playerVelocity", -_rb.velocity.magnitude);
        }
        else
        {
            // This is for idle and forward run. 
            _animator.SetFloat("playerVelocity", _rb.velocity.magnitude);
        }


        if (_jumpObject.GetComponent<isGroundForJump>().isGround)
        {
            _animator.SetBool("isGround", true);
        }
        else
        {
            _animator.SetBool("isGround", false);
        }


        if (Input.GetKeyDown(KeyCode.Space) && _jumpObject.GetComponent<isGroundForJump>().isGround)
        {
            _rb.AddForce(_rb.velocity.x, jumpHeight, _rb.velocity.z, ForceMode.Impulse);

            _animator.SetBool("isJump", true);
        }
        else
        {
            _animator.SetBool("isJump", false);
        }
    }

    void rotatePlayerBody()
    {
        // According to mouse input, the player is looking in that direction.

        rotateX = sensivityX * Input.GetAxis("Mouse X");
        Vector3 lookX = new Vector3(0, rotateX, 0);
        transform.Rotate(lookX);
    }
}
