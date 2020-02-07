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
    }
}
