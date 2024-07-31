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
    public static bool isDashing = false; 
    public TrailRenderer tr;
    public Animator anim;
    public bool Swimming = false;
    public LayerMask Water;
    public LayerMask Ground;
    public Manabar mana;
    // Start is called before the first frame update
    // Update is called once per frame

    void Start()
    {
     Swimming = false;
    }
    void Update()
    {
             if(mana.totalMana < 0.2f)
            {
             isDashing = false;//player cannot dash 
            }
            else
            {
             StartCoroutine(Dash(8f));//player can dash if it has enough juice
            }
     Horizontal = Input.GetAxisRaw("Horizontal");
     Vertical = Input.GetAxisRaw("Vertical"); 
     IsWalkable();
     IsSwimmable();
    }
    private void FixedUpdate()
    {
      body.velocity = new Vector2(Horizontal * speed, Vertical * speed);
    }

    //dash mechanic
    public IEnumerator Dash(float dashing)
    {

      if(!isDashing && Input.GetMouseButtonDown(1) && mana.totalMana > 0)
      {
        AudioSourceController.Instance.PlaySFX("Dash");
         isDashing = true;
         speed += dashing;
         mana.Magic_Cost(0.1f);
         tr.emitting = true;
         yield return new WaitForSeconds(0.4f);
         tr.emitting = false;
         isDashing = false;
         speed = 3f;
      }
    }

    public void UpdateAnim()
    {
      if(body.velocity != Vector2.zero)
      {
      anim.SetBool("Swimming", false);
      anim.SetBool("Walking", true);
      anim.SetFloat("Horizontal", body.velocity.x);
      anim.SetFloat("Vertical", body.velocity.y);
      }
      else
      {
       anim.SetBool("Walking", false);
      }
    }

    public void UpdateWater()
    {
      if(body.velocity != Vector2.zero)
      {
      anim.SetBool("Swimming", true);
      anim.SetBool("Walking", false);
      anim.SetFloat("Horizontal", body.velocity.x);
      anim.SetFloat("Vertical", body.velocity.y);
      }
  
    }
              private bool IsSwimmable()
        {
            //enables collisisions for interactive objects
            if (Physics2D.OverlapCircle(transform.position, 0.3f, Water) != null)
            {
                Swimming = true;
                UpdateWater();
                return false;
            }
            
            return true;
        }

                 private bool IsWalkable()
        {
            //enables collisisions for interactive objects
            if (Physics2D.OverlapCircle(transform.position, 0.3f, Ground) == null)
            {
                Swimming = false;
                UpdateAnim();
                return false;
            }
            
            return true;
        }

}
