#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("23/3Rx5Der+ns8bHOYf6BcYy+HmtaQWH/DIEfFjowNbOjZohtTxBaTgDb580dl8sT4NikH1l3ANlfcwhuzs01j44qPifhYFvA7oITeA0bTRCaz7O/LakwjT2UmP6X5DtjSNeZyak9MIpVQKlXtulIFpNbHICy84KlyWmhZeqoa6NIe8hUKqmpqaip6RdCQMnYM6oFot/vafQTeUB/kzbjdL5gBREJbs8jJN2fqPWfrpo4nZJJaaop5clpq2lJaampyOktIDxnKmUn6E2cBVR/dV12GRuowKedROhoMdfcIfov3EBONEUit2q+4emNF9nBHZYh7X6Fv9PfwYT9lDa+W8EJhyZcd47Zxt3SkS3XIQafHCs99aTWrMo5t0yD3pVfqWkpqem");
        private static int[] order = new int[] { 9,4,12,12,10,8,9,11,13,10,12,12,12,13,14 };
        private static int key = 167;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
