using UnityEngine;

[RequireComponent (typeof(TowerManageInRange))]
public class TowerTriggerResponse : MonoBehaviour
{
	TowerManageInRange _towerManageInRange;

	void Awake(){
		_towerManageInRange = GetComponent<TowerManageInRange> ();
	}

	#region Unity CallBacks | Trigger Enter Exit 2D
	void OnTriggerEnter2D(Collider2D triggeredBy){
		if(triggeredBy.transform != null)
			_towerManageInRange.AddTarget (triggeredBy.transform);
	}

	void OnTriggerExit2D(Collider2D triggeredBy){
		if(triggeredBy.transform != null)
			_towerManageInRange.RemoveTarget (triggeredBy.transform);
	}
	#endregion
}
