using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ClickAction : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        SceneManager.LoadScene("Success_scene");
    }
}
