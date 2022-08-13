# cdk-csharp
This is a CDK hello world in C# for AWS


## Episode 6

* [Reference Hugo Static Site Deploy](https://constructs.dev/packages/cdk-hugo-deploy/v/0.0.86?lang=dotnet)


## How To

* [Read Intro Docs](https://docs.aws.amazon.com/cdk/v1/guide/home.html)
* [Read Tutorial Docs](https://docs.aws.amazon.com/cdk/v1/guide/hello_world.html)

`mkdir -p hello-cdk && cd hello-cdk`
`cdk init app --language csharp`
`dotnet build src`

Now list the stack:

`cdk ls`

Add code for AWS S3 in `src/HelloCdk`:

`dotnet add package Amazon.CDK.AWS.S3`

Synth things:

`cdk synth`

## References

* This looks pretty cool, learn more [.NET Core CLI](https://docs.microsoft.com/dotnet/articles/core/) 
