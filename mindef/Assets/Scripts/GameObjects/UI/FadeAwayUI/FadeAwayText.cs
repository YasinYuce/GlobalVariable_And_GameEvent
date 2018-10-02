using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeAwayText : MonoBehaviour 
{
	#region Fade Away Text

	[SerializeField]
	private float yieldOnStart = 1f, fadeAwayFrameCount = 40f;

	[SerializeField]
	protected Text textToFade = null;

	protected Coroutine fadeRoutine = null;

	protected void startFadeRoutine(){
		if (!textToFade.enabled)
			textToFade.enabled = true;
		if (fadeRoutine != null) {
			StopCoroutine (fadeRoutine);
		}
		fadeRoutine = StartCoroutine (fadeAway ());
	}

	protected void stopFadeRoutine(){
		if (fadeRoutine != null) {
			StopCoroutine (fadeRoutine);
			fadeRoutine = null;
		}
		textToFade.enabled = false;
	}

	IEnumerator fadeAway(){
		Color c = textToFade.color;
		c.a = 1f;
		textToFade.color = c;
		yield return new WaitForSeconds (yieldOnStart);
		float plus = 1f / fadeAwayFrameCount;
		for (int i = 0; i < fadeAwayFrameCount; i++) {
			c.a -= plus;
			textToFade.color = c;
			yield return new WaitForFixedUpdate ();
		}
		fadeRoutine = null;
		textToFade.enabled = false;
	}

	#endregion
}
