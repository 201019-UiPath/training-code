### Asp.Net 
- Active Server Pages
- **History** - .Net Framework (2002) -> Asp.Net Forms (Rapid Application Development) 
                - Asp.Net forms had capability to drag and drop the controls 
                - Fat and unmanagable 
                - Tight coupling : front end code was tighlty coupled with server side
                - less testable
                - Very less Separation of BL, UI, DL

    - In 2010 .Net Framework introduced Asp.Net MVC is based on MVC design pattern

### MVC Design Pattern
- **Models**: That contains structure of the data, its validation and business logic for that data.
- **Views**: UI logic 
- **Controllers**: the component which handles users request.
- ![MVC lifecycle diagram]()

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
    - HTTPS