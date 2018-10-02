using UnityEngine;
using System.Collections.Generic;

public abstract class RuntimeSet<T> : ScriptableObject 
{
	private List<T> Items = new List<T>();

	public virtual void Add(T item){
		if (!Items.Contains (item)) {
			Items.Add (item);
		}
	}
	public void Remove(T item){
		if (Items.Contains (item))Items.Remove (item);
	}
}
