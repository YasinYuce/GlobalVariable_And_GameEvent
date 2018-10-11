using UnityEngine;

[RequireComponent(typeof (Monster))]
[RequireComponent(typeof(IHasReward))]
public class MonsterDamagable : MonoBehaviour, IDamagable
{
	Monster _monster;
	IHasReward _reward;

	void Awake(){
		_monster = GetComponent<Monster> ();
		_reward = GetComponent<IHasReward> ();
	}

	#region IDamagable implementation

	public void TakeDamage (float _damage)
	{
		//I just chose to effect half of the damage with armor
		float hit = _damage - (_damage / 2f) / (100f - _monster.Info.Armor);
		_monster.Info.MonsterHP -= hit;
		if (_monster.Info.MonsterHP <= 0f) {
			_reward.GiveReward ();
			Destroy (gameObject);
		}
	}

	#endregion
	
}
