using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemies : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform spawner;

    private Transform target;
    public GameObject player;
    private Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("target");
        target = player.transform;
      
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, target.position, step);
    }

   

    private void OnTriggerEnter2D(Collider2D colliderTriggered)
    {
        rigidbody2D.transform.position = spawner.position;
        //destroy
    }

}
