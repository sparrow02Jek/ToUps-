using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public bool Istrue;
    public GameObject Coins;
   
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.collider.tag == "Player"){
            Destroy(Coins);
        }
        if( collision.gameObject.tag == "enemy" ){
            Destroy(Coins);
            Istrue = false;
        }
    }
    private void OnCollisionStay2D(Collision2D collision2)
    {
        if( collision2.gameObject.tag == "enemy" ){
            Istrue = false;
            Destroy(Coins);
        }
    }
}

