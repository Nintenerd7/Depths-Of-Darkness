using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
  public float speed = 20f;
  public GameObject Explosion;
    // Update is called once per frame
    void Update()
    {
         transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
  private void OnTriggerEnter2D(Collider2D other)
  {
    Instantiate(Explosion,transform.position, Quaternion.identity);
        if(other.tag == "Destroyable")
        {
            Destroy(gameObject);
        }
        if(other.tag == "Enemy")
        {
            var enemy = other.GetComponent<Enemy_Damage>();//gets class enemy damage
           if (enemy)
        {
         enemy.TakeHit(1f);//enemy takes a hit from the bullet
        }
            Destroy(gameObject);//destroys object after collision
        }
  }
}
