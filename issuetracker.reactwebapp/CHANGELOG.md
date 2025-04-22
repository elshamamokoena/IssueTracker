This file explains how Visual Studio created the project.

The following tools were used to generate this project:
- create-vite

The following steps were used to generate this project:
- Create react project with create-vite: `npm init --yes vite@latest issuetracker.reactwebapp -- --template=react-ts`.
- Create project file (`issuetracker.reactwebapp.esproj`).
- Create `launch.json` to enable debugging.
- Create `nuget.config` to specify location of the JavaScript Project System SDK (which is used in the first line in `issuetracker.reactwebapp.esproj`).
- Add project to solution.
- Write this file.
