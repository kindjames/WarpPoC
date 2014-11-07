using System.Data.Entity;
using Warp.Core.Command;
using Warp.Core.Exceptions;
using Warp.Core.Query;
using Warp.Core.Util;
using Warp.Data.Models;
using Warp.Data.Queries.Clients;

namespace Warp.Data.Commands.Clients
{
    public sealed class SaveClientCommand : ICommand
    {
        public Client Client { get; set; }
    }

    public sealed class SaveClientCommandHandler : ICommandHandler<SaveClientCommand>
    {
        private readonly IHospitalityGemDbContext _dbContext;
        private readonly IQueryDispatcher _queryDispatcher;

        public SaveClientCommandHandler(IHospitalityGemDbContext dbContext, IQueryDispatcher queryDispatcher)
        {
            _dbContext = dbContext;
            _queryDispatcher = queryDispatcher;
        }

        public void Execute(SaveClientCommand command)
        {
            Check.NotNull(command, "command");
            Check.NotNull(command.Client, "command.Client");

            var client = command.Client;

            //if (client.ClientID == 0)
            //{
            //    var query = new CheckClientExistsForCodeQuery {CustomerId = client.CustomerID, ClientCode = client.Code};

            //    if (_queryDispatcher.Execute(query))
            //    {
            //        throw new ClientAlreadyExistsException(query.CustomerId, query.ClientCode);
            //    }

            //    client.ClientHistories.Add(new ClientHistory
            //    {
            //        ClientStatusID = client.ClientStatusID;
            //        History.ClientName = client.Name;
            //        if (Request.Code == null)
            //        {
            //            var code = Convert.ToString(Response.ClientID);
            //            History.Code = code;
            //            Response.ClientCode = code;
            //        }
            //        else
            //        {
            //            History.Code = client.Code;
            //            Response.ClientCode = client.Code;
            //        }
            //        History.DateValidTo = (DateTime?)null;
            //        History.DateValidFrom = NewDateValidFrom;
            //        History.EnteredByAdminID = Request.userId;
            //        History.Notes = "Record Created";
            //        History.Active = true;
            //    });

            //    _dbContext.Clients.Add(client);
            //}
            //else
            //{
            //    _dbContext.Clients.Attach(client);
            //    _dbContext.Entry(client).State = EntityState.Modified;
            //}
        }
    }
}