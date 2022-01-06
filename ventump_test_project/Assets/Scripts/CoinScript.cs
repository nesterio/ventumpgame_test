using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

	private Vector3 DefaultPosition;
	

    void Awake()
    {
        DefaultPosition = transform.position;
    }

    void OnDisable()
    {
        transform.position = DefaultPosition;
    }

}
