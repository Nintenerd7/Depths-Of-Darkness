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
    public GameObject Heart_Loot;
    public GameObject Ore_Loot;
    public Hearts_System health;

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
            Enemy_Spawnner.count ++;
        
        }
    }
//randomizing the ammount of times you can get loot from enemies
    public void LootDrop()
    {
               if (health.HeartHealth <=2)
            {
               Debug.Log("loot");
              Instantiate(Heart_Loot,transform.position, Quaternion.identity);//spawns loot from enemy position
            }
            else 
            {
              //nothing for now
            }
                

    }


}
