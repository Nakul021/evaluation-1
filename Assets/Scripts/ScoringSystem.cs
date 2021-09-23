using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoringSystem : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
      if (tag == "Coin")
     {
        
         Destroy(gameObject);
     }
    }
}
