﻿using IntelliTect.Coalesce.AuditLogging;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace SzyCo.F1VE.Data.Coalesce;

public class AuditOperationContext : DefaultAuditOperationContext<AuditLog>
{
    public AuditOperationContext(IHttpContextAccessor accessor) : base(accessor) { }

    public override void Populate(AuditLog auditEntry, EntityEntry changedEntity)
    {
        base.Populate(auditEntry, changedEntity);

        auditEntry.UserId = User?.GetUserId() ?? "sysadmin";

    }
}