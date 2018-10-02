using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour{

	[SerializeField]
	private MonstersRuntimeSet monstersRefs = null;

	[SerializeField]
	MonsterInfo info;


	void OnEnable(){
		monstersRefs.Add (this);
	}

	void OnDisable(){
		monstersRefs.Remove (this);
	}
}