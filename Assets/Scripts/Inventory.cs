using UnityEngine;   

public class Inventory : MonoBehaviour
{
    public GameObject[] _prefab;
    public GameObject _panel;

    private int _inventorySlotsLength = 10;

    private void Start() 
    {
        AddInventorySlots(_inventorySlotsLength);
    }

    public void AddInventorySlots(int numberSlots) 
    {
        for(int i = 0; i < numberSlots; i++) 
        {   
            Instantiate(_prefab[i], _panel.transform);
        }
    }
}