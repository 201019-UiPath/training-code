## ADO.NET
- ActiveX Direct Object
- We use this framework as a middleware to connect Application Logic program to backend.
- Two architectures in ADO.NET
    - Connected Architecture
        - Reading from data happens when client app and backend are live 
        - reading happends in forward only directions, reading one record at a time
        - which means no back-tracking of records
    - Disconnected Architecture
        - fire and forget the query
        - once connection is made the backend would send results to client which are stored locally
        - The local data source is called *DataSet*



- to connect your application to DB there are 3 basic steps to be followed
    - create a connection
    - Fire the query
    - get the results