using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository: ITransferRepository
    {
        private readonly TransferDbContext _ctx;

        public TransferRepository(TransferDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<TrasferLog> GetTransferLogs()
        {
            return _ctx.TransferLogs;
        }

        public void Add(TrasferLog transferLog)
        {
            _ctx.TransferLogs.Add(transferLog);
            _ctx.SaveChanges();
        }
    }
}
