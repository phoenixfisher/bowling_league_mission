# FullStack Test Repo

Monorepo-style layout with:
- `frontend/`: React + TypeScript + Vite
- `backend/`: ASP.NET Core Web API
- `backend/test.sln`: .NET solution including the backend project

## Prerequisites
- Node.js 22+
- npm 10+
- .NET SDK 10

## Quick start
1. Install frontend dependencies:
   ```bash
   cd frontend
   npm install
   ```
2. Run backend API:
   ```bash
   cd backend
   dotnet run
   ```
3. Run frontend app (separate terminal):
   ```bash
   cd frontend
   npm run dev
   ```

## Git setup
Initialize Git at the repo root:
```bash
git init
git add .
git commit -m "Initial project structure"
```
