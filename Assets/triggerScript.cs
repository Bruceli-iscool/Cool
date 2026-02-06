using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerScript: MonoBehaviour
{
   // Called when this object collides with another
   void OnCollisionEnter(Collision collision)
   {
       // Detect by tag
       if (collision.gameObject.tag == "Finish")
       {
        Debug.Log("triggered");
       }
       // Detect by name
   }
}
