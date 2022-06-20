using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ClickTrigger : MonoBehaviour
{
	TicTacToeAI _ai;

	[SerializeField]
	private int _myCoordX = 0;
	[SerializeField]
	private int _myCoordY = 0;

	[SerializeField] private int Ai_coordX;

	[SerializeField] private int Ai_coordY;

	[SerializeField]
	public bool canClick;

	private void Awake()
	{
		_ai = FindObjectOfType<TicTacToeAI>();
	}

	private void Start(){

		_ai.onGameStarted.AddListener(AddReference);
		_ai.onGameStarted.AddListener(() => SetInputEndabled(true));
		_ai.onPlayerWin.AddListener((win) => SetInputEndabled(false));
		//_ai.clickRegistered.AddListener(ClickRegister);
	}



	// when game starts, user can click on the buttons.
	private void SetInputEndabled(bool val){
		canClick = val;
	}

	// enable all buttons to be clickable?
	private void AddReference()
	{
		_ai.RegisterTransform(_myCoordX, _myCoordY, this);
		
		canClick = true;
	}

	// only mouseDown on one button not all.
	private void OnMouseDown()
	{
		if(canClick){
			_ai.PlayerSelects(_myCoordX, _myCoordY);
			//canClick = false;
			//StartCoroutine(TimeDelay());
		}
	}
	
	
	

}
