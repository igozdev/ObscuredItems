using UnityEngine;
using UnityEngine.UI;
using oint = ObscuredItems.ObscuredInt;
using obool = ObscuredItems.ObscuredBool;
using ofloat = ObscuredItems.ObscuredFloat;

[ExecuteInEditMode]
public class InspectorDemo : MonoBehaviour
{
    #if (UNITY_EDITOR)
    [SerializeField] private int _exampleInspectorInt = 0;
    [SerializeField] private bool _exampleInspectorBool = false;
    [SerializeField] private float _exampleInspectorFloat = 0.0f;
    #endif

    private oint _exampleObscuredInt;
    private obool _exampleObscuredBool;
    private ofloat _exampleObscuredFloat;
    private Text _valuesText;

    private void Start()
    {
        _exampleObscuredInt = new oint();
        _exampleObscuredBool = new obool();
        _exampleObscuredFloat = new ofloat();
        _valuesText = GameObject.Find("ValuesText").GetComponent<Text>();
    }

    private void Update()
    {
        #if (UNITY_EDITOR)
        _exampleObscuredInt.Value = _exampleInspectorInt;
        _exampleObscuredBool.Value = _exampleInspectorBool;
        _exampleObscuredFloat.Value = _exampleInspectorFloat;
        #endif

        _valuesText.text = string.Format("Values:\nObscuredInt: {0}\nObscuredBool: {1}\nObscuredFloat: {2}", _exampleObscuredInt.Value, _exampleObscuredBool.Value, _exampleObscuredFloat.Value);
    }
}