public class SubjectEntityConfiguration : IEntityTypeConfiguration<SubjectEntity>
{
    public void Configure(EntityTypeBuilder<SubjectEntity> entity)
    {
        entity.HasKey(e => e.Id).HasName("subject_pkey");

        entity.Property(e => e.Status)
            .HasMaxLength(45)
            .HasColumnName("status")
            .HasConversion(new EnumMemberValueConverter<SubjectStatuses>());
    }
}