using timsoft.entities;

namespace timsoft.repositories
{
    public interface IQuestionRepository
    {
        Question AddQuestion(QuestionForm question);
        String UpdateQuestion(QuestionForm question , int id);
        List<Question> GetAllQuestions();
        Question GetQuestionById(int id);
       string DeleteQuestion(int id);
      
    }
}
