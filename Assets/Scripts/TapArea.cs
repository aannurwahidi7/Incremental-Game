using UnityEngine;
using UnityEngine.EventSystems;

public class TapArea : MonoBehaviour, IPointerDownHandler
{
    public AudioSource coinSounds;
    public void OnPointerDown(PointerEventData eventData)
    {
        GameManager.Instance.CollectByTap(eventData.position, transform);
        coinSounds.Play();
    }
}
