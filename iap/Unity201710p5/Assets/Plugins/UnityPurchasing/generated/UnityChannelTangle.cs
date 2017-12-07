#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class UnityChannelTangle
    {
        private static byte[] data = System.Convert.FromBase64String("OfT09AFRSXjxH15pZEClwHA3d2ThYmxjU+FiaWHhYmJju4yenx2AAVPhYkFTbmVqSeUr5ZRuYmJiZmNgTCvxu7Yk7RoGUIKjt651uofu7rUX2L4sU1CkmVnCpD59qvkBCfmfF32huT/YlUyCelrMC0oQX3ARPIcOSMsxscVpXQZgW7nNRR7fspMPt5cfqmWXvBtAiAO2LVpBJgXWvsG5Gr1gwC94LoMMsihyQeYRNE1y+AxQqgE5wmUYy6ToqOsPN36rxWB04UVm68Jo83X3cSD465OGaHRk/gYG5VDPTzec2k/UBypaSsADtH8ZsnAY7NMFwB6ZrX7GAtc+x10D9e+3yI5QF9r69DWSLfa5gbsdFjoBlTUNj6UTU6cSK9NeeGFgYmNi");
        private static int[] order = new int[] { 11,1,11,6,10,8,12,8,13,12,10,11,12,13,14 };
        private static int key = 99;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
