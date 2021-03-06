/****** Script for SelectTopNRows command from SSMS  ******/
SELECT [SiteID]
      ,[SiteCode]
      ,[SiteName]
      ,[Latitude]
      ,[Longitude]
      ,[LatLongDatumID]
      ,[Elevation_m]
      ,[VerticalDatum]
      ,[LocalX]
      ,[LocalY]
      ,[LocalProjectionID]
      ,[PosAccuracy_m]
      ,[State]
      ,[County]
      ,[Comments]
      ,[SiteType]
  FROM [Summary].[dbo].[Sites]
  
  
  
-- Delete from Summary.dbo.Sites where SiteID in (
--Select SiteID FROM(
--	Select s.SiteID, s.SiteCode, s.SiteType, dv.SiteID AS DVSite from [Summary].[dbo].[Sites] as s
--	Left join (select Distinct(SiteID) from [Summary].[dbo].DataValues) AS dv
--	On s.SiteID = dv.SiteID)
--	as data
--	where data.DVSite is NULL)