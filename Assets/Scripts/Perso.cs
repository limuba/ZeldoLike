using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class Perso : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float maxSpeed;

    [SerializeField] private float time;
    [SerializeField] private float waitTime;

    private Vector2 direction;
    private PersoControls controls;  
    private Rigidbody2D rigidbody2D;
    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider2D;
    private Animator animator;
    private bool walk;
    //private RigidBody2D rigidbody2D;

    private void OnEnable()
    {
        controls = new PersoControls(); 
        controls.Enable();
        controls.MoveHit.Move.performed += MoveOnPerformed;
        controls.MoveHit.Move.canceled += MoveOnCanceled;
        controls.MoveHit.Hit.performed += HitOnPerformed;
        //controls.MoveHit.Move.canceled += HitOnCanceled;
        //controls.MoveHit.Hit.performed += HitPerformed;

    }

    private void MoveOnPerformed (InputAction.CallbackContext obj)
    {
        direction = obj.ReadValue<Vector2>();
        animator.SetBool("walk", true);
       //boolean marche true
        //rigidbody2D.constraints = RigidbodyConstraints2D.None;
    }
    private void MoveOnCanceled (InputAction.CallbackContext obj)
    {
        direction = Vector2.zero;
        animator.SetBool("walk", false);
        //boolean marche false
        //rigidbody2D.constraints = RigidbodyConstraints2D.FreezePosition;
    }
    private void HitOnPerformed (InputAction.CallbackContext obj)
    {
        animator.SetBool("attack", true);

        boxCollider2D.enabled = true;
        Debug.Log("hit");
    }
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider2D = GetComponent<BoxCollider2D>();

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (boxCollider2D.enabled == true)
        {
            time += Time.deltaTime;

            if (time > waitTime)
            {
                boxCollider2D.enabled = false;
                time = time - waitTime;
                Debug.Log("hitf");

                animator.SetBool("attack", false);
            }
        }
    }

    private void FixedUpdate()
    {
        var Speed = Mathf.Abs(rigidbody2D.velocity.magnitude);
       
        if (Speed < maxSpeed)
        {
            rigidbody2D.AddForce(speed * direction);
        }

        float playerdirectionx = rigidbody2D.velocity.x;
        animator.SetFloat("Speedx", playerdirectionx);

        float playerdirectiony = rigidbody2D.velocity.y;
        animator.SetFloat("Speedy", playerdirectiony);

    }    
}