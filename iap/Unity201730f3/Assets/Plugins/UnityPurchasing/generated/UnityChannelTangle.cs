#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class UnityChannelTangle
    {
        private static byte[] data = System.Convert.FromBase64String("2o6EoOdJL5EM+DogV8pihnnLXAqiIS8gEKIhKiKiISEgpCMzB3YbLhMYJrH3ktZ6UvJf4+kkhRnylCYnEKIhAhAtJikKpmim1y0hISElICMe9lm84JzwzcMw2wOd+/crcFEU3aEjc0Wu0oUi2Vwip93K6/WFTEmNg/HfADJ9kXjI+IGUcdddfuiDoZs8vLNRub8vfxgCBuiEPY/KZ7Pqs0DY9wBvOPaGv1aTDVotfAAhs9jgv4ToGLPx2KvIBOUX+uJbhOL6S6Yq7oIAe7WD+99vR1FJCh2mMrvG7sXsuUl7MSNFs3HV5H3YF2oKpNngVX4Hk8OiPLsLFPH5JFH5Pe9l8c5c+HDAmcT9OCA0QUC+AH2CQbV//jSvYVq1iP3S+SIjISAh");
        private static int[] order = new int[] { 11,1,3,11,5,8,7,11,11,12,11,11,13,13,14 };
        private static int key = 32;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
