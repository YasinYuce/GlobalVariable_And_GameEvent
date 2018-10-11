using UnityEngine;

[CreateAssetMenu(menuName = "InGameData/MonsterInfo", fileName = "MonsterInfo")]
public class MonsterInfo : ScriptableObject 
{
	[Range (0f, 100f)]
	public float Armor;
	public float MonsterSpeed, MonsterHP;
	public int Earning;

	public void FillInstance(MonsterInfo instance){
		instance.Armor = Armor;
		instance.MonsterSpeed = MonsterSpeed;
		instance.MonsterHP = MonsterHP;
		instance.Earning = Earning;
	}
}
