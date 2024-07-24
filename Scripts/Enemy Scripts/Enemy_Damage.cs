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
       if (Random.Range(0, 3) <= 1)//if random range is more or equal to two
            {
                     Debug.Log("loot");
                 Loot_Types.Can_loot = true;
                Instantiate(Loot,transform.position, Quaternion.identity);//spawns loot from enemy position
            }
            else if (Random.Range(0, 3) <= 3)//if random range is equal to six
            {
                     Debug.Log("No loot");
              Loot_Types.Can_loot = false;
            }
    }


}
