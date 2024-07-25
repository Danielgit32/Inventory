using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slots : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler, IDropHandler
{
    public static Graphic button;
    public static Color basicColor = Color.black;
    public static Color hoverColor = Color.blue;
    
    private void Start() 
    {
        GetComponent<Graphic>().color = basicColor;
    }

    public void OnPointerEnter(PointerEventData button) 
    {
        GetComponent<Graphic>().color = hoverColor;
    }
    
    public void OnPointerExit(PointerEventData button) 
    {
        GetComponent<Graphic>().color = basicColor;
    }

    public void OnDrop(PointerEventData eventData) 
    {
        var _otherItemTransforms = eventData.pointerDrag.transform;
        _otherItemTransforms.SetParent(transform);
        _otherItemTransforms.localPosition = Vector3.zero;
        
    }
}