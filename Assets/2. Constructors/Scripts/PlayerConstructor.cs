using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerConstructor : MonoBehaviour
{
	public string Name;
	public int Health;
	public TMP_Text Text;

	private InventoryConstructor playerInventory;
	private float delay;

	private void Start()
	{
		playerInventory = new InventoryConstructor(10, 20, 30);
	}

	private void Update()
	{
		delay -= Time.deltaTime;
		if(delay <= 0f)
		{
			delay = 1f;

			if (Health > 0f)
				Health--;

			if (playerInventory.Gold > 0)
				playerInventory.Gold--;

			if (playerInventory.Silver > 0)
				playerInventory.Silver--;

			if (playerInventory.Copper > 0)
				playerInventory.Copper--;

			Text.text = Name + "\nHealth: " + Health + "\nGold: " + playerInventory.Gold + " - Silver: " + playerInventory.Silver + " - Copper: " + playerInventory.Copper;
		}
	}
}
