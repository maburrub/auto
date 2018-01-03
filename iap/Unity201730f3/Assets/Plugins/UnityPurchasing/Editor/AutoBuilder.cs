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

    static void PerformWindowsUniversalBuild()
    {

		#if UNITY_5_6_OR_NEWER 
        	EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.WSA, BuildTarget.WSAPlayer);
		#else
        	EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.WSAPlayer);
		#endif

        EditorUserBuildSettings.SetWSADotNetNative(WSABuildType.Debug, true);
        EditorUserBuildSettings.wsaBuildAndRunDeployTarget = WSABuildAndRunDeployTarget.LocalMachineAndWindowsPhone;
        EditorUserBuildSettings.wsaSDK = WSASDK.UWP;
        EditorUserBuildSettings.wsaSubtarget = WSASubtarget.AnyDevice;
        EditorUserBuildSettings.wsaUWPBuildType = WSAUWPBuildType.XAML;
        EditorUserBuildSettings.wsaUWPSDK = "10.0.10586.0";
        BuildPipeline.BuildPlayer(GetScenePaths(), "Builds/WindowsUniversal", BuildTarget.WSAPlayer, BuildOptions.None);
    }

	static void PerformWin64Build ()
	{
		#if UNITY_5_6_OR_NEWER 
		   EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Standalone, BuildTarget.StandaloneWindows);
		#else
		   EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.StandaloneWindows);
		#endif

		BuildPipeline.BuildPlayer(GetScenePaths(), "Builds/Win64/" + GetProjectName() + ".exe",BuildTarget.StandaloneWindows64,BuildOptions.None);
	}
 
	static void PerformMacBuild ()
	{
		#if UNITY_5_6_OR_NEWER 
		   EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Standalone, BuildTarget.StandaloneOSX);
	       PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Standalone, "com.unity3d.unityiap.mac.demo");
		#else
		   EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.StandaloneOSXUniversal);
		#endif

		BuildPipeline.BuildPlayer(GetScenePaths(), "Builds/OSX-Universal/" + GetProjectName() + "_mac.app",BuildTarget.StandaloneOSX,BuildOptions.None);
	}
 
	static void PerformFacebookWebglBuild ()
	{		
		#if UNITY_5_6_OR_NEWER 
		   EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Facebook, BuildTarget.WebGL);
		   //EditorUserBuildSettings.facebookCreatePackageForSubmission = true;
		   //EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Facebook, BuildTarget.StandaloneWindows);	

		   PlayerSettings.Facebook.sdkVersion = "7.9.4";
		   List<string> appIds = new List<string>();
		   appIds.Add("339961179753667");
		   Facebook.Unity.Settings.FacebookSettings.AppIds = appIds;
				
		   BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
           buildPlayerOptions.scenes = GetScenePaths();
           buildPlayerOptions.locationPathName = "Builds/facebook";
           buildPlayerOptions.target = BuildTarget.WebGL;
           buildPlayerOptions.targetGroup = BuildTargetGroup.Facebook;
           buildPlayerOptions.options = BuildOptions.None;
           BuildPipeline.BuildPlayer(buildPlayerOptions);
		#else
		   Debug.Log("Facebook not supported");
		#endif

	}

	static void PerformiOSBuild ()
	{
		#if UNITY_5_6_OR_NEWER 
		   EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.iOS, BuildTarget.iOS);
	       PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.iOS, "com.unity3d.unityiap.demo");
		#else
		   EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.iOS);
		#endif

	    PlayerSettings.iOS.appleDeveloperTeamID = "3XGDM87KDL";
	    PlayerSettings.iOS.appleEnableAutomaticSigning = true;
		BuildPipeline.BuildPlayer(GetScenePaths(), "Builds/iOS",BuildTarget.iOS, BuildOptions.None);
	}

	static void PerformResetNonConsumableBuild ()
	{
		#if UNITY_5_6_OR_NEWER 
		   EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Android, BuildTarget.Android);
		   PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android, "com.eight.bit.avenue.amorcam");
		#else
		   EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.Android);
		#endif

		BuildPipeline.BuildPlayer(GetScenePaths(), "Builds/reset_non_consumable.apk", BuildTarget.Android,BuildOptions.None);
	}

	static void PerformXiaomiBuild ()
	{
		#if UNITY_5_6_OR_NEWER 
		   EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Android, BuildTarget.Android);
		   PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android, "com.unity.channel.sdk.sample");
		#else
		   EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.Android);
		#endif

		BuildPipeline.BuildPlayer(GetScenePaths(), "Builds/xiaomi.apk",BuildTarget.Android,BuildOptions.None);
	}

	static void PerformCloudMoolahBuild ()
	{
		#if UNITY_5_6_OR_NEWER 
		   EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Android, BuildTarget.Android);
           PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android, "com.eight.bit.avenue.amorcam");
		#else
		   EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.Android);
		#endif

		BuildPipeline.BuildPlayer(GetScenePaths(), "Builds/cloud_moolah.apk",BuildTarget.Android,BuildOptions.None);
	}
	
	static void PerformDoubleInitBuild ()
	{
		#if UNITY_5_6_OR_NEWER 
		   EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Android, BuildTarget.Android);
		   PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android, "com.eight.bit.avenue.amorcam");
		#else
		   EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.Android);
		#endif

		BuildPipeline.BuildPlayer(GetScenePaths(), "Builds/double_init.apk",BuildTarget.Android,BuildOptions.None);
	}

	static void PerformUnknownProdBuild ()
	{
		#if UNITY_5_6_OR_NEWER 
		   EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Android, BuildTarget.Android);
		   PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android, "com.eight.bit.avenue.amorcam");
		#else
		   EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.Android);
		#endif

		BuildPipeline.BuildPlayer(GetScenePaths(), "Builds/unknown_prod.apk",BuildTarget.Android,BuildOptions.None);
	}
	
	static void PerformGooglePlayIl2cppBuild ()
	{
		#if UNITY_5_6_OR_NEWER 
		   EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Android, BuildTarget.Android);
		   PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android, "com.eight.bit.avenue.amorcam");
		#else
		   EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.Android);
		#endif

		PlayerSettings.SetPropertyInt( "ScriptingBackend", (int)ScriptingImplementation.IL2CPP, BuildTargetGroup.Android);
		BuildPipeline.BuildPlayer(GetScenePaths(), "Builds/google_play.apk",BuildTarget.Android,BuildOptions.None);
	}

	static void PerformGooglePlayBuild ()
	{
		#if UNITY_5_6_OR_NEWER 
		   EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Android, BuildTarget.Android);
		   PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android, "com.eight.bit.avenue.amorcam");
		#else
		   EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.Android);
		#endif

		BuildPipeline.BuildPlayer(GetScenePaths(), "Builds/google_play.apk",BuildTarget.Android,BuildOptions.None);
	}
	
	static void PerformFrenchLocaleBuild ()
	{
		#if UNITY_5_6_OR_NEWER 
		   EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Android, BuildTarget.Android);
		   PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android, "com.eight.bit.avenue.amorcam");
		#else
		   EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.Android);
		#endif

		BuildPipeline.BuildPlayer(GetScenePaths(), "Builds/fr_locale.apk",BuildTarget.Android,BuildOptions.None);
	}
	
	static void PerformGalaxyPassBuild ()
	{
		#if UNITY_5_6_OR_NEWER 
		   EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Android, BuildTarget.Android);
		   PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android, "com.unity.purchasing.samsungappsbasic");
		#else
		   EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.Android);
		#endif

		BuildPipeline.BuildPlayer(GetScenePaths(), "Builds/galaxy_pass.apk",BuildTarget.Android, BuildOptions.None);
	}

	static void PerformGalaxyFailBuild ()
	{
		#if UNITY_5_6_OR_NEWER 
		   EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Android, BuildTarget.Android);
		   PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android, "com.unity.purchasing.samsungappsbasic");
		#else
		   EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.Android);
		#endif

		BuildPipeline.BuildPlayer(GetScenePaths(), "Builds/galaxy_fail.apk",BuildTarget.Android, BuildOptions.None);
	}
}
