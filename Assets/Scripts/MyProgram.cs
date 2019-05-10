
using UnityEngine;
using Shapes;
using UnityEngine.UI;

public class MyProgram : MonoBehaviour
{

    public InputField inputField;

    public void Show()
    {
        //Debug.Log("<b>Log</b>");
        //Debug.LogWarning("<i>Warning</i>");
        //Debug.LogError("<color=#ff0000ff>Error</color>");        

        //Debug.Log("1 - square");
        //Debug.Log("2 - circle");
        string shapeSelected = inputField.text;//Console.ReadLine();

        Shape shape = null;
        switch (shapeSelected)
        {
            case "1":
                shape = new Square("MySquare", 5);
                break;

            case "2":
                shape = new Circle("MyCircle", 2);
                break;
        }

        if (shape != null)
            Debug.Log(shape.Area());
    }

}
