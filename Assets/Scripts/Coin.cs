using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;

[System.Serializable]
public class Coin : MonoBehaviour
{
    public int id;
    public bool active = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CoinClass data = new CoinClass();

        if (collision.gameObject.CompareTag("player"))
        {
            active = false;
            data.id = id;
            data.active = active;
            GameController.gameController.collectCoin(data);
            Destroy(this.gameObject);
        }
    }
}
