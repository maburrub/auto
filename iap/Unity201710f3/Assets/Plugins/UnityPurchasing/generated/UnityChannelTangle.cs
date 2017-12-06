#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class UnityChannelTangle
    {
        private static byte[] data = System.Convert.FromBase64String("dMZFZnRJQk1uwgzCs0lFRUVBREdBzOVP1FLQVgffzLShT1ND2SEhwjD/mQt0d4O+fuWDGVqN3iYu3rgwjSYe5UI/7IPPj8woEFmM4kdTxmLL9CLnOb6KWeEl8BngeiTSyJDvqVqGnhj/smulXX3rLG03eFc2G6Apb+wWluJOeiFHfJ7qYjn4lbQokLCaR+cIXwmkK5UPVWbBNhNqVd8rd3foaBC7/WjzIA19beckk1g+lVc/HtPT0yZ2bl/WOHlOQ2eC51cQUENrDNackQPKPSF3pYSQiVKdoMnJksZFS0R0xkVORsZFRUScq7m4OqcmdzD93dMStQrRnqacOjEdJrISKqg4jUKwmzxnrySRCn1mASLxmeaePYI0dIA1DPR5X0ZHRURF");
        private static int[] order = new int[] { 0,4,10,3,9,8,12,13,10,11,12,11,13,13,14 };
        private static int key = 68;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
