using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Itemcollect : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(gameObject);
        
        }
    }
}
