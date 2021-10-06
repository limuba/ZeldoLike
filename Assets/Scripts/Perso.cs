using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class Perso : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float maxSpeed;

    private Vector2 direction;
    private PersoControls controls;  //aled
    private Rigidbody2D rigidbody2D;
    private SpriteRenderer spriteRenderer;
    //private RigidBody2D rigidbody2D;

    private void OnEnable()
    {
        controls = new PersoControls(); //aled
        controls.Enable();
        controls.MoveHit.Move.performed += MoveOnPerformed;
        controls.MoveHit.Move.canceled += MoveOnCanceled;
        //controls.MoveHit.Move.canceled += MoveOncanceled;
        //controls.MoveHit.Hit.performed += HitPerformed;

    }

    private void MoveOnPerformed (InputAction.CallbackContext obj)
    {
        direction = obj.ReadValue<Vector2>();

        rigidbody2D.constraints = RigidbodyConstraints2D.None;
    }
    private void MoveOnCanceled (InputAction.CallbackContext obj)
    {
        direction = Vector2.zero ;
        rigidbody2D.constraints = RigidbodyConstraints2D.FreezePosition;
    }
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        var Speed = Mathf.Abs(rigidbody2D.velocity.magnitude);
       
        if (Speed < maxSpeed)
        {
            rigidbody2D.AddForce(speed * direction);
        }
    }
}
