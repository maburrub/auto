using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.IO;
 
public static class AutoBuilder {
 
	static string GetProjectName()
	{
		string[] s = Application.dataPath.Split('/');
		return s[s.Length - 2];
	}
 
	static string[] GetScenePaths()
	{
		string[] scenes = new string[EditorBuildSettings.scenes.Length];
 
		for(int i = 0; i < scenes.Length; i++)
		{
			scenes[i] = EditorBuildSettings.scenes[i].path;
		}
 
		return scenes;
	}

	static void PerformWin64Build ()
	{
		//EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.StandaloneWindows);
		BuildPipeline.BuildPlayer(GetScenePaths(), "Builds/Win64/" + GetProjectName() + ".exe",BuildTarget.StandaloneWindows64,BuildOptions.None);
	}
 
	static void PerformOSXUniversalBuild ()
	{
		//EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.StandaloneOSXUniversal);
		BuildPipeline.BuildPlayer(GetScenePaths(), "Builds/OSX-Universal/" + GetProjectName() + ".app",BuildTarget.StandaloneOSXUniversal,BuildOptions.None);
	}
 
	static void PerformiOSBuild ()
	{
		//EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.iOS);
		BuildPipeline.BuildPlayer(GetScenePaths(), "Builds/iOS",BuildTarget.iOS,BuildOptions.None);
	}

	static void PerformGooglePlayBuild ()
	{
		PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android, "com.eight.bit.avenue.amorcam");
		EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.Android);
		BuildPipeline.BuildPlayer(GetScenePaths(), "Builds/google_play.apk",BuildTarget.Android,BuildOptions.None);
	}
	
	static void PerformGalaxyBuild ()
	{
		PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android, "com.unity.purchasing.samsungappsbasic");
		EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.Android);
		BuildPipeline.BuildPlayer(GetScenePaths(), "Builds/galaxy.apk",BuildTarget.Android,BuildOptions.None);
	}
}
