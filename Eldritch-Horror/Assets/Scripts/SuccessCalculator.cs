using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccessCalculator
{
	public const int SUCCESS_THRESHOLD = 5;

	public static int Count (Dice[] dices)
	{
		return Count (dices, SUCCESS_THRESHOLD);
	}

	public static int Count (Dice[] dices, bool beni)
	{
		return Count (dices, SUCCESS_THRESHOLD + (beni ? -1 : 1));
	}

	private static int Count (Dice[] dices, int threshold)
	{
		int count = 0;
		foreach (Dice d in dices)
		{
			if (d.Value >= threshold)
			{
				count++;
			}
		}
		return count;
	}
}
