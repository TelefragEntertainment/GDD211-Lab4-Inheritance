using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeGoblin : Goblin
{
	public override void TakeDamage(float dmg)
	{
		base.TakeDamage(dmg);

		//Large goblins can regenerate health.
		if (Health > 0f)
		{
			Health += 1f;
			Debug.Log(Name + " gained 1 health!");
		}
	}
}
