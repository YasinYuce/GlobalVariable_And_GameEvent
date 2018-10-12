using UnityEngine;

public class FollowTarget : Damager, IChaseTarget
{
	private Transform target;

	[SerializeField]
	private bool lookAt = false;

	[SerializeField]
	private float speed = 0f;

	#region IChaseTarget Implementation

	public void Follow(float _damage, Transform _target){
		damage = _damage;
		target = _target;
		gameObject.SetActive (true);
	}

	#endregion

	void FixedUpdate(){
		if (target == null) {
			close ();
			return;
		}
		moveToTarget ();
	}

	void moveToTarget ()
	{
		Vector3 myPos = transform.position, targetPos = target.position;
		myPos = Vector3.MoveTowards (myPos, targetPos, speed);
		transform.position = myPos;
		if (lookAt)
			transform.LookAt (target);
		if (Vector3.Distance (myPos, targetPos) < 0.25f)
			hitDamage ();
	}

	void hitDamage(){
		target.GetComponent<IDamagable> ().TakeDamage (damage);
		target = null;
		close ();
	}

	void close(){
		Destroy (gameObject);
	}
}
