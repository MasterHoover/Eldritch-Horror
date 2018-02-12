using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice 
{
	#region Fields
	public const int MIN_VALUE = 1;
	public const int MAX_VALUE = 6;

	private int value;
	#endregion

	#region Methods
	public int Roll ()
	{
		return value = Random.Range (MIN_VALUE, MAX_VALUE + 1);
	}

	public int Increase ()
	{
		value++;
		if (value > 6)
		{
			value = 6;
		}
		return value;
	}
	public int Decrease ()
	{
		value--;
		if (value < 1)
		{
			value = 1;
		}
		return value;
	}
	#endregion
	#region Accessors
	public int Value
	{
		get
		{
			return value;
		}
	}
	#endregion
}
