# HtmxTailwindGsapBlazor

- Blazor
- HTMX
- TailwindCss
- GSAP
- Vite
  
Template For .NET 8 Blazor Web App With HTMX for SSR interactivity, Tailwind for styling, GSAP for animtions in interactive components and Vite for bundling the Npm packages

1. open terminal with command:
  ```
    git clone https://github.com/WilliamMcRoberts/HtmxTailwindGsapBlazor/

  ```
4. cd HtmxTailwindGsapBlazor/HtmxTailwindGsapBlazor
5. in appsettings.json, provide your SQL connection string:
  ```
      {
        "ConnectionStrings": {
         "DefaultConnection": "<YOUR_CONNECTION_STRING>",
       }
     }
  ```
4. open PM console with command:
  ```
     Update-Database
  ```
7. enter command:
  ```
    dotnet run
  ```
9. go to Register page and register a name, email, and password
10. confirm
11. go back to Home Page to see Htmx in action
