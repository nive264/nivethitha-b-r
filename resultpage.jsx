import { useVotes } from "../context/VoteContext.jsx";
import ProgressBar from "../components/ProgressBar.jsx";

export default function ResultsPage() {
  const { votes } = useVotes();
  const totalVotes = votes.A + votes.B + votes.C;

  const leadingCandidate = Object.entries(votes).reduce(
    (a, b) => (b[1] > a[1] ? b : a),
    ["None", 0]
  )[0];

  const getPercentage = (count) =>
    totalVotes > 0 ? ((count / totalVotes) * 100).toFixed(1) : 0;

  return (
    <div className="results-page">
      <h1>Voting Results</h1>
      <p>Total Votes: {totalVotes}</p>

      {Object.entries(votes).map(([candidate, count]) => (
        <div key={candidate} className="result-item">
          <h2>{candidate}: {count} votes ({getPercentage(count)}%)</h2>
          <ProgressBar percentage={getPercentage(count)} />
        </div>
      ))}

      <h2 className="leading">Leading Candidate: {leadingCandidate}</h2>
    </div>
  );
}
