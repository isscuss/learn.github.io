using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour {
	public float health;
	public void ApplyDamage(float damageValue)
	{

	    health-=damageValue;
		if(health<=0)
		{
			Dead();
		}

	}

	public void Dead()
	{
		//Todo:dead
	}
}
