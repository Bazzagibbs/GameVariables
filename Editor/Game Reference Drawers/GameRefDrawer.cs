using UnityEditor;
using UnityEngine;

namespace BazzaGibbs.GameVariables{
    public class GameRefDrawer : PropertyDrawer {
        private readonly string[] m_PopupOptions = {
            "Use Constant",
            "Use Variable"
        };
        
        private GUIStyle m_PopupStyle;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            if (m_PopupStyle == null) {
                m_PopupStyle = new GUIStyle(GUI.skin.GetStyle("PaneOptions"));
                m_PopupStyle.imagePosition = ImagePosition.ImageOnly;
            }

            label = EditorGUI.BeginProperty(position, label, property);
            position = EditorGUI.PrefixLabel(position, label);
            
            EditorGUI.BeginChangeCheck();
            
            // Get properties
            SerializedProperty useConstant = property.FindPropertyRelative("useConstantVal");
            SerializedProperty constantVal = property.FindPropertyRelative("constantVal");
            SerializedProperty gameVariable = property.FindPropertyRelative("gameVariable");

            Rect buttonRect = new(position);
            buttonRect.yMin += m_PopupStyle.margin.top;
            buttonRect.width = m_PopupStyle.fixedWidth + m_PopupStyle.margin.right;
            position.xMin = buttonRect.xMax;
            
            int indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;

            int result = EditorGUI.Popup(buttonRect, useConstant.boolValue ? 0 : 1, m_PopupOptions, m_PopupStyle);
            useConstant.boolValue = result == 0;

            EditorGUI.PropertyField(position, 
                useConstant.boolValue ? constantVal : gameVariable, 
                GUIContent.none);

            if (EditorGUI.EndChangeCheck()) {
                property.serializedObject.ApplyModifiedProperties();
            }

            EditorGUI.indentLevel = indent;
            EditorGUI.EndProperty();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
            bool isUsingConstant = property.FindPropertyRelative("useConstantVal").boolValue;
            if (isUsingConstant) {
                return EditorGUI.GetPropertyHeight(property.FindPropertyRelative("constantVal"), true);
            }

            return EditorGUI.GetPropertyHeight(property.FindPropertyRelative("gameVariable"));
        }
    }
    
}
