using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level : MonoBehaviour
{   
    
    public GameObject prefabCadeau;
    public Vector2[] positionCadeau;
    private int indexArrayVectorCadeau=0;
    public Grinch sac;
    public sol sol;

    private int depart=0;
    private int fin=1;

    public int score=0;
    public Text textScore;

    public GameObject perdu;
    
    public GameObject gagne;
    public GameObject[] life;
    

    void Start()
    {
        indexArrayVectorCadeau=0;
        StartCoroutine(spawncadeau());
       
        
    }

    private void Update() 
    {
        textScore.text= " "+score;

        // if(sol.toucheSolMin==3)                                         <= demander au prof pourquoi ça ne fonctionne pas. 
        // {
        //     perdu.SetActive(true);
        // }

        
    }
   
    
    public IEnumerator spawncadeau()
    {
       
        while (depart<fin)
        {
                
            if(indexArrayVectorCadeau<positionCadeau.Length && indexArrayVectorCadeau>=0) 
            {           
                yield return new WaitForSeconds(2);   
                indexArrayVectorCadeau = Random.Range(0,3);
                // Debug.Log(indexArrayVectorCadeau);
                transform.position=positionCadeau[indexArrayVectorCadeau];                     
                Instantiate<GameObject>(prefabCadeau,transform.position,transform.rotation);                   
    
            }

        depart++;
        fin++;
    
        } 
            
    }
        




    //     public void spawnCadeau() 
//    {    
        
//        if(indexArrayVectorCadeau<positionCadeau.Length && indexArrayVectorCadeau>=0 && sac.sacGrinch==false) 
//        {
           
//            indexArrayVectorCadeau = Random.Range(0,3);
//            Debug.Log(indexArrayVectorCadeau);
//            transform.position=positionCadeau[indexArrayVectorCadeau];           
//            Instantiate<GameObject>(prefabCadeau,transform.position,transform.rotation);
             
//        }
       
//    } 


}
