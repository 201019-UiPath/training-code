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

## Lifetime of the context
- there are built in IoC containers that manages the lifetime of a registered service (Context)
    - Singleton - service will be available through out the lifetime of the application
    - Transient - it will create a new instance of the the specified service type every time you ask for it.
    - Scoped - it will create the instance of the specified service once per request and it will be shared in a single request.


## Helpers in MVC Views
- There are 2 types of helpers which can be used to generate the html at runtime by razor engine
    - HTML Helpers: C# methods which create the HTML at run time
    - Tag Helpers: which are more like mark ups and HTML friendly syntaxes

## Validations:
- To check the user's input at client side as well as Server side we use validations
- Data Annotations: Can be used to:
    - perform client side validations using annotations like StringLength/Range,RegularExpression, Required
    - Display Views : Datatype, Display Name
    - Mention schema logic: Key, Foreign Key, DataType

## SOA - Service Oriented Architecture
- Architectural Approach in which appliactions make use of services available in the network. Two components of services are
    - Service Provider
    - Service Consumer
- Both the components interact with each other via *Messages* (text/json/xml) over a *Protocol* (TCP, MSMQ, HTTP(s), named Pipes).
- **Principles of SOA**
    - Standardized Service Contract: A service should have a service description document. Eg: [Swagger](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-3.1&tabs=visual-studio) for REST Apis, and [WSDL](https://www.tutorialspoint.com/wsdl/wsdl_introduction.htm) for SOAP services.
    - Loose Coupling: each service should be designed in a way that it is self contained component and has minimal dependencies on other services.
    - Abstraction: Need not to expose the Service internal logic but it should be defined by its description document and the Service contract.
    - Reusability 
    - Autonomy: Services are encapsulated in terms of logic and consumer don't need to know about the implementation.
    - Discoverablity
    - Composablity: Using services as building blocks, sophisticated and complex operations.
- Advantages of SOA: Service Resuablity, Easy maintainance, Platform independance, Availibilty, reliability, Scalibilty
- Disadvantages of SOA: load balancing, High costs and investments involved, High Overload could also because of network latency
- SOA can be impleneted in 2 ways:
    - SOAP Service-> a web service which uses XML format when it comes to exchanging of messages over various protocols (Http(s), TCP, MSMQ, named Pipes).
    - In .Net Framework use WCF (Windows Communication Foundation)
        - Communication between consumer and provider happens on SOAP Packet (XML data)
        - WCF Contracts:
            - Service Contract
                - Operation Contract
            - Data Contract
                - Data Memeber
            - Fault Contract
            
    - RESTFul Service-> Asp.Net core web API
- **Why industries prefer REST over SOAP service**
    - Light weight messaging using Json.
    - Easy setup and extend for REST over SOAP service.
    - Statelessness of RESTful service is helpful in scalability
    - Reachability because of HTTP as we have more devices supporting HTTP.

## ASP.Net Core Web API 
- [Content Negiotiation](https://docs.microsoft.com/en-us/aspnet/core/web-api/advanced/formatting?view=aspnetcore-3.1): Whenever client request for a format of data using *Accept* header, this is called content Negotiation.
- By Default Asp.Net core offers Json data unless configured.
- Some browsers also have default accept header like edge and IE requests for JSON.
- Or use Formatter ciustom or default


## How can you consume an Asp.Net Web API
1. Client-side -> using JS or any frameworks based on client-scripting language
2. Server-side -> HttpClient

## references 
- [Practise](https://docs.microsoft.com/en-us/learn/modules/build-web-api-net-core/)