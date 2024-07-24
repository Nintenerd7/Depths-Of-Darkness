using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Bullet_Operator : MonoBehaviour
{
  //bullet index
  public static Bullet_Operator Instance;
  public GameObject Bullet;
  public Bullet_Index[] BULLETS;
  public bool isShooting;
      private void Awake()
    {
        if (Instance == null)//if there is no instance in the audio source
        {
            Instance = this;//set instance to the index of the sound name.
            DontDestroyOnLoad(gameObject);//do not destroy
        }
        else
        {
            Destroy(gameObject);
        }
    }
      private void Start()
    {
        SwitchBullet("Fire");
    }
    public void SwitchBullet(string Name)
    {
        Bullet_Index s = Array.Find(BULLETS, X => X.Bullet_Name == Name);

        if (s == null)
        {
          isShooting = false;
            Debug.Log("Error");
        }
        else
        {
          isShooting = true;
          Bullet = s.Bullet_Type;
        }
    }

}
