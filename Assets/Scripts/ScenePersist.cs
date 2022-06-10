using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScenePersist : MonoBehaviour
{
    void Awake()
    {   
        //Singleton
        int numScenePersists = FindObjectsOfType<ScenePersist>().Length;
        
        if(numScenePersists > 1) // if it's created again we destroy it
        {
            Destroy(gameObject);
        }
        else 
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void ResetScenePersist()
    {
        Destroy(gameObject);
    }
   
}
