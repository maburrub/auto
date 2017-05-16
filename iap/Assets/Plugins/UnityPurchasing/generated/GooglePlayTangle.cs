#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("xfos6TewhFfvK/4X7nQq3Mae4ac+8ZcFenmNsHDrjRdUg9AoINC2PnrIS2h6R0xDYMwCzL1HS0tLT0pJT8LrQdpc3lgJ0cK6r0FdTdcvL8yUSekGUQeqJZsBW2jPOB1kW9EleTaDTL6VMmmhKp8Ec2gPLP+X6JAzeeZmHrXzZv0uA3Nj6SqdVjCbWTFh4hiY7EB0L0lykORsN/abuiaevnk+89PdHLsE35CokjQ/Eyi8HCSmZQLYkp8NxDMveauKnodck67Hx5xUiJAW8bxlq1Nz5SJjOXZZOBWuJ4MoEOtMMeKNwYHCJh5XguxJXchsyEtFSnrIS0BIyEtLSpKlt7Y0qSgQ3d3dKHhgUdg2d0BNaYzpWR5eTYw6eo47Avp3UUhJS0pL");
        private static int[] order = new int[] { 9,10,9,4,13,5,9,12,12,9,12,13,12,13,14 };
        private static int key = 74;

        public static byte[] Data() {
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
