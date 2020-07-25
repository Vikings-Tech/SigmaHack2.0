using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuideSheetHandler : MonoBehaviour
{
    public Texture[] images;
    public Material overlayMaterial;
    private int current = 0;

    [SerializeField] private Dropdown options;

    private Hashtable textureNames;
    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.Landscape; 
        List<string> optionName = new List<string>();
        
        options.ClearOptions();
        foreach (var VARIABLE in images)
        {
            optionName.Add(VARIABLE.name);
            
        }
        
        options.AddOptions(optionName);
        overlayMaterial.mainTexture = images[0];

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void change()
    {
        
        overlayMaterial.mainTexture = images[options.value];
    }
}
