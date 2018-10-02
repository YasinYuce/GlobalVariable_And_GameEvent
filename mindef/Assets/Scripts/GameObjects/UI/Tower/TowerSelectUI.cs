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
			AvailableTowers.Array.Length * TowerInfoParent.GetComponentInParent<GridLayoutGroup> ().cellSize.y + (AvailableTowers.Array.Length - 1) *  TowerInfoParent.GetComponentInParent<GridLayoutGroup> ().spacing.y);

		for (int i = 0; i < AvailableTowers.Array.Length; i++) {
			
			TowerInfoUI t = Instantiate (TowerUIInfoPrefab, TowerInfoParent).GetComponent<TowerInfoUI> ();

			Tower tower = AvailableTowers.Array [i].GetComponent<Tower> ();

			setTowerInfoUI (t, tower);
		}
	}

	void setTowerInfoUI(TowerInfoUI t, Tower tower){
		t.Fill (tower.info);
		t.myPrefab = tower.gameObject;
	}
}
