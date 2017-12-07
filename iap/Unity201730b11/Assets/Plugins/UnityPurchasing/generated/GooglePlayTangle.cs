#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("C68nl86Tqm93YxYX6Vcq1RbiKKmN2dP3sB54xluvbXcAnTXRLpwLXQIpUMSU9WvsXEOmrnMGrmq4MqaZa+vkBu7oeChPVVG/02rYnTDkveT2dCQS+YXSdY4LdfCKnbyi0hse2tSmiFdlKsYvn6/WwyaACim/1PbMfbnVVyzi1KyIOBAGHl1K8WXskbn1dnh3R/V2fXX1dnZ383RkUCFMeejTv0/kpo/8n1OyQK21DNO1rRzxRE9x5qDFgS0FpQi0vnPSTqXDcXBJoQ7rt8unmpRnjFTKrKB8JwZDihePoFc4b6HR6AHEWg16K1d25I+3R/V2VUd6cX5d8T/xgHp2dnZyd3SSu+4eLGZ0EuQmgrMqj0A9XfOOt2P4Ng3i36qFrnV0dnd2");
        private static int[] order = new int[] { 9,11,13,13,8,7,8,11,12,13,11,12,13,13,14 };
        private static int key = 119;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
