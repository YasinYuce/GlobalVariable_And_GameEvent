using UnityEngine;
using System.Collections.Generic;

public class UpdateAdds : MonoBehaviour 
{
	public static bool InstanceExist{get{ return instance; }}

	private static volatile UpdateAdds instance;
	private static readonly Object syncLockObj = new Object();
	public static UpdateAdds Instance { 
		get
		{
			if (instance != null)
				return instance;
			else {
				lock (syncLockObj) {
					if (instance == null) {
						return (instance = (new GameObject ("Update Adds Singleton", new System.Type[]{ typeof(UpdateAdds) })).GetComponent<UpdateAdds> ());
					}
				}
				return instance;
			}
		} 
	}

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
