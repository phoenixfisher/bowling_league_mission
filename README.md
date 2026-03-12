# FullStack Test Repo

Monorepo-style layout with:
- `frontend/`: React + TypeScript + Vite
- `backend/`: ASP.NET Core Web API
- `test.sln`: .NET solution including the backend project

## Prerequisites
- Node.js 22+
- npm 10+
- .NET SDK 10

## Quick start
1. Install frontend dependencies:
   ```bash
   npm --prefix frontend install
   ```
2. Run backend API:
   ```bash
   dotnet run --project backend/backend.csproj
   ```
3. Run frontend app (separate terminal):
   ```bash
   npm --prefix frontend run dev
   ```

## Root convenience scripts
You can also use root scripts:
- `npm run dev:frontend`
- `npm run dev:backend`
- `npm run build`
- `npm run lint`

## Git setup
Initialize Git at the repo root:
```bash
git init
git add .
git commit -m "Initial project structure"
```
