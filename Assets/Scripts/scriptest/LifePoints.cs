using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifePoints : MonoBehaviour
{
    public int Health = 3;
    int damageHealth;
    // Start is called before the first frame update
    void Start()
    {
        damageHealth = Health;
    }
    
    public void Damaged(int damage)
    {
        damageHealth -= damage;

        if(damageHealth <= 0)
        {
            Dead();
        }
    }

    void Dead()
    {
        Debug.Log("jsumor");
        //load scene ded
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
