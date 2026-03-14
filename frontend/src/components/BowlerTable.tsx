export type Bowler = {
  firstName: string
  middleInit: string
  lastName: string
  teamName: string
  address: string
  city: string
  state: string
  zip: string
  phoneNumber: string
}

type BowlerTableProps = {
  bowlers: Bowler[]
}

function formatName(bowler: Bowler) {
  return [bowler.firstName, bowler.middleInit, bowler.lastName].filter(Boolean).join(' ')
}

function BowlerTable({ bowlers }: BowlerTableProps) {
  return (
    <div className="table-responsive">
      <table className="table table-striped table-bordered align-middle">
        <thead>
          <tr>
            <th>Bowler Name</th>
            <th>Team Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {bowlers.map((bowler) => (
            <tr key={`${bowler.teamName}-${formatName(bowler)}`}>
              <td>{formatName(bowler)}</td>
              <td>{bowler.teamName}</td>
              <td>{bowler.address}</td>
              <td>{bowler.city}</td>
              <td>{bowler.state}</td>
              <td>{bowler.zip}</td>
              <td>{bowler.phoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  )
}

export default BowlerTable
