using TMPro;
using UnityEngine;

public class TextTranslator : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;

    [SerializeField] private string _ru;
    [SerializeField] private string _en;

    private void Start()
    {
        if (_text == null)
            _text = gameObject.GetComponent<TMP_Text>();
    }

    private void OnEnable()
    {
        EventController.OnLangueChanged += UpdateText;
    }

    private void OnDisable()
    {
        EventController.OnLangueChanged -= UpdateText;
    }

    /// <summary>
    /// Переводим текст
    /// </summary>
    public void UpdateText()
    {
        /*if ()
            _text.text = _ru;
        else
            _text.text = _en;*/
    }
}
