using Amazon.CDK;

namespace CdkWorkshop
{
    sealed class Program
    {
        public static void Main(string[] args)
        {

            var envAny = Helper.makeEnv(account: "", region: "");

            var app = new App();
            new CdkWorkshopStack(app, "Stack"+ System.Guid.NewGuid().ToString("n"), new StackProps { Env = envAny });
            app.Synth();
        }
    }
}
