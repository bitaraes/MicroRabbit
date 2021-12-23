using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using MicroRabbit.Banking.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Data.Context;

namespace MicroRabbit.Infra.Ioc
{
    public class DependecyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            //services.AddTransient<IEventBus, RabbitMQBus>();
            //Application services
            services.AddTransient<IAccountService, AccountService>();
            //data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDBContext>();
        }
    }
}
