using UnityEngine;

[CreateAssetMenu(menuName = "InGameData/TowerInfo", fileName = "TowerInfo")]
public class TowerInfo : ScriptableObject 
{
	public Texture2D Image;
	[Space(7f)]
	public float Damage = 0f;
	public float Range = 3.3f;
	public float Speed = 1.5f;
	public float Price = 20f;

	public void FillInstance (TowerInfo instance){
		instance.Damage = Damage;
		instance.Range = Range;
		instance.Speed = Speed;
		instance.Price = Price;
	}
}
