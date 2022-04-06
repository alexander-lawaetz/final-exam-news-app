﻿// <auto-generated />
using System;
using JwtBlogArtikelApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JwtBlogArtikelApi.Migrations
{
    [DbContext(typeof(BlogArtiklenDbContext))]
    partial class BlogArtiklenDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.2.22153.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("JwtBlogArtikelApi.Models.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Headline")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("JwtBlogArtikelApi.Models.ArticleTag", b =>
                {
                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.Property<int>("ArtilceId")
                        .HasColumnType("int");

                    b.HasKey("TagId", "ArtilceId");

                    b.HasIndex("ArtilceId");

                    b.ToTable("ArticleTags");
                });

            modelBuilder.Entity("JwtBlogArtikelApi.Models.Bookmark", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ArtilceId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "ArtilceId");

                    b.HasIndex("ArtilceId");

                    b.ToTable("Bookmarks");
                });

            modelBuilder.Entity("JwtBlogArtikelApi.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("UserId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("JwtBlogArtikelApi.Models.Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Activated")
                        .HasColumnType("int");

                    b.Property<int>("NewsSignup")
                        .HasColumnType("int");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("JwtBlogArtikelApi.Models.Follow", b =>
                {
                    b.Property<int>("FollowerId")
                        .HasColumnType("int");

                    b.Property<int>("FolloweringId")
                        .HasColumnType("int");

                    b.HasKey("FollowerId", "FolloweringId");

                    b.HasIndex("FolloweringId");

                    b.ToTable("Follows");
                });

            modelBuilder.Entity("JwtBlogArtikelApi.Models.Reply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CommentId")
                        .HasColumnType("int");

                    b.Property<string>("ReplyComment")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CommentId");

                    b.HasIndex("UserId");

                    b.ToTable("Reply");
                });

            modelBuilder.Entity("JwtBlogArtikelApi.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("JwtBlogArtikelApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("About")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("EmailId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Subscribtion")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("EmailId")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("JwtBlogArtikelApi.Models.Article", b =>
                {
                    b.HasOne("JwtBlogArtikelApi.Models.User", "Author")
                        .WithMany("Articles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("JwtBlogArtikelApi.Models.ArticleTag", b =>
                {
                    b.HasOne("JwtBlogArtikelApi.Models.Article", "Article")
                        .WithMany("ArticleTags")
                        .HasForeignKey("ArtilceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JwtBlogArtikelApi.Models.Tag", "Tag")
                        .WithMany("ArticleTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("JwtBlogArtikelApi.Models.Bookmark", b =>
                {
                    b.HasOne("JwtBlogArtikelApi.Models.Article", "Article")
                        .WithMany("Bookmarks")
                        .HasForeignKey("ArtilceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JwtBlogArtikelApi.Models.User", "User")
                        .WithMany("Bookmarks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("User");
                });

            modelBuilder.Entity("JwtBlogArtikelApi.Models.Comment", b =>
                {
                    b.HasOne("JwtBlogArtikelApi.Models.Article", "Article")
                        .WithMany("Comments")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JwtBlogArtikelApi.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("User");
                });

            modelBuilder.Entity("JwtBlogArtikelApi.Models.Follow", b =>
                {
                    b.HasOne("JwtBlogArtikelApi.Models.User", "Follower")
                        .WithMany("Followers")
                        .HasForeignKey("FollowerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JwtBlogArtikelApi.Models.User", "Following")
                        .WithMany("Followings")
                        .HasForeignKey("FolloweringId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Follower");

                    b.Navigation("Following");
                });

            modelBuilder.Entity("JwtBlogArtikelApi.Models.Reply", b =>
                {
                    b.HasOne("JwtBlogArtikelApi.Models.Comment", "Comment")
                        .WithMany("Replies")
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JwtBlogArtikelApi.Models.User", "User")
                        .WithMany("Replies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("JwtBlogArtikelApi.Models.User", b =>
                {
                    b.HasOne("JwtBlogArtikelApi.Models.Email", "Email")
                        .WithOne("User")
                        .HasForeignKey("JwtBlogArtikelApi.Models.User", "EmailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Email");
                });

            modelBuilder.Entity("JwtBlogArtikelApi.Models.Article", b =>
                {
                    b.Navigation("ArticleTags");

                    b.Navigation("Bookmarks");

                    b.Navigation("Comments");
                });

            modelBuilder.Entity("JwtBlogArtikelApi.Models.Comment", b =>
                {
                    b.Navigation("Replies");
                });

            modelBuilder.Entity("JwtBlogArtikelApi.Models.Email", b =>
                {
                    b.Navigation("User")
                        .IsRequired();
                });

            modelBuilder.Entity("JwtBlogArtikelApi.Models.Tag", b =>
                {
                    b.Navigation("ArticleTags");
                });

            modelBuilder.Entity("JwtBlogArtikelApi.Models.User", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("Bookmarks");

                    b.Navigation("Comments");

                    b.Navigation("Followers");

                    b.Navigation("Followings");

                    b.Navigation("Replies");
                });
#pragma warning restore 612, 618
        }
    }
}