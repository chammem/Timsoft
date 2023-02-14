using timsoft.entities;

namespace timsoft.services
{
    public interface IQuestionService
    {

        Question AddQuestion(QuestionForm question);
        String UpdateQuestion(QuestionForm question, int id);
        List<Question> GetAllQuestions();
        Question GetQuestionById(int id);
        String DeleteQuestion(int id);

    }
}
