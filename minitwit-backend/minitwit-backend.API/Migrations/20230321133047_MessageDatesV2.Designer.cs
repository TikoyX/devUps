﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using minitwit_backend.Data;

#nullable disable

namespace minitwitbackend.Migrations
{
    [DbContext(typeof(MinitwitContext))]
    [Migration("20230321133047_MessageDatesV2")]
    partial class MessageDatesV2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("UserUser", b =>
                {
                    b.Property<int>("FollowersUserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FollowingUserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FollowersUserId", "FollowingUserId");

                    b.HasIndex("FollowingUserId");

                    b.ToTable("UserUser");
                });

            modelBuilder.Entity("minitwit_backend.Data.Model.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("message_id");

                    b.Property<int>("AuthorId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("author_id");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("TEXT")
                        .HasColumnName("date");

                    b.Property<int?>("Flagged")
                        .HasColumnType("INTEGER")
                        .HasColumnName("flagged");

                    b.Property<int?>("PubDate")
                        .HasColumnType("INTEGER")
                        .HasColumnName("pub_date");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("string")
                        .HasColumnName("text");

                    b.HasKey("MessageId");

                    b.ToTable("message", (string)null);
                });

            modelBuilder.Entity("minitwit_backend.Data.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("user_id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("string")
                        .HasColumnName("email");

                    b.Property<string>("PwHash")
                        .IsRequired()
                        .HasColumnType("string")
                        .HasColumnName("pw_hash");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("string")
                        .HasColumnName("username");

                    b.HasKey("UserId");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("UserUser", b =>
                {
                    b.HasOne("minitwit_backend.Data.Model.User", null)
                        .WithMany()
                        .HasForeignKey("FollowersUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("minitwit_backend.Data.Model.User", null)
                        .WithMany()
                        .HasForeignKey("FollowingUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
