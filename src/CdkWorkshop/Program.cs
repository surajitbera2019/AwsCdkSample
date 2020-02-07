using Amazon.CDK;
namespace CdkWorkshop
{
    sealed class Program
    {
        public static void Main(string[] args)
        {

            var envAny = Helper.makeEnv(account: "", region: "");

            var app = new App();
            new CdkWorkshopStack(app, "Stack-S3", new StackProps { Env = envAny });
            app.Synth();
        }
    }
}
