// <auto-generated />
using Innovators.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Innovators.Migrations.QuizModelDb
{
    [DbContext(typeof(QuizModelDbContext))]
    [Migration("20221022040627_QuestionsAndAnswers")]
    partial class QuestionsAndAnswers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Innovators.Models.QuizModel", b =>
                {
                    b.Property<int>("QuizId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("A1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Excecise")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("Memo1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Memo2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Memo3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Memo4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Memo5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("QuizId");

                    b.ToTable("QuizModel");
                });
#pragma warning restore 612, 618
        }
    }
}
