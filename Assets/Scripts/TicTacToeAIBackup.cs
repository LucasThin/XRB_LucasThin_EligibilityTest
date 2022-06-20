using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;
/*
public enum TicTacToeState{none, cross, circle}

[System.Serializable]
public class WinnerEvent : UnityEvent<int>
{
}

public class TicTacToeAI : MonoBehaviour
{

	int _aiLevel;

	TicTacToeState[,] boardState;
	
	// Boolean to check if it is player's turn
	[SerializeField]
	private bool _isPlayerTurn; // true is player's turn, false is ai's turn.

	[SerializeField]
	private int _gridSize = 3;
	
	// players = cross and ai = circle.
	[SerializeField]
	private TicTacToeState playerState = TicTacToeState.circle;
	TicTacToeState aiState = TicTacToeState.cross;

	// assigning prefab to related game object
	[SerializeField]
	private GameObject _xPrefab;

	[SerializeField]
	private GameObject _oPrefab;
	

	// Create a unity event for game started. When game is started, hide retry button. 
	public UnityEvent onGameStarted;
	public UnityEvent clickRegistered;

	//Call This event with the player number to denote the winner. One player win in unity, it shows the retry button.
	public WinnerEvent onPlayerWin;

	ClickTrigger[,] _triggers;
	
	[SerializeField]
	private List<string> GameSpots = new List<string>{"0,2", "1,2", "2,2", "0,1", "1,1", "2,1", "0,0", "1,0", "2,0"};
	[SerializeField]
	private List<string> PlayerSpots = new List<string>{};
	[SerializeField]
	private List<string> AiSpots = new List<string>{};
	private int indexClicked;
	private void Awake()
	{
		if(onPlayerWin == null){
			onPlayerWin = new WinnerEvent();
		}
	}

	// Choose the ai difficulty level and then starts game
	public void StartAI(int AILevel){
		_aiLevel = AILevel;
		StartGame();
	}

	// Registers the click
	public void RegisterTransform(int myCoordX, int myCoordY, ClickTrigger clickTrigger)
	{
		_triggers[myCoordX, myCoordY] = clickTrigger;
		//Debug.Log($"Registered Transform myCoordX{myCoordX} myCoordY{myCoordY}");
	}

	private void StartGame()
	{
		_triggers = new ClickTrigger[3,3];
		onGameStarted.Invoke();
	}

	// when player or ai selects, give the coordinates to SetVisual method as well as who selected it (target state)
	public void PlayerSelects(int coordX, int coordY){
		if (_isPlayerTurn)
		{
			//Save clickedSpot to compare to lists
			
			string clickedSpot = coordX.ToString() + "," + coordY.ToString();
			//Debug.Log($"This is clickedspot {clickedSpot}");
			for (int i = 0; i < GameSpots.Count; i++)
			{
				// if clickedspot is still in overall game spots, remove it
				if (GameSpots[i] == clickedSpot)
				{
					indexClicked = i;
					SetVisual(coordX, coordY, playerState);
					//Debug.Log($"i = {indexClicked}, clickedspot found");
					GameSpots.RemoveAt(indexClicked);
					PlayerSpots.Add(clickedSpot);
					//_isPlayerTurn = false;
					//AiSelects(0,0);
				}
			}

			//Debug.Log("Player have taken their turn. It is now Ai's Turn");
		}

	}

	public void AiSelects(int coordX, int coordY){
		while (_isPlayerTurn == false)
		{
			//Generate a random spot
			coordX = Random.Range(0, 3);
			coordY = Random.Range(0, 3);
			
			string AiSpot = coordX.ToString() + "," + coordY.ToString();
			Debug.Log($"This is Ai's Spot {AiSpot}");
			for (int i = 0; i < GameSpots.Count; i++)
			{
				// if clickedspot is still in overall game spots, remove it
				if (GameSpots[i] == AiSpot)
				{
					indexClicked = i;
					SetVisual(coordX, coordY, aiState);
					//Debug.Log($"i = {indexClicked}, Aispot found");
					GameSpots.RemoveAt(indexClicked);
					AiSpots.Add(AiSpot);
					_isPlayerTurn = true;
					
				}
			}
			//Debug.Log("Ai have taken their turn. It is now Player's Turn");
			if (GameSpots.Count < 1)
			{
				_isPlayerTurn = true;
			}
		}
		
	}

	// SetVisual is a method to instantiate the prefabs at the coordinate the player selected.
	public void SetVisual(int coordX, int coordY, TicTacToeState targetState)
	{

		Instantiate(
			targetState == TicTacToeState.circle ? _oPrefab : _xPrefab,
			_triggers[coordX, coordY].transform.position,
			Quaternion.identity
		);
		
		CheckPlayerWin();
		//clickRegistered.Invoke();
	}

	public void CheckPlayerWin()
	{
		for (int i = 0; i < PlayerSpots.Count; i++)
		{
			if (PlayerSpots[i] == "0,0")
			{
				Debug.Log("Top Left Registered");
				
				for (int j = 0; j < PlayerSpots.Count; j++)
				{
					if (PlayerSpots[j] == "0,1")
					{
						Debug.Log("Top Middle Registered");
						
						for (int k = 0; k < PlayerSpots.Count; k++)
						{
							if (PlayerSpots[k] == "0,2")
							{
								Debug.Log("Player Wins");
								
							}
						}
					}
				}
				
			}
		}

	}
	
}
*/