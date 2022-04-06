using UnityEngine;
using UnityEngine.EventSystems;

public class MMButtonScript : MonoBehaviour
{
    private EventSystem _eventSystem;

    private void Start()
    {
        _eventSystem = EventSystem.current;
    }

    private void Update()
    {
        if (_eventSystem.currentSelectedGameObject == gameObject)
        {
            LeanTween.scale(gameObject.GetComponent<RectTransform>(), gameObject.GetComponent<RectTransform>().localScale*1.25f, 1f).setDelay(1f);
        }
    }
}
