using UnityEngine;

public class ProximityInfo : MonoBehaviour
{
    public GameObject infoPanel;

    private static GameObject currentPanel;

    void Start()
    {
        if (infoPanel != null)
            infoPanel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Close the previous exhibit's panel
            if (currentPanel != null && currentPanel != infoPanel)
            {
                currentPanel.SetActive(false);
            }

            // Open this exhibit's panel
            if (infoPanel != null)
            {
                infoPanel.SetActive(true);
                currentPanel = infoPanel;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (infoPanel != null)
            {
                infoPanel.SetActive(false);

                if (currentPanel == infoPanel)
                    currentPanel = null;
            }
        }
    }
}