using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// HelpURL Attribute
/// The HelpURL attribute will use to links, that send the user to e.g. the documentation.
/// This attribute must be added above the class definition.
/// If you were to click this icon, a browser window would open taking you to the documentation for that specific component.
/// It is very useful in team projects.
/// Syntax : [HelpURL (“URL”)]
/// </summary>
[HelpURL("https://unity.com/how-to/organizing-your-project")]

/// <summary>
/// SelectionBase Attribute
/// SelectionBase attribute prevents the frustration of selecting a child object when you meant to select the parent object.
/// It is useful in big games in which the parent objects have many child objects.
/// Syntax : [SelectionBase]
/// </summary>
[SelectionBase]
public class UnityAttributes : MonoBehaviour
{
    /////////////////////////////////////////////////////////////////////////
    //_  _ _  _ _ ___ _   _    ____ ___ ___ ____ _ ___  _  _ ___ ____ ____ //
    //|  | |\ | |  |   \_/     |__|  |   |  |__/ | |__] |  |  |  |___ [__  //
    //|__| | \| |  |    |      |  |  |   |  |  \ | | __]|__|  |  |___ ___] //
    //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++=//

    //Attributes are markers that can be placed above a class, property,
    //or function in a script to indicate a special behavior.
    //Attributes can apply to variables, functions, or even an entire class.
    //It helps you create write more efficient and flexible code.
    //For example, you can assign a float value using a slider and show private variables in the Inspector.

    #region attributes

    /// <summary>
    /// Header Attribute
    /// This attribute is useful by adding a header above fields in the Inspector
    /// [Header ("Sphere variable")]
    /// </summary>
    [Header("Header Attribute")]
    [Tooltip("This attribute is useful by adding a header above fields in the Inspector")]
    public string HeaderAttribute = "sample var";

    /// <summary>
    /// Space Attribute
    /// This attribute is creating a space between fields.
    /// Syntax : [Space(“int”)]
    /// Whereby the value you pass is the padding in pixels
    /// </summary>
    [Space(50)]
    [Header("======Xamp Space======")]
    [Space(50)]
    public string SpaceAttribute = "xample";

    /// <summary>
    /// Tooltip Attribute
    /// This attribute creates a tooltip, that appears once you hover over the variable with the attribute
    /// Syntax : [Tooltip (“text”)]
    /// </summary>
    [Tooltip("This variable represent 3 dimension position values of Capsule ")]
    [Header("Tooltip Attribute")]
    public Vector3 TooltipAttribute;

    /// <summary>
    /// Range Attribute
    /// This attribute is used to give you a slider, to select values within a range, directly from the Unity Editor
    /// Syntax : [Range (float value ,float value)]
    /// </summary>
    [Range(0.0f, 25.0f)]
    [Header("Range Attribute")]
    [Tooltip("This attribute is used to give you a slider, to select values within a range, directly from the Unity Editor")]
    public float RangeAttribute;

    /// <summary>
    /// TextArea Attribute
    /// The TextArea attribute is useful when you have to add a long string (long text, message) in a string variable via the editor
    /// Syntax : [TextArea(int minLines ,int maxLines)]
    /// </summary>
    [Header("No TextArea Attribute in variable")]
    [Tooltip("No TextArea Attribute in variable")]
    public string normalString;
    [TextArea(1,10)]
    [Header("TextArea Attribute in variable")]
    [Tooltip("The TextArea attribute is useful when you have to add a long string (long text, message) in a string variable via the editor")]
    public string TextAreaAttribute;

    /// <summary>
    /// SerializeField Attribute
    /// The SerializeField attribute is used to show private variables in the inspector.
    /// Syntax : [SerializeField]
    /// </summary>
    [Header("This is a private variable that will be made available in the editor")]
    [SerializeField]
    private int SerializeFieldAttribute;

    /// <summary>
    /// HideInInspector Attribute
    /// HideInInspector attribute is used to hide public variables in the inspector.
    /// Syntax : [HideInInspector]
    /// </summary>
    [HideInInspector]
    public bool HideInInspectorAttribute;

    /// <summary>
    /// ContextMenuItem Attribute
    /// When you assign the ContextMenuItem attribute to any variable.
    /// It will display a menu option when right-clicking the variable in the Inspector.
    /// Syntax : [ContextMenuItem(“string description of method”,”Method name”)]
    /// </summary>
    [Header("Right click this variable name!")]
    [SerializeField]
    [ContextMenuItem("Get a random scale", "ContextMenuItemAttribute")]
    private float randomScale;
    public void ContextMenuItemAttribute()
    {
        randomScale = Random.Range(0.0f, 5.0f);
    }
    #endregion
}
