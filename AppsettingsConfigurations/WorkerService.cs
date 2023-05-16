using AppsettingsConfigurations.ConfigModel;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsettingsConfigurations
{
    public class WorkerService : IWorkerService
    {
        private readonly PositionOptions position;

        public WorkerService(IOptions<PositionOptions> position)
        {
            this.position = position.Value;
        }

        public async Task StartProcess()
        {
            _ = Console.ReadLine();
        }
    }
}
