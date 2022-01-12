using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shape : MonoBehaviour
{
    private Rigidbody2D rb;

    private Animator anim;

    public Grinch sac ;
    public level spawn;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
    }

   
    void Update()
    {
        
    }



    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (CompareTag("shape")&& sac.sacGrinch==true)
        {
                    
            anim.SetTrigger("isGettingOpen");
            sac.sacGrinch=false;     
            sac.cadeauCatching.SetActive(false);    
            spawn.score++;

            if (spawn.score==10)
            {
                spawn.gagne.SetActive(true);
            }        
                        
        }
    }

    

}
