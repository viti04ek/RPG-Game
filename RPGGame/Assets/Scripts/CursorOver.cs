using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CursorOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        PlayerMove.CanMove = false;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        PlayerMove.CanMove = true;
    }
}
