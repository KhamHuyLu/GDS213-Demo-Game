using UnityEngine;

public class ChestInteraction : MonoBehaviour
{
    public Animator chestAnimator;
    public GameObject coinUIPanel;
    public KeyCode interactKey = KeyCode.A;

    private bool isOpened = false;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && !isOpened && Input.GetKeyDown(interactKey))
        {
            OpenChest();
        }
    }

    private void OpenChest()
    {
        // Play the chest opening animation
        chestAnimator.SetTrigger("Open");

        // Increase the coin count on the UI panel
        coinUIPanel.GetComponent<CoinUI>().IncreaseCoinCount();

        // Set the chest as opened to prevent multiple interactions
        isOpened = true;
    }
}