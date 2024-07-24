using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staff_Shooting : MonoBehaviour
{
    public float Offset;
  
    public Transform Fire_Point;
    public Bullet_Operator fire;
    public Manabar Mana;
    //bullet cooldowns
    private float ShotDelay;
    public float HasShot;
    // Start is called before the first frame update
    void Update()
    {
      Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition)-transform.position;
      float rotZ = Mathf.Atan2(difference.y,difference.x)*Mathf.Rad2Deg;
      transform.rotation = Quaternion.Euler(0f,0f,rotZ);
        
        if(ShotDelay <= 0)
        {
        if(Input.GetMouseButtonDown(0)&& fire.isShooting)
        {
          Shoot();
        }
        }
        else
        {
           ShotDelay -= Time.deltaTime;//cooldown
        }
    }

void Shoot()
{
 Instantiate(fire.Bullet,Fire_Point.position, Fire_Point.rotation);
 ShotDelay = HasShot;
 Mana.Magic_Cost(0.02f);
 
}
}
