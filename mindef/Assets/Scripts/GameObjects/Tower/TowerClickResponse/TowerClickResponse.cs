using UnityEngine;

[RequireComponent(typeof(Tower))]
public class TowerClickResponse : MonoBehaviour, IResponse 
{
	[SerializeField]
	private GameObject towerRangeObj = null;

	private Tower _tower;

	#region Initialize
	private void Awake(){
		_tower = GetComponent<Tower> ();
		towerRangeObj.transform.localScale = _tower.PrefabInfo.Range * 2f * Vector3.one;
	}
	#endregion

	#region IResponse implementation

	public void Response ()
	{
		if (!towerRangeObj.activeSelf)
			towerRangeObj.SetActive (true);
	}

	#endregion

	#region When Focus Losed to this tower
	public void LosedFocus(){
		if (towerRangeObj.activeSelf)
			towerRangeObj.SetActive (false);
	}
	#endregion
}
