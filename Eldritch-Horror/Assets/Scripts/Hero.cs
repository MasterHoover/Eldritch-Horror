using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Hero
{
	#region Fields
	private string name;

	private int maxHp;
	private int maxMp;
	private int currentHp;
	private int currentMp;

	private int force;
	private int influence;
	private int observation;
	private int volonte;
	private int savoir;

	private int forceMod;
	private int influenceMod;
	private int observationMod;
	private int volonteMod;
	private int savoirMod;

	private int indiceCount;

	private int locationID;
	#endregion

	#region Constructors
	public Hero (string name, int maxHp, int maxMp, 
		int force, int influence, int observation, int volonte, int savoir,
		int indiceCount)
	{
		this.name = name;
		this.maxHp = maxHp;
		this.maxMp = maxMp;
		this.force = force;
		this.influence = influence;
		this.observation = observation;
		this.volonte = volonte;
		this.savoir = savoir;
		this.indiceCount = indiceCount;

		currentHp = maxHp;
		currentMp = maxMp;
	}
	#endregion

	#region Methods
	public void GainIndice (int amount)
	{
		indiceCount += amount;
	}
	public void LoseIndice (int amount)
	{
		indiceCount -= amount;
	}

	public void HealHp (int amount)
	{
		currentHp += amount;
	}
	public void HealMp (int amount)
	{
		currentMp += amount;
	}
	public void LoseHp (int amount)
	{
		currentHp -= amount;
	}
	public void LoseMp (int amount)
	{
		currentMp -= amount;
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
	public int MaxMp
	{
		get 
		{
			return maxMp;
		}
	}

	public int CurrentHp
	{
		get 
		{
			return currentHp;
		}
	}
	public int CurrentMp
	{
		get 
		{
			return currentMp;
		}
	}

	public int BaseForce
	{
		get 
		{
			return force;
		}
	}
	public int BaseInfluence
	{
		get 
		{
			return influence;
		}
	}
	public int BaseObservation
	{
		get 
		{
			return observation;
		}
	}
	public int BaseVolonte
	{
		get 
		{
			return volonte;
		}
	}
	public int BaseSavoir
	{
		get 
		{
			return savoir;
		}
	}

	public int ForceMod
	{
		get 
		{
			return ForceMod;
		}
	}
	public int InfluenceMod
	{
		get 
		{
			return influenceMod;
		}
	}
	public int ObservationMod
	{
		get 
		{
			return observationMod;
		}
	}
	public int VolonteMod
	{
		get 
		{
			return volonteMod;
		}
	}
	public int SavoirMod
	{
		get 
		{
			return savoirMod;
		}
	}

	public int Force
	{
		get
		{
			return force + forceMod;
		}
	}
	public int Influence
	{
		get
		{
			return influence + influenceMod;
		}
	}
	public int Observation
	{
		get
		{
			return observation + observationMod;
		}
	}
	public int Volonte
	{
		get
		{
			return volonte + volonteMod;
		}
	}
	public int Savoir
	{
		get 
		{
			return savoir + savoirMod;
		}
	}

	public int IndiceCount
	{
		get 
		{
			return indiceCount;
		}
	}
	#endregion
}
