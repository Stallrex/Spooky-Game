using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{

    public int nextLevelID;
    
    void Start()
    {

    }
    
    void Update()
    {
        
            
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player"){
        SceneManager.LoadScene(nextLevelID);
        }
    }
    
}
