using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Location : MonoBehaviour
{
	public enum Type
	{
		City,
		Sea,
		Nature
	}
		
	public Type type;

	public Location[] neighbours;
}
