namespace UniversityVotingApp.Model.Enums
{
    public enum AuditAction
    {
        Login = 1,
        Logout = 2,
        VoteCast = 3,
        ElectionCreated = 4,
        ElectionUpdated = 5,
        CandidateAdded = 6,
        CandidateRemoved = 7,
        ResultViewed = 8,
        SystemError = 9
    }
}
