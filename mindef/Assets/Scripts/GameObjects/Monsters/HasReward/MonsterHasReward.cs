using UnityEngine;

[RequireComponent(typeof(Monster))]
public class MonsterHasReward : MonoBehaviour, IHasReward
{
	[SerializeField]
	private MoneyManager moneyManager = null;

	private Monster _monster;

	void Awake(){
		_monster = GetComponent<Monster> ();
	}

	#region IHasReward implementation

	public void GiveReward ()
	{
		moneyManager.ChangeMoney (_monster.Info.Earning);
	}

	#endregion
}
