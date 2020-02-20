using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//An abstract class cannot be used itself, but classes that inherit from it can.
public abstract class Animal : MonoBehaviour
{
	public string Name;
	public float Speed;

	private Vector3 moveTarget;
	private float changeDelay;

	private void Update()
	{
		changeDelay -= Time.deltaTime;
		if(changeDelay <= 0f || Vector2.Distance(transform.position, moveTarget) < 1f)
		{
			changeDelay = Random.Range(2f, 6f);
			moveTarget = new Vector3(Random.Range(-7f, 7f), Random.Range(-7f, 7f), 0f);
		}

		transform.position += (moveTarget - transform.position).normalized * Speed * Time.deltaTime;
		transform.localScale = Vector3.Lerp(transform.localScale, Vector2.one * 3f, Time.deltaTime * 3f);
	}

	//A "Virtual" function is a function that inherited classes can override.
	public virtual void OnMouseDown()
	{
		transform.localScale = Vector2.one * 5f;
	}
}