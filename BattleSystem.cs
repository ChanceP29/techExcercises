﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST}

public class BattleSystem : MonoBehaviour
{

    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    public Transform playerBattleStation;
    public Transform enemyBattleStation;

    Unit playerUnit;
    Unit enemyUnit;

    public Text dialogueText;

    public BattleState state;
    void SetupBattle()
        {
            GameObject playerGO = Instantiate(playerPrefab, playerBattleStation);
            playerUnit = playerGO.GetComponent<Unit>();

            GameObject enemyGO = Instantiate(enemyPrefab, enemyBattleStation);
            enemyUnit = enemyGO.GetComponent<Unit>();

            dialogueText.text = "A wild" + enemyUnit.unitName + " approaches.";

            
        }
    void Start()
    {
        state = BattleState.START;
        SetupBattle();
    }

    
    
}
