import { useEffect, useState } from 'react'
import BowlerTable, { type Bowler } from './components/BowlerTable'
import Heading from './components/Heading'

function App() {
  const [bowlers, setBowlers] = useState<Bowler[]>([])
  const [isLoading, setIsLoading] = useState(true)
  const [error, setError] = useState('')

  useEffect(() => {
    async function loadBowlers() {
      try {
        const response = await fetch('/api/bowlers')

        if (!response.ok) {
          throw new Error('Failed to load bowlers.')
        }

        const data: Bowler[] = await response.json()
        setBowlers(data)
      } catch {
        setError('Unable to load bowlers right now.')
      } finally {
        setIsLoading(false)
      }
    }

    loadBowlers()
  }, [])

  return (
    <main className="container py-4">
      <Heading />
      {isLoading ? <div className="alert alert-secondary">Loading bowlers...</div> : null}
      {error ? <div className="alert alert-danger">{error}</div> : null}
      {!isLoading && !error ? <BowlerTable bowlers={bowlers} /> : null}
    </main>
  )
}

export default App
