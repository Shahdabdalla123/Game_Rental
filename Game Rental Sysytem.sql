/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2017                    */
/* Created on:     5/30/2022 9:34:26 PM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ADMIN') and o.name = 'FK_ADMIN_SYSTEM_US_USER')
alter table ADMIN
   drop constraint FK_ADMIN_SYSTEM_US_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BROWSING') and o.name = 'FK_BROWSING_BROWSING_CLIENT')
alter table BROWSING
   drop constraint FK_BROWSING_BROWSING_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BROWSING') and o.name = 'FK_BROWSING_BROWSING2_GAME')
alter table BROWSING
   drop constraint FK_BROWSING_BROWSING2_GAME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CLIENT') and o.name = 'FK_CLIENT_SYSTEM_US_USER')
alter table CLIENT
   drop constraint FK_CLIENT_SYSTEM_US_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DEVELOP') and o.name = 'FK_DEVELOP_ADDING_VENDOR')
alter table DEVELOP
   drop constraint FK_DEVELOP_ADDING_VENDOR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('GAME') and o.name = 'FK_GAME_ADD_ADMIN')
alter table GAME
   drop constraint FK_GAME_ADD_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('GAME') and o.name = 'FK_GAME_ADD_DATE_DEVELOP')
alter table GAME
   drop constraint FK_GAME_ADD_DATE_DEVELOP
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('GAME') and o.name = 'FK_GAME_UPDATE_ADMIN')
alter table GAME
   drop constraint FK_GAME_UPDATE_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RENT') and o.name = 'FK_RENT_RENTINGOP_GAME')
alter table RENT
   drop constraint FK_RENT_RENTINGOP_GAME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RENT') and o.name = 'FK_RENT_RENTING_O_CLIENT')
alter table RENT
   drop constraint FK_RENT_RENTING_O_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"RETURN"') and o.name = 'FK_RETURN_RETURNOPE_GAME')
alter table "RETURN"
   drop constraint FK_RETURN_RETURNOPE_GAME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"RETURN"') and o.name = 'FK_RETURN_RETURN_OP_CLIENT')
alter table "RETURN"
   drop constraint FK_RETURN_RETURN_OP_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SHOWLIST') and o.name = 'FK_SHOWLIST_SHOWLIST_CLIENT')
alter table SHOWLIST
   drop constraint FK_SHOWLIST_SHOWLIST_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SHOWLIST') and o.name = 'FK_SHOWLIST_SHOWLIST2_GAME')
alter table SHOWLIST
   drop constraint FK_SHOWLIST_SHOWLIST2_GAME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('UPDATE_DETAILS') and o.name = 'FK_UPDATE_D_UPDATE_DE_USER')
alter table UPDATE_DETAILS
   drop constraint FK_UPDATE_D_UPDATE_DE_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('UPDATE_DETAILS') and o.name = 'FK_UPDATE_D_UPDATE_DE_USER2')
alter table UPDATE_DETAILS
   drop constraint FK_UPDATE_D_UPDATE_DE_USER2
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMIN')
            and   type = 'U')
   drop table ADMIN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BROWSING')
            and   name  = 'BROWSING2_FK'
            and   indid > 0
            and   indid < 255)
   drop index BROWSING.BROWSING2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BROWSING')
            and   name  = 'BROWSING_FK'
            and   indid > 0
            and   indid < 255)
   drop index BROWSING.BROWSING_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BROWSING')
            and   type = 'U')
   drop table BROWSING
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CLIENT')
            and   type = 'U')
   drop table CLIENT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DEVELOP')
            and   type = 'U')
   drop table DEVELOP
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('GAME')
            and   name  = 'ADD_DATE_FK'
            and   indid > 0
            and   indid < 255)
   drop index GAME.ADD_DATE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('GAME')
            and   name  = 'ADD_FK'
            and   indid > 0
            and   indid < 255)
   drop index GAME.ADD_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('GAME')
            and   name  = 'UPDATE_FK'
            and   indid > 0
            and   indid < 255)
   drop index GAME.UPDATE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('GAME')
            and   type = 'U')
   drop table GAME
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RENT')
            and   name  = 'RENTINGOPERATION_FK'
            and   indid > 0
            and   indid < 255)
   drop index RENT.RENTINGOPERATION_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RENT')
            and   name  = 'RENTING_OPERATION_FK'
            and   indid > 0
            and   indid < 255)
   drop index RENT.RENTING_OPERATION_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RENT')
            and   type = 'U')
   drop table RENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"RETURN"')
            and   name  = 'RETURNOPERATION_FK'
            and   indid > 0
            and   indid < 255)
   drop index "RETURN".RETURNOPERATION_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"RETURN"')
            and   name  = 'RETURN_OPERATION_FK'
            and   indid > 0
            and   indid < 255)
   drop index "RETURN".RETURN_OPERATION_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"RETURN"')
            and   type = 'U')
   drop table "RETURN"
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SHOWLIST')
            and   name  = 'SHOWLIST2_FK'
            and   indid > 0
            and   indid < 255)
   drop index SHOWLIST.SHOWLIST2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SHOWLIST')
            and   name  = 'SHOWLIST_FK'
            and   indid > 0
            and   indid < 255)
   drop index SHOWLIST.SHOWLIST_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SHOWLIST')
            and   type = 'U')
   drop table SHOWLIST
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('UPDATE_DETAILS')
            and   name  = 'UPDATE_DETAILS2_FK'
            and   indid > 0
            and   indid < 255)
   drop index UPDATE_DETAILS.UPDATE_DETAILS2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('UPDATE_DETAILS')
            and   name  = 'UPDATE_DETAILS_FK'
            and   indid > 0
            and   indid < 255)
   drop index UPDATE_DETAILS.UPDATE_DETAILS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('UPDATE_DETAILS')
            and   type = 'U')
   drop table UPDATE_DETAILS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"USER"')
            and   type = 'U')
   drop table "USER"
go

if exists (select 1
            from  sysobjects
           where  id = object_id('VENDOR')
            and   type = 'U')
   drop table VENDOR
go

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN (
   ADMINID              varchar(10)          not null,
   EMAIL                varchar(30)          not null,
   PASSWORD             varchar(25)          not null,
   FNAME                varchar(12)          not null,
   LNAME                varchar(12)          not null,
   PHONENUMBER          varchar(11)          not null,
   constraint PK_ADMIN primary key (ADMINID)
)
go

/*==============================================================*/
/* Table: BROWSING                                              */
/*==============================================================*/
create table BROWSING (
   GAMEID               varchar(10)          not null,
   NAME                 varchar(15)          not null,
   constraint PK_BROWSING primary key (GAMEID)
)
go

/*==============================================================*/
/* Index: BROWSING_FK                                           */
/*==============================================================*/

create nonclustered index BROWSING_FK on BROWSING (GAMEID ASC)
go

/*==============================================================*/
/* Index: BROWSING2_FK                                          */
/*==============================================================*/


create nonclustered index BROWSING2_FK on BROWSING (NAME ASC)
go

/*==============================================================*/
/* Table: CLIENT                                                */
/*==============================================================*/
create table CLIENT (
   ID                   varchar(10)          not null,
   EMAIL                varchar(30)          not null,
   PASSWORD             varchar(25)          not null,
   FNAME                varchar(12)          not null,
   LNAME                varchar(12)          not null,
   PHONENUMBER          varchar(11)          not null,
   constraint PK_CLIENT primary key (ID)
)
go

/*==============================================================*/
/* Table: DEVELOP                                               */
/*==============================================================*/
create table DEVELOP (
   VENDOR_ID            numeric(3)           not null,
   ADDINGDATE           datetime             not null,
   constraint PK_DEVELOP primary key (VENDOR_ID)
)
go

/*==============================================================*/
/* Table: GAME                                                  */
/*==============================================================*/
create table GAME (
   YEAR                 varchar(4)           not null,
   VENDORNAME           varchar(10)          not null,
   CATEGORY             varchar(10)          not null,
   NAME                 varchar(15)          not null,
   GAMEID               varchar(10)          null,
   ADMINID              varchar(10)          null,
   VENDOR_ID            numeric(3)           not null,
   constraint PK_GAME primary key (NAME)
)
go

/*==============================================================*/
/* Index: UPDATE_FK                                             */
/*==============================================================*/

create nonclustered index UPDATE_FK on GAME (GAMEID ASC)
go

/*==============================================================*/
/* Index: ADD_FK                                                */
/*==============================================================*/

create nonclustered index ADD_FK on GAME (ADMINID ASC)
go

/*==============================================================*/
/* Index: ADD_DATE_FK                                           */
/*==============================================================*/

create nonclustered index ADD_DATE_FK on GAME (VENDOR_ID ASC)
go

/*==============================================================*/
/* Table: RENT                                                  */
/*==============================================================*/
create table RENT (
   GAMEID               varchar(10)          not null,
   NAME                 varchar(15)          not null,
   RENTDATE             datetime             not null,
   constraint PK_RENT primary key (GAMEID)
)
go

/*==============================================================*/
/* Index: RENTING_OPERATION_FK                                  */
/*==============================================================*/

create nonclustered index RENTING_OPERATION_FK on RENT (GAMEID ASC)
go

/*==============================================================*/
/* Index: RENTINGOPERATION_FK                                   */
/*==============================================================*/

create nonclustered index RENTINGOPERATION_FK on RENT (NAME ASC)
go

/*==============================================================*/
/* Table: "RETURN"                                              */
/*==============================================================*/
create table "RETURN" (
   GAMEID               varchar(10)          not null,
   NAME                 varchar(15)          not null,
   RETURNDATE           datetime             not null,
   constraint PK_RETURN primary key (GAMEID)
)
go

/*==============================================================*/
/* Index: RETURN_OPERATION_FK                                   */
/*==============================================================*/

create nonclustered index RETURN_OPERATION_FK on "RETURN" (GAMEID ASC)
go

/*==============================================================*/
/* Index: RETURNOPERATION_FK                                    */
/*==============================================================*/

create nonclustered index RETURNOPERATION_FK on "RETURN" (NAME ASC)
go

/*==============================================================*/
/* Table: SHOWLIST                                              */
/*==============================================================*/
create table SHOWLIST (
   GAMEID               varchar(10)          not null,
   NAME                 varchar(15)          not null,
   constraint PK_SHOWLIST primary key (GAMEID)
)
go

/*==============================================================*/
/* Index: SHOWLIST_FK                                           */
/*==============================================================*/

create nonclustered index SHOWLIST_FK on SHOWLIST (GAMEID ASC)
go

/*==============================================================*/
/* Index: SHOWLIST2_FK                                          */
/*==============================================================*/

create nonclustered index SHOWLIST2_FK on SHOWLIST (NAME ASC)
go

/*==============================================================*/
/* Table: UPDATE_DETAILS                                        */
/*==============================================================*/
create table UPDATE_DETAILS (
   ID                   varchar(10)          not null,
   NAME                 varchar(10)          not null,
   constraint PK_UPDATE_DETAILS primary key (ID)
)
go

/*==============================================================*/
/* Index: UPDATE_DETAILS_FK                                     */
/*==============================================================*/

create nonclustered index UPDATE_DETAILS_FK on UPDATE_DETAILS (ID ASC)
go

/*==============================================================*/
/* Index: UPDATE_DETAILS2_FK                                    */
/*==============================================================*/

create nonclustered index UPDATE_DETAILS2_FK on UPDATE_DETAILS (NAME ASC)
go

/*==============================================================*/
/* Table: "USER"                                                */
/*==============================================================*/
create table "USER" (
   EMAIL                varchar(30)          not null,
   PASSWORD             varchar(25)          not null,
   FNAME                varchar(12)          not null,
   LNAME                varchar(12)          not null,
   PHONENUMBER          varchar(11)          not null,
   ID                   varchar(10)          not null,
   constraint PK_USER primary key (ID)
)
go

/*==============================================================*/
/* Table: VENDOR                                                */
/*==============================================================*/
create table VENDOR (
   VENDOR_ID            numeric(3)           not null,
   VENDOR_NAME          varchar(12)          not null,
   constraint PK_VENDOR primary key (VENDOR_ID)
)
go

alter table ADMIN
   add constraint FK_ADMIN_SYSTEM_US_USER foreign key (ADMINID)
      references "USER" (ID)
go

alter table BROWSING
   add constraint FK_BROWSING_BROWSING_CLIENT foreign key (GAMEID)
      references CLIENT (ID)
go

alter table BROWSING
   add constraint FK_BROWSING_BROWSING2_GAME foreign key (NAME)
      references GAME (NAME)
go

alter table CLIENT
   add constraint FK_CLIENT_SYSTEM_US_USER foreign key (ID)
      references "USER" (ID)
go

alter table DEVELOP
   add constraint FK_DEVELOP_ADDING_VENDOR foreign key (VENDOR_ID)
      references VENDOR (VENDOR_ID)
go

alter table GAME
   add constraint FK_GAME_ADD_ADMIN foreign key (ADMINID)
      references ADMIN (ADMINID)
go

alter table GAME
   add constraint FK_GAME_ADD_DATE_DEVELOP foreign key (VENDOR_ID)
      references DEVELOP (VENDOR_ID)
go

alter table GAME
   add constraint FK_GAME_UPDATE_ADMIN foreign key (GAMEID)
      references ADMIN (ADMINID)
go

alter table RENT
   add constraint FK_RENT_RENTINGOP_GAME foreign key (NAME)
      references GAME (NAME)
go

alter table RENT
   add constraint FK_RENT_RENTING_O_CLIENT foreign key (GAMEID)
      references CLIENT (ID)
go

alter table "RETURN"
   add constraint FK_RETURN_RETURNOPE_GAME foreign key (NAME)
      references GAME (NAME)
go

alter table "RETURN"
   add constraint FK_RETURN_RETURN_OP_CLIENT foreign key (GAMEID)
      references CLIENT (ID)
go

alter table SHOWLIST
   add constraint FK_SHOWLIST_SHOWLIST_CLIENT foreign key (GAMEID)
      references CLIENT (ID)
go

alter table SHOWLIST
   add constraint FK_SHOWLIST_SHOWLIST2_GAME foreign key (NAME)
      references GAME (NAME)
go

alter table UPDATE_DETAILS
   add constraint FK_UPDATE_D_UPDATE_DE_USER foreign key (ID)
      references "USER" (ID)
go

alter table UPDATE_DETAILS
   add constraint FK_UPDATE_D_UPDATE_DE_USER2 foreign key (NAME)
      references "USER" (ID)
go

select top 1 with ties GAME.NAME 
from GAME join RENT on GAME.GAMEID = RENT.GAMEID
group by GAME.NAME
order by count(*) desc;


select NAME from GAME 
where GAME.GAMEID not in (select GAME.GAMEID from RENT, "RETURN" 
where DATEDIFF(day,RENTDATE, RETURNDATE)<=30);


select top 1 with ties CLIENT.FNAME, CLIENT.LNAME
from CLIENT , "USER", RENT , "RETURN" where "USER".ID = CLIENT.ID and CLIENT.ID = RENT.GAMEID
and DATEDIFF(day,RENTDATE, RETURNDATE)<=30
group by CLIENT.FNAME , CLIENT.LNAME
order by count(*) desc;

select top 1 with ties VENDOR_NAME 
from RENT , GAME , VENDOR , "RETURN" where RENT.GAMEID = GAME.GAMEID and VENDOR.VENDOR_ID = GAME.VENDOR_ID 
and  DATEDIFF(day,RENTDATE, RETURNDATE)<=30
group by  VENDOR_NAME 
order by count(*) desc;

select VENDOR_NAME from VENDOR
where VENDOR.VENDOR_NAME not in (select GAME.VENDORNAME from GAME, RENT
where GAME.NAME = RENT.NAME
and DATEPART ( m , RENTDATE ) = DATEPART ( m , DATEADD ( m , -1 , GETDATE ( ) ) )
and DATEPART ( year , RENTDATE  ) = DATEPART ( yy , DATEADD ( m , -1 , GetDate ( ) ) )
group by GAME.VENDORNAME)

select VENDOR_NAME , GAME.VENDOR_ID from VENDOR , GAME, DEVELOP
where VENDOR.VENDOR_NAME  = GAME.VENDORNAME
and not DATEPART ( year , ADDINGDATE) = DATEPART ( yy , DATEADD( yy , -1 ,GETDATE( ) ) )