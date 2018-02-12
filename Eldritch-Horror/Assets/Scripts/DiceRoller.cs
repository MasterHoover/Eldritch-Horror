using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoller 
{
	private static Dice[] dices;

	public static int Roll (int amount)
	{
		JustRoll (amount);
		return SuccessCalculator.Count (dices);
	}

	public static int Roll (int amount, bool beni)
	{
		JustRoll (amount);
		return SuccessCalculator.Count (dices, beni);
	}

	private static void JustRoll (int amount)
	{
		dices = new Dice[amount];
		for (int i = 0; i < amount; i++)
		{
			dices[i] = new Dice ();
			dices[i].Roll ();
		}
	}

	public static int[] DicesValues
	{
		get 
		{
			int[] values = new int[dices.Length];
			for (int i = 0; i < dices.Length; i++)
			{
				values [i] = dices [i].Value;
			}
			return values;
		}
	}
}
