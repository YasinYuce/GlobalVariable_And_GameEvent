using System;
using UnityEngine;
using UnityEditor;
using UnityEngine.Serialization;

[CustomPropertyDrawer(typeof(VariableReference), true)]
public class VariableReferencePropertyDrawer : PropertyDrawer
{
	private GUIContent localContent = new GUIContent("Constant Value");
	private GUIContent globalContent = new GUIContent("Global Reference");
	private GUIStyle buttonStyle;
	private bool usingGlobalVar;

	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
	{
		// Get properties
		SerializedProperty usingGlobal = property.FindPropertyRelative("useReference");
		SerializedProperty globalReference = property.FindPropertyRelative("variable");
		SerializedProperty localValue = property.FindPropertyRelative("constantValue");

		if (buttonStyle == null)
		{
			buttonStyle = new GUIStyle(GUI.skin.GetStyle("Icon.Options"));
			buttonStyle.imagePosition = ImagePosition.ImageOnly;
			buttonStyle.fixedWidth = 15;
			buttonStyle.fixedHeight = 14;

			usingGlobalVar = usingGlobal.boolValue;
		}

		label = EditorGUI.BeginProperty(position, label, property);

		// Context Menu Button position
		Rect buttonPosition = position;
		buttonPosition.xMin = position.xMax - 12;

		// give the context button space
		position.xMax -= 18;

		// Draw the context menu first, so we get an immediate change in the editor on switching
		// between global and local
		if (GUI.Button(buttonPosition, GUIContent.none, buttonStyle))
		{
			GenericMenu menu = new GenericMenu();
			menu.AddItem(localContent, !usingGlobalVar, () => usingGlobalVar = false);
			menu.AddItem(globalContent, usingGlobalVar, () => usingGlobalVar = true);
			menu.ShowAsContext();
		}

		usingGlobal.boolValue = usingGlobalVar;

		// Draw the property editor
		if (usingGlobalVar)
		{
			EditorGUI.PropertyField(position, globalReference, label, true);
			position.yMin += EditorGUI.GetPropertyHeight(globalReference, globalReference.isExpanded) + EditorGUIUtility.standardVerticalSpacing;
		}
		else
		{
			EditorGUI.PropertyField(position, localValue, label, true);
			position.yMin += EditorGUI.GetPropertyHeight(localValue, localValue.isExpanded) + EditorGUIUtility.standardVerticalSpacing;
		}

		EditorGUI.EndProperty();
	}

	public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
	{
		float height = 0.0f;

		if (usingGlobalVar)
		{
			height += EditorGUIUtility.singleLineHeight + 2;
		}
		else
		{
			SerializedProperty localValue = property.FindPropertyRelative("constantValue");

			height += EditorGUI.GetPropertyHeight(localValue, localValue.isExpanded) + EditorGUIUtility.standardVerticalSpacing;
		}

		return height;
	}
}