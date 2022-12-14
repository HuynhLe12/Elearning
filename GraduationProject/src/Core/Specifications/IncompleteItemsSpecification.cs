using Ardalis.Specification;
using Core.Entities;
using System;



namespace Core.Specifications
{
    public class IncompleteItemsSpecification : Specification<ToDoItem>
    {
        public IncompleteItemsSpecification()
        {
            Query.Where(item => !item.IsDone);
        }
    }

    public class GetDetailCourse : Specification<Course>
    {
        public GetDetailCourse(Guid id)
        {
            Query.Where(item => item.Id == id);
        }
    }

    public class GetDetailSection : Specification<Section>
    {
        public GetDetailSection(Guid id)
        {
            Query.Where(item => item.Id == id);
        }
    }
    
    public class GetDetailLesson : Specification<Lesson>
    {
        public GetDetailLesson(Guid id)
        {
            Query.Where(item => item.SectionId == id);
        }
    }

    public class GetDetailQuizzByID : Specification<Quizz>
    {
        public GetDetailQuizzByID(Guid id)
        {
            Query.Where(item => item.Id == id);
        }
    }

    public class GetDetailQuestionByID : Specification<QuizzQuestion>
    {
        public GetDetailQuestionByID(Guid id)
        {
            Query.Where(item => item.Id == id);
        }
    }

    public class GetDetailAnswerByID : Specification<QuizzAnswer>
    {
        public GetDetailAnswerByID(Guid id)
        {
            Query.Where(item => item.QuestionId == id);
        }
    }


    public class GetAllDetailAnswerByID : Specification<UserQuizzAnswer>
    {
        public GetAllDetailAnswerByID(Guid id)
        {
            Query.Where(item => item.UserId == id);
        }
    }

    public class GetQuizzComplete : Specification<QuizzCompletion>
    {
        public GetQuizzComplete(Guid userId, Guid quizzId)
        {
            Query.Where(item => item.UserId == userId && item.QuizzId == quizzId);
        }
    }

    public class GetDetailQuizz : Specification<Quizz>
    {
        public GetDetailQuizz(Guid id)
        {
            Query.Where(item => item.SectionId == id).Include(item => item.QuizzQuestions).ThenInclude(item => item.QuizzAnswers);
        }
    }
    
    public class GetQuizzQuestion : Specification<QuizzQuestion>
    {
        public GetQuizzQuestion(Guid id)
        {
            Query.Where(item => item.QuizzId == id);
        }
    }
    
    public class GetQuizzAnswer : Specification<QuizzAnswer>
    {
        public GetQuizzAnswer(Guid id)
        {
            Query.Where(item => item.QuestionId == id);
        }
    }

    public class GetAllItem : Specification<Course>
    {
        public GetAllItem()
        {
            Query.Where(item => true).Include(item => item.SubCategory);
        }
    }

    public class GetAllComment : Specification<QuestionAndAnswer>
    {
        public GetAllComment(Guid id)
        {
            Query.Where(item => item.CourseId.Equals(id)).Include(item => item.User);
        }
    }

    public class GetApproveItem : Specification<Course>
    {
        public GetApproveItem()
        {
            Query.Where(item => item.Status == "Waiting for approved").Include(item => item.SubCategory);
        }
    }

    public class GetRejectedItem : Specification<Course>
    {
        public GetRejectedItem()
        {
            Query.Where(item => item.IsRejected == true).Include(item => item.SubCategory);

        }
    }

    public class GetBlockItem : Specification<Course>
    {
        public GetBlockItem()
        {
            Query.Where(item => item.IsBlocked == true).Include(item => item.SubCategory);

        }
    }

    public class GetActiveItem : Specification<Course>
    {
        public GetActiveItem()
        {
            Query.Where(item => item.IsBlocked == false && item.Status == "Active").Include(item => item.SubCategory);

        }
    }

    public class GetActiveItemStudent : Specification<Course>
    {
        public GetActiveItemStudent()
        {
            Query.Where(item => item.IsBlocked == false && item.Status == "Active").Include(item => item.User);

        }
    }

    public class GetCourseByUser : Specification<Course>
    {
        public GetCourseByUser(Guid Id)
        {
            Query.Where(item => item.UserId == Id).Include(item => item.SubCategory);
        }
    }

    public class GetSectionByCourseId : Specification<Section>
    {
        public GetSectionByCourseId(Guid Id)
        {
            Query.Where(item => item.CourseId == Id);
        }
    }

    public class GetUpcomingCourse : Specification<Course>
    {
        public GetUpcomingCourse(Guid id)
        {
            Query.Where(item => item.UserId == id && item.Status == "Waiting for approve").Include(item => item.SubCategory);
		}
    }
    
	public class GetDraftCourse : Specification<Course>
    {
        public GetDraftCourse(Guid Id)
        {
            Query.Where(item => item.UserId == Id && item.Status == "Draft").Include(item => item.SubCategory);
        }
    }

    public class GetAllRoleItem : Specification<Role>
    {
        public GetAllRoleItem()
        {
            Query.Where(item => true).Include(item => item.RolePermissions).ThenInclude(item => item.Permission);
        }
    }
    public class GetRoleItemById : Specification<RolePermission>
    {
        public GetRoleItemById(Guid Id)
        {
            Query.Where(item => item.RoleId.Equals(Id));
        }
    }

    public class GetAllFeedBack : Specification<Feedback>
    {
        public GetAllFeedBack()
        {
            Query.Where(item => true).Include(x => x.User);
        }
    }

    public class SearchFeedBack : Specification<Feedback>
    {
        //query search feedback
        public SearchFeedBack(string input)
        {
            Query.Where(item => item.Content.Contains(input) || item.Email.Contains(input) || item.CreateAt.ToString().Contains(input)).Include(x => x.User);
        }
    }

    public class GetPayout : Specification<Payout>
    {
        public GetPayout()
        {
            Query.Where(item => true).Include(x => x.Instructor);
        }

        public GetPayout(Guid id)
        {
            Query.Where(item => item.InstructorId == id);
        }
    }

    public class SearchPayout : Specification<Payout>
    {
        public SearchPayout(string input)
        {
            Query.Where(item => item.Instructor.UserName.Contains(input) || item.Price.ToString().Contains(input) || item.Remark.Contains(input) || item.Status.Contains(input)).Include(x => x.Instructor);
        }
    }

    public class GetAllReview : Specification<Review>
    {
        //query get all review
        public GetAllReview(Guid id)
        {
            Query.Where(item => item.UserId.Equals(id));
        }
    }
    public class GetEnrollmentById : Specification<Enrollment>
    {
        //query get courses by user id
        public GetEnrollmentById(Guid id)
        {
            Query.Where(item => item.UserId.Equals(id)).Include(x=>x.Reviews);
        }
    }
    public class GetReviewById : Specification<Review>
    {
        //query get review by courses id
        public GetReviewById(Guid id)
        {
            Query.Where(item => item.EnrollmentId.Equals(id));
        }
    }
   

    public class GetOrderDetail : Specification<OrderDetail>
    {
        public GetOrderDetail(int month, int year, Guid id)
        {
            Query.Where(item => item.PurchasedDay.Year == year && item.PurchasedDay.Month == month && item.Course.UserId == id).Include(item => item.Course);
        }

        public GetOrderDetail()
        {
            Query.Where(item => true).Include(item => item.Course);
        }

        public GetOrderDetail(Guid id)
        {
            Query.Where(item => true).Where(x => x.UserId == id).Include(item => item.Course).ThenInclude(item => item.User);
        }
    }


    public class GetOrderDetailWithCourse : Specification<OrderDetail>
    {
        public GetOrderDetailWithCourse(Guid id)
        {
            Query.Where(item => true).Where(x => x.CourseId == id).Include(item => item.User).ThenInclude(x => x.QuizzCompletions);
        }
    }

    public class ListEarning : Specification<OrderDetail>
    {
        public ListEarning(Guid id)
        {
            Query.Where(item => item.Course.UserId == id).Include(item => item.Course);
        }
    }

    public class GetAllSubscription : Specification<Subscription>
    {
        public GetAllSubscription()
        {
            Query.Where(item => true).Include(item => item.Subscriper);
        }
    }

    public class GetEarning : Specification<OrderDetail>
    {
        public GetEarning(Guid id)
        {
            Query.Where(item => item.Course.UserId == id).Include(item => item.Course);
        }
    }
}
