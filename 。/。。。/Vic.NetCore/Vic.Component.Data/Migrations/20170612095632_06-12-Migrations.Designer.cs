﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Vic.Core.Data;

namespace Vic.Core.Data.Migrations
{
    [DbContext(typeof(TradeDbContext))]
    [Migration("20170612095632_06-12-Migrations")]
    partial class _0612Migrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Vic.Core.Domain.Entities.Article", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FID")
                        .HasMaxLength(32);

                    b.Property<Guid>("ArticleTypeID")
                        .HasColumnName("FArticleTypeID");

                    b.Property<string>("Author")
                        .HasColumnName("FAuthor")
                        .HasMaxLength(20);

                    b.Property<int>("BrowseNum")
                        .HasColumnName("FBrowseNum");

                    b.Property<string>("Content")
                        .HasColumnName("FContent")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnName("FCreateTime");

                    b.Property<Guid>("CreatorID")
                        .HasColumnName("FCreatorID")
                        .HasMaxLength(32);

                    b.Property<string>("Description")
                        .HasColumnName("FDescription")
                        .HasMaxLength(800);

                    b.Property<string>("Images")
                        .HasColumnName("FImages")
                        .HasMaxLength(200);

                    b.Property<Guid>("LanguageTypeID")
                        .HasColumnName("FLanguageTypeID")
                        .HasMaxLength(32);

                    b.Property<DateTime?>("LastUpdateTime")
                        .HasColumnName("FLastUpdateTime");

                    b.Property<Guid?>("LastUpdateUserID")
                        .HasColumnName("FLastUpdateUserID")
                        .HasMaxLength(32);

                    b.Property<DateTime>("PublishDate")
                        .HasColumnName("FPublishDate")
                        .HasColumnType("DateTime");

                    b.Property<string>("Remark")
                        .HasColumnName("FRemark")
                        .HasMaxLength(200);

                    b.Property<string>("SeoTitle")
                        .HasColumnName("FSeoTitle")
                        .HasMaxLength(100);

                    b.Property<int>("SerialNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FSerialNumber");

                    b.Property<string>("Source")
                        .HasColumnName("FSource")
                        .HasMaxLength(20);

                    b.Property<string>("Title")
                        .HasColumnName("FTitle")
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.ToTable("T_CMS_Article");
                });

            modelBuilder.Entity("Vic.Core.Domain.Entities.ArticleType", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FID")
                        .HasMaxLength(32);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnName("FCreateTime");

                    b.Property<Guid>("CreatorID")
                        .HasColumnName("FCreatorID")
                        .HasMaxLength(32);

                    b.Property<string>("Images")
                        .HasColumnName("FImages")
                        .HasMaxLength(200);

                    b.Property<Guid>("LanguageTypeID")
                        .HasColumnName("FLanguageTypeID")
                        .HasMaxLength(32);

                    b.Property<DateTime?>("LastUpdateTime")
                        .HasColumnName("FLastUpdateTime");

                    b.Property<Guid?>("LastUpdateUserID")
                        .HasColumnName("FLastUpdateUserID")
                        .HasMaxLength(32);

                    b.Property<int>("SerialNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FSerialNumber");

                    b.Property<string>("Title")
                        .HasColumnName("FTitle")
                        .HasMaxLength(100);

                    b.Property<string>("Url")
                        .HasColumnName("FUrl")
                        .HasMaxLength(200);

                    b.HasKey("ID");

                    b.ToTable("T_CMS_ArticleType");
                });

            modelBuilder.Entity("Vic.Core.Domain.Entities.Banner", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FID")
                        .HasMaxLength(32);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnName("FCreateTime");

                    b.Property<Guid>("CreatorID")
                        .HasColumnName("FCreatorID")
                        .HasMaxLength(32);

                    b.Property<string>("Image")
                        .HasColumnName("FImage")
                        .HasMaxLength(200);

                    b.Property<Guid>("LanguageTypeID")
                        .HasColumnName("FLanguageTypeID")
                        .HasMaxLength(32);

                    b.Property<DateTime?>("LastUpdateTime")
                        .HasColumnName("FLastUpdateTime");

                    b.Property<Guid?>("LastUpdateUserID")
                        .HasColumnName("FLastUpdateUserID")
                        .HasMaxLength(32);

                    b.Property<int>("SerialNumber")
                        .HasColumnName("FSerialNumber");

                    b.Property<string>("Title")
                        .HasColumnName("FTitle")
                        .HasMaxLength(100);

                    b.Property<string>("Url")
                        .HasColumnName("FUrl")
                        .HasMaxLength(200);

                    b.HasKey("ID");

                    b.ToTable("T_CMS_Banner");
                });

            modelBuilder.Entity("Vic.Core.Domain.Entities.CustomerUser", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FID")
                        .HasMaxLength(32);

                    b.Property<int>("AuthenticationVerify")
                        .HasColumnName("FAuthenticationVerify");

                    b.Property<string>("CardFrontPhoto")
                        .HasColumnName("FCardFrontPhoto")
                        .HasMaxLength(100);

                    b.Property<string>("CardHandHeldPhoto")
                        .HasColumnName("FCardHandHeldPhoto")
                        .HasMaxLength(100);

                    b.Property<string>("CardNegativePhoto")
                        .HasColumnName("FCardNegativePhoto")
                        .HasMaxLength(100);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnName("FCreateTime");

                    b.Property<Guid>("CreatorID")
                        .HasColumnName("FCreatorID")
                        .HasMaxLength(32);

                    b.Property<string>("Email")
                        .HasColumnName("FEmail")
                        .HasMaxLength(50);

                    b.Property<string>("IDCard")
                        .HasColumnName("FIDCard")
                        .HasMaxLength(18);

                    b.Property<DateTime?>("LastUpdateTime")
                        .HasColumnName("FLastUpdateTime");

                    b.Property<Guid?>("LastUpdateUserID")
                        .HasColumnName("FLastUpdateUserID")
                        .HasMaxLength(32);

                    b.Property<string>("Mobile")
                        .HasColumnName("FMobile")
                        .HasMaxLength(20);

                    b.Property<string>("NickName")
                        .HasColumnName("FNickName")
                        .HasMaxLength(20);

                    b.Property<string>("PassWord")
                        .HasColumnName("FPassWord")
                        .HasMaxLength(200);

                    b.Property<string>("RealName")
                        .HasColumnName("FRealName")
                        .HasMaxLength(20);

                    b.Property<Guid>("RecommendID")
                        .HasColumnName("FRecommendID")
                        .HasMaxLength(32);

                    b.Property<int>("Status")
                        .HasColumnName("FStatus");

                    b.Property<string>("TPassWord")
                        .HasColumnName("FTPassWord")
                        .HasMaxLength(200);

                    b.Property<int>("TradeAccount")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FTradeAccount");

                    b.Property<int>("Type")
                        .HasColumnName("FType");

                    b.Property<int>("VerifyResult")
                        .HasColumnName("FVerifyResult");

                    b.HasKey("ID");

                    b.ToTable("T_PST_CustomerUser");
                });

            modelBuilder.Entity("Vic.Core.Domain.Entities.Department", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FID")
                        .HasMaxLength(32);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnName("FCode")
                        .HasMaxLength(20);

                    b.Property<string>("ContactNumber")
                        .HasColumnName("FContactNumber")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnName("FCreateTime");

                    b.Property<Guid>("CreatorID")
                        .HasColumnName("FCreatorID")
                        .HasMaxLength(32);

                    b.Property<bool>("IsDeleted")
                        .HasColumnName("FIsDeleted");

                    b.Property<DateTime?>("LastUpdateTime")
                        .HasColumnName("FLastUpdateTime");

                    b.Property<Guid?>("LastUpdateUserID")
                        .HasColumnName("FLastUpdateUserID")
                        .HasMaxLength(32);

                    b.Property<string>("Manager")
                        .HasColumnName("FManager")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("FName")
                        .HasMaxLength(50);

                    b.Property<Guid>("ParentId")
                        .HasColumnName("FParentId")
                        .HasMaxLength(32);

                    b.Property<string>("Remarks")
                        .HasColumnName("FRemarks")
                        .HasMaxLength(200);

                    b.HasKey("ID");

                    b.ToTable("T_AM_Department");
                });

            modelBuilder.Entity("Vic.Core.Domain.Entities.LanguageType", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FID")
                        .HasMaxLength(32);

                    b.Property<string>("Code")
                        .HasColumnName("FCode")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnName("FCreateTime");

                    b.Property<Guid>("CreatorID")
                        .HasColumnName("FCreatorID")
                        .HasMaxLength(32);

                    b.Property<string>("Images")
                        .HasColumnName("FImages")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("LastUpdateTime")
                        .HasColumnName("FLastUpdateTime");

                    b.Property<Guid?>("LastUpdateUserID")
                        .HasColumnName("FLastUpdateUserID")
                        .HasMaxLength(32);

                    b.Property<string>("Title")
                        .HasColumnName("FTitle")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("T_PL_LanguageType");
                });

            modelBuilder.Entity("Vic.Core.Domain.Entities.MailConfig", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FID")
                        .HasMaxLength(32);

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasColumnName("FAccountName")
                        .HasMaxLength(50);

                    b.Property<string>("AccountPwd")
                        .IsRequired()
                        .HasColumnName("FAccountPwd")
                        .HasMaxLength(200);

                    b.Property<string>("CallEnumKey")
                        .IsRequired()
                        .HasColumnName("FCallEnumKey")
                        .HasMaxLength(50);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnName("FContent")
                        .HasMaxLength(8000);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnName("FCreateTime");

                    b.Property<Guid>("CreatorID")
                        .HasColumnName("FCreatorID")
                        .HasMaxLength(32);

                    b.Property<bool>("IsDefault")
                        .HasColumnName("FIsDefault");

                    b.Property<DateTime?>("LastUpdateTime")
                        .HasColumnName("FLastUpdateTime");

                    b.Property<Guid?>("LastUpdateUserID")
                        .HasColumnName("FLastUpdateUserID")
                        .HasMaxLength(32);

                    b.Property<string>("MailFrom")
                        .IsRequired()
                        .HasColumnName("FMailFrom")
                        .HasMaxLength(50);

                    b.Property<string>("MailTo")
                        .IsRequired()
                        .HasColumnName("FMailTo")
                        .HasMaxLength(50);

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnName("FNickName")
                        .HasMaxLength(50);

                    b.Property<short>("Port")
                        .HasColumnName("FPort")
                        .HasMaxLength(10);

                    b.Property<string>("Stmp")
                        .IsRequired()
                        .HasColumnName("FStmp")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("T_PL_MailConfig");
                });

            modelBuilder.Entity("Vic.Core.Domain.Entities.MailTemplate", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FID")
                        .HasMaxLength(32);

                    b.Property<string>("CallEnumKey")
                        .IsRequired()
                        .HasColumnName("FCallEnumKey")
                        .HasMaxLength(50);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnName("FContent")
                        .HasMaxLength(8000);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnName("FCreateTime");

                    b.Property<Guid>("CreatorID")
                        .HasColumnName("FCreatorID")
                        .HasMaxLength(32);

                    b.Property<bool>("IsDefault")
                        .HasColumnName("FIsDefault");

                    b.Property<Guid>("LanguageTypeID")
                        .HasColumnName("FLanguageTypeID")
                        .HasMaxLength(32);

                    b.Property<DateTime?>("LastUpdateTime")
                        .HasColumnName("FLastUpdateTime");

                    b.Property<Guid?>("LastUpdateUserID")
                        .HasColumnName("FLastUpdateUserID")
                        .HasMaxLength(32);

                    b.Property<string>("MailTitle")
                        .IsRequired()
                        .HasColumnName("FMailTitle")
                        .HasMaxLength(500);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("FTitle")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("T_PL_MailTemplate");
                });

            modelBuilder.Entity("Vic.Core.Domain.Entities.Menu", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FID")
                        .HasMaxLength(32);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnName("FCode")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnName("FCreateTime");

                    b.Property<Guid>("CreatorID")
                        .HasColumnName("FCreatorID")
                        .HasMaxLength(32);

                    b.Property<string>("Icon")
                        .HasColumnName("FIcon")
                        .HasMaxLength(50);

                    b.Property<bool>("IsTopMenu")
                        .HasColumnName("FIsTopMenu");

                    b.Property<DateTime?>("LastUpdateTime")
                        .HasColumnName("FLastUpdateTime");

                    b.Property<Guid?>("LastUpdateUserID")
                        .HasColumnName("FLastUpdateUserID")
                        .HasMaxLength(32);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("FName")
                        .HasMaxLength(50);

                    b.Property<Guid>("ParentId")
                        .HasColumnName("FParentId")
                        .HasMaxLength(32);

                    b.Property<string>("Remarks")
                        .HasColumnName("FRemarks")
                        .HasMaxLength(200);

                    b.Property<int>("SerialNumber")
                        .HasColumnName("FSerialNumber");

                    b.Property<int>("Type")
                        .HasColumnName("FType");

                    b.Property<string>("Url")
                        .HasColumnName("FUrl")
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.ToTable("T_AM_Menu");
                });

            modelBuilder.Entity("Vic.Core.Domain.Entities.PlateSetting", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FID")
                        .HasMaxLength(32);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnName("FCreateTime");

                    b.Property<Guid>("CreatorID")
                        .HasColumnName("FCreatorID")
                        .HasMaxLength(32);

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnName("FKey")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("LastUpdateTime")
                        .HasColumnName("FLastUpdateTime");

                    b.Property<Guid?>("LastUpdateUserID")
                        .HasColumnName("FLastUpdateUserID")
                        .HasMaxLength(32);

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnName("FTag")
                        .HasMaxLength(50);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnName("FValue")
                        .HasMaxLength(200);

                    b.HasKey("ID");

                    b.ToTable("T_PL_PlateSetting");
                });

            modelBuilder.Entity("Vic.Core.Domain.Entities.PushService", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FID")
                        .HasMaxLength(32);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnName("FCreateTime");

                    b.Property<Guid>("CreatorID")
                        .HasColumnName("FCreatorID")
                        .HasMaxLength(32);

                    b.Property<string>("IP")
                        .IsRequired()
                        .HasColumnName("FIP")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("LastUpdateTime")
                        .HasColumnName("FLastUpdateTime");

                    b.Property<Guid?>("LastUpdateUserID")
                        .HasColumnName("FLastUpdateUserID")
                        .HasMaxLength(32);

                    b.Property<int>("Port")
                        .HasColumnName("FPort")
                        .HasMaxLength(10);

                    b.HasKey("ID");

                    b.ToTable("T_PL_PushService");
                });

            modelBuilder.Entity("Vic.Core.Domain.Entities.Role", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FID")
                        .HasMaxLength(32);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnName("FCode")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnName("FCreateTime");

                    b.Property<Guid>("CreatorID")
                        .HasColumnName("FCreatorID")
                        .HasMaxLength(32);

                    b.Property<DateTime?>("LastUpdateTime")
                        .HasColumnName("FLastUpdateTime");

                    b.Property<Guid?>("LastUpdateUserID")
                        .HasColumnName("FLastUpdateUserID")
                        .HasMaxLength(32);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("FName")
                        .HasMaxLength(50);

                    b.Property<string>("Remarks")
                        .HasColumnName("FRemarks")
                        .HasMaxLength(200);

                    b.HasKey("ID");

                    b.ToTable("T_AM_Role");
                });

            modelBuilder.Entity("Vic.Core.Domain.Entities.RoleMenu", b =>
                {
                    b.Property<Guid>("RoleId")
                        .HasColumnName("FRoleId")
                        .HasMaxLength(32);

                    b.Property<Guid>("MenuId")
                        .HasColumnName("FMenuId")
                        .HasMaxLength(32);

                    b.HasKey("RoleId", "MenuId");

                    b.HasIndex("MenuId");

                    b.ToTable("T_AM_RoleMenu");
                });

            modelBuilder.Entity("Vic.Core.Domain.Entities.ShortMsgConfig", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FID")
                        .HasMaxLength(32);

                    b.Property<string>("AccountName")
                        .HasColumnName("FAccountName")
                        .HasMaxLength(50);

                    b.Property<string>("AccountPwd")
                        .HasColumnName("FAccountPwd")
                        .HasMaxLength(200);

                    b.Property<string>("ApiKey")
                        .HasColumnName("FApiKey")
                        .HasMaxLength(200);

                    b.Property<string>("ApiSecret")
                        .HasColumnName("FApiSecret")
                        .HasMaxLength(200);

                    b.Property<string>("ApiUrl")
                        .IsRequired()
                        .HasColumnName("FApiUrl")
                        .HasMaxLength(200);

                    b.Property<string>("CallEnumKey")
                        .HasColumnName("FCallEnumKey")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnName("FCreateTime");

                    b.Property<Guid>("CreatorID")
                        .HasColumnName("FCreatorID")
                        .HasMaxLength(32);

                    b.Property<bool>("IsDefault")
                        .HasColumnName("FIsDefault");

                    b.Property<DateTime?>("LastUpdateTime")
                        .HasColumnName("FLastUpdateTime");

                    b.Property<Guid?>("LastUpdateUserID")
                        .HasColumnName("FLastUpdateUserID")
                        .HasMaxLength(32);

                    b.HasKey("ID");

                    b.ToTable("T_PL_ShortMsgConfig");
                });

            modelBuilder.Entity("Vic.Core.Domain.Entities.ShortMsgTemplate", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FID")
                        .HasMaxLength(32);

                    b.Property<string>("CallEnumKey")
                        .IsRequired()
                        .HasColumnName("FCallEnumKey")
                        .HasMaxLength(50);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnName("FContent")
                        .HasMaxLength(8000);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnName("FCreateTime");

                    b.Property<Guid>("CreatorID")
                        .HasColumnName("FCreatorID")
                        .HasMaxLength(32);

                    b.Property<bool>("IsDefault")
                        .HasColumnName("FIsDefault");

                    b.Property<Guid>("LanguageTypeID")
                        .HasColumnName("FLanguageTypeID")
                        .HasMaxLength(32);

                    b.Property<DateTime?>("LastUpdateTime")
                        .HasColumnName("FLastUpdateTime");

                    b.Property<Guid?>("LastUpdateUserID")
                        .HasColumnName("FLastUpdateUserID")
                        .HasMaxLength(32);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("FTitle")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("T_PL_ShortMsgTemplate");
                });

            modelBuilder.Entity("Vic.Core.Domain.Entities.SiteSetting", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FID")
                        .HasMaxLength(32);

                    b.Property<string>("Code")
                        .HasColumnName("FCode")
                        .HasMaxLength(20);

                    b.Property<string>("ContractAddress")
                        .HasColumnName("FContractAddress")
                        .HasMaxLength(200);

                    b.Property<string>("ContractEmail")
                        .HasColumnName("FContractEmail")
                        .HasMaxLength(50);

                    b.Property<string>("ContractPhone")
                        .HasColumnName("FContractPhone")
                        .HasMaxLength(50);

                    b.Property<string>("ContractQQ")
                        .HasColumnName("FContractQQ")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnName("FCreateTime");

                    b.Property<Guid>("CreatorID")
                        .HasColumnName("FCreatorID")
                        .HasMaxLength(32);

                    b.Property<bool>("IsAdmin")
                        .HasColumnName("FIsAdmin");

                    b.Property<Guid>("LanguageTypeID")
                        .HasColumnName("FLanguageTypeID")
                        .HasMaxLength(32);

                    b.Property<DateTime?>("LastUpdateTime")
                        .HasColumnName("FLastUpdateTime");

                    b.Property<Guid?>("LastUpdateUserID")
                        .HasColumnName("FLastUpdateUserID")
                        .HasMaxLength(32);

                    b.Property<string>("Logo")
                        .HasColumnName("FLogo")
                        .HasMaxLength(50);

                    b.Property<string>("LogoIco")
                        .HasColumnName("FLogoIco")
                        .HasMaxLength(50);

                    b.Property<string>("QrCode")
                        .HasColumnName("FQrCode")
                        .HasMaxLength(50);

                    b.Property<string>("SiteRight")
                        .HasColumnName("FSiteRight")
                        .HasMaxLength(200);

                    b.Property<string>("Title")
                        .HasColumnName("FTitle")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("T_PL_SiteSetting");
                });

            modelBuilder.Entity("Vic.Core.Domain.Entities.SysLog", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FID")
                        .HasMaxLength(32);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnName("FContent")
                        .HasMaxLength(1000);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnName("FCreateTime");

                    b.Property<Guid>("CreatorID")
                        .HasColumnName("FCreatorID")
                        .HasMaxLength(32);

                    b.Property<string>("IP")
                        .IsRequired()
                        .HasColumnName("FIP")
                        .HasMaxLength(20);

                    b.Property<bool>("IsAdmin")
                        .HasColumnName("FIsAdmin");

                    b.Property<DateTime?>("LastUpdateTime")
                        .HasColumnName("FLastUpdateTime");

                    b.Property<Guid?>("LastUpdateUserID")
                        .HasColumnName("FLastUpdateUserID")
                        .HasMaxLength(32);

                    b.Property<string>("LogType")
                        .IsRequired()
                        .HasColumnName("FLogType")
                        .HasMaxLength(50);

                    b.Property<decimal>("Num")
                        .HasColumnName("FNum");

                    b.Property<string>("SecurityLevel")
                        .IsRequired()
                        .HasColumnName("FSecurityLevel")
                        .HasMaxLength(5);

                    b.HasKey("ID");

                    b.ToTable("T_PL_SysLog");
                });

            modelBuilder.Entity("Vic.Core.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FID")
                        .HasMaxLength(32);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnName("FCreateTime");

                    b.Property<Guid>("CreatorID")
                        .HasColumnName("FCreatorID")
                        .HasMaxLength(32);

                    b.Property<Guid>("DepartmentId")
                        .HasColumnName("FDepartmentId")
                        .HasMaxLength(32);

                    b.Property<string>("EMail")
                        .HasColumnName("FEMail")
                        .HasMaxLength(50);

                    b.Property<bool>("IsDeleted")
                        .HasColumnName("FIsDeleted");

                    b.Property<DateTime>("LastLoginTime")
                        .HasColumnName("FLastLoginTime");

                    b.Property<DateTime?>("LastUpdateTime")
                        .HasColumnName("FLastUpdateTime");

                    b.Property<Guid?>("LastUpdateUserID")
                        .HasColumnName("FLastUpdateUserID")
                        .HasMaxLength(32);

                    b.Property<int>("LoginTimes")
                        .HasColumnName("FLoginTimes");

                    b.Property<string>("MobileNumber")
                        .HasColumnName("FMobileNumber")
                        .HasMaxLength(20);

                    b.Property<string>("Name")
                        .HasColumnName("FName")
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("FPassword")
                        .HasMaxLength(200);

                    b.Property<string>("Remarks")
                        .HasColumnName("FRemarks")
                        .HasMaxLength(200);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnName("FUserName")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.HasIndex("DepartmentId");

                    b.ToTable("T_AM_User");
                });

            modelBuilder.Entity("Vic.Core.Domain.Entities.UserMenu", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FID")
                        .HasMaxLength(32);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnName("FCode")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnName("FCreateTime");

                    b.Property<Guid>("CreatorID")
                        .HasColumnName("FCreatorID")
                        .HasMaxLength(32);

                    b.Property<string>("Icon")
                        .HasColumnName("FIcon")
                        .HasMaxLength(10);

                    b.Property<Guid>("LanguageTypeID")
                        .HasColumnName("FLanguageTypeID")
                        .HasMaxLength(32);

                    b.Property<DateTime?>("LastUpdateTime")
                        .HasColumnName("FLastUpdateTime");

                    b.Property<Guid?>("LastUpdateUserID")
                        .HasColumnName("FLastUpdateUserID")
                        .HasMaxLength(32);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("FName")
                        .HasMaxLength(50);

                    b.Property<Guid>("ParentId")
                        .HasColumnName("FParentId")
                        .HasMaxLength(32);

                    b.Property<string>("Remarks")
                        .HasColumnName("FRemarks")
                        .HasMaxLength(200);

                    b.Property<int>("SerialNumber")
                        .HasColumnName("FSerialNumber");

                    b.Property<int>("Type")
                        .HasColumnName("FType");

                    b.Property<string>("Url")
                        .HasColumnName("FUrl")
                        .HasMaxLength(150);

                    b.HasKey("ID");

                    b.ToTable("T_CMS_UserMenu");
                });

            modelBuilder.Entity("Vic.Core.Domain.Entities.UserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnName("FUserId")
                        .HasMaxLength(32);

                    b.Property<Guid>("RoleId")
                        .HasColumnName("FRoleId")
                        .HasMaxLength(32);

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("T_AM_UserRole");
                });

            modelBuilder.Entity("Vic.Core.Domain.Entities.VerifyCode", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FID")
                        .HasMaxLength(32);

                    b.Property<short>("BussinessType")
                        .HasColumnName("FBussinessType");

                    b.Property<string>("Code")
                        .HasColumnName("FCode")
                        .HasMaxLength(10);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnName("FCreateTime");

                    b.Property<Guid>("CreatorID")
                        .HasColumnName("FCreatorID")
                        .HasMaxLength(32);

                    b.Property<DateTime?>("LastUpdateTime")
                        .HasColumnName("FLastUpdateTime");

                    b.Property<Guid?>("LastUpdateUserID")
                        .HasColumnName("FLastUpdateUserID")
                        .HasMaxLength(32);

                    b.Property<string>("Phone")
                        .HasColumnName("FPhone")
                        .HasMaxLength(20);

                    b.Property<DateTime>("SendTime")
                        .HasColumnName("FSendTime");

                    b.Property<DateTime?>("ValidTime")
                        .HasColumnName("FValidTime");

                    b.Property<short>("ValidTimeLen")
                        .HasColumnName("FValidTimeLen");

                    b.Property<short>("VerifyFlag")
                        .HasColumnName("FVerifyFlag");

                    b.Property<DateTime?>("VerifyTime")
                        .HasColumnName("FVerifyTime");

                    b.HasKey("ID");

                    b.ToTable("T_PL_VerifyCode");
                });

            modelBuilder.Entity("Vic.Core.Domain.Entities.RoleMenu", b =>
                {
                    b.HasOne("Vic.Core.Domain.Entities.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Vic.Core.Domain.Entities.Role", "Role")
                        .WithMany("RoleMenus")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Vic.Core.Domain.Entities.User", b =>
                {
                    b.HasOne("Vic.Core.Domain.Entities.Department", "Department")
                        .WithMany("Users")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Vic.Core.Domain.Entities.UserRole", b =>
                {
                    b.HasOne("Vic.Core.Domain.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Vic.Core.Domain.Entities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
