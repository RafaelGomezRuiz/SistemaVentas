﻿namespace SistemaVentas.Core.Domain.Common
{
    public class AuditableBaseEntity
    {
        public virtual int Id {get;set;}
        public string? CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string? LastModifyBy { get; set; }
        public DateTime? LastModified { get; set; }
    }
}