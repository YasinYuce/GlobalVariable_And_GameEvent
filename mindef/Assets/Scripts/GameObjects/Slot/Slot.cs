using UnityEngine;

public class Slot : MonoBehaviour 
{
	[SerializeField]
	private SlotRuntimeSet slotsRuntimeSet = null;

	internal Tower OnMe;

	public void PlaceTower(Tower towerToPlace){
		OnMe = towerToPlace;
		OnMe.transform.parent = transform;
		OnMe.transform.localPosition = Vector3.zero;
	}

	void OnEnable(){
		slotsRuntimeSet.Add (this);
	}

	void OnDisable(){
		slotsRuntimeSet.Remove (this);
	}
	
}
