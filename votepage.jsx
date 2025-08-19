import Candidate from "../components/Candidate.jsx";
import { useVotes } from "../context/VoteContext.jsx";

export default function VotingPage() {
  const { votes, addVote, resetVotes } = useVotes();

  return (
    <div className="voting-page">
      <h1>Cast Your Vote</h1>
      <div className="candidates">
        <Candidate name="Candidate A" votes={votes.A} onVote={() => addVote("A")} />
        <Candidate name="Candidate B" votes={votes.B} onVote={() => addVote("B")} />
        <Candidate name="Candidate C" votes={votes.C} onVote={() => addVote("C")} />
      </div>
      <button className="reset-btn" onClick={resetVotes}>Reset Votes</button>
    </div>
  );
}
