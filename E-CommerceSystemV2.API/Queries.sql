dbug: 12/17/2023 17:46:15.819 RelationalEventId.ConnectionDisposed[20008] (Microsoft.EntityFrameworkCore.Database.Connection) 
      Disposed connection to database '' on server '' (16ms).
warn: 12/17/2023 17:47:28.624 CoreEventId.SensitiveDataLoggingEnabledWarning[10400] (Microsoft.EntityFrameworkCore.Infrastructure) 
      Sensitive data logging is enabled. Log entries and exception messages may include sensitive application data; this mode should only be enabled during development.
dbug: 12/17/2023 17:47:28.753 CoreEventId.ShadowPropertyCreated[10600] (Microsoft.EntityFrameworkCore.Model.Validation) 
      The property 'Product.CategoryId' was created in shadow state because there are no eligible CLR members with a matching name.
dbug: 12/17/2023 17:47:28.754 CoreEventId.ShadowPropertyCreated[10600] (Microsoft.EntityFrameworkCore.Model.Validation) 
      The property 'Product.TagId' was created in shadow state because there are no eligible CLR members with a matching name.
dbug: 12/17/2023 17:47:28.968 CoreEventId.ContextInitialized[10403] (Microsoft.EntityFrameworkCore.Infrastructure) 
      Entity Framework Core 8.0.0 initialized 'ECommerceContext' using provider 'Microsoft.EntityFrameworkCore.SqlServer:8.0.0' with options: SensitiveDataLoggingEnabled 
dbug: 12/17/2023 17:47:29.028 CoreEventId.QueryCompilationStarting[10111] (Microsoft.EntityFrameworkCore.Query) 
      Compiling query expression: 
      'DbSet<TagProducts>()
          .TagWith("First")
          .Where(tp => tp.TagId == __tagId_0)
          .Select(tp => tp.Product)'
dbug: 12/17/2023 17:47:29.304 CoreEventId.QueryExecutionPlanned[10107] (Microsoft.EntityFrameworkCore.Query) 
      Generated query execution expression: 
      'queryContext => new SingleQueryingEnumerable<Product>(
          (RelationalQueryContext)queryContext, 
          RelationalCommandCache.QueryExpression(
              Projection Mapping:
                  EmptyProjectionMember -> Dictionary<IProperty, int> { [Property: Product.ProductId (Guid) Required PK AfterSave:Throw ValueGenerated.OnAdd, 0], [Property: Product.CategoryId (no field, Guid?) Shadow FK Index, 1], [Property: Product.CategoryType (CategoryType) Required, 2], [Property: Product.Name (string), 3], [Property: Product.Price (decimal) Required, 4], [Property: Product.TagId (no field, Guid?) Shadow FK Index, 5] }
              -- FirstSELECT p.ProductId, p.CategoryId, p.CategoryType, p.Name, p.Price, p.TagId
              FROM TagProducts AS t
              INNER JOIN Products AS p ON t.ProductId == p.ProductId
              WHERE t.TagId == @__tagId_0), 
          null, 
          Func<QueryContext, DbDataReader, ResultContext, SingleQueryResultCoordinator, Product>, 
          E_CommerceSystemV2.API.ECommerceContext, 
          False, 
          False, 
          True
      )'
dbug: 12/17/2023 17:47:29.346 RelationalEventId.ConnectionCreating[20005] (Microsoft.EntityFrameworkCore.Database.Connection) 
      Creating DbConnection.
dbug: 12/17/2023 17:47:29.368 RelationalEventId.ConnectionCreated[20006] (Microsoft.EntityFrameworkCore.Database.Connection) 
      Created DbConnection. (21ms).
dbug: 12/17/2023 17:47:29.375 RelationalEventId.ConnectionOpening[20000] (Microsoft.EntityFrameworkCore.Database.Connection) 
      Opening connection to database 'E-Commerce' on server '.'.
dbug: 12/17/2023 17:47:29.542 RelationalEventId.ConnectionOpened[20001] (Microsoft.EntityFrameworkCore.Database.Connection) 
      Opened connection to database 'E-Commerce' on server '.'.
dbug: 12/17/2023 17:47:29.548 RelationalEventId.CommandCreating[20103] (Microsoft.EntityFrameworkCore.Database.Command) 
      Creating DbCommand for 'ExecuteReader'.
dbug: 12/17/2023 17:47:29.554 RelationalEventId.CommandCreated[20104] (Microsoft.EntityFrameworkCore.Database.Command) 
      Created DbCommand for 'ExecuteReader' (4ms).
dbug: 12/17/2023 17:47:29.565 RelationalEventId.CommandInitialized[20106] (Microsoft.EntityFrameworkCore.Database.Command) 
      Initialized DbCommand for 'ExecuteReader' (17ms).
dbug: 12/17/2023 17:47:29.574 RelationalEventId.CommandExecuting[20100] (Microsoft.EntityFrameworkCore.Database.Command) 
      Executing DbCommand [Parameters=[@__tagId_0='e19e7131-285f-4a94-b01e-7421f0c22b59'], CommandType='Text', CommandTimeout='30']
      -- First
      
      SELECT [p].[ProductId], [p].[CategoryId], [p].[CategoryType], [p].[Name], [p].[Price], [p].[TagId]
      FROM [TagProducts] AS [t]
      INNER JOIN [Products] AS [p] ON [t].[ProductId] = [p].[ProductId]
      WHERE [t].[TagId] = @__tagId_0
info: 12/17/2023 17:47:29.624 RelationalEventId.CommandExecuted[20101] (Microsoft.EntityFrameworkCore.Database.Command) 
      Executed DbCommand (49ms) [Parameters=[@__tagId_0='e19e7131-285f-4a94-b01e-7421f0c22b59'], CommandType='Text', CommandTimeout='30']
      -- First
      
      SELECT [p].[ProductId], [p].[CategoryId], [p].[CategoryType], [p].[Name], [p].[Price], [p].[TagId]
      FROM [TagProducts] AS [t]
      INNER JOIN [Products] AS [p] ON [t].[ProductId] = [p].[ProductId]
      WHERE [t].[TagId] = @__tagId_0
dbug: 12/17/2023 17:47:29.676 CoreEventId.StartedTracking[10806] (Microsoft.EntityFrameworkCore.ChangeTracking) 
      Context 'ECommerceContext' started tracking 'Product' entity with key '{ProductId: 7bcce6d2-f1ee-4664-8d5e-577cde13fe11}'.
dbug: 12/17/2023 17:47:29.707 CoreEventId.StartedTracking[10806] (Microsoft.EntityFrameworkCore.ChangeTracking) 
      Context 'ECommerceContext' started tracking 'Product' entity with key '{ProductId: 7036dc85-833f-4be8-9b38-57c4b8915195}'.
dbug: 12/17/2023 17:47:29.708 CoreEventId.StartedTracking[10806] (Microsoft.EntityFrameworkCore.ChangeTracking) 
      Context 'ECommerceContext' started tracking 'Product' entity with key '{ProductId: a5065ae5-ae59-4bab-b715-77d56ee04074}'.
dbug: 12/17/2023 17:47:29.709 CoreEventId.StartedTracking[10806] (Microsoft.EntityFrameworkCore.ChangeTracking) 
      Context 'ECommerceContext' started tracking 'Product' entity with key '{ProductId: 6272d26a-bd72-4eb9-ab68-b68c86a27230}'.
dbug: 12/17/2023 17:47:29.712 CoreEventId.StartedTracking[10806] (Microsoft.EntityFrameworkCore.ChangeTracking) 
      Context 'ECommerceContext' started tracking 'Product' entity with key '{ProductId: ca5240cc-1597-4d70-be9f-bb36a6917dfa}'.
dbug: 12/17/2023 17:47:29.713 CoreEventId.StartedTracking[10806] (Microsoft.EntityFrameworkCore.ChangeTracking) 
      Context 'ECommerceContext' started tracking 'Product' entity with key '{ProductId: 0388871d-1ed4-40d9-9141-fbc7ec3ec36e}'.
dbug: 12/17/2023 17:47:29.719 RelationalEventId.DataReaderClosing[20301] (Microsoft.EntityFrameworkCore.Database.Command) 
      Closing data reader to 'E-Commerce' on server '.'.
dbug: 12/17/2023 17:47:29.724 RelationalEventId.DataReaderDisposing[20300] (Microsoft.EntityFrameworkCore.Database.Command) 
      A data reader for 'E-Commerce' on server '.' is being disposed after spending 96ms reading results.
dbug: 12/17/2023 17:47:29.729 RelationalEventId.ConnectionClosing[20002] (Microsoft.EntityFrameworkCore.Database.Connection) 
      Closing connection to database 'E-Commerce' on server '.'.
dbug: 12/17/2023 17:47:29.736 RelationalEventId.ConnectionClosed[20003] (Microsoft.EntityFrameworkCore.Database.Connection) 
      Closed connection to database 'E-Commerce' on server '.' (6ms).
dbug: 12/17/2023 17:47:29.739 CoreEventId.QueryCompilationStarting[10111] (Microsoft.EntityFrameworkCore.Query) 
      Compiling query expression: 
      'DbSet<Product>()
          .TagWith("Second")
          .Where(p => p.TagProducts
              .Select(t => t.Tag.TagId)
              .Contains(__tagId_0))'
dbug: 12/17/2023 17:47:29.776 CoreEventId.QueryExecutionPlanned[10107] (Microsoft.EntityFrameworkCore.Query) 
      Generated query execution expression: 
      'queryContext => new SingleQueryingEnumerable<Product>(
          (RelationalQueryContext)queryContext, 
          RelationalCommandCache.QueryExpression(
              Projection Mapping:
                  EmptyProjectionMember -> Dictionary<IProperty, int> { [Property: Product.ProductId (Guid) Required PK AfterSave:Throw ValueGenerated.OnAdd, 0], [Property: Product.CategoryId (no field, Guid?) Shadow FK Index, 1], [Property: Product.CategoryType (CategoryType) Required, 2], [Property: Product.Name (string), 3], [Property: Product.Price (decimal) Required, 4], [Property: Product.TagId (no field, Guid?) Shadow FK Index, 5] }
              -- SecondSELECT p.ProductId, p.CategoryId, p.CategoryType, p.Name, p.Price, p.TagId
              FROM Products AS p
              WHERE @__tagId_0 IN (
                  SELECT t0.TagId
                  FROM TagProducts AS t
                  INNER JOIN Tags AS t0 ON t.TagId == t0.TagId
                  WHERE (p.ProductId != NULL) && (p.ProductId == t.ProductId))), 
          null, 
          Func<QueryContext, DbDataReader, ResultContext, SingleQueryResultCoordinator, Product>, 
          E_CommerceSystemV2.API.ECommerceContext, 
          False, 
          False, 
          True
      )'
dbug: 12/17/2023 17:47:29.786 RelationalEventId.ConnectionOpening[20000] (Microsoft.EntityFrameworkCore.Database.Connection) 
      Opening connection to database 'E-Commerce' on server '.'.
dbug: 12/17/2023 17:47:29.789 RelationalEventId.ConnectionOpened[20001] (Microsoft.EntityFrameworkCore.Database.Connection) 
      Opened connection to database 'E-Commerce' on server '.'.
dbug: 12/17/2023 17:47:29.790 RelationalEventId.CommandCreating[20103] (Microsoft.EntityFrameworkCore.Database.Command) 
      Creating DbCommand for 'ExecuteReader'.
dbug: 12/17/2023 17:47:29.790 RelationalEventId.CommandCreated[20104] (Microsoft.EntityFrameworkCore.Database.Command) 
      Created DbCommand for 'ExecuteReader' (0ms).
dbug: 12/17/2023 17:47:29.792 RelationalEventId.CommandInitialized[20106] (Microsoft.EntityFrameworkCore.Database.Command) 
      Initialized DbCommand for 'ExecuteReader' (2ms).
dbug: 12/17/2023 17:47:29.793 RelationalEventId.CommandExecuting[20100] (Microsoft.EntityFrameworkCore.Database.Command) 
      Executing DbCommand [Parameters=[@__tagId_0='e19e7131-285f-4a94-b01e-7421f0c22b59'], CommandType='Text', CommandTimeout='30']
      -- Second
      
      SELECT [p].[ProductId], [p].[CategoryId], [p].[CategoryType], [p].[Name], [p].[Price], [p].[TagId]
      FROM [Products] AS [p]
      WHERE @__tagId_0 IN (
          SELECT [t0].[TagId]
          FROM [TagProducts] AS [t]
          INNER JOIN [Tags] AS [t0] ON [t].[TagId] = [t0].[TagId]
          WHERE [p].[ProductId] = [t].[ProductId]
      )
info: 12/17/2023 17:47:29.799 RelationalEventId.CommandExecuted[20101] (Microsoft.EntityFrameworkCore.Database.Command) 
      Executed DbCommand (6ms) [Parameters=[@__tagId_0='e19e7131-285f-4a94-b01e-7421f0c22b59'], CommandType='Text', CommandTimeout='30']
      -- Second
      
      SELECT [p].[ProductId], [p].[CategoryId], [p].[CategoryType], [p].[Name], [p].[Price], [p].[TagId]
      FROM [Products] AS [p]
      WHERE @__tagId_0 IN (
          SELECT [t0].[TagId]
          FROM [TagProducts] AS [t]
          INNER JOIN [Tags] AS [t0] ON [t].[TagId] = [t0].[TagId]
          WHERE [p].[ProductId] = [t].[ProductId]
      )
dbug: 12/17/2023 17:47:29.803 RelationalEventId.DataReaderClosing[20301] (Microsoft.EntityFrameworkCore.Database.Command) 
      Closing data reader to 'E-Commerce' on server '.'.
dbug: 12/17/2023 17:47:29.804 RelationalEventId.DataReaderDisposing[20300] (Microsoft.EntityFrameworkCore.Database.Command) 
      A data reader for 'E-Commerce' on server '.' is being disposed after spending 1ms reading results.
dbug: 12/17/2023 17:47:29.806 RelationalEventId.ConnectionClosing[20002] (Microsoft.EntityFrameworkCore.Database.Connection) 
      Closing connection to database 'E-Commerce' on server '.'.
dbug: 12/17/2023 17:47:29.807 RelationalEventId.ConnectionClosed[20003] (Microsoft.EntityFrameworkCore.Database.Connection) 
      Closed connection to database 'E-Commerce' on server '.' (1ms).
dbug: 12/17/2023 17:47:29.833 CoreEventId.ContextDisposed[10407] (Microsoft.EntityFrameworkCore.Infrastructure) 
      'ECommerceContext' disposed.
dbug: 12/17/2023 17:47:29.838 RelationalEventId.ConnectionDisposing[20007] (Microsoft.EntityFrameworkCore.Database.Connection) 
      Disposing connection to database 'E-Commerce' on server '.'.
dbug: 12/17/2023 17:47:29.842 RelationalEventId.ConnectionDisposed[20008] (Microsoft.EntityFrameworkCore.Database.Connection) 
      Disposed connection to database '' on server '' (4ms).