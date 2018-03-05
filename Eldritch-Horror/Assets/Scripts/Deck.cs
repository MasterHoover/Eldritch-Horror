using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Deck<T>
{
	private List<T> items;

	public Deck (T[] items)
	{
		this.items = new List<T> (items);
	}

	public Deck (List<T> items)
	{
		items = new List<T> (items);
	}

	public T Draw ()
	{
		return Draw (0);
	}

	public T Draw (int index)
	{
		return items [index];
	}

	public void Shuffle ()
	{
		List<T> shuffled = new List<T> ();
		for (int i = 0; i < items.Count; i++)
		{
			int random = Random.Range (0, items.Count);
			shuffled.Add (items [random]);
			items.RemoveAt (random);
		}
		items = shuffled;
	}

	public List<T> Items
	{
		get 
		{
			return items;
		}
	}
}
