using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{
    public int intRow;
    public int intCol;
    private Text tileText;
    private Image tileImage;
    private Animator anim;
    private int number;
    public bool mergedThisTurn = false;
    public int Number
    {
        get
        {
            return number;
        }
        set
        {
            number = value;
            if (number == 0)
            {
                SetEmpty();
            }
            else
            {
                ApplyStyle(number);
                SetVisible();
            }
        }
    }
    private void Awake()
    {
        anim = GetComponent<Animator>();
        tileText = GetComponentInChildren<Text>();
        tileImage = transform.Find("NumberedCell").GetComponent<Image>();
    }

    public void PlayMeragedAnimation()
    {
        anim.SetTrigger("Merge");
    }

    public void PlayAppearAnimation()
    {
        anim.SetTrigger("Appear");
    }

    public void ApplyStyleFromHolder(int index)
    {
        tileText.text = TileStyleHolder.Instance.TileStyles[index].number.ToString();
        tileText.color = TileStyleHolder.Instance.TileStyles[index].textColor;
        tileImage.color = TileStyleHolder.Instance.TileStyles[index].titleColor;
    }

    public void ApplyStyle(float num)
    {
        print(num);
        float value = Mathf.Log(num, 2);
        print(value);
        ApplyStyleFromHolder((int) value - 1);
    }

    private void SetVisible()
    {
        tileImage.enabled = true;
        tileText.enabled = true;
    }

    private void SetEmpty()
    {
        tileImage.enabled = false;
        tileText.enabled = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
