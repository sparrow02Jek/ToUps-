using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour
{
    GameObject newObj;
    public GameObject Player;
    [SerializeField]
    float BGmove;
    public GameObject BG1;
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
      
        transform.Translate(new Vector3(0,-BGmove,0));
    }
    
    private void OnTriggerEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Finish")
        {
            Destroy(gameObject);
            Debug.Log("diaw");
        }
    }
    
    /*private void OnTriggerEnter2D(Collision2D coll){
        if(coll.collider.tag == "END"){
            Destroy(newObj);
        }
    }*/

    
}
