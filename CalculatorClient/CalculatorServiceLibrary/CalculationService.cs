using CalculatorService;
using Grpc.Core;
using Grpc.Net.Client;
using System;

namespace CalculatorServiceLibrary
{
    public class CalculationService : CalculatorService.Calculator.CalculatorClient
    {
        public CalculationService() : base(GrpcChannel.ForAddress(" https://localhost:5001", 
            new GrpcChannelOptions { HttpHandler = HttpClientHandlerHelper.GetHandler() }))
        {

        }

        public string PerformAdd(int number1, int number2)
        {
            var result = Add(new InputData { FirstNumber = number1, SecondNumber = number2 });
            return result.Resultmessage;
        }

        public override Result Add(InputData request, CallOptions options)
        {
            return base.Add(request, options);
        }
    }
}
