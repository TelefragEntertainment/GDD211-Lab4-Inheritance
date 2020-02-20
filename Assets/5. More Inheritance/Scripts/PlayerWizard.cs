using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWizard : MonoBehaviour
{
	private void Update()
	{
		if(Input.GetMouseButtonDown(0))
		{
			Vector3 mPos = Input.mousePosition;
			mPos.z = 0;

			RaycastHit2D hit = Physics2D.Raycast(transform.position, Camera.main.ScreenToWorldPoint(mPos) - transform.position);
			
			if(hit)
			{
				Debug.DrawLine(transform.position, hit.point, Color.red, 1f);

				Enemy hitEnemy = hit.collider.GetComponent<Enemy>();
				if(hitEnemy)
				{
					hitEnemy.TakeDamage(10f);
				}
			}
			
		}
	}
}
