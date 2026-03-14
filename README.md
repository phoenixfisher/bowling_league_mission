# Bowling League Mission

This project shows bowler information from the Bowling League database.

It uses:
- React + TypeScript for the frontend
- ASP.NET Core with C# for the backend
- SQLite for the database

The app only displays bowlers from the Marlins and Sharks teams.

## Files

- `frontend` contains the React app
- `backend` contains the ASP.NET Core API
- `db/BowlingLeague.sqlite` is the database file

## How to run it

Backend:
```bash
cd backend/backend
dotnet run
```

Frontend:
```bash
cd frontend
npm install
npm run dev
```

## What the page shows

- Bowler name
- Team name
- Address
- City
- State
- Zip
- Phone number
