using Amazon.CDK;
using Amazon.CDK.AWS.S3;
namespace CdkWorkshop
{
    public class CdkWorkshopStack : Stack
    {
        internal CdkWorkshopStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            //****************Code************* 
            new Bucket(this, Helper.RandomString(15));
            //****************End Code************* 
        }
    }
}
