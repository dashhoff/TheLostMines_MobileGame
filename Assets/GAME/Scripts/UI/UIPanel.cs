using UnityEngine;
using System;
using DG.Tweening;
using UnityEngine.UI;

public class UIPanel : MonoBehaviour
{
    [SerializeField] private Image _background;
    [SerializeField] private GameObject _panel;

    [SerializeField] private float _backgroundAlpha;

    [SerializeField] private float _openDuration;
    [SerializeField] private float _closeDuration;

    /// <summary>
    /// ����� �������� ������ � ���������
    /// </summary>
    public void Open(Action callback = null)
    {
        _background.gameObject.SetActive(true);
        _panel.SetActive(true);

        DOTween.Sequence()
            .Append(_background.DOFade(_backgroundAlpha, _openDuration))
            .OnComplete(() => 
            { 
                callback?.Invoke();
            });
    }

    /// <summary>
    /// ����� �������� ������ � ���������
    /// </summary>
    public void Close(Action callback = null)
    {
        _panel.SetActive(false);

        DOTween.Sequence()
            .Append(_background.DOFade(0, _closeDuration))
            .OnComplete(() =>
            {
                _background.gameObject.SetActive(false);
                callback?.Invoke();
            });
    }

    /// <summary>
    /// ����� �������� ������ ��� ��������
    /// </summary>
    public void Open()
    {
        _background.gameObject.SetActive(true);
        _panel.SetActive(true);

        DOTween.Sequence()
            .Append(_background.DOFade(_backgroundAlpha, _openDuration));
    }

    /// <summary>
    /// ����� �������� ������ ��� ��������
    /// </summary>
    public void Close()
    {
        _panel.SetActive(false);

        DOTween.Sequence()
            .Append(_background.DOFade(0, _closeDuration))
            .OnComplete(() =>
            {
                _background.gameObject.SetActive(false);
            });
    }
}
