using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour {

    [SerializeField]
    List<GameObject> planetList = new List<GameObject>();

    [SerializeField]
    GameObject gameManager;

    [SerializeField]
    GameObject shopPanel;

    [SerializeField]
    GameObject[] shopPanels;

    public void OnClickShop()
    {
        shopPanel.SetActive(true);
    } 
    
    public void OnClickCloseShop()
    {
        shopPanel.SetActive(false);
    }

    public void OnClickPlanetUp()
    {
        shopPanels[1].SetActive(false);
        shopPanels[2].SetActive(false);    
    }

    public void OnClickShipUp()
    {
        shopPanels[1].SetActive(true);
        shopPanels[2].SetActive(false);
    }

    public void OnClickDonate()
    {
        shopPanels[2].SetActive(true);
    }

    public void OnClickUpgradeAmountPerClick()
    {
        int indexCurrentPlanet = gameManager.GetComponent<GameManager>().GetIndexOfCurrentPlanet();
        planetList[indexCurrentPlanet].GetComponent<PlanetController>().ChangeAmountCoinPerClick();
    }

    public void OnClickUpgradePermanentAmount()
    {
        int indexCurrentPlanet = gameManager.GetComponent<GameManager>().GetIndexOfCurrentPlanet();
        planetList[indexCurrentPlanet].GetComponent<PlanetController>().ChangePremanentAmountForReward();
    }
}
