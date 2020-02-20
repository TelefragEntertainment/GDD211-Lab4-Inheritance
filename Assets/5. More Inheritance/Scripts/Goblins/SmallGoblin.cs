using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallGoblin : Goblin
{
	public override void TakeDamage(float dmg)
	{
		base.TakeDamage(dmg);

		//Small goblins can be smashed to pieces.
		if (Health <= 0f)
		{
			Debug.Log(Name + " was smashed to pieces!");
		}
	}
}
