﻿using System;

namespace Warp.Core.Services.Dtos.Client
{
    public class GetClientDto
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public short ClientStatusId { get; set; }
        public string Code { get; set; }
        public int CustomerId { get; set; }
        public DateTime? DateValidFrom { get; set; }
    }
}