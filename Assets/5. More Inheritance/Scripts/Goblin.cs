using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Goblin : Enemy
{
	[Range(0f,1f)] public float Armor;

	public override void TakeDamage(float dmg)
	{
		float modDamage = dmg * (1f - Armor);
		Health -= modDamage;
		Debug.Log(Name + " took " + modDamage);
	}
}
