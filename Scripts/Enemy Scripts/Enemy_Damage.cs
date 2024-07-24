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
    public GameObject Loot;

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
            LootDrop();
            Instantiate(Explosion,transform.position, Quaternion.identity);
            Destroy(this.gameObject);//enemy is killed
        
        }
    }
//randomizing the ammount of times you can get loot from enemies
    public void LootDrop()
    {
                 Debug.Log("loot");
                Instantiate(Loot,transform.position, Quaternion.identity);//spawns loot from enemy position

    }


}
