using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destin 
{
	private int destin;
	public const int MAX = 20;

	public Destin (int initialValue)
	{
		destin = initialValue;
	}

	public void Advance (int amount = 1)
	{
		Debug.Log ("Advancing destin by " + amount);
		destin -= amount;
		Debug.Log ("Destin is now " + destin);
	}
		
	public void Retreat (int amount = 1)
	{
		Debug.Log ("Retreating destin by " + amount);
		destin += amount;
		if (destin > 20)
		{
			destin = 20;
		}
		Debug.Log ("Destin is now " + destin);
	}

	public int Value
	{
		get
		{
			return destin;
		}
	}
}
