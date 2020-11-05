### [Asp.Net](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
- Active Server Pages
- **History** 
    - .Net Framework (2002) 
    - Asp.Net Forms (Rapid Application Development) 
        - Asp.Net forms had capability to drag and drop the controls 
        - Fat and unmanagable 
        - Tight coupling : front end code was tighlty coupled with server side
        - less testable
        - Very less Separation of BL, UI, DL
    - In 2010 and later versions .Net Framework introduced Asp.Net MVC is based on MVC design pattern

### MVC Design Pattern
- **Models**: That contains structure of the data, its validation and business logic for that data.
- **Views**: UI logic 
- **Controllers**: the component which handles users request.
- ![MVC lifecycle diagram](https://github.com/201019-UiPath/training-code/blob/main/images/MVC%20lifecycle%20-%20brief.png)

### .Net Core -> Asp.Net Core 
- Asp.Net Core MVC app: Web application with UI
    - MVC
    - Razor Pages
    - Blazor
- Asp.Net Core Web API: Service application for creating RESTful services
- Asp.Net core is compatible with all environments
- **Hosts**: 
    - IIS - Microsoft's server, Windows only
    - Kestrel - platform independant. Can be used in macOS, Linux, Windows
    - HTTP.sys
    - Nginx
    - Apache
    - Docker

### Controllers
- Handles all user interaction
- A controller class is inheriting Controller class from Microsoft.AspNetCore.Mvc namespace
- All public methods in controller class are called **Actions**
- Actions can be of basically 2 types:
    - GET - it will return you something like a view
    - POST - They are used to submit some user input

### Actions
- They are the methods that handles the forwarded requet from the controller
- They typically have a return type as *IActionResult*
- from IActionResult you can return various outputs:
    - ViewResult - View()
    - JsonResult 
    - FileResult
    - ContentResult
    - ActionResult

### Passing data to views and controllers
- Controllers to view data can be passed in 2 ways:
    - Weakly-typed:
        - ViewData: this is dictionery object which needs type casting for complex data
        - ViewBag: this is dynamic type object which don't need casting for complex data. Also ViewBag is wrapper over viewdata
        - TempData:
            - ViewBag and ViewData can only pass values from controller actions to View but cannot pass it from one controller to another.
            - TempData can pass the value from one controller to another allowing atleast 1 time read.
            - TempData.Keep() -> this method will preserve the value of TempData for next read.
    - Strongly-typed
        - by using Models in the views which are called view-models
        - 1 view is tied to only 1 model
    - Dynamic way

### Views
- Consists of UI logic
- supports C# and html
- C# code is accessed @ sign which is also called *Razor syntax*
- @chsarp one line code 
- ```
        @{
        multiple lines of C# code
        }
    ```
- Types of Views:
    - Weakly-Typed
    - Strongly-Typed
    - Dynamic-Typed
    - Layout View - implement the principle Donot Repeat Yourself
        - RenderBody()- placeholder for all the views
        - RenderSection() - a placeholder for view specific data
    - Partial Views - 

### Model Binding
- It is a mechanism which allows the binding of values of parameters action methods from different locations of that data:
    - RouteData
    - FormCollection
    - QueryString
    - File

### Routing 
- mechanism to implement powerful and meaningful URLs and its mapping
- It is Performed by Routing Engine
- A routing engine has a route table which maintains the repository of the the patterns, controller, actions and its parameters.
- Link generation independant of the file structure of webserver.
- Routing can be done in 2 ways:
    1. Conventional based Routing - globally defining of the routes
    2. Attribute based Routing - Routes for Controller and action methods
    
## references 
- [Practise](https://docs.microsoft.com/en-us/learn/modules/build-web-api-net-core/)