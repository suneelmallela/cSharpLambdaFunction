using System;

using Amazon.Lambda.Core;

[assembly: LambdaSerializerAttribute(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! ABC");
        }

        public string FunctionHandler(string input, ILambdaContext context)
        {
            return input?.ToUpper();
        }
    }
}
