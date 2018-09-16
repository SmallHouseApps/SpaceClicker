using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    [SerializeField]
    List<GameObject> planetList = new List<GameObject>();

    [SerializeField]
    int indexOfCurrentPlanet = 0;

    [SerializeField]
    int countCoins = 0;

    public int GetIndexOfCurrentPlanet()
    {
        return indexOfCurrentPlanet;
    }

    public void OnClickScreen()
    {
        planetList[indexOfCurrentPlanet].GetComponent<PlanetController>().AddCoins();
    }

    public void ChangeCountCoins(int _count)
    {
        countCoins += _count;
    }
}
