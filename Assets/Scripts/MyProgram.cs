
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

        Class Class = null;
        switch (shapeSelected)
        {
            case "1":
                Class = new Knight("NewKnight");
                break;

            case "2":
                Class = new Cleric("NewCleric");
                break;

            case "3":
                Class = new Warrior("NewWarrior");
                break;
        }

        if (Class != null)
            Debug.Log("Your selected " +Class.Area());
    }

}
