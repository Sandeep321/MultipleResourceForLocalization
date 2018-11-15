# MultipleResourceForLocalization
.Net core 2.0 localization with more than one resource file. 

Just clone/download and run the project. It shall open Swagger URL like "http://localhost:8000/swagger" which has only one end point. Hit that end point with "Info" OR "Warn" in type field and "Key" in key field.
Upon providing "Info", it will return the value for 'Key' from .Info file and Upon providing "Warn", it will return the value for 'Key' from .Warn file.

It supports Spanish language also, so you can test for that via postman also. Provide Accept-Language header values as 'es'. You should see the results from .es files.

Note the cases for 'Info, Warn and Key'. Don't mess these up.
Thank you.
