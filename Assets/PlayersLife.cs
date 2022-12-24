using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersLife : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Enemy Body")){
            Die();
        }
    }
    void die(){
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
    }
}
