using UnityEngine;
using UnityEngine.Events;

public class CreatorsScreen : Screen
{
    public event UnityAction BackButtonClick;

    public override void Close()
    {
        CanvasGroup.alpha = 0;
        Button.interactable = false;
    }

    public override void Open()
    {
        CanvasGroup.alpha = 1;
        Button.interactable = true;
    }

    protected override void OnButtonClick()
    {
        BackButtonClick?.Invoke();
    }
}
