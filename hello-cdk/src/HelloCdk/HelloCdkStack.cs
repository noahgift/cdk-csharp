using Amazon.CDK;
using Amazon.CDK.AWS.S3;

namespace HelloCdk
{
    public class HelloCdkStack : Stack
    {
        public HelloCdkStack(Construct scope, string id, IStackProps props=null) : base(scope, id, props)
        {
            new Bucket(this, "MyFirstBucket08022022", new BucketProps
            {
                Versioned = true
            });
        }
    }
}