namespace SigmaSoftwareTest.Common.Helpers
{
    public class AssertionConcern
    {
        private const string EmailRegex = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
        private const string PhoneRegex = @"^01(0|1|2|4|5|7|9)[0-9]{8}$";
        public static void AssertArgumentMessage(string message)
        {

            throw new Exception(message);
        }
        public static void AssertArgumentNotNull(object object1, string message)
        {
            if (object1 == null)
            {
                throw new Exception(message);
            }
        }
    }
}
