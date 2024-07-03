using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MS.PROM.BACKEND.MidasDTO
{
    public partial class MidasDataContext : DbContext
    {
        //public MidasDataContext()
        //{
        //}
        public MidasDataContext(DbContextOptions<MidasDataContext> options)
    : base(options)
        {
        }
       

        public virtual DbSet<AbpAuditLog> AbpAuditLogs { get; set; } = null!;
        public virtual DbSet<AbpBackgroundJob> AbpBackgroundJobs { get; set; } = null!;
        public virtual DbSet<AbpDynamicParameter> AbpDynamicParameters { get; set; } = null!;
        public virtual DbSet<AbpDynamicParameterValue> AbpDynamicParameterValues { get; set; } = null!;
        public virtual DbSet<AbpEdition> AbpEditions { get; set; } = null!;
        public virtual DbSet<AbpEntityChange> AbpEntityChanges { get; set; } = null!;
        public virtual DbSet<AbpEntityChangeSet> AbpEntityChangeSets { get; set; } = null!;
        public virtual DbSet<AbpEntityDynamicParameter> AbpEntityDynamicParameters { get; set; } = null!;
        public virtual DbSet<AbpEntityDynamicParameterValue> AbpEntityDynamicParameterValues { get; set; } = null!;
        public virtual DbSet<AbpEntityPropertyChange> AbpEntityPropertyChanges { get; set; } = null!;
        public virtual DbSet<AbpFeature> AbpFeatures { get; set; } = null!;
        public virtual DbSet<AbpLanguage> AbpLanguages { get; set; } = null!;
        public virtual DbSet<AbpLanguageText> AbpLanguageTexts { get; set; } = null!;
        public virtual DbSet<AbpNotification> AbpNotifications { get; set; } = null!;
        public virtual DbSet<AbpNotificationSubscription> AbpNotificationSubscriptions { get; set; } = null!;
        public virtual DbSet<AbpOrganizationUnit> AbpOrganizationUnits { get; set; } = null!;
        public virtual DbSet<AbpOrganizationUnitRole> AbpOrganizationUnitRoles { get; set; } = null!;
        public virtual DbSet<AbpPermission> AbpPermissions { get; set; } = null!;
        public virtual DbSet<AbpRole> AbpRoles { get; set; } = null!;
        public virtual DbSet<AbpRoleClaim> AbpRoleClaims { get; set; } = null!;
        public virtual DbSet<AbpSetting> AbpSettings { get; set; } = null!;
        public virtual DbSet<AbpTenant> AbpTenants { get; set; } = null!;
        public virtual DbSet<AbpTenantNotification> AbpTenantNotifications { get; set; } = null!;
        public virtual DbSet<AbpUser> AbpUsers { get; set; } = null!;
        public virtual DbSet<AbpUserAccount> AbpUserAccounts { get; set; } = null!;
        public virtual DbSet<AbpUserClaim> AbpUserClaims { get; set; } = null!;
        public virtual DbSet<AbpUserLogin> AbpUserLogins { get; set; } = null!;
        public virtual DbSet<AbpUserLoginAttempt> AbpUserLoginAttempts { get; set; } = null!;
        public virtual DbSet<AbpUserNotification> AbpUserNotifications { get; set; } = null!;
        public virtual DbSet<AbpUserOrganizationUnit> AbpUserOrganizationUnits { get; set; } = null!;
        public virtual DbSet<AbpUserRole> AbpUserRoles { get; set; } = null!;
        public virtual DbSet<AbpUserToken> AbpUserTokens { get; set; } = null!;
        public virtual DbSet<AbpWebhookEvent> AbpWebhookEvents { get; set; } = null!;
        public virtual DbSet<AbpWebhookSendAttempt> AbpWebhookSendAttempts { get; set; } = null!;
        public virtual DbSet<AbpWebhookSubscription> AbpWebhookSubscriptions { get; set; } = null!;
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; } = null!;
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; } = null!;
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } = null!;
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Designation> Designations { get; set; } = null!;
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<RoleUser> RoleUsers { get; set; } = null!;
       
        public virtual DbSet<TbPfcAllocation> TbPfcAllocations { get; set; } = null!;
        public virtual DbSet<TbPfcAllocationSection> TbPfcAllocationSections { get; set; } = null!;
        public virtual DbSet<TbPfcAllocationSectionV2> TbPfcAllocationSectionV2s { get; set; } = null!;
        public virtual DbSet<TbPfcAllocationSectionV3> TbPfcAllocationSectionV3s { get; set; } = null!;
        public virtual DbSet<TbPfcMachine> TbPfcMachines { get; set; } = null!;
        public virtual DbSet<TbPfcMachineType> TbPfcMachineTypes { get; set; } = null!;
        public virtual DbSet<TbPfcMainSection> TbPfcMainSections { get; set; } = null!;
        public virtual DbSet<TbPfcMaterialCode> TbPfcMaterialCodes { get; set; } = null!;
        public virtual DbSet<TbPfcParameter> TbPfcParameters { get; set; } = null!;
        public virtual DbSet<TbPfcParameterNorm> TbPfcParameterNorms { get; set; } = null!;
        public virtual DbSet<TbPfcParameterQualifiedValue> TbPfcParameterQualifiedValues { get; set; } = null!;
        public virtual DbSet<TbPfcPlantDepartment> TbPfcPlantDepartments { get; set; } = null!;
        public virtual DbSet<TbPfcPlantDeptApbUser> TbPfcPlantDeptApbUsers { get; set; } = null!;
        public virtual DbSet<TbPfcSectionTemplate> TbPfcSectionTemplates { get; set; } = null!;
        public virtual DbSet<TbPfcShift> TbPfcShifts { get; set; } = null!;
        public virtual DbSet<TbPfcSubSection> TbPfcSubSections { get; set; } = null!;
        public virtual DbSet<TbPfcTolerance> TbPfcTolerances { get; set; } = null!;
        public virtual DbSet<TbPfcToleranceValueDropDown> TbPfcToleranceValueDropDowns { get; set; } = null!;
        public virtual DbSet<TbPfcToleranceValueNumeric> TbPfcToleranceValueNumerics { get; set; } = null!;
        public virtual DbSet<TbPfcUser> TbPfcUsers { get; set; } = null!;
        public virtual DbSet<TbPfcUserMainSection> TbPfcUserMainSections { get; set; } = null!;
        
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=midas-rds-dev.c4uiuoljkhl1.ap-southeast-1.rds.amazonaws.com;Initial Catalog=MidasData;User ID=sa;Password=Init@12345;Enlist=False;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AbpAuditLog>(entity =>
            {
                entity.Property(e => e.BrowserInfo).HasMaxLength(512);

                entity.Property(e => e.ClientIpAddress).HasMaxLength(64);

                entity.Property(e => e.ClientName).HasMaxLength(128);

                entity.Property(e => e.CustomData).HasMaxLength(2000);

                entity.Property(e => e.Exception).HasMaxLength(2000);

                entity.Property(e => e.MethodName).HasMaxLength(256);

                entity.Property(e => e.Parameters).HasMaxLength(1024);

                entity.Property(e => e.ServiceName).HasMaxLength(256);
            });

            modelBuilder.Entity<AbpBackgroundJob>(entity =>
            {
                entity.Property(e => e.JobType).HasMaxLength(512);
            });

            modelBuilder.Entity<AbpDynamicParameter>(entity =>
            {
                entity.Property(e => e.ParameterName).HasMaxLength(450);
            });

            modelBuilder.Entity<AbpDynamicParameterValue>(entity =>
            {
                entity.HasOne(d => d.DynamicParameter)
                    .WithMany(p => p.AbpDynamicParameterValues)
                    .HasForeignKey(d => d.DynamicParameterId);
            });

            modelBuilder.Entity<AbpEdition>(entity =>
            {
                entity.Property(e => e.DisplayName).HasMaxLength(64);

                entity.Property(e => e.Name).HasMaxLength(32);
            });

            modelBuilder.Entity<AbpEntityChange>(entity =>
            {
                entity.Property(e => e.EntityId).HasMaxLength(48);

                entity.Property(e => e.EntityTypeFullName).HasMaxLength(192);

                entity.HasOne(d => d.EntityChangeSet)
                    .WithMany(p => p.AbpEntityChanges)
                    .HasForeignKey(d => d.EntityChangeSetId);
            });

            modelBuilder.Entity<AbpEntityChangeSet>(entity =>
            {
                entity.Property(e => e.BrowserInfo).HasMaxLength(512);

                entity.Property(e => e.ClientIpAddress).HasMaxLength(64);

                entity.Property(e => e.ClientName).HasMaxLength(128);

                entity.Property(e => e.Reason).HasMaxLength(256);
            });

            modelBuilder.Entity<AbpEntityDynamicParameter>(entity =>
            {
                entity.Property(e => e.EntityFullName).HasMaxLength(450);

                entity.HasOne(d => d.DynamicParameter)
                    .WithMany(p => p.AbpEntityDynamicParameters)
                    .HasForeignKey(d => d.DynamicParameterId);
            });

            modelBuilder.Entity<AbpEntityDynamicParameterValue>(entity =>
            {
                entity.HasOne(d => d.EntityDynamicParameter)
                    .WithMany(p => p.AbpEntityDynamicParameterValues)
                    .HasForeignKey(d => d.EntityDynamicParameterId);
            });

            modelBuilder.Entity<AbpEntityPropertyChange>(entity =>
            {
                entity.Property(e => e.NewValue).HasMaxLength(512);

                entity.Property(e => e.OriginalValue).HasMaxLength(512);

                entity.Property(e => e.PropertyName).HasMaxLength(96);

                entity.Property(e => e.PropertyTypeFullName).HasMaxLength(192);

                entity.HasOne(d => d.EntityChange)
                    .WithMany(p => p.AbpEntityPropertyChanges)
                    .HasForeignKey(d => d.EntityChangeId);
            });

            modelBuilder.Entity<AbpFeature>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(128);

                entity.Property(e => e.Value).HasMaxLength(2000);

                entity.HasOne(d => d.Edition)
                    .WithMany(p => p.AbpFeatures)
                    .HasForeignKey(d => d.EditionId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<AbpLanguage>(entity =>
            {
                entity.Property(e => e.DisplayName).HasMaxLength(64);

                entity.Property(e => e.Icon).HasMaxLength(128);

                entity.Property(e => e.IsDisabled)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Name).HasMaxLength(128);
            });

            modelBuilder.Entity<AbpLanguageText>(entity =>
            {
                entity.Property(e => e.Key).HasMaxLength(256);

                entity.Property(e => e.LanguageName).HasMaxLength(128);

                entity.Property(e => e.Source).HasMaxLength(128);
            });

            modelBuilder.Entity<AbpNotification>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DataTypeName).HasMaxLength(512);

                entity.Property(e => e.EntityId).HasMaxLength(96);

                entity.Property(e => e.EntityTypeAssemblyQualifiedName).HasMaxLength(512);

                entity.Property(e => e.EntityTypeName).HasMaxLength(250);

                entity.Property(e => e.NotificationName).HasMaxLength(96);
            });

            modelBuilder.Entity<AbpNotificationSubscription>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EntityId).HasMaxLength(96);

                entity.Property(e => e.EntityTypeAssemblyQualifiedName).HasMaxLength(512);

                entity.Property(e => e.EntityTypeName).HasMaxLength(250);

                entity.Property(e => e.NotificationName).HasMaxLength(96);
            });

            modelBuilder.Entity<AbpOrganizationUnit>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(95);

                entity.Property(e => e.DisplayName).HasMaxLength(128);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId);
            });

            modelBuilder.Entity<AbpPermission>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AbpPermissions)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpPermissions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<AbpRole>(entity =>
            {
                entity.Property(e => e.ConcurrencyStamp).HasMaxLength(128);

                entity.Property(e => e.DisplayName).HasMaxLength(64);

                entity.Property(e => e.Name).HasMaxLength(32);

                entity.Property(e => e.NormalizedName).HasMaxLength(32);

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.AbpRoleCreatorUsers)
                    .HasForeignKey(d => d.CreatorUserId);

                entity.HasOne(d => d.DeleterUser)
                    .WithMany(p => p.AbpRoleDeleterUsers)
                    .HasForeignKey(d => d.DeleterUserId);

                entity.HasOne(d => d.LastModifierUser)
                    .WithMany(p => p.AbpRoleLastModifierUsers)
                    .HasForeignKey(d => d.LastModifierUserId);
            });

            modelBuilder.Entity<AbpRoleClaim>(entity =>
            {
                entity.Property(e => e.ClaimType).HasMaxLength(256);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AbpRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AbpSetting>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(256);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpSettings)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpTenant>(entity =>
            {
                entity.Property(e => e.ConnectionString).HasMaxLength(1024);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.Property(e => e.TenancyName).HasMaxLength(64);

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.AbpTenantCreatorUsers)
                    .HasForeignKey(d => d.CreatorUserId);

                entity.HasOne(d => d.DeleterUser)
                    .WithMany(p => p.AbpTenantDeleterUsers)
                    .HasForeignKey(d => d.DeleterUserId);

                entity.HasOne(d => d.Edition)
                    .WithMany(p => p.AbpTenants)
                    .HasForeignKey(d => d.EditionId);

                entity.HasOne(d => d.LastModifierUser)
                    .WithMany(p => p.AbpTenantLastModifierUsers)
                    .HasForeignKey(d => d.LastModifierUserId);
            });

            modelBuilder.Entity<AbpTenantNotification>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DataTypeName).HasMaxLength(512);

                entity.Property(e => e.EntityId).HasMaxLength(96);

                entity.Property(e => e.EntityTypeAssemblyQualifiedName).HasMaxLength(512);

                entity.Property(e => e.EntityTypeName).HasMaxLength(250);

                entity.Property(e => e.NotificationName).HasMaxLength(96);
            });

            modelBuilder.Entity<AbpUser>(entity =>
            {
                entity.Property(e => e.AuthenticationSource).HasMaxLength(64);

                entity.Property(e => e.ConcurrencyStamp).HasMaxLength(128);

                entity.Property(e => e.EmailAddress).HasMaxLength(256);

                entity.Property(e => e.EmailConfirmationCode).HasMaxLength(328);

                entity.Property(e => e.Name).HasMaxLength(64);

                entity.Property(e => e.NormalizedEmailAddress).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.Password).HasMaxLength(128);

                entity.Property(e => e.PasswordResetCode).HasMaxLength(328);

                entity.Property(e => e.PhoneNumber).HasMaxLength(32);

                entity.Property(e => e.SecurityStamp).HasMaxLength(128);

                entity.Property(e => e.Surname).HasMaxLength(64);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.InverseCreatorUser)
                    .HasForeignKey(d => d.CreatorUserId);

                entity.HasOne(d => d.DeleterUser)
                    .WithMany(p => p.InverseDeleterUser)
                    .HasForeignKey(d => d.DeleterUserId);

                entity.HasOne(d => d.LastModifierUser)
                    .WithMany(p => p.InverseLastModifierUser)
                    .HasForeignKey(d => d.LastModifierUserId);
            });

            modelBuilder.Entity<AbpUserAccount>(entity =>
            {
                entity.Property(e => e.EmailAddress).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AbpUserClaim>(entity =>
            {
                entity.Property(e => e.ClaimType).HasMaxLength(256);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpUserLogin>(entity =>
            {
                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(256);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpUserLoginAttempt>(entity =>
            {
                entity.Property(e => e.BrowserInfo).HasMaxLength(512);

                entity.Property(e => e.ClientIpAddress).HasMaxLength(64);

                entity.Property(e => e.ClientName).HasMaxLength(128);

                entity.Property(e => e.TenancyName).HasMaxLength(64);

                entity.Property(e => e.UserNameOrEmailAddress).HasMaxLength(256);
            });

            modelBuilder.Entity<AbpUserNotification>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AbpUserOrganizationUnit>(entity =>
            {
                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");
            });

            modelBuilder.Entity<AbpUserRole>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpUserToken>(entity =>
            {
                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.Property(e => e.Value).HasMaxLength(512);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpWebhookEvent>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AbpWebhookSendAttempt>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.WebhookEvent)
                    .WithMany(p => p.AbpWebhookSendAttempts)
                    .HasForeignKey(d => d.WebhookEventId);
            });

            modelBuilder.Entity<AbpWebhookSubscription>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "AspNetUserRole",
                        l => l.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId").HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId"),
                        r => r.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId").HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId").HasName("PK_dbo.AspNetUserRoles");

                            j.ToTable("AspNetUserRoles");

                            j.IndexerProperty<string>("UserId").HasMaxLength(128);

                            j.IndexerProperty<string>("RoleId").HasMaxLength(128);
                        });
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.RnDepId);

                entity.ToTable("Department");

                entity.Property(e => e.RnDepId)
                    .ValueGeneratedNever()
                    .HasColumnName("RnDepID");

                entity.Property(e => e.DeptName).IsUnicode(false);
            });

            modelBuilder.Entity<Designation>(entity =>
            {
                entity.HasKey(e => e.DsgCode);

                entity.ToTable("Designation");

                entity.Property(e => e.DsgCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DsgName)
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.ProductVersion).HasMaxLength(32);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.RnRoleId);

                entity.ToTable("Role");

                entity.Property(e => e.RnRoleId)
                    .ValueGeneratedNever()
                    .HasColumnName("RnRoleID");

                entity.Property(e => e.LastUpdateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Role1)
                    .IsUnicode(false)
                    .HasColumnName("Role");

                entity.Property(e => e.WorkflowId).HasColumnName("WorkflowID");
            });

            modelBuilder.Entity<RoleUser>(entity =>
            {
                entity.HasKey(e => e.RnRoleUserId);

                entity.ToTable("RoleUser");

                entity.Property(e => e.RnRoleUserId)
                    .ValueGeneratedNever()
                    .HasColumnName("RnRoleUserID");

                entity.Property(e => e.LbcluserId).HasColumnName("LBCLUserID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

           

            modelBuilder.Entity<TbPfcAllocationSectionV3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TB_PFC_AllocationSectionV3");

                entity.Property(e => e.AllocationId).HasColumnName("allocationId");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createdTime");

                entity.Property(e => e.CreatorId)
                    .HasMaxLength(900)
                    .IsUnicode(false)
                    .HasColumnName("creatorId");

                entity.Property(e => e.HasDeleted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("hasDeleted")
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modifiedTime");

                entity.Property(e => e.ModifierId)
                    .HasMaxLength(900)
                    .IsUnicode(false)
                    .HasColumnName("modifierId");

                entity.Property(e => e.ParameterNormId)
                    .HasColumnName("parameterNormId")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.SectionTemplateId).HasColumnName("sectionTemplateId");

                entity.Property(e => e.SessionCreatedDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("sessionCreatedDateTime");

                entity.Property(e => e.SessionCreatorUserId)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("sessionCreatorUserId");

                entity.Property(e => e.SessionId)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("sessionId");

                entity.Property(e => e.ToleranceValue)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("toleranceValue");
            });

            modelBuilder.Entity<TbPfcMachine>(entity =>
            {
                entity.HasKey(e => new { e.MachineCode, e.PlantDepId })
                    .HasName("PK__TB_PFC.M__6F9FA8A1DC3B3B72");

                entity.ToTable("TB_PFC_Machine");

                entity.Property(e => e.MachineCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("machineCode");

                entity.Property(e => e.PlantDepId)
                    .HasColumnName("plantDepId")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createdTime");

                entity.Property(e => e.HasDeleted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("hasDeleted")
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.MachineType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("machineType");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modifiedTime");

                entity.Property(e => e.SapResource)
                    .HasMaxLength(900)
                    .IsUnicode(false)
                    .HasColumnName("sapResource");

                entity.HasOne(d => d.PlantDep)
                    .WithMany(p => p.TbPfcMachines)
                    .HasForeignKey(d => d.PlantDepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_PFC_Machine_plantDepId");
            });

            modelBuilder.Entity<TbPfcMachineType>(entity =>
            {
                entity.HasKey(e => new { e.MachineType, e.PlantDepId })
                    .HasName("PK__TB_PFC.M__E378CEB77B454C6F");

                entity.ToTable("TB_PFC_MachineType");

                entity.Property(e => e.MachineType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("machineType");

                entity.Property(e => e.PlantDepId)
                    .HasColumnName("plantDepId")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createdTime");

                entity.Property(e => e.HasDeleted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("hasDeleted")
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modifiedTime");

                entity.HasOne(d => d.PlantDep)
                    .WithMany(p => p.TbPfcMachineTypes)
                    .HasForeignKey(d => d.PlantDepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_PFC_MachineType_plantDepId");
            });

            modelBuilder.Entity<TbPfcMainSection>(entity =>
            {
                entity.HasKey(e => new { e.MainSection, e.PlantDepId })
                    .HasName("PK__TB_PFC.M__D8DE909A1E11BF39");

                entity.ToTable("TB_PFC_MainSection");

                entity.Property(e => e.MainSection)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("mainSection");

                entity.Property(e => e.PlantDepId)
                    .HasColumnName("plantDepId")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createdTime");

                entity.Property(e => e.HasDeleted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("hasDeleted")
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.MainSectionName)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("mainSectionName");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modifiedTime");

                entity.HasOne(d => d.PlantDep)
                    .WithMany(p => p.TbPfcMainSections)
                    .HasForeignKey(d => d.PlantDepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_PFC_MainSection_plantDepId");
            });

            modelBuilder.Entity<TbPfcMaterialCode>(entity =>
            {
                entity.HasKey(e => new { e.MaterialCode, e.PlantDepId });

                entity.ToTable("TB_PFC_MaterialCode");

                entity.Property(e => e.MaterialCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("materialCode");

                entity.Property(e => e.PlantDepId)
                    .HasColumnName("plantDepId")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createdTime");

                entity.Property(e => e.HasDeleted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("hasDeleted")
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modifiedTime");

                entity.HasOne(d => d.PlantDep)
                    .WithMany(p => p.TbPfcMaterialCodes)
                    .HasForeignKey(d => d.PlantDepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_PFC_MaterialCode_plantDepId");
            });

            modelBuilder.Entity<TbPfcParameter>(entity =>
            {
                entity.HasKey(e => new { e.Parameter, e.PlantDepId })
                    .HasName("PK__TB_PFC.P__F9C069AAE4FBFB27");

                entity.ToTable("TB_PFC_Parameter");

                entity.Property(e => e.Parameter)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("parameter");

                entity.Property(e => e.PlantDepId)
                    .HasColumnName("plantDepId")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createdTime");

                entity.Property(e => e.HasDeleted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("hasDeleted")
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modifiedTime");

                entity.HasOne(d => d.PlantDep)
                    .WithMany(p => p.TbPfcParameters)
                    .HasForeignKey(d => d.PlantDepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_PFC_Parameter_plantDepId");
            });

            modelBuilder.Entity<TbPfcParameterNorm>(entity =>
            {
                entity.ToTable("TB_PFC_Parameter_Norm");

                entity.HasIndex(e => new { e.Parameter, e.PlantDepId, e.NDateTime }, "UC_TB_PFC_Parameter_Norm")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createdTime");

                entity.Property(e => e.HasDeleted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("hasDeleted")
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.MaxValue).HasColumnName("maxValue");

                entity.Property(e => e.MinValue).HasColumnName("minValue");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modifiedTime");

                entity.Property(e => e.NDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("nDateTime");

                entity.Property(e => e.Parameter)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("parameter");

                entity.Property(e => e.PlantDepId).HasColumnName("plantDepId");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.TbPfcParameterNorms)
                    .HasForeignKey(d => new { d.Parameter, d.PlantDepId })
                    .HasConstraintName("FK_TB_PFC_Parameter_Norm");
            });

            modelBuilder.Entity<TbPfcParameterQualifiedValue>(entity =>
            {
                entity.ToTable("TB_PFC_ParameterQualifiedValue");

                entity.Property(e => e.MaterialCode).IsUnicode(false);

                entity.Property(e => e.Parameter).IsUnicode(false);

                entity.Property(e => e.PlantDepId).HasColumnName("plantDepId");

                entity.HasOne(d => d.PlantDep)
                    .WithMany(p => p.TbPfcParameterQualifiedValues)
                    .HasForeignKey(d => d.PlantDepId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PFC_ParameterQualifiedValue_TB_PFC_Plant_Department");
            });

            modelBuilder.Entity<TbPfcPlantDepartment>(entity =>
            {
                entity.ToTable("TB_PFC_Plant_Department");

                entity.HasIndex(e => new { e.PlantId, e.DepartmentId }, "UC_PLANT_DEPARTMENT_ID")
                    .IsUnique();

                entity.HasIndex(e => new { e.PlantName, e.DepartmentName }, "UC_plantName_departmentName")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentId");

                entity.Property(e => e.DepartmentName)
                    .IsUnicode(false)
                    .HasColumnName("departmentName");

                entity.Property(e => e.HasDeleted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("hasDeleted")
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.PlantId).HasColumnName("plantId");

                entity.Property(e => e.PlantName)
                    .IsUnicode(false)
                    .HasColumnName("plantName");
            });

            modelBuilder.Entity<TbPfcPlantDeptApbUser>(entity =>
            {
                entity.ToTable("TB_PFC_PlantDeptApbUser");
            });

            modelBuilder.Entity<TbPfcSectionTemplate>(entity =>
            {
                entity.ToTable("TB_PFC_SectionTemplate");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createdTime");

                entity.Property(e => e.CreatorId)
                    .HasMaxLength(900)
                    .IsUnicode(false)
                    .HasColumnName("creatorId");

                entity.Property(e => e.Equation)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("equation")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HasDeleted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("hasDeleted")
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.IsDynamic)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("isDynamic")
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.MachineType)
                    .HasMaxLength(900)
                    .IsUnicode(false)
                    .HasColumnName("machineType");

                entity.Property(e => e.MainSection)
                    .HasMaxLength(900)
                    .IsUnicode(false)
                    .HasColumnName("mainSection");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modifiedTime");

                entity.Property(e => e.ModifierId)
                    .HasMaxLength(900)
                    .IsUnicode(false)
                    .HasColumnName("modifierId");

                entity.Property(e => e.Parameter)
                    .HasMaxLength(900)
                    .IsUnicode(false)
                    .HasColumnName("parameter");

                entity.Property(e => e.ParameterShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("parameterShortName");

                entity.Property(e => e.PlantDepId).HasColumnName("plantDepId");

                entity.Property(e => e.SortNumber)
                    .HasColumnName("sortNumber")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SubSection)
                    .HasMaxLength(900)
                    .IsUnicode(false)
                    .HasColumnName("subSection");

                entity.Property(e => e.Threshold).HasColumnName("threshold");

                entity.Property(e => e.ToleranceId).HasColumnName("toleranceId");

                entity.HasOne(d => d.PlantDep)
                    .WithMany(p => p.TbPfcSectionTemplates)
                    .HasForeignKey(d => d.PlantDepId)
                    .HasConstraintName("FK_TB_PFC_SectionTemplate_plantDepId");
            });

            modelBuilder.Entity<TbPfcShift>(entity =>
            {
                entity.HasKey(e => new { e.Shift, e.PlantDepId });

                entity.ToTable("TB_PFC_Shift");

                entity.Property(e => e.Shift)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("shift");

                entity.Property(e => e.PlantDepId).HasColumnName("plantDepId");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createdTime");

                entity.Property(e => e.HasDeleted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("hasDeleted")
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modifiedTime");

                entity.HasOne(d => d.PlantDep)
                    .WithMany(p => p.TbPfcShifts)
                    .HasForeignKey(d => d.PlantDepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_PFC_Shift_plantDepId");
            });

            modelBuilder.Entity<TbPfcSubSection>(entity =>
            {
                entity.HasKey(e => new { e.SubSection, e.PlantDepId })
                    .HasName("PK__TB_PFC.S__64DF40B75A2F18F6");

                entity.ToTable("TB_PFC_SubSection");

                entity.Property(e => e.SubSection)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("subSection");

                entity.Property(e => e.PlantDepId)
                    .HasColumnName("plantDepId")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createdTime");

                entity.Property(e => e.HasDeleted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("hasDeleted")
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modifiedTime");

                entity.HasOne(d => d.PlantDep)
                    .WithMany(p => p.TbPfcSubSections)
                    .HasForeignKey(d => d.PlantDepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_PFC_SubSection_plantDepId");
            });

            modelBuilder.Entity<TbPfcTolerance>(entity =>
            {
                entity.ToTable("TB_PFC_Tolerance");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createdTime");

                entity.Property(e => e.CreatorId)
                    .HasMaxLength(900)
                    .IsUnicode(false)
                    .HasColumnName("creatorId");

                entity.Property(e => e.HasDeleted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("hasDeleted")
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modifiedTime");

                entity.Property(e => e.ModifierId)
                    .HasMaxLength(900)
                    .IsUnicode(false)
                    .HasColumnName("modifierId");

                entity.Property(e => e.Name)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PlantDepId)
                    .HasColumnName("plantDepId")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Type)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.HasOne(d => d.PlantDep)
                    .WithMany(p => p.TbPfcTolerances)
                    .HasForeignKey(d => d.PlantDepId)
                    .HasConstraintName("FK_TB_PFC_Tolerance_plantDepId");
            });

            modelBuilder.Entity<TbPfcToleranceValueDropDown>(entity =>
            {
                entity.ToTable("TB_PFC_ToleranceValueDropDown");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createdTime");

                entity.Property(e => e.CreatorId)
                    .HasMaxLength(900)
                    .IsUnicode(false)
                    .HasColumnName("creatorId");

                entity.Property(e => e.HasDeleted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("hasDeleted")
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modifiedTime");

                entity.Property(e => e.ModifierId)
                    .HasMaxLength(900)
                    .IsUnicode(false)
                    .HasColumnName("modifierId");

                entity.Property(e => e.ToleranceId).HasColumnName("toleranceId");

                entity.Property(e => e.Value)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("value");

                entity.HasOne(d => d.Tolerance)
                    .WithMany(p => p.TbPfcToleranceValueDropDowns)
                    .HasForeignKey(d => d.ToleranceId)
                    .HasConstraintName("FK_ToleranceId");
            });

            modelBuilder.Entity<TbPfcToleranceValueNumeric>(entity =>
            {
                entity.HasKey(e => e.ToleranceId)
                    .HasName("PK_ToleranceValueNumeric");

                entity.ToTable("TB_PFC_ToleranceValueNumeric");

                entity.Property(e => e.ToleranceId)
                    .ValueGeneratedNever()
                    .HasColumnName("toleranceId");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createdTime");

                entity.Property(e => e.CreatorId)
                    .HasMaxLength(900)
                    .IsUnicode(false)
                    .HasColumnName("creatorId");

                entity.Property(e => e.DecimalPoints)
                    .HasColumnName("decimalPoints")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HasDeleted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("hasDeleted")
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modifiedTime");

                entity.Property(e => e.ModifierId)
                    .HasMaxLength(900)
                    .IsUnicode(false)
                    .HasColumnName("modifierId");

                entity.Property(e => e.ToleranceMax)
                    .HasColumnName("toleranceMax")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ToleranceMin)
                    .HasColumnName("toleranceMin")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Tolerance)
                    .WithOne(p => p.TbPfcToleranceValueNumeric)
                    .HasForeignKey<TbPfcToleranceValueNumeric>(d => d.ToleranceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ToleranceValueNumericId");
            });

            modelBuilder.Entity<TbPfcUser>(entity =>
            {
                entity.ToTable("TB_PFC_User");

                entity.HasIndex(e => new { e.PlantDepId, e.UserName }, "UC_USERNAME_PLANTDEPID")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createdTime");

                entity.Property(e => e.IsActive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("('1')")
                    .IsFixedLength();

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modifiedTime");

                entity.Property(e => e.Password)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.PlantDepId)
                    .HasColumnName("plantDepId")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Role)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("role");

                entity.Property(e => e.UserName)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("userName");

                entity.HasOne(d => d.PlantDep)
                    .WithMany(p => p.TbPfcUsers)
                    .HasForeignKey(d => d.PlantDepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PFC_User_plantDepId");
            });

            modelBuilder.Entity<TbPfcUserMainSection>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.MainSection, e.PlantDepId });

                entity.ToTable("TB_PFC_User_MainSection");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.MainSection)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("mainSection");

                entity.Property(e => e.PlantDepId).HasColumnName("plantDepId");

                entity.HasOne(d => d.TbPfcMainSection)
                    .WithMany(p => p.TbPfcUserMainSections)
                    .HasForeignKey(d => new { d.MainSection, d.PlantDepId })
                    .HasConstraintName("FK_TB_PFC_User_MainSection");
            });

          

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
