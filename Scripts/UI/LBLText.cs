using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class LBLText : MonoBehaviour
{
    public TMP_Text component;
    public string[] lines;
    public float speed;

    private int index;
    // Start is called before the first frame update
    void Start()
    {
        component.text = string.Empty;
        StartText();
    }

    // Update is called once per frame
    void Update()
    {
if(Input.GetKeyDown(KeyCode.Space))
{
          if(component.text == lines[index])
          {
            NewLine(); 
          }
          else
          {
            StopAllCoroutines();
            component.text = lines[index];
          }
}

    }

    void StartText()
    {
      index = 0;
      StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
     foreach(char c in lines[index].ToCharArray())
     {
      AudioSourceController.Instance.PlaySFX("LBL");
      component.text += c;
      yield return new WaitForSeconds(speed);
     }
    }

    void NewLine()
    {
      if(index < lines.Length - 1)
      {
        index ++;
        component.text = string.Empty;
        StartCoroutine(TypeLine());
      }
      else
      {
        AudioSourceController.Instance.PlayMusic("Level");
        SceneManager.LoadScene(2);
        gameObject.SetActive(false);
      }
    }
}
