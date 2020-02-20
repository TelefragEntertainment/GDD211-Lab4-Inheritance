using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
	public override void OnMouseDown()
	{
		base.OnMouseDown();
		Debug.Log(Name + ": Woof!");
	}
}
