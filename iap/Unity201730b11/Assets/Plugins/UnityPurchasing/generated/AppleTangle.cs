#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class AppleTangle
    {
        private static byte[] data = System.Convert.FromBase64String("DAlfFwQOHA4eIdpjTZ58A/T+YYckSqz9TUd1AlQ6FQwJXxcpDhI6HAWXN/khQyIQwvTEv7ME01QW3ME3bj8pH0EfUxe5nv38lpTFWrDLUloCIQwLDw8NCAscFGJ+fnp5MCUlfTk8UDpoOwE6AwwJXw4MGQhfWTsZDgwZCF9ZOxk6GwwJXw4AGQBLenoPCgmICwUKOogLAAiICwsK7pujAyplbCp+Ym8qfmJvZCprenpmY2lrAlQ6iAsbDAlfFyoOiAsCOogLDjoN5ncziYFZKtkyzru1kEUAYfUh9mZvKkNkaSQ7LDouDAlfDgEZF0t6DDoFDAlfFxkLC/UODzoJCwv1OhdYb2Zja2RpbyplZCp+YmN5KmlveHhraX5jaW8qeX5rfm9nb2R+eSQ6iAsKDAMgjEKM/WluDws6i/g6IAx+Y2xjaWt+bypocyprZHMqemt4fr8wp/4FBAqYAbsrHCR+3zYH0WgcHDoeDAlfDgkZB0t6emZvKlhlZX5oZm8qeX5rZG5reG4qfm94Z3kqa319JGt6emZvJGllZyVrenpmb2lroal7mE1ZX8ulJUu58vHpesfsqUZ+YmV4Y35zOxw6HgwJXw4JGQdLemRuKmllZG5jfmNlZHkqZWwqf3lvBwwDIIxCjP0HCwsPDwoJiAsLClY8k0Yncr3nhpHW+X2R+HzYfTpFyxWb0RRNWuEP51RzjifhPKhdRl/mKmtkbippb3h+Y2xjaWt+Y2VkKno6iA6xOogJqaoJCAsICAsIOgcMA0PSfJU5Hm+rfZ7DJwgJCwoLqYgLotZ0KD/AL9/TBdxh3qguKRv9q6ZPdBVGYVqcS4POfmgBGolLjTmAi9M8dcuNX9Otk7M4SPHS33uUdKtYcDqIC3w6BAwJXxcFCwv1Dg4JCAvKaTl9/TANJlzh0AUrBNCweRNFv1OtDwN2HUpcGxR+2b2BKTFNqd9lemZvKlhlZX4qSUs6FB0HOjw6PjgqSUs6iAsoOgcMAyCMQoz9BwsLCxWPiY8RkzdNPfijkUqEJt67mhjStP55keTYbgXBc0U+0qg083L1YcI3LG0qgDlg/QeIxdThqSXzWWBRboV5i2rMEVEDJZi48k5C+moylB//Pzg7Pjo5PFAdBzk/Ojg6Mzg7PjqBE4PU80Fm/w2hKDoI4hI08loD2b0Rt5lILhggzQUXvEeWVGnCQYodih4h2mNNnnwD9P5hhyRKrP1NR3V6Zm8qSW94fmNsY2lrfmNlZCpLf3Mqa3l5f2dveSpraWlven5rZGlvLujh27161QVP6y3A+2dy5+2/HR27OlLmUA44hmK5hRfUb3n1bVRvtsMTeP9XBN91VZH4LwmwX4VHVwf7n5RwBq5NgVHeHD05wc4FR8QeY9tjbGNpa35jZWQqS39+YmV4Y35zO22FAr4q/cGmJiplerw1CzqGvUnFdUuikvPbwGyWLmEb2qmx7hEgyRUmKmlveH5jbGNpa35vKnplZmNpcyw6LgwJXw4BGRdLenpmbypJb3h+IIxCjP0HCwsPDwo6aDsBOgMMCV8lOovJDAIhDAsPDw0ICDqLvBCLuTobDAlfDgAZAEt6emZvKkNkaSQ7WqCA39Du9toDDT26f38r");
        private static int[] order = new int[] { 30,31,22,20,35,8,22,14,41,33,51,20,29,38,46,34,39,23,29,42,36,24,41,43,47,48,34,45,30,45,54,48,58,54,57,52,41,38,49,50,56,55,46,50,59,58,52,56,53,57,52,58,55,56,55,59,58,58,58,59,60 };
        private static int key = 10;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
