# IATC-WebAPI

- ASP.NET Core WebAPI Course from IAmTimCorey.com </br>
- Check commits for progress throughout the course, and/or notes. </br>
- Built on Rider & VS

# For MAC

## Commands

> `dotnet new webapi -lang "c#" -n "S5L2-Sandbox" -f "net7.0" -o S5L2-Sandbox -d -v diag`

- Note here, `.\` was not used when sepcifying output directory, usually, just -n is enough,
  it will automatically create directory, use -n Only if you want folder name to be different,
  or when grouping projects under specific folders.

> `dotnet sln add S5L2-Sandbox/S5L2-Sandbox.csproj`

- again, see how `.\` was omitted as we are in the same directory, this is different in windows.

> `dotnet run --project S5L2-Sandbox --launch-profile "https"`

- the command already looks for .csproj file, so just passing the directory here is fine.

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
- <strong>Using <em>dotnet user-secrets</em></strong>
  - dotnet user-secrets -?
  - specific to project, but stored in a protected location for any project in system to access

# Commands

- <strong><em>dotnet user-secrets set "first" "last" -p Section-5-Lesson-2 -v</em></strong>
- Project file path C:\Users\pironadmin\Desktop\Projects\OTonGitHub\IATC-WebAPI\Section-5-Lesson-2\Section-5-Lesson-2.csproj.
- Secrets file path C:\Users\pironadmin\AppData\Roaming\Microsoft\UserSecrets\32b634af-3239-497e-9b34-4d017d577777\secrets.json.
