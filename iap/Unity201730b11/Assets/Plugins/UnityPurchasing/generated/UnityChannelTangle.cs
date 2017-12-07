#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class UnityChannelTangle
    {
        private static byte[] data = System.Convert.FromBase64String("0jqVcCxQPAEP/BfPUTc757yd2BGMFDvMo/Q6SnOaX8GW4bDM7X8ULG3vv4liHknuFZDuaxEGJzlJgIVBc0gk1H89FGcEyCnbNi6XSC42h2rmIk7Mt3lPNxOji52FxtFq/ncKItxu7c7c4erlxmqkahvh7e3t6ezvTz0TzP6xXbQENE1YvRuRsiRPbVfwcH+ddXPjs9TOyiRI8UMGq38mf9/U6n07Xhq2nj6TLyXoSdU+WOrrFkJIbCuF413ANPbsmwauSrUHkMaZsstfD27wd8fYPTXonTXxI6k9ApA0vAxVCDH07PiNjHLMsU6NebMyCSB1hbf974l/vRkosRTbpsZoFSxu7ePs3G7t5u5u7e3saO//y7rX4vhjrZZ5RDEeNe7v7ezt");
        private static int[] order = new int[] { 5,6,8,12,4,5,7,8,12,11,13,11,13,13,14 };
        private static int key = 236;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
