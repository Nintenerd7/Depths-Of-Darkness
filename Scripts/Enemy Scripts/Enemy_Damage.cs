using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Damage : MonoBehaviour
{
   //variables
    public float HitPoints;
    public float maxHitPoints = 3;
    public Rigidbody2D EnemyBody;
    public GameObject Explosion;
    //

    void start()
    {
        HitPoints = maxHitPoints;
        EnemyBody = GetComponent<Rigidbody2D>();

    }

    public void TakeHit(float damage)
    {
        HitPoints -= damage;

        if (HitPoints <= 0)
        {
            
            Instantiate(Explosion,transform.position, Quaternion.identity);
            Destroy(this.gameObject);//enemy is killed
        
        }
    }


}
