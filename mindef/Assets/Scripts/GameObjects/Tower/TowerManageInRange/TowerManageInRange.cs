using UnityEngine;
using System.Collections.Generic;

[RequireComponent(typeof(TowerShoot))]
public class TowerManageInRange : MonoBehaviour, IResponse
{
	private List<Transform> InMyRange = new List<Transform> ();

	private TowerShoot _towerShoot;

	void Awake(){
		_towerShoot = GetComponent<TowerShoot> ();
	}

	#region Add & Remove Target 

	public void AddTarget(Transform _target){
		if (!InMyRange.Contains (_target))
			InMyRange.Add (_target);
		Response ();
	}

	public void RemoveTarget(Transform _target){
		if (InMyRange.Contains (_target))
			InMyRange.Remove (_target);
		Response ();
	}

	#endregion

	#region IResponse implementation

	public void Response ()
	{
		for (int i = InMyRange.Count - 1; i >= 0; i--)
			if (InMyRange [i] == null)
				InMyRange.RemoveAt (i);
		Transform _target = InMyRange.FindClosestTransformToGivenPoint (transform.position);
		if (_target != _towerShoot.target) {
			_towerShoot.target = _target;
		}
	}

	#endregion
}
