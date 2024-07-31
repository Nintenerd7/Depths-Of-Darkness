using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Select : MonoBehaviour
{
    public static bool IsPaused;
    public GameObject[] HiddenOBJ = new GameObject [2];
    [SerializeField] GameObject SelectMenu;

    void Update()
    {
      if(!PauseMenu.IsPaused)
      {
        CanSelect();//player can select bullets if not paused
      }
 
    }
    public void Pause_Menu()
    {
        IsPaused = true;
        SelectMenu.SetActive(true);
        Time.timeScale = 0f;//pauses menu

    }

    
    public void resume()
    {
        //AudioSourceController.Instance.PlaySFX("Button");//plays game over jingle
        IsPaused=false;
        SelectMenu.SetActive(false);
        Time.timeScale = 1f;//menu disapears
    }

    public void Fire()
    {
        Bullet_Operator.Instance.SwitchBullet("Fire");
        IsPaused=false;
        SelectMenu.SetActive(false);
        HiddenOBJ[0].SetActive(true);
         HiddenOBJ[1].SetActive(true);
        Time.timeScale = 1f;//menu disapears
    }
        public void Water()
    {
        Bullet_Operator.Instance.SwitchBullet("Water");
        IsPaused=false;
        SelectMenu.SetActive(false);
        Time.timeScale = 1f;//menu disapears
        HiddenOBJ[0].SetActive(true);
         HiddenOBJ[1].SetActive(true);
    }
      public void Air()
    {
        Bullet_Operator.Instance.SwitchBullet("Air");
        IsPaused=false;
        SelectMenu.SetActive(false);
        Time.timeScale = 1f;//menu disapears
                HiddenOBJ[0].SetActive(true);
         HiddenOBJ[1].SetActive(true);
    }
     public void Earth()
    {
        Bullet_Operator.Instance.SwitchBullet("Earth");
        IsPaused=false;
        SelectMenu.SetActive(false);
        Time.timeScale = 1f;//menu disapears
                HiddenOBJ[0].SetActive(true);
         HiddenOBJ[1].SetActive(true);
    }

    void CanSelect()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (IsPaused)
            {
                resume();
                HiddenOBJ[0].SetActive(true);
                HiddenOBJ[1].SetActive(true);
            }
            else
            {
                Pause_Menu();
                HiddenOBJ[0].SetActive(false);
                HiddenOBJ[1].SetActive(false);
            }
        }
    }

}
