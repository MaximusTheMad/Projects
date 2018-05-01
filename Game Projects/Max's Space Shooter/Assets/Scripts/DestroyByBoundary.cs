using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour {


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag != "Bolt" && other.gameObject.tag!="EnemyBolt")
        {
            
            Destroy(other.gameObject);
        }
        else
        {
            Destroy(other.gameObject.transform.parent.gameObject);
        }
    }
}
