using UnityEngine;
using UnityEngine.UI;

public class CoinUI : MonoBehaviour
{
    public Text coinCountText;
    private int coinCount = 0;

    public void IncreaseCoinCount()
    {
        coinCount++;
        coinCountText.text = coinCount.ToString();
    }
}
