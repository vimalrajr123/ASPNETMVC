# ASPNETMVC
Linkhub

Roles:
user
-can browse urls
-can register
-can submit a url

Admin
-can CRUD category
-can view all users
-can approve or reject url
----------------------------------------
identifying the objects: 3
-user
-category
-url
----------------------------------------
relation between objects: 2
-category : url (1:M)
1------>n correct
n------>1 wrong
n------>n wrong

-user : url  (1:M)
1------>n correct
n------>1 wrong
n------>n wrong

no need to create a relationship between user and category because url has category..so no need.
----------------------------------------

Design database based on objects and relationship:
-one table for each object.

-for 1:M relationship. 1 will become master and M will become child, (ie) PRIMARY KEY OF 1 WILL ACT AS A FORIGN KEY FOR M.
eg : department:employees is 1:M

-for M:M relationship.  both the object will become master and there will be one more new table called as transaction table
 or child table with primary keys of masters as foreign keys in it.
 eg: student:course
 student table------------course table
	sid						  cid
		student_course Table
				sid
				cid
----------------------------------------
3 tier architecture:

business objects(BO)

ui------------bll------------DAL---------------database
asp.netmvc	   c#.net        ADO.NET(EF)		MS SQL

-BOL: is the replica of the database tables in the form of classes(one table will generate a class)
		Object Relation Mappinf is done in BOL
