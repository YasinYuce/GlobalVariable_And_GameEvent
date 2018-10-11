using UnityEngine;

public class FollowTarget : MonoBehaviour, IChaseTarget
{
	private Transform target;

	[SerializeField]
	private bool lookAt = false;

	[SerializeField]
	private float speed = 0f;
	private float damage = 0;

	public void Follow(float _damage, Transform _target){
		damage = _damage;
		target = _target;
		gameObject.SetActive (true);
	}

	void FixedUpdate(){
		if (target == null) {
			close ();
			return;
		}
		Vector3 myPos = transform.position, targetPos = target.position;

		myPos = Vector3.MoveTowards (myPos, targetPos, speed);
		transform.position = myPos;
		if(lookAt)
			transform.LookAt (target);

		if (Vector3.Distance(myPos, targetPos) < 0.25f)
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
