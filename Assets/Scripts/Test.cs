using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public float time;
    public float maxTime;
    public float onTime;
    public float offTime;

    private Image image;


    void Awake()
    {
        image = GetComponent<Image>();
        image.enabled = false;
    }

    void Update()
    {
        time += Time.deltaTime;

        if (time > maxTime)
        {
            time = 0f;
            image.enabled = false;
        } 
        else if (time > offTime)
        {
            image.enabled = false;
        }
        else if (time > onTime)
        {
            image.enabled = true;
        }
    }
}
