using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Monster
{
	#region Fields
	private string name;
	private int maxHp;
	private int currentHp;

	private int strength;
	private int fearness;

	private int strengthMod;
	private int fearnessMod;
	#endregion

	#region Constructors
	public Monster (string name, int maxHp, int strength, int strengthMod, int fearness, int fearnessMod)
	{
		this.name = name;
		this.maxHp = maxHp;
		this.strength = strength;
		this.strengthMod = strengthMod;
		this.fearness = fearness;
		this.fearnessMod = fearnessMod;
		currentHp = maxHp;
	}
	#endregion

	#region Accessors
	public string Name
	{
		get 
		{
			return name;
		}
	}
	public int MaxHp
	{
		get 
		{
			return maxHp;
		}
	}
	public int CurrentHp
	{
		get 
		{
			return currentHp;
		}
	}
	public int Strength
	{
		get
		{
			return strength;
		}
	}
	public int Fearness
	{
		get 
		{
			return fearness;
		}
	}
	#endregion
}
