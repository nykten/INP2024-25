using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PathInspect : MonoBehaviour
{
    private string aPath;
    private string scriptPath;
    private string appdataPath;
    // private string
    // Start is called before the first frame update
    void Start()
    {
        aPath = Directory.GetParent(Application.dataPath) + @"\VFTest-tests\Tests";
        scriptPath = Application.dataPath + "/VFTest-tests/scripts";
        appdataPath = Application.dataPath;


        Debug.Log("aPath = " + aPath);
        Debug.Log("Parent = " + Directory.GetParent(Application.dataPath));
        Debug.Log("scriptPath = " + scriptPath);
        Debug.Log("appdataPath = " + appdataPath);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



// C:/Users/Caleb/Documents/nik-INP/visual-field-mapping-testing-and-correction/IntegratedVFTnR/Assets\VFTest-tests\scripts
// C:\Users\Caleb\Documents\nik-INP\visual-field-mapping-testing-and-correction\IntegratedVFTnR\VFTest-tests