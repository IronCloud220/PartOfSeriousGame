using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundChange : MonoBehaviour//add
{
    public Image image;
    //public float backgroundSpeed;
    //public Renderer backgroundRenderer;
    public Sprite[] sprites;
    public static int crust = 10;
    public static int mantle = 50;
    public static int outercore = 100;
    public static int innercore = 150;
  

    // Update is called once per frame
    void Update()
    {
        //backgroundRenderer = backgroundRenderer.GetComponent<Renderer>();
        if(Contact1.distanceTravelled < crust)
        {
            image.sprite = sprites[0];
        }
        else if(Contact1.distanceTravelled < mantle)
        {
            image.sprite = sprites[1];
        }
        else if (Contact1.distanceTravelled < outercore)
        {
            image.sprite = sprites[2];
        }
        else
        {
            image.sprite = sprites[3];
        }
        
        //backgroundRenderer.material.mainTextureOffset += new Vector2(0f, backgroundSpeed * Time.deltaTime);
        
    }
}
