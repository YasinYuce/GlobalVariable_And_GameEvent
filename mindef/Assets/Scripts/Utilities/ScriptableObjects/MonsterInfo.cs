using UnityEngine;

[CreateAssetMenu(menuName = "InGameData/MonsterInfo", fileName = "MonsterInfo")]
public class MonsterInfo : ScriptableObject 
{
	public float Armor, MonsterSpeed, MonsterHP;
	public int Earning;
	
}
