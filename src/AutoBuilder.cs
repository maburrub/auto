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
 
	static void PerformMacBuild ()
	{
		//EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.StandaloneOSXUniversal);
		BuildPipeline.BuildPlayer(GetScenePaths(), "Builds/OSX-Universal/" + GetProjectName() + ".app",BuildTarget.StandaloneOSXUniversal,BuildOptions.None);
	}
 
	static void PerformFacebookWebglBuild ()
	{
		//targetPlatform (webgl or gameroom)
		//package build for uploading
		//appID
		//Note we can use BuildOptions.AutoRunPlayer
		//BuildTarget : facebook or gameroom ?
		
		PlayerSettings.Facebook.sdkVersion = "7.9.4";	
		PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Facebook, "281077639005121");	
		
		EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Facebook, BuildTarget.WebGL);	
		
		BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = GetScenePaths();
        buildPlayerOptions.locationPathName = "Builds/facebook";
        buildPlayerOptions.target = BuildTarget.WebGL;
        buildPlayerOptions.targetGroup = BuildTargetGroup.Facebook;
        buildPlayerOptions.options = BuildOptions.None;
        BuildPipeline.BuildPlayer(buildPlayerOptions);
	}

	static void PerformiOSBuild ()
	{
	    PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.iOS, "com.unity3d.unityiap.demo");
	    PlayerSettings.iOS.appleDeveloperTeamID = "3XGDM87KDL";
	    PlayerSettings.iOS.appleEnableAutomaticSigning = true;
		EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.iOS);
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
