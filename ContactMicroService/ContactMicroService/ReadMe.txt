ContactMicroService

Created ASP.Net core WebApi to get,Add, Update, delete contact
Swagger is used to check if get,Put,Post, Delete is working as expected or not
Partially added XUnit to unit test of ContactMicroService
Exception handling and logging is pending in ContactMicroService
Phone number accepts 10 digits, Mobile number
Used EF InMemory staorage

1. Open ContactMicroService solution
2. Keep start up project as ContactMicroService
3. Check all nuget dependency is installed like Swagger
4. Run ContactmicroService
5. InMemory data wil display on Get
6. ContactId is Key column and getting handle in code.No need to provide contactId Manually while Post
6. Add,Update, Delete record from Swagger