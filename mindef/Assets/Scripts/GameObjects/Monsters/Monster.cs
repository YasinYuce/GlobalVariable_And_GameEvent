using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
	[SerializeField]
	private MonstersRuntimeSet monstersRefs = null;

	[SerializeField]
	private MonsterInfo info = null;
	[System.NonSerialized]
	public MonsterInfo Info;

	void initializeMyInfo(){
		Info = ScriptableObject.CreateInstance<MonsterInfo> ();
		info.FillInstance (Info);
	}

	#region UnityCallbacks
	//Creatation for pooling (not currently have one)
	void OnEnable(){
		initializeMyInfo ();
		monstersRefs.Add (this);
	}

	//Death
	void OnDisable(){
		monstersRefs.Remove (this);
	}
	#endregion
}