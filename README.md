# RemoteApplication
This is the documentation of the PTS LIbrary.

It follows an n-tier architecture for the app. We first created the database, added the tables from which we  used DAO(Data Access Objects)  for manipulating the data in the database. For the business tier, we used the rest of the classes for activities such as authentication, listing tasks, etc. The facade classes provide ‘templates’ to the business logic classes. So the library mainly houses the business logic. The tier is already created using Microsoft SQL server.

> The DAO classes arehoused in the DAO folder.
