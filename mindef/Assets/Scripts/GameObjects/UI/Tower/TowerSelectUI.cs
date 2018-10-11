using UnityEngine;
using UnityEngine.UI;

public class TowerSelectUI : MonoBehaviour 
{
	[SerializeField]
	private GameObjectArray AvailableTowers = null;

	[SerializeField]
	private RectTransform TowerInfoParent = null;
	[SerializeField]
	private GameObject TowerUIInfoPrefab = null;

	void Awake(){
		createTowerInfoUIs ();
	}

	void createTowerInfoUIs(){
		TowerInfoParent.sizeDelta = new Vector2 (TowerInfoParent.sizeDelta.x,
			AvailableTowers.Values.Length * TowerInfoParent.GetComponentInParent<GridLayoutGroup> ().cellSize.y + (AvailableTowers.Values.Length - 1) *  TowerInfoParent.GetComponentInParent<GridLayoutGroup> ().spacing.y);

		for (int i = 0; i < AvailableTowers.Values.Length; i++) {
			
			TowerInfoUI t = Instantiate (TowerUIInfoPrefab, TowerInfoParent).GetComponent<TowerInfoUI> ();

			Tower tower = AvailableTowers.Values [i].GetComponent<Tower> ();

			setTowerInfoUI (t, tower);
		}
	}

	void setTowerInfoUI(TowerInfoUI t, Tower tower){
		t.Fill (tower.PrefabInfo);
		t.myPrefab = tower.gameObject;
	}
}
