using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Presage 
{
	private int index;

	public enum Symbol
	{
		Comet,
		Thunder,
		Gear
	}

	public void Advance ()
	{
		Debug.Log ("Advancing Presage.");
		index++;
		Debug.Log ("Presage is now " + Value);
	}

	public Symbol Value
	{
		get 
		{
			switch (index % 4)
			{
			case 0:
				return Symbol.Comet;
			case 1:
				return Symbol.Thunder;
			case 2:
				return Symbol.Gear;
			case 3:
				return Symbol.Thunder;
			default:
				Debug.LogAssertion ("[ASSERT] Presage/getValue: Symbol to return is unknown.");
				return 0;
			}
		}
	}
}
