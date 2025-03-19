using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Fuzzy : MonoBehaviour
{
    private const string labelText = "{0} true";
    public AnimationCurve starving;
    public AnimationCurve hungry;
    public AnimationCurve stomachFull;

    public Slider hungerInput;

    public TMP_Text stomachFullLabel;
    public TMP_Text hungryLabel;
    public TMP_Text starvingLabel;

    private float starvingValue = 0f;
    private float hungryValue = 0f;
    private float stomachFullValue = 0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetLabels();        
    }

    // Update is called once per frame
    void Update()
    {
        EvaluateStatements();       
    }

    public void EvaluateStatements()
    {
        float inputValue = hungerInput.value;

        stomachFullValue = stomachFull.Evaluate(inputValue);
        hungryValue = hungry.Evaluate(inputValue);
        starvingValue = starving.Evaluate(inputValue);

        SetLabels();
    }

    private void SetLabels()
    {
        stomachFullLabel.text = string.Format(labelText, stomachFullValue);
        hungryLabel.text = string.Format(labelText, hungryValue);
        starvingLabel.text = string.Format(labelText, starvingValue);

    }
}
