using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PhaseMachine
{
	public enum Phase
	{
		Action = 0,
		Rencontre = 1,
		Mythe = 2
	}

	private Phase currentPhase;

	public void Next ()
	{
		currentPhase = (Phase) (((int) ++currentPhase) % 3);
	}
}
