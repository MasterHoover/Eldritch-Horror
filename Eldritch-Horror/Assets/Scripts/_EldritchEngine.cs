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
	private PhaseMachine phaseMachine;

	private int[] dicesValues;
	private int successCount;

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
		phaseMachine = new PhaseMachine ();
		hero = new Hero ("My Hero!", 5, 5, 2, 2, 2, 2, 2, 0);
		monster = new Monster ("Da Monsta", 7, 3, 2, 2, 1); 
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.KeypadMinus))
		{
			phaseMachine.Next ();
		}
	}

	private void RollDices (int amount)
	{
		successCount = DiceRoller.Roll (amount);
		dicesValues = DiceRoller.DicesValues;
	}
}
