using Amazon.CDK;
using Amazon.CDK.AWS.S3;

namespace HelloCdk
{
    public class HelloCdkStack : Stack
    {
        public HelloCdkStack(App scope, string id, IStackProps props=null) : base(scope, id, props)
        {
            new Bucket(this, "random-rabbit-aug9", new BucketProps
            {
                Versioned = true
            });
        }
    }
}