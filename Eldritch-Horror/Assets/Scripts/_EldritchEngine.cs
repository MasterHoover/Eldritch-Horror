using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _EldritchEngine : MonoBehaviour 
{
	public int initialDestinValue = 15;
	public int diceAmount = 1;
	public RollStatus rollStatus;

	private Destin value;
	private Presage presage;

	private int[] dicesValues;

	private Hero hero;
	private Monster monster;

	public enum RollStatus
	{
		Normal,
		Beni,
		Maudit
	}

	void Start ()
	{
		value = new Destin (initialDestinValue);
		presage = new Presage ();
		hero = new Hero ("My Hero!", 5, 5, 2, 2, 2, 2, 2, 0);
		monster = new Monster ("Da Monsta", 7, 3, 2, 2, 1); 
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.KeypadMinus))
		{
			//value.Advance ();
			presage.Advance ();
		}
		if (Input.GetKeyDown (KeyCode.KeypadPlus))
		{
			//value.Retreat ();
		}

		if (Input.GetKeyDown (KeyCode.KeypadMultiply))
		{
			int successCount = 0;

			switch (rollStatus)
			{
			case RollStatus.Normal:
				successCount = DiceRoller.Roll (diceAmount);
				break;
			case RollStatus.Beni:
				successCount = DiceRoller.Roll (diceAmount, true);
				break;
			case RollStatus.Maudit:
				successCount = DiceRoller.Roll (diceAmount, false);
				break;
			}

			dicesValues = DiceRoller.DicesValues;

			string message = diceAmount + " dices were rolled with the " + rollStatus + " status! Here is the result: ";
			if (diceAmount <= 0)
				message += ("N/A - There is 0 success.");
			else
			{
				for (int i = 0; i < diceAmount; i++)
				{
					if (i != 0)
						message += ", ";
					message += ("[" + dicesValues[i] + "]");
				}
				message += (" - There is " + successCount + " success.");
			}

			Debug.Log (message);
			Debug.Log (hero.Name + " is braving " + monster.Name + "!.");
			CombatEncounter.BraveEncounter (successCount, hero, monster);
		}

		if (Input.GetKeyDown (KeyCode.KeypadDivide))
		{
			int successCount = 0;

			switch (rollStatus)
			{
			case RollStatus.Normal:
				successCount = DiceRoller.Roll (diceAmount);
				break;
			case RollStatus.Beni:
				successCount = DiceRoller.Roll (diceAmount, true);
				break;
			case RollStatus.Maudit:
				successCount = DiceRoller.Roll (diceAmount, false);
				break;
			}

			dicesValues = DiceRoller.DicesValues;

			string message = diceAmount + " dices were rolled with the " + rollStatus + " status! Here is the result: ";
			if (diceAmount <= 0)
				message += ("N/A - There is 0 success.");
			else
			{
				for (int i = 0; i < diceAmount; i++)
				{
					if (i != 0)
						message += ", ";
					message += ("[" + dicesValues[i] + "]");
				}
				message += (" - There is " + successCount + " success.");
			}

			Debug.Log (message);
			Debug.Log (hero.Name + " is attacking " + monster.Name + "!.");

			CombatEncounter.AttackEncounter (successCount, hero, monster);
		}
	}
}
