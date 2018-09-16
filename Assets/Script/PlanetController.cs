using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetController : MonoBehaviour {

    [SerializeField]
    GameObject gameManager;

    [SerializeField]
    int CoinsPerClick;

    [SerializeField]
    int PermanentCoinForReward;

    public void AddCoins()
    {
        gameManager.GetComponent<GameManager>().ChangeCountCoins(CoinsPerClick);
    }

    public void ChangeAmountCoinPerClick()
    {
        CoinsPerClick = CoinsPerClick*2;
    }

    public void ChangePremanentAmountForReward()
    {
        PermanentCoinForReward += 1;
    }
}
