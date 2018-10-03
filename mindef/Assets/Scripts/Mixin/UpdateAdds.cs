using UnityEngine;
using System.Collections.Generic;

public class UpdateAdds : MonoBehaviour 
{
	private List<BaseAdd> Items = new List<BaseAdd>();

	void FixedUpdate(){
		for (int i = Items.Count - 1; i >= 0; i--) {
			Items [i].Action ();
		}
	}

	public void Add(BaseAdd t){
		if (!Items.Contains (t))
			Items.Add (t);
	}

	public void Remove(BaseAdd t){
		if (Items.Contains (t))
			Items.Remove (t);
	}
}
