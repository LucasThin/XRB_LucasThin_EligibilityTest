using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndMessage : MonoBehaviour
{

	[SerializeField]
	private TMP_Text _playerMessage = null;

	public void OnGameEnded(int winner)
	{
		_playerMessage.text = winner == -1 ? "Tie" : winner == 1 ? "AI wins" : "Player wins";
		StartCoroutine(TimeDelay(1f));
		
	}

	private IEnumerator TimeDelay(float seconds)
	{
		yield return new WaitForSeconds(seconds);
		Time.timeScale = 0;
	}
}
