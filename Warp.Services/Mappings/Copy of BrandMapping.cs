using System;
using Warp.Core.Infrastructure;
using Warp.Core.Services.Dtos;
using Warp.Core.Services.Dtos.Brand;
using Warp.Core.Services.Dtos.Client;
using Warp.Core.Util;
using Warp.Data.Models;

namespace Warp.Services.Mappings
{
    //public sealed class SaveClientDtoMapping : IMappingConfiguration<SaveClientDto, Client>
    //{
    //    public Client Map(SaveClientDto source)
    //    {
    //        Check.NotNull(source, "source");

    //        Client = new Model.Entities.Client();
    //        Client.AccountMangerAdminId = Request.AccountManager;
    //        Client.ClientId = Request.ID;
    //        Client.ClientStatusId = Request.Status;
    //        Client.Code = Request.Code;
    //        //Client.LegacyID = Request.LegacyID;
    //        Client.Name = Request.Name;
    //        Client.CustomerId = Request.CustomerID;
    //        Client.Addresses = Request.ContactAddresses.Select(x => new ContactAddressAssigned()
    //        {
    //            AssignedByAdminId = x.AssignedByAdminId,
    //            ContactAddressId = x.ContactAddressId,
    //            ContactAddressTypeId = x.ContactAddressTypeId,
    //            DateValidFrom = x.DateValidFrom,
    //            DateValidTo = x.DateValidTo
    //        }).ToList();

    //        return new BrandSummaryDto
    //        {
    //            AccountManagerAdminId = 0,
    //            AccountManagerAdminName = "",
    //            AssessorBanDays = 69,
    //            BrandId = source.BrandID,
    //            BrandName = source.Name,
    //            BrandStatusName = "",
    //            IndustrySectorName = "",
    //            ManagerId = 0,
    //            ManagerName = "",
    //            NoOfBranches = 0
    //        };
    //    }
    //}
}