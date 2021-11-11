using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

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
        initializeGame();

    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = coin.ToString();
        lifeText.text = life.ToString();
    }
    private void initializeGame()
    {
       
    }
    public void playerHit()
    {
        life -= 1;
        Player.player.transform.position = respawnPoint;
        
    }


    public void collectCoin(CoinClass item)
    {
        coin += 1;
        /*CoinClass coinClass = new CoinClass();
        coinClass.id = item.id;
        coinClass.active = item.active;
        coinsList.Add(coinClass); */
    }

    public void setRespawnPoint(Vector3 position)
    {
        respawnPoint = position;
        print(transform.position);
        saveState();
    }

    public void saveState()
    {

    }

    void endGame()
    {
        SaveManager.sv.DeleteSavedFile();
        SceneManager.LoadScene("Game");
    }
}
