using UnityEngine;

[CreateAssetMenu(menuName = "InGameData/MoneyManager", fileName = "MoneyManager")]
public class MoneyManager : ScriptableObject 
{
	[SerializeField]
	internal FloatReference Money = null;

	[SerializeField]
	private GameEvent onMoneyChange = null, onMoneyNotEnought = null;

	public bool IsHaveEnoughtMoney(float p){
		if (Money.Value.IsBiggerOrEqualThan (p))
			return true;
		else
			onMoneyNotEnought.Raise ();
		return false;
	}

	public void ChangeMoney(float c){
		Money.Value -= c;
		onMoneyChange.Raise ();
	}
}
