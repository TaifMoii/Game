using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nhanvat : MonoBehaviour
{
    public float tocDo;
    public float doCao;
    private Rigidbody2D rb;
    private Animator ani;
    private bool quayPhai = true;
    private float traiPhai;
    public GameObject obj;
    private bool duocnhay;
    private Vector2 hs;
    public int HP=5;
    void Start()
    {
        hs = transform.position;
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
       
        
    }

    void Update()
    {
        traiPhai=Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(traiPhai * tocDo,rb.velocity.y);
        nhay();
        flip();
        ani.SetFloat("move", Mathf.Abs(traiPhai));
        spawn();
        Lose();
    }
    public void nhay()
    { 
     if ((Input.GetKeyDown(KeyCode.Space) && duocnhay) || (Input.GetKeyDown(KeyCode.UpArrow) && duocnhay))
     {
      rb.AddForce(Vector2.up * doCao,ForceMode2D.Impulse);
     }
    }
    private void OnTriggerEnter2D(Collider2D hitbox) 
    {
     if(hitbox.gameObject.tag == "san")
     {
      duocnhay = true;
     }
     if (hitbox.gameObject.tag == "spawn")
     {
      transform.position = hs;
      HP-=1;
     }
    }
    
    private void OnTriggerExit2D(Collider2D hitbox) 
    {
     if(hitbox.gameObject.tag == "san")
     {
      duocnhay = false;
     }
    }
    void flip()
    { 
     if (quayPhai && traiPhai < 0 || !quayPhai && traiPhai > 0 )
     {
      quayPhai = !quayPhai;
      Vector3 kt = transform.localScale;
      kt.x = kt.x * -1;
      transform.localScale = kt;
     }
    }  
   void spawn()
   {
    if (Input.GetKeyDown(KeyCode.R))
    {
     transform.position = hs;

    }
   }
   void Lose()
   {
    void slose()
    {
     SceneManager.LoadScene(5);
    }
    if (HP<=0)
   { 
    slose(); 
   }
    
   }
}
