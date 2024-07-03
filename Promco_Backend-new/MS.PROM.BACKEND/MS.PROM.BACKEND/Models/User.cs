namespace MS.PROM.BACKEND.Models
{
    public class User
    {
        public long Id { get; set; }
        public int AccessFailedCount { get; set; }
        public string? AuthenticationSource { get; set; }
        public string? ConcurrencyStamp { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public string EmailAddress { get; set; } = null!;
        public string? EmailConfirmationCode { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public bool IsLockoutEnabled { get; set; }
        public bool IsPhoneNumberConfirmed { get; set; }
        public bool IsTwoFactorEnabled { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }
        public string Name { get; set; } = null!;
        public string NormalizedEmailAddress { get; set; } = null!;
        public string NormalizedUserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? PasswordResetCode { get; set; }
        public string? PhoneNumber { get; set; }
        public string? SecurityStamp { get; set; }
        public string Surname { get; set; } = null!;
        public int? TenantId { get; set; }
        public string UserName { get; set; } = null!;
    }
}
