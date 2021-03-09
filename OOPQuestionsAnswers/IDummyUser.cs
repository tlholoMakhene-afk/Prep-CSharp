namespace OOPQuestionsAnswers
{
    public interface IDummyUser
    {
        void DisplayDetails();
        bool Equals(object obj);
        int GetHashCode();
        string ToString();
    }
}