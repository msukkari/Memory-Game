using UnityEngine;
using System.Collections;

public class MemoryCard : MonoBehaviour {
	[SerializeField] private GameObject cardback;

	public void OnMouseDown(){
		if (cardback.activeSelf)
			cardback.SetActive (false);
	}
}
