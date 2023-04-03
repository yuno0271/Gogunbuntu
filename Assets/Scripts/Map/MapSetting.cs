using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSetting : MonoBehaviour
{
	[SerializeField] private float distance = 20f;
	public float Distance => distance;

	public int currentGoldCoins = 0;
	private int maxGoldCoins;
	private bool isGold;

	private void Awake()
	{
		Transform[] myChildren = this.GetComponentsInChildren<Transform>();

		foreach (Transform child in myChildren)
			if (child.tag == "Gold_Coin")
				maxGoldCoins++;


		if (maxGoldCoins > 0)
		{
			isGold = true;
		}
	}

	private void Update()
	{
		if (transform.position.x < -(distance + 10))
		{
			Destroy(gameObject);
		}

		if(currentGoldCoins == maxGoldCoins && isGold)
		{
			isGold = false;
			Debug.Log("Bonus!");
		}
	}
}