using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TowerInfoUI : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	#region UI part variables
	[SerializeField]
	private Image towerImage = null, selectedBackground = null;

	[SerializeField]
	private Text damageText = null, rangeText = null, speedText = null, priceText = null;
	#endregion

	#region Money manager
	[SerializeField]
	private MoneyManager moneyManager = null;
	#endregion

	#region Tower info
	internal GameObject myPrefab = null;

	private TowerInfo info;
	#endregion

	#region Fill func
	public void Fill(TowerInfo _info){
		info = _info;
		towerImage.sprite = Sprite.Create(_info.Image, new Rect(0f, 0f , _info.Image.width, _info.Image.height), Vector2.zero);
		damageText.text = _info.Damage.ToString ();
		rangeText.text = _info.Range.ToString ();
		speedText.text = _info.Speed.ToString ();
		priceText.text = _info.Price.ToString ();
	}
    #endregion

	#region IDrag implementations
	bool isBuyable = false;
	int siblingIndex = 0;
	Transform parent = null;
	#region IBeginDragHandler implementation


	public void OnBeginDrag (PointerEventData eventData)
	{
		isBuyable = moneyManager.IsHaveEnoughtMoney (info.Price);
		if (isBuyable) {
			GetComponentInParent<GridLayoutGroup> ().enabled = false;
			siblingIndex = transform.GetSiblingIndex ();
			parent = transform.parent;
			transform.SetParent (transform.parent.parent.parent);
			selectedBackground.enabled = true;
		}
	}


	#endregion

	#region IDragHandler implementation

	public void OnDrag (PointerEventData eventData)
	{
		if (isBuyable)
			transform.position = Input.mousePosition;
	}

	#endregion

	#region IEndDragHandler implementation

	public void OnEndDrag (PointerEventData eventData)
	{
		if (isBuyable) {
			transform.SetParent (parent);
			transform.SetSiblingIndex (siblingIndex);
			GetComponentInParent<GridLayoutGroup> ().enabled = true;
			isBuyable = false;
			rayForSlot ();
			selectedBackground.enabled = false;
		}
	}

	#endregion
	#endregion

	#region Drop
	void rayForSlot(){
		RaycastHit2D hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (transform.position), Vector2.zero);
		if (hit.transform != null && hit.transform.tag == "Slot" && hit.transform.GetComponent<Slot> ().OnMe == null) {
			createAndDropTower (hit.transform.GetComponent<Slot> ());
		}
	}

	void createAndDropTower (Slot s)
	{
		Tower t = Instantiate (myPrefab).GetComponent<Tower> ();
		s.PlaceTower (t);
		moneyManager.ChangeMoney (-t.Info.Price);
	}
	#endregion
}