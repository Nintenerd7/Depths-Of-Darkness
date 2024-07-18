using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top_Down_movement : MonoBehaviour
{
    //variables for the game 
    public Rigidbody2D body;
    public float speed;
    float Horizontal;
    float Vertical;
    public bool isDashing = false; 
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
     Horizontal = Input.GetAxisRaw("Horizontal");
     Vertical = Input.GetAxisRaw("Vertical"); 
     StartCoroutine(Dash(6f));
     Flip();
    }
    private void FixedUpdate()
    {
      body.velocity = new Vector2(Horizontal * speed, Vertical * speed);
    }

    //dash mechanic
    public IEnumerator Dash(float dashing)
    {

      if(!isDashing && Input.GetMouseButtonDown(1))
      {
         isDashing = true;
         speed += dashing;
         yield return new WaitForSeconds(0.4f);
         isDashing = false;
         speed = 5f;
      }
    }
    public void Flip()
    {
        if (Horizontal < -.01f)
        {
            transform.localScale = new Vector2(-1, 1);
        }
        else if (Horizontal > .01f)
        {
            transform.localScale = new Vector2(1, 1);
        }
    }
}
