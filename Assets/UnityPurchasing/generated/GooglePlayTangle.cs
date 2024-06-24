// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("mCqpipilrqGCLuAuX6WpqamtqKvd43YQQDkKQ9CoRmgqSzEX6wBcSkeUsmhkFujDR4CLK5KkKv9syRZKTebiAQ6AubMxw/86l/h2DAvzHeGWzzK+uzj3Sblvhpon8nkuii4rKqRRkEMnn5GK6pL5NLMEQRLxzndU9ShMxNu8+3vh97NAgx+s2ToIvbZG9w3ZbqKxScV06ovUWZ/JQ+cXQu61ElKZZ//mCnBWQzyd6vWfJo21w6MqLSq47FpQ53ZTfzXSA5eXAKMqqaeomCqpoqoqqamoPq2NdGBq77uZqSBxdg7SSh/ulrU/RybWAE6B4MEPvXoMzaFRpIsUcXxli2X1yeF3weSst0pvAzJ/Ibo1P2NW5ggHkKGrW/IxRHWwDaqrqaip");
        private static int[] order = new int[] { 0,7,6,4,12,10,11,12,8,10,12,11,12,13,14 };
        private static int key = 168;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
