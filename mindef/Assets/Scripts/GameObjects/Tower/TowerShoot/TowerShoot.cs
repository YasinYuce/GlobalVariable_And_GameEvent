using UnityEngine;
using System.Collections;

[RequireComponent(typeof (Tower))]
[RequireComponent(typeof(TowerManageInRange))]
public class TowerShoot : MonoBehaviour 
{
	private Tower _tower = null;

	[SerializeField]
	private Transform shootPoint = null;

	internal Transform target;

	void Awake(){
		_tower = GetComponent<Tower> ();
	}

	void Shoot(float _damage){
		Instantiate (_tower.Info.Bullet, shootPoint.position, shootPoint.rotation).GetComponent<IChaseTarget> ().Follow (_damage, target);
	}

	Coroutine shootRoutine;
	IEnumerator shootWithYield(){
		while (true) {
			yield return new WaitUntil (() => target != null);
			_tower.transform.LookAt (target);
			Shoot (_tower.Info.Damage);
			yield return new WaitForSeconds (1f / _tower.Info.Speed);
		}
	}

	#region Unity Callbacks
	void OnEnable(){
		shootRoutine = StartCoroutine (shootWithYield ());
	}

	void OnDisable(){
		StopCoroutine (shootRoutine);
		shootRoutine = null;
	}
	#endregion
}
