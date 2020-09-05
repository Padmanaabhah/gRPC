using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace CalculatorService
{
    public class GreeterService : Calculator.CalculatorBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<Result> Add(InputData request, ServerCallContext context)
        {
            int result = request.FirstNumber + request.SecondNumber;
            return Task.FromResult(new Result
            {
                Resultmessage = "The added result is " + result
            });
        } 
    }
}
