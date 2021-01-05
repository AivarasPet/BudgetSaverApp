namespace BudgetSaverApp.Goals
{
    public class DboGoal
    {
        public int Id { get; set; }
        public string GoalItemName { get; set; }
        public float GoalItemPrice { get; set; }
        public string GoalDescription { get; set; }
        public int UserId { get; set; }
    }
}
