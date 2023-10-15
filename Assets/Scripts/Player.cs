using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float speed = 5f;
    public int nextLevelID;
    public GameObject start;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = start.transform.position;
    }
    private void OnCollisionEnter2D(Collision2D other) {

        if(other.gameObject.tag == "Wall"){
        SceneManager.LoadScene(nextLevelID);
        }

        
        if(other.gameObject.tag == "Exit"){
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        var worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPos.z = 0;
        var targetPos = Vector2.MoveTowards(transform.position, worldPos, speed * Time.deltaTime);
        rb.MovePosition(targetPos);

    }
    
}
