using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameController gameController;

    public int life = 10;
    public int coin = 0;
    public TextMeshProUGUI lifeText;
    public TextMeshProUGUI coinText;
    public Vector3 respawnPoint;
    public GameObject[] coins;
    public List<CoinClass> coinsList = new List<CoinClass>();
    private void Awake()
    {
        gameController = this;
    }
    void Start()
    {
        if (SaveManager.sv.hasLoad == true)
        {
            life = SaveManager.sv.activeSave.life;
            coin = SaveManager.sv.activeSave.coin;
            print(SaveManager.sv.activeSave.respawnPoint);
            respawnPoint = SaveManager.sv.activeSave.respawnPoint;
            Player.player.transform.position = respawnPoint;

            coinsList = SaveManager.sv.activeSave.coinsList;

            for(int i = 0; i < coinsList.Count; i++)
            {
                if (coinsList[i].active == false)
                {
                    coins[i].SetActive(false);
                }

            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = coin.ToString();
        lifeText.text = life.ToString();
    }

    public void playerHit()
    {
        Player.player.transform.position = respawnPoint;
        life -= 1;
        SaveManager.sv.activeSave.life = life;
        SaveManager.sv.Save();
    }


    public void collectCoin(CoinClass item)
    {
        coin += 1;
        CoinClass coinClass = new CoinClass();
        coinClass.id = item.id;
        coinClass.active = item.active;
        coinsList.Add(coinClass);
        SaveManager.sv.activeSave.coin = coin;
        SaveManager.sv.activeSave.coinsList = coinsList;
        SaveManager.sv.Save();
    }

    public void setRespawnPoint(Vector3 position)
    {
        respawnPoint = position;
        SaveManager.sv.activeSave.respawnPoint = respawnPoint;
        SaveManager.sv.Save();
        print(transform.position);
    }
}
