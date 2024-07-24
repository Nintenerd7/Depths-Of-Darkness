using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hearts_System : MonoBehaviour
{
 //variables 
    public int HeartHealth;
    public int HeartCount;
    int i = 0;//for the ammount of hearts you have displaying on the hud
    //UI Variables
    public Image[] hearts;
    public Sprite Full;
    public Sprite Empty;
    //
    // Update is called once per frame
    void Update()
    {
        if (HeartHealth > HeartCount)
        {
            HeartHealth = HeartCount;   
        }


        for (int i = 0; i< hearts.Length; i++)
        {
            if (i < HeartHealth)
            {
                hearts[i].sprite = Full;
            }
            else
            {
                hearts[i].sprite = Empty;
            }

            if (i< HeartCount)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }

    
        }
    }

    #region TakeHeart And GiveHeart Methods 
    public void TakeHeart(int Heart_Damage)
    {
        HeartHealth-=Heart_Damage;
        hearts[i].sprite = Empty;
       // AudioSourceController.Instance.PlaySFX("Player_Hit");
        if (HeartHealth == 0)
        {
            //SceneManager.LoadScene(2);
            HeartHealth = 3; 
        }
    }
    #endregion
    public void GiveHeart()
    {

        HeartHealth+=1; 
        
        hearts[i].sprite = Full;//sprite changes 
        if (HeartHealth == 3)
        {
            HeartHealth = 3; 
        }
    }
}
