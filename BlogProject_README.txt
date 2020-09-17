Blogging Journal Requirements
Project Name: The Daily Blogger
Project Description: This web app will allow a user to post, in a long journal-like entry,
their thoughts online.
Tech Stack :
● C#
● ASP.NET
● Microsoft SQL Server
Features:
● Users will be able to create a new blog post
● Users will be able to view a history all their blog posts
● Blog posts will be saved to the database 

Limitations
● We will not be implementing user logins or multiple user accounts
● Users will not be able to edit a previous blog post
● Users will not be able to delete a blog post
● Users will not be able to click on a blog post to view the details of the blog post.
● We won’t worry about making the web app look pretty right now.

Checklist: 
1 Plan the design of the Database
2 Create the Database In SQL

Data Design
Database Name: Blog

Table Name: BlogPost
Column 		Data Type 	Description
id 		INT 		Unique ID of blog post. Primary Key.
blogTitle 	VarChar(Max) 	The title of the blog post.
content 	Text 		The content of the blog post.
blogDate 	DateTime 	The date the blog post was added.


3 Create a Connection to our Database 
 
in appsettings.json:
  "ConnectionStrings" ; 
      {
     "blog" : "server = localhost\SQLExpress;Database = blog;Trusted_Connection= True;"
      },

4 Create a C# Model Class to represent our SQL Data

5 Configure our web app to connect to the database on Start-Up 


6 Create a C# Controller for working with our data

7 Create a C# View class for viewing our data.

8 Improve our Controller to have a New Blog Post form. Create an appropriate View.
tasks:
 ● Our Model classes & databases are already setup, so there is nothing to do here.
 ● We need to update the controller to tell it to have a “New Blog Post” method.
 ● We need to create a view for new blog posts
 ● We need to update the controller to tell it to save the new blog post back to the
database

9 Improve our Controller to have it Create the blog post in the database



At this point, we should be able to
1. Go to /blog/list and see a list of all blog posts
2. Go to /blog/new and get a form to create a new post
3. Click the Post Blog button on the form and have a new post created. At that point, we should be returned to the list.


Lesson 2.2 Understanding the Controller Class
Our Blog Control can currently do 3 things.
● List all blog posts List()
● Provide a form for a New Blog Post New()
● Create a new blog post when the form is submitted to the server Create()

Create a new Controller class to see some more examples.  
In the new ExampleController, create these Actions:
●  ShowMeAnError()
●  GiveMeAFile()
●  ShowMeAPage()
●  GiveMeSomeJson()
●  TakeMeToGoogle()


Lesson 2.3  Improving the Blog Web App

In this lesson, we’ll continue working on our Blog Web App to make the following improvements to it.
 ● Allow users to view the details of a post
 ● Allow users to edit a post
 ● Allow users to delete a post
 ● Apply CSS styles to improve the appearance of the site










