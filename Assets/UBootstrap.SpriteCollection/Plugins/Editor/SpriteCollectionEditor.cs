using UnityEngine;
using UnityEditor;
using System.IO;

namespace UBootstrap
{
    [CustomEditor (typeof(SpriteCollection))]
    public class SpriteCollectionUtilities : Editor
    {
        private SerializedProperty folderName, sprites;

        protected virtual void OnEnable ()
        {
            folderName = serializedObject.FindProperty ("folderName");
            sprites = serializedObject.FindProperty ("sprites");
        }

        override public void OnInspectorGUI ()
        {
            SpriteCollection component = (SpriteCollection)target;
            EditorGUILayout.BeginHorizontal ();
            EditorGUILayout.PropertyField (folderName);

            float reloadWidth = GUI.skin.label.CalcSize (new GUIContent ("Reload")).x + 20;
            if (GUILayout.Button ("Reload", GUILayout.Width (reloadWidth))) {
                Debug.Log (this.GetType ().Name + "::OnInspectorGUI Load pngs from " + component.folderName);
                string[] spritePaths = Directory.GetFiles (Application.dataPath + "/" + component.folderName, "*.png", SearchOption.TopDirectoryOnly);
                component.sprites.Clear ();

                string spritePath = string.Empty;
                for (int i = 0; i < spritePaths.Length; i++) {
                    var index = spritePaths [i].IndexOf ("/Assets") + 1;
                    spritePath = spritePaths [i].Substring (index);
                    var sprite = AssetDatabase.LoadAssetAtPath<Sprite> (spritePath);
                    component.sprites.Add (sprite);
                }
            }

            EditorGUILayout.EndHorizontal ();
            EditorGUILayout.PropertyField (sprites, true);
            serializedObject.ApplyModifiedProperties ();
        }
    }
}