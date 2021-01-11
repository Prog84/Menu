using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MenuScreen : Screen
{
    [SerializeField] private Button _buttonCreators;
    [SerializeField] private Button _buttonExit;

    public event UnityAction PlayButtonClick;
    public event UnityAction CreatorsButtonClick;
    public event UnityAction ExitButtonClick;

    public override void Close()
    {
        CanvasGroup.alpha = 0;
        Button.interactable = false;
        _buttonCreators.interactable = false;
        _buttonExit.interactable = false;
    }

    public override void Open()
    {
        CanvasGroup.alpha = 1;
        Button.interactable = true;
        _buttonCreators.interactable = true;
        _buttonExit.interactable = true;
    }

    protected override void OnButtonClick()
    {
        PlayButtonClick?.Invoke();
    }

    private void OnEnable()
    {
        _buttonCreators.onClick.AddListener(OnButtonCreatorsClick);
        _buttonExit.onClick.AddListener(OnButtonExitClick);
    }

    private void OnDisable()
    {
        _buttonCreators.onClick.RemoveListener(OnButtonCreatorsClick);
        _buttonExit.onClick.RemoveListener(OnButtonExitClick);
    }

    private void OnButtonCreatorsClick()
    {
        CreatorsButtonClick?.Invoke();
    }

    private void OnButtonExitClick()
    {
        ExitButtonClick?.Invoke();
    }
}
