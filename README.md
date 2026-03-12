# Bowling League Mission

Monorepo with a React frontend and ASP.NET Core backend.

## Project structure
- `frontend/`: React 19 + TypeScript + Vite 7
- `backend/`: ASP.NET Core Web API (.NET 10)
- `backend/backend.sln`: .NET solution file

## Prerequisites
- Node.js 22+
- npm 10+
- .NET SDK 10.0+

## Getting started

Run all commands from the repository root.

### Backend

Start the API:
```bash
dotnet run --project backend/backend/backend.csproj
```

### Frontend

Install dependencies (one-time setup), then start the dev server:
```bash
npm --prefix frontend install
npm --prefix frontend run dev
```

## Local URLs
- Frontend (Vite dev server): `http://localhost:5173`
- Backend HTTP profile: `http://localhost:5184`
- Backend HTTPS profile: `https://localhost:7187`
- OpenAPI document (Development): `http://localhost:5184/openapi/v1.json`

## API endpoint included
- `GET /weatherforecast`

Example request:
```bash
curl http://localhost:5184/weatherforecast
```

## Useful frontend scripts
From the repository root:

- `npm --prefix frontend run dev`: Start Vite dev server
- `npm --prefix frontend run build`: Type-check and build production assets
- `npm --prefix frontend run preview`: Preview production build
- `npm --prefix frontend run lint`: Run ESLint
