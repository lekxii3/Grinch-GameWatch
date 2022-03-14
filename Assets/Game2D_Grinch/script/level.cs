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

    public GameObject menu;
    private bool menuBool = false;

    
    

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
        showMenu();
        
        
       
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
        

        /// affichage menu 
        public void showMenu()
        {
            if(Input.GetKeyDown(KeyCode.Escape) && menuBool == false)
            {
                Time.timeScale = 0;
                menuBool = true;           
                menu.SetActive(true);                  
            }

            else if(Input.GetKeyDown(KeyCode.Escape)&& menuBool == true)
            {
                Time.timeScale = 1;
                menuBool = false;
                menu.SetActive(false);                
            }
        }

    ///recommencer le niveau
    public void Reload()
    {
        SceneManager.LoadScene(0);
    }
    
    ///reprendre le jeu
    public void Reprendre()
    {
        Time.timeScale = 1;
        menuBool = false;
        menu.SetActive(false);    
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
