using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gain_Health : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {

            var health = other.GetComponent<Hearts_System>();
            //AudioSourceController.Instance.PlaySFX("Collect");
        if (health)
        {
          health.GiveHeart(1);
          Destroy(gameObject);
        }
        }
    }
}
