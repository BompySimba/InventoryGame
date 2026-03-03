using UnityEngine;

public class InventoryButton : MonoBehaviour
{
    public GameObject InventoryMenu;
    private bool menuActivated;
    public void ToggleMenu()
    {
        Debug.Log("Button Press");
        if(menuActivated)
        {
            InventoryMenu.SetActive(false);
            menuActivated = false;
        }
        else if(!menuActivated)
        {
            InventoryMenu.SetActive(true);
            menuActivated = true;
        }
    }
}
