using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(TowerInfo))]
public class TowerInfoCustomInspector : Editor 
{
	TowerInfo targett;

	void OnEnable(){
		targett = (TowerInfo)target;
	}
	public override void OnInspectorGUI ()
	{
		base.OnInspectorGUI ();
		if (targett.Image != null) {
			GUI.DrawTexture (GUILayoutUtility.GetRect(75f, 75f), targett.Image, ScaleMode.ScaleToFit);
		}
	}
}
