using IntelliTect.Coalesce.AuditLogging;

namespace SzyCo.F1VE.Data.Models;

[Edit(DenyAll)]
[Delete(DenyAll)]
[Create(DenyAll)]
public class AuditLog : DefaultAuditLog
{
    public string UserId = "1";
}