using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScript : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Coin"))
        {
        	col.gameObject.SetActive(false);
        }
    }

}
