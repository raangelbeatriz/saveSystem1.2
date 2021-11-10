using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int id;
    public bool active = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            GameController.gameController.collectCoin(id);
            active = false;
            Destroy(this.gameObject);
        }
    }
}
