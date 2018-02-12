using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatEncounter 
{
	public static void BraveEncounter (int successCount, Hero hero, Monster monster)
	{
		int difference = successCount - monster.Fearness;
		if (difference < 0)
		{
			hero.LoseMp (Mathf.Abs (difference));
		}
	}

	public static void AttackEncounter (int successCount, Hero hero, Monster monster)
	{
		int difference = successCount - monster.Strength;
		if (difference < 0)
		{
			hero.LoseHp (Mathf.Abs (difference));
		}
	}
}
