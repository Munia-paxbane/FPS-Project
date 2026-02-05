using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class Playermovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;

    public AudioClip footStepSFX;

    private Rigidbody rb;
    private Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        StartCoroutine(PlayFootSep());
        
    }

    void Update()
    {
           
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }
    void OnJump()
    {
        rb.AddForce(new Vector3(0f, jumpForce, 0f), ForceMode.Impulse);
    }

    void OnMovement(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
    void MovePlayer()
    {
        Vector3 direction = (transform.right * moveInput.x) + (transform.forward * moveInput.y);
        direction = direction.normalized;
    
    rb.linearVelocity = new Vector3(direction.x * moveSpeed, rb.linearVelocity.y, direction.z * moveSpeed);
    }

    IEnumerator PlayFootSep()
    {
        while (true)
        {
            if(rb.linearVelocity.magnitude> 0.1f)
            {
               AudioManager.instance.PlaySFX(footStepSFX);
            }
            yield return new WaitForSeconds(0.5f);
        }
    }
}
