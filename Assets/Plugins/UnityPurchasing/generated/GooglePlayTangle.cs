#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("5f0EHB1RSH4hsQGrI5F9abz9uG30AvjoaNToEQt4UqHkrhQoWJVnvaFJSQQlYY3thbUB4xq1JrBDWyS5ZpYwFRB7WrZq/v8TwfKfFEABKr+mG+jQtkDLUbloCnv8+tYie6KzC3fFRmV3SkFObcEPwbBKRkZGQkdEqXgZdUxOB1TKdmSUlZtoWo1GvUdd3EEewba9mgnrQ2kpdx6UWk4dvWOHrELkP1nzQQbLRlq6TyEx90gf4paTxpvUxX9PIPPkV9KWKkfUloxUE7Oz/CwMb/rIwllf/ue6L8/ORq2KMVM7JxD4Q5OVbaFWCggKXY7DM8/UVoTX4AjBQaQ1igopOEYExf3FRkhHd8VGTUXFRkZH3tmCZ+aJSEvsP3k3i2eU0kVERkdG");
        private static int[] order = new int[] { 6,12,9,4,9,6,8,9,8,9,10,11,13,13,14 };
        private static int key = 71;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
