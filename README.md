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
2. go to server project directory
  ```
    cd HtmxTailwindGsapBlazor/HtmxTailwindGsapBlazor/HtmxTailwindGsapBlazor
  ```
3. in appsettings.json, provide your SQL connection string:
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
5. launch project:
  ```
    dotnet run
  ```
9. navigate to the Register page and register a name, email, and password
10. confirm
11. navigate back to the Home Page to see Htmx with SSR and Tailwind in action
