# CodeFirstRelation

##Practical - Code First Relation
Creating Database and Relationships with Code First Approach
Code First approach was implemented using Entity Framework Core.

##User Table:

Id: int, primary key and auto incrementing.

Username: string, user's username.

Email: string, user's email address.

##Post Table:

Id: int, primary key and auto incrementing.

Title: string, title of the post.

Content: string, content of the post.

UserId: int, author of the post (user's ID).

A user can have multiple posts, but each post belongs to only one user.

The name of the context class is PatikaSecondDbContext.
The name of the database is PatikaCodeFirstDb2.
The names of the tables in the database are Users and Posts.
