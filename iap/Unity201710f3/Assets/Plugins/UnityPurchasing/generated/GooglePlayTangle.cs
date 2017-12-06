#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("a94R48hvNPx3wlkuNVJxosq1zW4J1c1LrOE49g4uuH8+ZCsEZUjzeieVFjUnGhEePZFfkeAaFhYWEhcUJGOujoBB5lmCzfXPaWJOdeFBefuYp3G0au3ZCrJ2o0qzKXeBm8O8+iS7O0Porjugc14uPrR3wAttxgRsTYCAgHUlPQyFayodEDTRtARDAxCVFhgXJ5UWHRWVFhYXz/jq62n0dRKfthyHAYMFVIyf5/IcABCKcnKRyRS0Wwxa93jGXAY1kmVAOQaMeCQ4X4XPwlCZbnIk9tfD2gHO85qawWOsylgnJNDtLbbQSgnejXV9jetjPL9FxbEdKXIUL825MWqrxud7w+PedU22EWy/0Jzcn3tDCt+xFACVMdFnJ9NmX6cqDBUUFhcW");
        private static int[] order = new int[] { 5,8,5,7,9,5,11,8,9,13,11,11,12,13,14 };
        private static int key = 23;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
