using Amazon.CDK;
namespace CdkWorkshop
{
  public static class Helper
    {
        public static  Environment makeEnv(string account=null, string region=null)
        {
            return new Environment
            {
                Account = account ?? System.Environment.GetEnvironmentVariable("CDK_DEFAULT_ACCOUNT"),
                Region = region ?? System.Environment.GetEnvironmentVariable("CDK_DEFAULT_REGION")
            };
        }

        public static string RandomString(int size)
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            System.Random random = new System.Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = System.Convert.ToChar(System.Convert.ToInt32(System.Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            return builder.ToString();
        }
    }
}
