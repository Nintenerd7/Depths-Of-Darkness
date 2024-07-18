using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
  public float speed = 20f;

    // Update is called once per frame
    void Update()
    {
         transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
  private void OnTrigger2D(Collider2D other)
  {
      Destroy(gameObject);
  }
}
