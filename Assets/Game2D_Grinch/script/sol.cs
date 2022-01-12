using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sol : MonoBehaviour
{

    public int toucheSolMin=0;
    public int toucheSolMax=3;

    public level level;



public void OnCollisionEnter2D(Collision2D other )   
    {
        if(CompareTag("sol"))
        {
           
            toucheSolMin++;
            if (toucheSolMin==1)
            {
                level.life[2].SetActive(false);
            }

            if (toucheSolMin==2)
            {
                level.life[1].SetActive(false);
            }

            if (toucheSolMin==3)
            {
                level.life[0].SetActive(false);
                level.perdu.SetActive(true);
            }
            
            Destroy(other.gameObject);


        

        }
    }




}
