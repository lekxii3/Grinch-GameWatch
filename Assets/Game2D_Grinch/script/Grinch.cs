using System.Collections.Generic;
using UnityEngine;

public class Grinch : MonoBehaviour
{
    
    private Rigidbody2D rb;
    private Animator anim;
    public Vector2[] positionsaving; 
    private int index =0;
    public bool sacGrinch = false;


    
    public GameObject cadeauCatching;
    // public GameObject prefabCadeau;
    // public Vector2[] positionCadeau;
    // private int indexArrayVectorCadeau=0;

  
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        index=1;    
        // indexArrayVectorCadeau=1;    
    }


    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.D) && index<positionsaving.Length-1) 
        {
            index++;
            transform.position = positionsaving[index];
        }
       
        if(Input.GetKeyDown(KeyCode.Q) && index>0) 
        {
            index--;
            transform.position = positionsaving[index]; 
        }

    }


    private void OnCollisionEnter2D(Collision2D other )   
    {
        if(CompareTag("grinch") && sacGrinch==false) 
        {
            
            anim.SetTrigger("isGettingKDO");
            Destroy(other.gameObject);            
            sacGrinch = true;   
            cadeauCatching.SetActive(true);
            
                        
        } 
           
    }

    // private void OnTriggerEnter2D(Collider2D other) 
    // {
           

    //     if(other.gameObject.CompareTag("shape")) 
    //     {
    //         Debug.Log("je suis touché");     
            
    //     } 
                
    // }

//    public void spawnCadeau() 
//    {    
//     //    if(sacGrinch==false)
//     //    {
//     //        Instantiate<GameObject>(prefabCadeau);
//     //    }

    
//        if(indexArrayVectorCadeau<positionCadeau.Length-1 && indexArrayVectorCadeau>0 && sacGrinch==false) 
//        {
//            indexArrayVectorCadeau++;
//            //indexArrayVectorCadeau = Random.Range(0,4);
//            transform.position=positionCadeau[indexArrayVectorCadeau];
//            Instantiate<GameObject>(prefabCadeau,transform.position, transform.rotation);
//        }
//    }     

 /*public void apparaitreCadeau(Vector2[] positionCadeau)
    {
        for (int i = Random.Range(0,4); i < positionCadeau.Length; i++)
        {
            Instantiate<GameObject>(prefabCadeau, positionCadeau[i],transform.position);
        }
    }*/



   
} 

