using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("hello this works");
    }

    private void OnTriggerEnter(Collider other) {
        //Debug.Log("entered the trigger");

        if(other.gameObject.CompareTag("PickUp")){
            //Debug.Log("ran into PickUp object");
            
            // whatever action you want
            //other.gameObject.SetActive(false);
            Destroy(other.gameObject);
        }

    }    
    
}
