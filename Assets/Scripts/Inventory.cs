using UnityEngine;   

public class Inventory : MonoBehaviour
{
    public GameObject[] _prefab;
    public GameObject _panel;

    private GameObject[] _inventorySlotsLength = new GameObject[20];

    private void Start() 
    {
        AddInventorySlots(_inventorySlotsLength);
    }

    public void AddInventorySlots(GameObject[] numberSlots) 
    {
        for(int i = 0; i < numberSlots.Length; i++) 
        {   
            Instantiate(_prefab[i], _panel.transform);
        }
    }
}