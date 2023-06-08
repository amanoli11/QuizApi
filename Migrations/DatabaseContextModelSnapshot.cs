﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using QuizApi.Data.DatabaseContext;

#nullable disable

namespace QuizApi.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("QuizApi.Data.Models.AnswerOptions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("QuestionId")
                        .HasColumnType("integer");

                    b.Property<string>("optionA")
                        .HasColumnType("text");

                    b.Property<string>("optionB")
                        .HasColumnType("text");

                    b.Property<string>("optionC")
                        .HasColumnType("text");

                    b.Property<string>("optionD")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("AnswerOptions");
                });

            modelBuilder.Entity("QuizApi.Data.Models.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("QuizApi.Data.Models.ExamAnswers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ExamId")
                        .HasColumnType("integer");

                    b.Property<int>("QuestionId")
                        .HasColumnType("integer");

                    b.Property<int>("answerChosen")
                        .HasColumnType("integer");

                    b.Property<bool>("isAnswerCorrect")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.HasIndex("QuestionId");

                    b.ToTable("ExamAnswers");
                });

            modelBuilder.Entity("QuizApi.Data.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("answerType")
                        .HasColumnType("integer");

                    b.Property<int>("correctAnswer")
                        .HasColumnType("integer");

                    b.Property<decimal>("marks")
                        .HasColumnType("numeric");

                    b.Property<string>("question")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("QuizApi.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("firstName")
                        .HasColumnType("text");

                    b.Property<string>("lastName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("QuizApi.Data.Models.AnswerOptions", b =>
                {
                    b.HasOne("QuizApi.Data.Models.Question", null)
                        .WithMany("options")
                        .HasForeignKey("QuestionId");
                });

            modelBuilder.Entity("QuizApi.Data.Models.ExamAnswers", b =>
                {
                    b.HasOne("QuizApi.Data.Models.Exam", null)
                        .WithMany("examAnswers")
                        .HasForeignKey("ExamId");

                    b.HasOne("QuizApi.Data.Models.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("QuizApi.Data.Models.Exam", b =>
                {
                    b.Navigation("examAnswers");
                });

            modelBuilder.Entity("QuizApi.Data.Models.Question", b =>
                {
                    b.Navigation("options");
                });
#pragma warning restore 612, 618
        }
    }
}
