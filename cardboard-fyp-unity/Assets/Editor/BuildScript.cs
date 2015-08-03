using UnityEngine;
using System.Collections;
using UnityEditor;

public class BuildScript
{
	static void PerformBuild ()
	{
		EditorApplication.ExecuteMenuItem ("Assets/Sync MonoDevelop Project");
	}
}
