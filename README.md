# IATC-WebAPI

- ASP.NET Core WebAPI Course from IAmTimCorey.com </br>
- Check commits for progress throughout the course, and/or notes. </br>
- Built on Rider & VS

# Projects
- Section-3-Lesson-2:
    - ASP.NET Core Web API
- Section-3-Lesson-8:
    - TBC
    - Injected Razor Pages
- Section-5-Lesson-2:
    - ASP.NET Core Web API

# Notes
[From Section-5-Lesson-2]
- Authentication Types (From Project Creation):
    - Windows Identity Platform:
        - Azure Active Directory BSC
    - Windows Authentication:
        - using windows accounts or AD (including Azure)
    - Auth0
- <strong>Storing Secrets</strong>
    - right click project secrets.json (depends IDE)
- If single HttpGet Action, and name not specified, will auto direct for class.
- If multiple HttpGet with no name in same class, will cause ambigious name.
- <HttpsRedirection> can be added to appsettings, if want to redirect, and along with app.UseHttpsRedirection in configure middleware for more control

# Managing Secrets
- For local development, storing connections strings,
- in Rider:
    - right click project > tools > .NET User Secrets
- in Visual Studio:
    - right click > manage user secrets
- C:\Users\OT\AppData\Roaming\Microsoft\UserSecrets
- \32b634af-3239-497e-9b34-4d017d575078\secrets.json