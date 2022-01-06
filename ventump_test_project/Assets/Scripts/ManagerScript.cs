using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ManagerScript : MonoBehaviour
{
	[Header("Reference assignment")]
	private ObjectPooler _ObjectPooler;
	[SerializeField]private TextMeshProUGUI BalanceText;

	[Space]

	[Header("Values assignment")]
	private int CurrentBalance;
	[SerializeField]private int DefaultBalance;



	void Start()
	{
		_ObjectPooler = ObjectPooler.Instance;
		CurrentBalance = DefaultBalance;
		BalanceText.text = "Balance: " + CurrentBalance;
	}


    public void SpawnCoin()
    {

        _ObjectPooler.SpawnFromPool("Coin");

        if(CurrentBalance > 0)
        {
        	CurrentBalance--;
        }
        else
        {
        	CurrentBalance = DefaultBalance;
        }

        BalanceText.text = "Balance: " + CurrentBalance;

    }

}
