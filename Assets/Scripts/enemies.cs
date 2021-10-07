using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemies : MonoBehaviour
{
    [SerializeField] private float speed;
   // [SerializeField] private Transform spawn;

    private Transform target;
    public GameObject player;



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("target");
        target = player.transform;
        float step = speed * Time.deltaTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, target.position, step);

        /*
        if (Vector2.Distance(transform.position, target.position) < 0.001f)
        {
           // target.position *= -1.0f;
        }
        */
    }
    
}
