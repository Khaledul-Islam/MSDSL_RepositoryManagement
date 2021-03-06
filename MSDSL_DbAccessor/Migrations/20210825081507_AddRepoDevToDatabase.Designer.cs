// <auto-generated />
using MSDSL_DbAccessor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MSDSL_DbAccessor.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210825081507_AddRepoDevToDatabase")]
    partial class AddRepoDevToDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MSDSL_RepoModel.Entities.Client", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Client_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("MSDSL_RepoModel.Entities.Developer", b =>
                {
                    b.Property<int>("DeveloperID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeveloperName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeveloperID");

                    b.ToTable("Developers");
                });

            modelBuilder.Entity("MSDSL_RepoModel.Entities.RepoClient", b =>
                {
                    b.Property<int>("RepoClientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<string>("Dates")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("RepoID")
                        .HasColumnType("int");

                    b.HasKey("RepoClientID");

                    b.HasIndex("ClientID");

                    b.HasIndex("RepoID");

                    b.ToTable("RepoClients");
                });

            modelBuilder.Entity("MSDSL_RepoModel.Entities.RepoDev", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AssignDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssignFrom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DevID")
                        .HasColumnType("int");

                    b.Property<bool>("IsFirstAssign")
                        .HasColumnType("bit");

                    b.Property<int>("RepoID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("DevID");

                    b.HasIndex("RepoID");

                    b.ToTable("RepoDevs");
                });

            modelBuilder.Entity("MSDSL_RepoModel.Entities.RepositoryList", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RepoType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RepositoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ToolsTech")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("RepositoryLists");
                });

            modelBuilder.Entity("MSDSL_RepoModel.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MSDSL_RepoModel.Entities.RepoClient", b =>
                {
                    b.HasOne("MSDSL_RepoModel.Entities.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MSDSL_RepoModel.Entities.RepositoryList", "RepositoryList")
                        .WithMany()
                        .HasForeignKey("RepoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("RepositoryList");
                });

            modelBuilder.Entity("MSDSL_RepoModel.Entities.RepoDev", b =>
                {
                    b.HasOne("MSDSL_RepoModel.Entities.Developer", "Developer")
                        .WithMany()
                        .HasForeignKey("DevID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MSDSL_RepoModel.Entities.RepositoryList", "RepositoryList")
                        .WithMany()
                        .HasForeignKey("RepoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Developer");

                    b.Navigation("RepositoryList");
                });
#pragma warning restore 612, 618
        }
    }
}
